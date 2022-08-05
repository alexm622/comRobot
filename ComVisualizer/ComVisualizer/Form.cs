using System;
using System.IO.Ports;

namespace ComVisualizer
{
    public partial class MainForm : Form
    {
        private SerialPort sp;

        private rotCircle r1;
        public MainForm()
        {
            sp = new SerialPort("COM11", 9600, Parity.Even, 8, StopBits.One);
            sp.Open();
            sp.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            
            

            InitializeComponent();

            //start graphics
            r1 = new rotCircle();
            r1.L_rot = 0.0;
            r1.D = g1.Width;
        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort SP = (SerialPort)sender;
            String data = SP.ReadExisting();
            this.appendTextBox(data);
            this.updateGraphics1(new Random().NextDouble() * 2.0 * Math.PI);
        }

        public void appendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(appendTextBox), new object[] { value });
                return;
            }
            comCommands.Text += value;
            comCommands.AppendText(Environment.NewLine);
        }

        public void updateGraphics1(double rot)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<double>(updateGraphics1), new Object[] { rot });
                return;
            }
            g1.Invalidate();
            
            this.r1.L_rot = rot;
            width1.Text = String.Format("Width: {0}{1}", Math.Round((180 / Math.PI) * rot, 2), "\u00b0");
        }

        private void g1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            e.Graphics.DrawEllipse(pen, new Rectangle(0, 0, g1.Width, g1.Height));
            /*
             * 0 = x1
             * 1 = y1
             * 
             * 2 = x2
             * 3 = y2
             */
            float[] line_pts = r1.calculatePoints();

            //shift the relative position of all the points
            line_pts[0] += g1.Width / 2;
            line_pts[1] += g1.Height / 2;

            line_pts[2] += g1.Width / 2;
            line_pts[3] += g1.Height / 2;


            //calculate rotation


            e.Graphics.DrawLine(pen, line_pts[0], line_pts[1], line_pts[2], line_pts[3]);
        }

        private void g1_Click(object sender, EventArgs e)
        {
            this.updateGraphics1(new Random().NextDouble() * 2.0 * Math.PI);
        }

        private void animateRotation()
        {

        };
    }
}
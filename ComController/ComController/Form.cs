using System;
using System.IO.Ports;

namespace ComController
{
    public partial class mainForm : Form
    {

        private SerialPort sp;
        public mainForm()
        {
            sp = new SerialPort("COM10", 9600, Parity.Even, 8, StopBits.One);
            sp.Open();
            InitializeComponent();
        }

        private void command_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //do something for enter key
                bttnSend_Click(sender, e);
            }
            else
            {
                return;
            }
        }

        private void bttnSend_Click(object sender, EventArgs e)
        {
            sentText.AppendText(command.Text);
            sentText.AppendText(Environment.NewLine);
            sendText(command.Text);
            command.Clear();
        }

        private void sendText(String text)
        {
            sp.Write(text);
        }
    }
}
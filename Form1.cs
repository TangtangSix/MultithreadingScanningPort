using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
namespace MultithreadingScanningPort
{
    public partial class Form1 : Form
    {
        private bool[] ports = new bool[65536];
        public Form1()
        {
            InitializeComponent();
            panel5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(beginPortText.Text)<0 || int.Parse(beginPortText.Text) > int.Parse(endPortText.Text)  || int.Parse(endPortText.Text)>65565)
            {
                messages.Items.Add("端口错误!");
                return;
            }

            messages.Items.Clear();
            messages.Items.Add("开始扫描.......");
            ScanningPort();

        }

        public void ScanningPort() {
            int start = int.Parse(beginPortText.Text);
            int end = int.Parse(endPortText.Text);
            messages.Items.Add("起始端口"+start);
            messages.Items.Add("结束端口" + end);
            for (int i = start; i <= end; i++)
            {
                Scanning(i);
            }

            messages.Items.Add("端口扫描结束");
        }


        public void Scanning(int port) {
            this.ports[port] = true;
            try {
                TcpClient tmp = new TcpClient(ipAddressText.Text, port);
                messages.Items.Add("端口" + port + "开放");
            }

            catch(System.Exception ex)
            {

            }
        }

    }
}

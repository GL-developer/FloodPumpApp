using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;



namespace FloodPumpApp
{
    public partial class MainForm : Form
    {
        private TcpClient client = new TcpClient();
        private int state = 0;

        private System.Drawing.Bitmap[] images = new System.Drawing.Bitmap[] { 
            Properties.Resources.pump00, 
            Properties.Resources.pump01, 
            Properties.Resources.pump02, 
            Properties.Resources.pump03, 
            Properties.Resources.pump04, 
            Properties.Resources.pump05 
        };
        private uint selectedImage = 0;
        public MainForm()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = images[selectedImage];
        }

        private void button_connection_Click(object sender, EventArgs e)
        {
            if (client.Connected == false)
            {
                client = new TcpClient(textbox_ip.Text, Int32.Parse(textbox_port.Text));
                if (client.Connected == true)
                {
                    MessageBox.Show("연결 성공!!!");
                    button_connection.Text = "이더넷 연결 해제";
                    button_connection.BackColor = System.Drawing.Color.Red;

                    Thread thr = new Thread(getDataThread);
                    thr.IsBackground = true;
                    thr.Start();
                }
                else
                {
                    MessageBox.Show("연결 실패...");
                }
            }
            else
            {
                client.Close();
                button_connection.Text = "이더넷 연결";
                button_connection.BackColor = System.Drawing.Color.Blue;
            }
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            if (client.Connected == true && state == 0)
            {
                NetworkStream buffer = client.GetStream();
                byte[] on = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x14, 0x00, 0x00, 0x4e, 0x58, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0x25, 0x44, 0x57, 0x31, 0x30, 0x30, 0x02, 0x00, 0x01, 0x00 };
                byte[] off = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x14, 0x00, 0x00, 0x4e, 0x58, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0x25, 0x44, 0x57, 0x31, 0x30, 0x30, 0x02, 0x00, 0x00, 0x00 };

                buffer.Write(on);
                Thread.Sleep(200);
                buffer.Write(off);
                return;
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {            
            if (client.Connected == true) 
            {
                NetworkStream buffer = client.GetStream();
                byte[] on = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x14, 0x00, 0x00, 0x4e, 0x58, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0x25, 0x44, 0x57, 0x31, 0x30, 0x31, 0x02, 0x00, 0x01, 0x00 };
                byte[] off = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x14, 0x00, 0x00, 0x4e, 0x58, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0x25, 0x44, 0x57, 0x31, 0x30, 0x31, 0x02, 0x00, 0x00, 0x00 };
                buffer.Write(on);
                Thread.Sleep(200);
                buffer.Write(off);
            }
        }
        private void button_down_Click(object sender, EventArgs e)
        {
            if (client.Connected == true)
            {
                NetworkStream buffer = client.GetStream();
                byte[] on = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x14, 0x00, 0x00, 0x4e, 0x58, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0x25, 0x44, 0x57, 0x31, 0x30, 0x32, 0x02, 0x00, 0x01, 0x00 };
                byte[] off = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x14, 0x00, 0x00, 0x4e, 0x58, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0x25, 0x44, 0x57, 0x31, 0x30, 0x32, 0x02, 0x00, 0x00, 0x00 };
                if (state == 2)
                {
                    buffer.Write(on);
                    button_down.Text = "비가동 정지";
                }
                else
                {
                    buffer.Write(off);
                    button_down.Text = "비가동 시작";
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if (client.Connected == true)
            {
                byte[] on = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x14, 0x00, 0x00, 0x4e, 0x58, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0x25, 0x44, 0x57, 0x31, 0x30, 0x33, 0x02, 0x00, 0x01, 0x00 };
                byte[] off = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x14, 0x00, 0x00, 0x4e, 0x58, 0x00, 0x02, 0x00, 0x00, 0x00, 0x01, 0x00, 0x06, 0x00, 0x25, 0x44, 0x57, 0x31, 0x30, 0x33, 0x02, 0x00, 0x00, 0x00 };
                NetworkStream buffer = client.GetStream();
                buffer.Write(on);
                Thread.Sleep(200);
                buffer.Write(off);
            }
        }

        private void getDataThread()
        {
            byte[] obuf = new byte[] { 0x4c, 0x47, 0x49, 0x53, 0x2d, 0x47, 0x4c, 0x4f, 0x46, 0x41, 0x00, 0x00, 0xb0, 0x33, 0x00, 0x00, 0x10, 0x00, 0x00, 0x00, 0x54, 0x00, 0x14, 0x00, 0x00, 0x00, 0x01, 0x00, 0x04, 0x00, 0x25, 0x44, 0x42, 0x32, 0x0E, 0x00};
            byte[] ibuf = new byte[100] ;
            NetworkStream buffer = client.GetStream();
            while (client.Connected == true )
            {
                buffer.Write(obuf);
                buffer.Read(ibuf, 0, ibuf.Length);
                
                int counter = (ibuf[33] << 8) + ibuf[32];
                int runtime = (ibuf[37] << 8) + ibuf[36];
                int downtime = (ibuf[41] << 8) + ibuf[40];
                state = ibuf[44];
                this.Invoke(new Action(
                    delegate ()
                    {
                        
                        string[] stateText = new string[] { "정지", "비가동", "가동" };
                        
                        label_runtime.Text = TimeSpan.FromSeconds(runtime).ToString();
                        label_downtime.Text = TimeSpan.FromSeconds(downtime).ToString();
                        label_counter.Text = counter.ToString() + " 회";
                        label_state.Text = stateText[state];
                        if(runtime + downtime <= 0)
                        {
                            label_downrate.Text = "0%";
                            label_runrate.Text = "0%";
                        }
                        else
                        {
                            label_downrate.Text = (downtime * 100 / (runtime + downtime)).ToString() + "%";
                            label_runrate.Text = (runtime * 100 / (runtime + downtime)).ToString() + "%";
                        }
                        if (state == 2)
                        {
                            selectedImage++;
                            pictureBox1.Image = images[selectedImage % 5];
                        }
                    }
                ));
                Thread.Sleep(200);
            }
        }        
    }
}

using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace Ethernet_Interface
{

    public partial class Form1 : Form
    {
        // 5-bitlik değişken
        private int statusBits = 0;
        private bool isConnected = false; // Bağlantı durumu

        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            //Connect to server

            client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));


            // Bağlantı başarılı olduğunda isConnected değişkenini true olarak ayarla
            if (client.TcpClient.Connected)
            {
                isConnected = true;

                await Task.Delay(50);

                txtStatus.Text = "Connection Successful!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;

        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            //Update message to txtStatus
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Connection required. Please connect first.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3));
            txtMessage.Text = ""; //mesaji yolladiktan sonra kutuyu temizler
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Connection required. Please connect first.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BtnRelay.BackColor == Color.DarkRed)
            {
                BtnRelay.BackColor = Color.Green;
                statusBits |= (1 << 4);
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("RLON", TimeSpan.FromSeconds(0));



            }
            else if (BtnRelay.BackColor == Color.Green)
            {
                BtnRelay.BackColor = Color.DarkRed;
                statusBits &= ~(1 << 4);
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("RLOFF", TimeSpan.FromSeconds(0));

            }
        }

        private void btnLed1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Connection required. Please connect first.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BtnLed1.BackColor == Color.DarkRed)
            {
                BtnLed1.BackColor = Color.Green;
                statusBits |= (1 << 0); //0. biti 1 yap
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("LED1ON", TimeSpan.FromSeconds(0));
            }
            else if (BtnLed1.BackColor == Color.Green)
            {
                BtnLed1.BackColor = Color.DarkRed;
                statusBits &= ~(1 << 0); //0. biti 0 yap
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("LED1OFF", TimeSpan.FromSeconds(0));
            }
        }

        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Connection required. Please connect first.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BtnLed2.BackColor == Color.DarkRed)
            {
                BtnLed2.BackColor = Color.Green;
                statusBits |= (1 << 1);
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("LED2ON", TimeSpan.FromSeconds(0));

            }
            else if (BtnLed2.BackColor == Color.Green)
            {
                BtnLed2.BackColor = Color.DarkRed;
                statusBits &= ~(1 << 1);
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("LED2OFF", TimeSpan.FromSeconds(0));

            }

        }

        private void btnLed3_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Connection required. Please connect first.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BtnLed3.BackColor == Color.DarkRed)
            {
                BtnLed3.BackColor = Color.Green;
                statusBits |= (1 << 2);
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("LED3ON", TimeSpan.FromSeconds(0));

            }
            else if (BtnLed3.BackColor == Color.Green)
            {
                BtnLed3.BackColor = Color.DarkRed;
                statusBits &= ~(1 << 2);
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("LED3OFF", TimeSpan.FromSeconds(0));

            }
        }

        private void btnLed4_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Connection required. Please connect first.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BtnLed4.BackColor == Color.DarkRed)
            {
                BtnLed4.BackColor = Color.Green;
                statusBits |= (1 << 3);
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("LED4ON", TimeSpan.FromSeconds(0));

            }
            else if (BtnLed4.BackColor == Color.Green)
            {
                BtnLed4.BackColor = Color.DarkRed;
                statusBits &= ~(1 << 3);
                label3.Text = Convert.ToString(statusBits, 2).PadLeft(5, '0');
                client.WriteLineAndGetReply("LED4OFF", TimeSpan.FromSeconds(0));
                
            }
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            

            if (isConnected)
            {
                //Once aktif pinleri kapat
                client.WriteLineAndGetReply("LED1OFF", TimeSpan.FromSeconds(0.1));
                client.WriteLineAndGetReply("LED2OFF", TimeSpan.FromSeconds(0.1));
                client.WriteLineAndGetReply("LED3OFF", TimeSpan.FromSeconds(0.1));
                client.WriteLineAndGetReply("LED4OFF", TimeSpan.FromSeconds(0.1));
                client.WriteLineAndGetReply("RLOFF", TimeSpan.FromSeconds(0.1));
                //Baglanti kapandiktan sonra butun butonlari kapali (kirmizi) hale getir
                BtnLed1.BackColor = Color.DarkRed;
                BtnLed2.BackColor = Color.DarkRed;
                BtnLed3.BackColor = Color.DarkRed;
                BtnLed4.BackColor = Color.DarkRed;
                BtnRelay.BackColor = Color.DarkRed;
                FloatingLeds.BackColor = Color.DarkRed;
                // Bağlantı hala açıksa kapat
                client.Disconnect();
                MessageBox.Show("Disconnected.");
                btnConnect.Enabled = true; // Bağlan düğmesini tekrar etkinleştir
                isConnected = false; // Bağlantı kapalı
                txtStatus.Text = "";
           



            }
            else
            {
                MessageBox.Show("Not Already Connected.");
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        { 
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Connection required. Please connect first.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FloatingLeds.BackColor == Color.DarkRed)
            {
                FloatingLeds.BackColor = Color.Green;
                client.WriteLineAndGetReply("LED1OFF", TimeSpan.FromSeconds(0));
                client.WriteLineAndGetReply("LED2OFF", TimeSpan.FromSeconds(0));
                client.WriteLineAndGetReply("LED3OFF", TimeSpan.FromSeconds(0));
                client.WriteLineAndGetReply("LED4OFF", TimeSpan.FromSeconds(0));
                while (FloatingLeds.BackColor == Color.Green)
                {
                    await Task.Delay(50);  // 50 milisaniye beklet
                    client.WriteLineAndGetReply("LED1ON", TimeSpan.FromSeconds(0.2));
                    client.WriteLineAndGetReply("LED2ON", TimeSpan.FromSeconds(0.2));
                    client.WriteLineAndGetReply("LED3ON", TimeSpan.FromSeconds(0.2));
                    client.WriteLineAndGetReply("LED4ON", TimeSpan.FromSeconds(0.2));
                    client.WriteLineAndGetReply("LED1OFF", TimeSpan.FromSeconds(0.2));
                    client.WriteLineAndGetReply("LED2OFF", TimeSpan.FromSeconds(0.2));
                    client.WriteLineAndGetReply("LED3OFF", TimeSpan.FromSeconds(0.2));
                    client.WriteLineAndGetReply("LED4OFF", TimeSpan.FromSeconds(0.2));
                    await Task.Delay(50);
                }


            }
            else if (FloatingLeds.BackColor == Color.Green)
            {
                FloatingLeds.BackColor = Color.DarkRed;
                client.WriteLineAndGetReply("LED1OFF", TimeSpan.FromSeconds(0));
                client.WriteLineAndGetReply("LED2OFF", TimeSpan.FromSeconds(0));
                client.WriteLineAndGetReply("LED3OFF", TimeSpan.FromSeconds(0));
                client.WriteLineAndGetReply("LED4OFF", TimeSpan.FromSeconds(0));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtStatus.Text = "";
        }
    }
}
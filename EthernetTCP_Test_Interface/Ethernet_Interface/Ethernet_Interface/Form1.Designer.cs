namespace Ethernet_Interface
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnDisconnect;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.BtnLed1 = new System.Windows.Forms.Button();
            this.BtnLed2 = new System.Windows.Forms.Button();
            this.BtnLed3 = new System.Windows.Forms.Button();
            this.BtnLed4 = new System.Windows.Forms.Button();
            this.BtnRelay = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FloatingLeds = new System.Windows.Forms.Button();
            this.Window = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new System.Drawing.Point(559, 37);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(94, 23);
            btnDisconnect.TabIndex = 10;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module IP Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(478, 37);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(211, 37);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 22);
            this.txtHost.TabIndex = 3;
            this.txtHost.Text = "192.168.127.123";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(369, 37);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "4001";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(95, 81);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(558, 82);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(578, 169);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(95, 198);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(558, 94);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // BtnLed1
            // 
            this.BtnLed1.BackColor = System.Drawing.Color.DarkRed;
            this.BtnLed1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnLed1.Location = new System.Drawing.Point(95, 339);
            this.BtnLed1.Name = "BtnLed1";
            this.BtnLed1.Size = new System.Drawing.Size(75, 33);
            this.BtnLed1.TabIndex = 8;
            this.BtnLed1.Text = "Led 1";
            this.BtnLed1.UseVisualStyleBackColor = false;
            this.BtnLed1.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // BtnLed2
            // 
            this.BtnLed2.BackColor = System.Drawing.Color.DarkRed;
            this.BtnLed2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnLed2.Location = new System.Drawing.Point(180, 339);
            this.BtnLed2.Name = "BtnLed2";
            this.BtnLed2.Size = new System.Drawing.Size(75, 33);
            this.BtnLed2.TabIndex = 8;
            this.BtnLed2.Text = "Led 2";
            this.BtnLed2.UseVisualStyleBackColor = false;
            this.BtnLed2.Click += new System.EventHandler(this.btnLed2_Click);
            // 
            // BtnLed3
            // 
            this.BtnLed3.BackColor = System.Drawing.Color.DarkRed;
            this.BtnLed3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnLed3.Location = new System.Drawing.Point(261, 339);
            this.BtnLed3.Name = "BtnLed3";
            this.BtnLed3.Size = new System.Drawing.Size(75, 33);
            this.BtnLed3.TabIndex = 8;
            this.BtnLed3.Text = "Led 3";
            this.BtnLed3.UseVisualStyleBackColor = false;
            this.BtnLed3.Click += new System.EventHandler(this.btnLed3_Click);
            // 
            // BtnLed4
            // 
            this.BtnLed4.BackColor = System.Drawing.Color.DarkRed;
            this.BtnLed4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnLed4.Location = new System.Drawing.Point(342, 339);
            this.BtnLed4.Name = "BtnLed4";
            this.BtnLed4.Size = new System.Drawing.Size(75, 33);
            this.BtnLed4.TabIndex = 8;
            this.BtnLed4.Text = "Led 4";
            this.BtnLed4.UseVisualStyleBackColor = false;
            this.BtnLed4.Click += new System.EventHandler(this.btnLed4_Click);
            // 
            // BtnRelay
            // 
            this.BtnRelay.BackColor = System.Drawing.Color.DarkRed;
            this.BtnRelay.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BtnRelay.Location = new System.Drawing.Point(430, 339);
            this.BtnRelay.Name = "BtnRelay";
            this.BtnRelay.Size = new System.Drawing.Size(75, 33);
            this.BtnRelay.TabIndex = 8;
            this.BtnRelay.Text = "Relay";
            this.BtnRelay.UseVisualStyleBackColor = false;
            this.BtnRelay.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "00000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Write by Mete Sepetcioglu";
            // 
            // FloatingLeds
            // 
            this.FloatingLeds.BackColor = System.Drawing.Color.DarkRed;
            this.FloatingLeds.ForeColor = System.Drawing.SystemColors.Menu;
            this.FloatingLeds.Location = new System.Drawing.Point(511, 339);
            this.FloatingLeds.Name = "FloatingLeds";
            this.FloatingLeds.Size = new System.Drawing.Size(111, 33);
            this.FloatingLeds.TabIndex = 11;
            this.FloatingLeds.Text = "Floating Leds";
            this.FloatingLeds.UseVisualStyleBackColor = false;
            this.FloatingLeds.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Window
            // 
            this.Window.AutoSize = true;
            this.Window.Location = new System.Drawing.Point(103, 179);
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(55, 16);
            this.Window.TabIndex = 12;
            this.Window.Text = "Window";
            this.Window.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(732, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Window);
            this.Controls.Add(this.FloatingLeds);
            this.Controls.Add(btnDisconnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.BtnRelay);
            this.Controls.Add(this.BtnLed4);
            this.Controls.Add(this.BtnLed3);
            this.Controls.Add(this.BtnLed2);
            this.Controls.Add(this.BtnLed1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button BtnLed1;
        private System.Windows.Forms.Button BtnLed2;
        private System.Windows.Forms.Button BtnLed3;
        private System.Windows.Forms.Button BtnLed4;
        private System.Windows.Forms.Button BtnRelay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FloatingLeds;
        private System.Windows.Forms.Label Window;
        private System.Windows.Forms.Button button1;
    }
}


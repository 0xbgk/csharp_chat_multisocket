namespace multisocket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_host = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.text_msg = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_dc = new System.Windows.Forms.Button();
            this.client_al = new System.Windows.Forms.TextBox();
            this.nthclient = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hostonly = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port ";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(22, 35);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 3;
            // 
            // text_port
            // 
            this.text_port.Location = new System.Drawing.Point(198, 35);
            this.text_port.Name = "text_port";
            this.text_port.Size = new System.Drawing.Size(100, 20);
            this.text_port.TabIndex = 5;
            this.text_port.Text = "1";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(22, 91);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(135, 23);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Client";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_host
            // 
            this.btn_host.Location = new System.Drawing.Point(87, 62);
            this.btn_host.Name = "btn_host";
            this.btn_host.Size = new System.Drawing.Size(135, 23);
            this.btn_host.TabIndex = 7;
            this.btn_host.Text = "Server";
            this.btn_host.UseVisualStyleBackColor = true;
            this.btn_host.Click += new System.EventHandler(this.btn_host_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(22, 374);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(241, 23);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // text_msg
            // 
            this.text_msg.Location = new System.Drawing.Point(22, 348);
            this.text_msg.Name = "text_msg";
            this.text_msg.Size = new System.Drawing.Size(276, 20);
            this.text_msg.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 222);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btn_dc
            // 
            this.btn_dc.Location = new System.Drawing.Point(163, 91);
            this.btn_dc.Name = "btn_dc";
            this.btn_dc.Size = new System.Drawing.Size(135, 23);
            this.btn_dc.TabIndex = 12;
            this.btn_dc.Text = "Leave";
            this.btn_dc.UseVisualStyleBackColor = true;
            this.btn_dc.Click += new System.EventHandler(this.btn_dc_Click);
            // 
            // client_al
            // 
            this.client_al.Location = new System.Drawing.Point(270, 376);
            this.client_al.Name = "client_al";
            this.client_al.Size = new System.Drawing.Size(28, 20);
            this.client_al.TabIndex = 17;
            this.client_al.Text = "1";
            this.client_al.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nthclient
            // 
            this.nthclient.AutoSize = true;
            this.nthclient.Location = new System.Drawing.Point(283, 404);
            this.nthclient.Name = "nthclient";
            this.nthclient.Size = new System.Drawing.Size(15, 14);
            this.nthclient.TabIndex = 18;
            this.nthclient.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "nth Client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Host Only";
            // 
            // hostonly
            // 
            this.hostonly.AutoSize = true;
            this.hostonly.Location = new System.Drawing.Point(205, 404);
            this.hostonly.Name = "hostonly";
            this.hostonly.Size = new System.Drawing.Size(15, 14);
            this.hostonly.TabIndex = 21;
            this.hostonly.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hostonly);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nthclient);
            this.Controls.Add(this.client_al);
            this.Controls.Add(this.btn_dc);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.text_msg);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_host);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.text_port);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "l";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_name;        
        private System.Windows.Forms.TextBox text_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_host;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox text_msg;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_dc;
        private System.Windows.Forms.TextBox client_al;
        private System.Windows.Forms.CheckBox nthclient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox hostonly;
        private System.Windows.Forms.Label label5;
    }
}


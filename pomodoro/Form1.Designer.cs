namespace pomodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.sureLabel = new System.Windows.Forms.Label();
            this.baslatButton = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.durdurbutton = new Guna.UI2.WinForms.Guna2Button();
            this.devamet = new Guna.UI2.WinForms.Guna2Button();
            this.sifirla = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sureLabel
            // 
            this.sureLabel.AutoSize = true;
            this.sureLabel.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sureLabel.Location = new System.Drawing.Point(342, 161);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(266, 109);
            this.sureLabel.TabIndex = 0;
            this.sureLabel.Text = "20:00";
            this.sureLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // baslatButton
            // 
            this.baslatButton.Animated = true;
            this.baslatButton.BorderRadius = 20;
            this.baslatButton.DefaultAutoSize = true;
            this.baslatButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.baslatButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.baslatButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.baslatButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.baslatButton.FillColor = System.Drawing.Color.Green;
            this.baslatButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.baslatButton.ForeColor = System.Drawing.Color.White;
            this.baslatButton.Location = new System.Drawing.Point(426, 273);
            this.baslatButton.Name = "baslatButton";
            this.baslatButton.Size = new System.Drawing.Size(99, 39);
            this.baslatButton.TabIndex = 1;
            this.baslatButton.Text = "Başlat";
            this.baslatButton.Click += new System.EventHandler(this.baslatButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // durdurbutton
            // 
            this.durdurbutton.Animated = true;
            this.durdurbutton.BorderRadius = 20;
            this.durdurbutton.DefaultAutoSize = true;
            this.durdurbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.durdurbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.durdurbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.durdurbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.durdurbutton.FillColor = System.Drawing.Color.Maroon;
            this.durdurbutton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.durdurbutton.ForeColor = System.Drawing.Color.White;
            this.durdurbutton.Location = new System.Drawing.Point(418, 273);
            this.durdurbutton.Name = "durdurbutton";
            this.durdurbutton.Size = new System.Drawing.Size(115, 39);
            this.durdurbutton.TabIndex = 2;
            this.durdurbutton.Text = "Durdur";
            this.durdurbutton.Visible = false;
            this.durdurbutton.Click += new System.EventHandler(this.durdurbutton_Click);
            // 
            // devamet
            // 
            this.devamet.Animated = true;
            this.devamet.BorderRadius = 20;
            this.devamet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.devamet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.devamet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.devamet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.devamet.FillColor = System.Drawing.Color.Green;
            this.devamet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devamet.ForeColor = System.Drawing.Color.White;
            this.devamet.Location = new System.Drawing.Point(361, 273);
            this.devamet.Name = "devamet";
            this.devamet.Size = new System.Drawing.Size(105, 39);
            this.devamet.TabIndex = 3;
            this.devamet.Text = "Devam Et";
            this.devamet.Visible = false;
            this.devamet.Click += new System.EventHandler(this.devamet_Click);
            // 
            // sifirla
            // 
            this.sifirla.Animated = true;
            this.sifirla.BorderRadius = 20;
            this.sifirla.DefaultAutoSize = true;
            this.sifirla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sifirla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sifirla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sifirla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sifirla.FillColor = System.Drawing.Color.Maroon;
            this.sifirla.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.sifirla.ForeColor = System.Drawing.Color.White;
            this.sifirla.Location = new System.Drawing.Point(466, 273);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(99, 39);
            this.sifirla.TabIndex = 4;
            this.sifirla.Text = "Sıfırla";
            this.sifirla.Visible = false;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(903, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PgLang Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "maze";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(950, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.devamet);
            this.Controls.Add(this.durdurbutton);
            this.Controls.Add(this.baslatButton);
            this.Controls.Add(this.sureLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label sureLabel;
        private Guna.UI2.WinForms.Guna2Button baslatButton;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button durdurbutton;
        private Guna.UI2.WinForms.Guna2Button devamet;
        private Guna.UI2.WinForms.Guna2Button sifirla;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
    }
}


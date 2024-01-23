
namespace DytBaharucarAppfinal
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.ExitAnasayfa = new System.Windows.Forms.Button();
            this.MinimalAnasayfa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appointmentCreate = new Guna.UI.WinForms.GunaButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.makeAppointment1 = new DytBaharucarAppfinal.UserInterface.MakeAppointment();
            this.danisanKontrol1 = new DytBaharucarAppfinal.UserInterface.DanisanKontrol();
            this.customerRegistiration1 = new DytBaharucarAppfinal.UserInterface.CustomerRegistiration();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitAnasayfa
            // 
            this.ExitAnasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitAnasayfa.BackgroundImage")));
            this.ExitAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitAnasayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitAnasayfa.Location = new System.Drawing.Point(12, 12);
            this.ExitAnasayfa.Name = "ExitAnasayfa";
            this.ExitAnasayfa.Size = new System.Drawing.Size(53, 49);
            this.ExitAnasayfa.TabIndex = 0;
            this.ExitAnasayfa.UseVisualStyleBackColor = false;
            this.ExitAnasayfa.Click += new System.EventHandler(this.ExitAnasayfa_Click);
            // 
            // MinimalAnasayfa
            // 
            this.MinimalAnasayfa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MinimalAnasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MinimalAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimalAnasayfa.BackgroundImage")));
            this.MinimalAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinimalAnasayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimalAnasayfa.Location = new System.Drawing.Point(12, 67);
            this.MinimalAnasayfa.Name = "MinimalAnasayfa";
            this.MinimalAnasayfa.Size = new System.Drawing.Size(53, 49);
            this.MinimalAnasayfa.TabIndex = 1;
            this.MinimalAnasayfa.UseVisualStyleBackColor = false;
            this.MinimalAnasayfa.Click += new System.EventHandler(this.MinimalAnasayfa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appointmentCreate);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(84, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 104);
            this.panel1.TabIndex = 2;
            // 
            // appointmentCreate
            // 
            this.appointmentCreate.AnimationHoverSpeed = 0.07F;
            this.appointmentCreate.AnimationSpeed = 0.03F;
            this.appointmentCreate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.appointmentCreate.BorderColor = System.Drawing.Color.Black;
            this.appointmentCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.appointmentCreate.FocusedColor = System.Drawing.Color.Empty;
            this.appointmentCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.appointmentCreate.ForeColor = System.Drawing.Color.White;
            this.appointmentCreate.Image = ((System.Drawing.Image)(resources.GetObject("appointmentCreate.Image")));
            this.appointmentCreate.ImageSize = new System.Drawing.Size(20, 20);
            this.appointmentCreate.Location = new System.Drawing.Point(375, 19);
            this.appointmentCreate.Name = "appointmentCreate";
            this.appointmentCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.appointmentCreate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.appointmentCreate.OnHoverForeColor = System.Drawing.Color.White;
            this.appointmentCreate.OnHoverImage = null;
            this.appointmentCreate.OnPressedColor = System.Drawing.Color.Black;
            this.appointmentCreate.Size = new System.Drawing.Size(150, 70);
            this.appointmentCreate.TabIndex = 3;
            this.appointmentCreate.Text = "Randevu Oluştur";
            this.appointmentCreate.Click += new System.EventHandler(this.appointmentCreate_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(202, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Danışan Kontrol";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(901, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Çalışanlar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(34, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Danışan Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this;
            // 
            // makeAppointment1
            // 
            this.makeAppointment1.Location = new System.Drawing.Point(12, 153);
            this.makeAppointment1.Name = "makeAppointment1";
            this.makeAppointment1.Size = new System.Drawing.Size(1374, 485);
            this.makeAppointment1.TabIndex = 3;
            // 
            // danisanKontrol1
            // 
            this.danisanKontrol1.Location = new System.Drawing.Point(12, 143);
            this.danisanKontrol1.Name = "danisanKontrol1";
            this.danisanKontrol1.Size = new System.Drawing.Size(1336, 505);
            this.danisanKontrol1.TabIndex = 4;
            // 
            // customerRegistiration1
            // 
            this.customerRegistiration1.Location = new System.Drawing.Point(12, 143);
            this.customerRegistiration1.Name = "customerRegistiration1";
            this.customerRegistiration1.Size = new System.Drawing.Size(1374, 505);
            this.customerRegistiration1.TabIndex = 5;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1401, 660);
            this.Controls.Add(this.customerRegistiration1);
            this.Controls.Add(this.danisanKontrol1);
            this.Controls.Add(this.makeAppointment1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MinimalAnasayfa);
            this.Controls.Add(this.ExitAnasayfa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitAnasayfa;
        private System.Windows.Forms.Button MinimalAnasayfa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaButton appointmentCreate;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private UserInterface.CustomerRegistiration customerRegistiration1;
        private UserInterface.DanisanKontrol danisanKontrol1;
        private UserInterface.MakeAppointment makeAppointment1;
    }
}

namespace DytBaharucarAppfinal.UserInterface
{
    partial class CustomerRegistiration
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegistiration));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.patientName = new Guna.UI.WinForms.GunaTextBox();
            this.patientPhone = new Guna.UI.WinForms.GunaTextBox();
            this.patientBirth = new Guna.UI.WinForms.GunaDateTimePicker();
            this.patientRegTime = new Guna.UI.WinForms.GunaDateTimePicker();
            this.patientPurchasePlan = new Guna.UI.WinForms.GunaComboBox();
            this.patientPaymentMethod = new Guna.UI.WinForms.GunaComboBox();
            this.patientGender = new Guna.UI.WinForms.GunaComboBox();
            this.patientRegButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.PatientRegistrationType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.PatientAdditionalNot = new Guna.UI.WinForms.GunaTextBox();
            this.PatientAmountPaid = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(575, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(89, 15);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Danışman Kayıt";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(121, 103);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(32, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "İsim ";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(121, 174);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(45, 15);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Telefon";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(121, 252);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Cinsiyet";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(121, 334);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(78, 15);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Doğum Tarihi";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(575, 103);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(64, 15);
            this.gunaLabel6.TabIndex = 5;
            this.gunaLabel6.Text = "Kayıt Tarihi";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(575, 174);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(67, 15);
            this.gunaLabel7.TabIndex = 6;
            this.gunaLabel7.Text = "Kayıt Süresi";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(575, 252);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel8.TabIndex = 7;
            this.gunaLabel8.Text = "Ödeme Türü";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientName
            // 
            this.patientName.BaseColor = System.Drawing.Color.White;
            this.patientName.BorderColor = System.Drawing.Color.Silver;
            this.patientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patientName.FocusedBaseColor = System.Drawing.Color.White;
            this.patientName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.patientName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patientName.Location = new System.Drawing.Point(124, 132);
            this.patientName.Name = "patientName";
            this.patientName.PasswordChar = '\0';
            this.patientName.SelectedText = "";
            this.patientName.Size = new System.Drawing.Size(225, 30);
            this.patientName.TabIndex = 8;
            // 
            // patientPhone
            // 
            this.patientPhone.BaseColor = System.Drawing.Color.White;
            this.patientPhone.BorderColor = System.Drawing.Color.Silver;
            this.patientPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patientPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.patientPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.patientPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patientPhone.Location = new System.Drawing.Point(124, 203);
            this.patientPhone.Name = "patientPhone";
            this.patientPhone.PasswordChar = '\0';
            this.patientPhone.SelectedText = "";
            this.patientPhone.Size = new System.Drawing.Size(225, 30);
            this.patientPhone.TabIndex = 9;
            // 
            // patientBirth
            // 
            this.patientBirth.BaseColor = System.Drawing.Color.White;
            this.patientBirth.BorderColor = System.Drawing.Color.Silver;
            this.patientBirth.CustomFormat = null;
            this.patientBirth.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.patientBirth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patientBirth.ForeColor = System.Drawing.Color.Black;
            this.patientBirth.Location = new System.Drawing.Point(126, 369);
            this.patientBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.patientBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.patientBirth.Name = "patientBirth";
            this.patientBirth.OnHoverBaseColor = System.Drawing.Color.White;
            this.patientBirth.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientBirth.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientBirth.OnPressedColor = System.Drawing.Color.Black;
            this.patientBirth.Size = new System.Drawing.Size(223, 30);
            this.patientBirth.TabIndex = 11;
            this.patientBirth.Text = "18 Ocak 2024 Perşembe";
            this.patientBirth.Value = new System.DateTime(2024, 1, 18, 15, 33, 12, 355);
            // 
            // patientRegTime
            // 
            this.patientRegTime.BaseColor = System.Drawing.Color.White;
            this.patientRegTime.BorderColor = System.Drawing.Color.Silver;
            this.patientRegTime.CustomFormat = null;
            this.patientRegTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.patientRegTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientRegTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patientRegTime.ForeColor = System.Drawing.Color.Black;
            this.patientRegTime.Location = new System.Drawing.Point(578, 132);
            this.patientRegTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.patientRegTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.patientRegTime.Name = "patientRegTime";
            this.patientRegTime.OnHoverBaseColor = System.Drawing.Color.White;
            this.patientRegTime.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientRegTime.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientRegTime.OnPressedColor = System.Drawing.Color.Black;
            this.patientRegTime.Size = new System.Drawing.Size(223, 30);
            this.patientRegTime.TabIndex = 12;
            this.patientRegTime.Text = "18 Ocak 2024 Perşembe";
            this.patientRegTime.Value = new System.DateTime(2024, 1, 18, 15, 33, 12, 355);
            // 
            // patientPurchasePlan
            // 
            this.patientPurchasePlan.BackColor = System.Drawing.Color.Transparent;
            this.patientPurchasePlan.BaseColor = System.Drawing.Color.White;
            this.patientPurchasePlan.BorderColor = System.Drawing.Color.Silver;
            this.patientPurchasePlan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.patientPurchasePlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientPurchasePlan.FocusedColor = System.Drawing.Color.Empty;
            this.patientPurchasePlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.patientPurchasePlan.ForeColor = System.Drawing.Color.Black;
            this.patientPurchasePlan.FormattingEnabled = true;
            this.patientPurchasePlan.Items.AddRange(new object[] {
            "1 Ay",
            "2 Ay",
            "3 Ay",
            "4 Ay",
            "5 Ay",
            "6 Ay",
            "7 Ay",
            "8 Ay",
            "9 Ay",
            "10 Ay",
            "11 Ay",
            "12 Ay"});
            this.patientPurchasePlan.Location = new System.Drawing.Point(578, 203);
            this.patientPurchasePlan.Name = "patientPurchasePlan";
            this.patientPurchasePlan.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientPurchasePlan.OnHoverItemForeColor = System.Drawing.Color.White;
            this.patientPurchasePlan.Size = new System.Drawing.Size(223, 26);
            this.patientPurchasePlan.TabIndex = 13;
            // 
            // patientPaymentMethod
            // 
            this.patientPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.patientPaymentMethod.BaseColor = System.Drawing.Color.White;
            this.patientPaymentMethod.BorderColor = System.Drawing.Color.Silver;
            this.patientPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.patientPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientPaymentMethod.FocusedColor = System.Drawing.Color.Empty;
            this.patientPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.patientPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.patientPaymentMethod.FormattingEnabled = true;
            this.patientPaymentMethod.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit"});
            this.patientPaymentMethod.Location = new System.Drawing.Point(578, 285);
            this.patientPaymentMethod.Name = "patientPaymentMethod";
            this.patientPaymentMethod.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientPaymentMethod.OnHoverItemForeColor = System.Drawing.Color.White;
            this.patientPaymentMethod.Size = new System.Drawing.Size(223, 26);
            this.patientPaymentMethod.TabIndex = 14;
            // 
            // patientGender
            // 
            this.patientGender.BackColor = System.Drawing.Color.Transparent;
            this.patientGender.BaseColor = System.Drawing.Color.White;
            this.patientGender.BorderColor = System.Drawing.Color.Silver;
            this.patientGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.patientGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientGender.FocusedColor = System.Drawing.Color.Empty;
            this.patientGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.patientGender.ForeColor = System.Drawing.Color.Black;
            this.patientGender.FormattingEnabled = true;
            this.patientGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.patientGender.Location = new System.Drawing.Point(124, 285);
            this.patientGender.Name = "patientGender";
            this.patientGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.patientGender.Size = new System.Drawing.Size(223, 26);
            this.patientGender.TabIndex = 16;
            // 
            // patientRegButton
            // 
            this.patientRegButton.AnimationHoverSpeed = 0.07F;
            this.patientRegButton.AnimationSpeed = 0.03F;
            this.patientRegButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patientRegButton.BorderColor = System.Drawing.Color.Black;
            this.patientRegButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.patientRegButton.FocusedColor = System.Drawing.Color.Empty;
            this.patientRegButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patientRegButton.ForeColor = System.Drawing.Color.White;
            this.patientRegButton.Image = ((System.Drawing.Image)(resources.GetObject("patientRegButton.Image")));
            this.patientRegButton.ImageSize = new System.Drawing.Size(20, 20);
            this.patientRegButton.Location = new System.Drawing.Point(1160, 441);
            this.patientRegButton.Name = "patientRegButton";
            this.patientRegButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.patientRegButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.patientRegButton.OnHoverForeColor = System.Drawing.Color.White;
            this.patientRegButton.OnHoverImage = null;
            this.patientRegButton.OnPressedColor = System.Drawing.Color.Black;
            this.patientRegButton.Size = new System.Drawing.Size(186, 42);
            this.patientRegButton.TabIndex = 17;
            this.patientRegButton.Text = "Kaydet";
            this.patientRegButton.Click += new System.EventHandler(this.patientRegButton_Click);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(575, 334);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(60, 15);
            this.gunaLabel9.TabIndex = 18;
            this.gunaLabel9.Text = "Kayıt Türü";
            this.gunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.Location = new System.Drawing.Point(957, 103);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(86, 15);
            this.gunaLabel10.TabIndex = 19;
            this.gunaLabel10.Text = "Ödenen Miktar";
            this.gunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientRegistrationType
            // 
            this.PatientRegistrationType.BackColor = System.Drawing.Color.Transparent;
            this.PatientRegistrationType.BaseColor = System.Drawing.Color.White;
            this.PatientRegistrationType.BorderColor = System.Drawing.Color.Silver;
            this.PatientRegistrationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatientRegistrationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientRegistrationType.FocusedColor = System.Drawing.Color.Empty;
            this.PatientRegistrationType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PatientRegistrationType.ForeColor = System.Drawing.Color.Black;
            this.PatientRegistrationType.FormattingEnabled = true;
            this.PatientRegistrationType.Items.AddRange(new object[] {
            "Probody+Diyet",
            "Probody",
            "Diyet",
            "Zumba"});
            this.PatientRegistrationType.Location = new System.Drawing.Point(578, 373);
            this.PatientRegistrationType.Name = "PatientRegistrationType";
            this.PatientRegistrationType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PatientRegistrationType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.PatientRegistrationType.Size = new System.Drawing.Size(223, 26);
            this.PatientRegistrationType.TabIndex = 20;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(957, 174);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel11.TabIndex = 22;
            this.gunaLabel11.Text = "Ekstra Not";
            this.gunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientAdditionalNot
            // 
            this.PatientAdditionalNot.BaseColor = System.Drawing.Color.White;
            this.PatientAdditionalNot.BorderColor = System.Drawing.Color.Silver;
            this.PatientAdditionalNot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientAdditionalNot.FocusedBaseColor = System.Drawing.Color.White;
            this.PatientAdditionalNot.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PatientAdditionalNot.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PatientAdditionalNot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatientAdditionalNot.Location = new System.Drawing.Point(960, 203);
            this.PatientAdditionalNot.Multiline = true;
            this.PatientAdditionalNot.Name = "PatientAdditionalNot";
            this.PatientAdditionalNot.PasswordChar = '\0';
            this.PatientAdditionalNot.SelectedText = "";
            this.PatientAdditionalNot.Size = new System.Drawing.Size(225, 196);
            this.PatientAdditionalNot.TabIndex = 23;
            // 
            // PatientAmountPaid
            // 
            this.PatientAmountPaid.BaseColor = System.Drawing.Color.White;
            this.PatientAmountPaid.BorderColor = System.Drawing.Color.Silver;
            this.PatientAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientAmountPaid.FocusedBaseColor = System.Drawing.Color.White;
            this.PatientAmountPaid.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PatientAmountPaid.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PatientAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatientAmountPaid.Location = new System.Drawing.Point(960, 132);
            this.PatientAmountPaid.Name = "PatientAmountPaid";
            this.PatientAmountPaid.PasswordChar = '\0';
            this.PatientAmountPaid.SelectedText = "";
            this.PatientAmountPaid.Size = new System.Drawing.Size(225, 30);
            this.PatientAmountPaid.TabIndex = 24;
            // 
            // CustomerRegistiration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PatientAmountPaid);
            this.Controls.Add(this.PatientAdditionalNot);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.PatientRegistrationType);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.patientRegButton);
            this.Controls.Add(this.patientGender);
            this.Controls.Add(this.patientPaymentMethod);
            this.Controls.Add(this.patientPurchasePlan);
            this.Controls.Add(this.patientRegTime);
            this.Controls.Add(this.patientBirth);
            this.Controls.Add(this.patientPhone);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "CustomerRegistiration";
            this.Size = new System.Drawing.Size(1374, 505);
            this.Load += new System.EventHandler(this.CustomerRegistiration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox patientGender;
        private Guna.UI.WinForms.GunaComboBox patientPaymentMethod;
        private Guna.UI.WinForms.GunaComboBox patientPurchasePlan;
        private Guna.UI.WinForms.GunaDateTimePicker patientRegTime;
        private Guna.UI.WinForms.GunaDateTimePicker patientBirth;
        private Guna.UI.WinForms.GunaTextBox patientPhone;
        private Guna.UI.WinForms.GunaTextBox patientName;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton patientRegButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaComboBox PatientRegistrationType;
        private Guna.UI.WinForms.GunaTextBox PatientAdditionalNot;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTextBox PatientAmountPaid;
    }
}

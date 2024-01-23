
namespace DytBaharucarAppfinal.UserInterface
{
    partial class MakeAppointment
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.HoursSelector = new System.Windows.Forms.ComboBox();
            this.MakeAppointmentButton = new System.Windows.Forms.Button();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.dytBaharDataSet = new DytBaharucarAppfinal.dytBaharDataSet();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsTableAdapter = new DytBaharucarAppfinal.dytBaharDataSetTableAdapters.appointmentsTableAdapter();
            this.appointmentsDateView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dytBaharDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDateView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // HoursSelector
            // 
            this.HoursSelector.FormattingEnabled = true;
            this.HoursSelector.Location = new System.Drawing.Point(295, 27);
            this.HoursSelector.Name = "HoursSelector";
            this.HoursSelector.Size = new System.Drawing.Size(210, 21);
            this.HoursSelector.TabIndex = 2;
            this.HoursSelector.Text = "randevu_deneme";
            this.HoursSelector.SelectedIndexChanged += new System.EventHandler(this.HoursSelector_SelectedIndexChanged_1);
            // 
            // MakeAppointmentButton
            // 
            this.MakeAppointmentButton.Location = new System.Drawing.Point(827, 27);
            this.MakeAppointmentButton.Name = "MakeAppointmentButton";
            this.MakeAppointmentButton.Size = new System.Drawing.Size(169, 23);
            this.MakeAppointmentButton.TabIndex = 3;
            this.MakeAppointmentButton.Text = "Randevu oluştur";
            this.MakeAppointmentButton.UseVisualStyleBackColor = true;
            this.MakeAppointmentButton.Click += new System.EventHandler(this.MakeAppointmentButton_Click);
            // 
            // patientComboBox
            // 
            this.patientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patientComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(542, 28);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(223, 21);
            this.patientComboBox.TabIndex = 4;
            // 
            // dytBaharDataSet
            // 
            this.dytBaharDataSet.DataSetName = "dytBaharDataSet";
            this.dytBaharDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "appointments";
            this.appointmentsBindingSource.DataSource = this.dytBaharDataSet;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentsDateView
            // 
            this.appointmentsDateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDateView.Location = new System.Drawing.Point(37, 161);
            this.appointmentsDateView.Name = "appointmentsDateView";
            this.appointmentsDateView.Size = new System.Drawing.Size(1238, 248);
            this.appointmentsDateView.TabIndex = 5;
            // 
            // MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appointmentsDateView);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.MakeAppointmentButton);
            this.Controls.Add(this.HoursSelector);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "MakeAppointment";
            this.Size = new System.Drawing.Size(1374, 463);
            this.Load += new System.EventHandler(this.MakeAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dytBaharDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDateView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private dytBaharDataSet dytBaharDataSet;
        private dytBaharDataSetTableAdapters.appointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.Button MakeAppointmentButton;
        private System.Windows.Forms.ComboBox HoursSelector;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.DataGridView appointmentsDateView;
    }
}

namespace ADTServis.UI
{
    partial class AppointmentsForm
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
            lblCustomer = new Label();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            lblNote = new Label();
            txtNote = new TextBox();
            cmbCustomer = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            pnlAppointment = new Panel();
            dgvAppointments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(524, 75);
            lblCustomer.Margin = new Padding(6, 0, 6, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(95, 32);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Müşteri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 224);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 0;
            label2.Text = "Randevu Tarihi";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(741, 224);
            dtpDate.Margin = new Padding(6, 6, 6, 6);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(368, 39);
            dtpDate.TabIndex = 2;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(524, 331);
            lblNote.Margin = new Padding(6, 0, 6, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(139, 32);
            lblNote.TabIndex = 0;
            lblNote.Text = "Not/Şikayet";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(793, 331);
            txtNote.Margin = new Padding(6, 6, 6, 6);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(182, 45);
            txtNote.TabIndex = 3;
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(776, 75);
            cmbCustomer.Margin = new Padding(6, 6, 6, 6);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(221, 40);
            cmbCustomer.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(524, 435);
            lblStatus.Margin = new Padding(6, 0, 6, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(88, 32);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Durum";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(776, 435);
            cmbStatus.Margin = new Padding(6, 6, 6, 6);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(221, 40);
            cmbStatus.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(793, 563);
            btnSave.Margin = new Padding(6, 6, 6, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 49);
            btnSave.TabIndex = 5;
            btnSave.Text = "Randevu Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pnlAppointment
            // 
            pnlAppointment.Location = new Point(102, 166);
            pnlAppointment.Margin = new Padding(6, 6, 6, 6);
            pnlAppointment.Name = "pnlAppointment";
            pnlAppointment.Size = new Size(371, 213);
            pnlAppointment.TabIndex = 6;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(312, 563);
            dgvAppointments.Margin = new Padding(6, 6, 6, 6);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 82;
            dgvAppointments.Size = new Size(446, 320);
            dgvAppointments.TabIndex = 7;
            dgvAppointments.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(dgvAppointments);
            Controls.Add(pnlAppointment);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(cmbCustomer);
            Controls.Add(txtNote);
            Controls.Add(dtpDate);
            Controls.Add(lblNote);
            Controls.Add(lblStatus);
            Controls.Add(label2);
            Controls.Add(lblCustomer);
            Margin = new Padding(6, 6, 6, 6);
            Name = "AppointmentsForm";
            Text = "Randevu Yönetimi";
            Load += AppointmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomer;
        private Label label2;
        private DateTimePicker dtpDate;
        private Label lblNote;
        private TextBox txtNote;
        private ComboBox cmbCustomer;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Panel pnlAppointment;
        private DataGridView dgvAppointments;
    }
}
namespace ADTServis.UI
{
    partial class MainForm
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
            pnlTop = new Panel();
            lblTitle = new Label();
            btnCustomers = new Button();
            btnAppointments = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 100);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(365, 145);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ADT Mekanik Servisi";
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(419, 206);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(75, 23);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Location = new Point(419, 235);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(75, 23);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "Randevular";
            btnAppointments.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(419, 274);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnAppointments);
            Controls.Add(btnCustomers);
            Controls.Add(lblTitle);
            Controls.Add(pnlTop);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblTitle;
        private Button btnCustomers;
        private Button btnAppointments;
        private Button btnExit;
    }
}
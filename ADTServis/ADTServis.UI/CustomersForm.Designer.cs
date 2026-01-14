using ADTServis.BLL.Services;
namespace ADTServis.UI

{
    partial class CustomersForm
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
            dgvCostumers = new DataGridView();
            btnAddCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCostumers).BeginInit();
            SuspendLayout();
            // 
            // dgvCostumers
            // 
            dgvCostumers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCostumers.Location = new Point(12, 151);
            dgvCostumers.Name = "dgvCostumers";
            dgvCostumers.Size = new Size(644, 239);
            dgvCostumers.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(375, 41);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(75, 23);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Yeni Müşteri";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += button1_Click;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddCustomer);
            Controls.Add(dgvCostumers);
            Name = "CustomersForm";
            Text = "CustomersForm";
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCostumers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCostumers;
        private Button btnAddCustomer;
    }
}
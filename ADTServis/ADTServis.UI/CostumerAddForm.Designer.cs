namespace ADTServis.UI
{
    partial class CostumerAddForm
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
            lblFullName = new Label();
            lblPhone = new Label();
            lblPlate = new Label();
            lblCarBrand = new Label();
            lblCarModel = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtPlate = new TextBox();
            txtCarBrand = new TextBox();
            txtCarModel = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(334, 21);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(57, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Ad Soyad";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(334, 60);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(46, 15);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Telefon";
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Location = new Point(334, 94);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(35, 15);
            lblPlate.TabIndex = 0;
            lblPlate.Text = "Plaka";
            // 
            // lblCarBrand
            // 
            lblCarBrand.AutoSize = true;
            lblCarBrand.Location = new Point(320, 134);
            lblCarBrand.Name = "lblCarBrand";
            lblCarBrand.Size = new Size(75, 15);
            lblCarBrand.TabIndex = 0;
            lblCarBrand.Text = "Araç Markası";
            // 
            // lblCarModel
            // 
            lblCarModel.AutoSize = true;
            lblCarModel.Location = new Point(324, 173);
            lblCarModel.Name = "lblCarModel";
            lblCarModel.Size = new Size(71, 15);
            lblCarModel.TabIndex = 0;
            lblCarModel.Text = "Araç Modeli";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(401, 18);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(401, 57);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 1;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(401, 91);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(100, 23);
            txtPlate.TabIndex = 1;
            // 
            // txtCarBrand
            // 
            txtCarBrand.Location = new Point(401, 126);
            txtCarBrand.Name = "txtCarBrand";
            txtCarBrand.Size = new Size(100, 23);
            txtCarBrand.TabIndex = 1;
            // 
            // txtCarModel
            // 
            txtCarModel.Location = new Point(401, 165);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(100, 23);
            txtCarModel.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(416, 219);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CostumerAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtCarModel);
            Controls.Add(txtCarBrand);
            Controls.Add(txtPlate);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(lblCarModel);
            Controls.Add(lblCarBrand);
            Controls.Add(lblPlate);
            Controls.Add(lblPhone);
            Controls.Add(lblFullName);
            Name = "CostumerAddForm";
            Text = "CostumerAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblPhone;
        private Label lblPlate;
        private Label lblCarBrand;
        private Label lblCarModel;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtPlate;
        private TextBox txtCarBrand;
        private TextBox txtCarModel;
        private Button btnSave;
    }
}
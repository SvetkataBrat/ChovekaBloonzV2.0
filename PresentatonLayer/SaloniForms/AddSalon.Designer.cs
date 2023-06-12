namespace PresentatonLayer.SaloniForms
{
    partial class AddSalon
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
            this.AddSalonLabel = new System.Windows.Forms.Label();
            this.SalonNameLabel = new System.Windows.Forms.Label();
            this.SalonAdressLabel = new System.Windows.Forms.Label();
            this.SalonNameTextbox = new System.Windows.Forms.TextBox();
            this.SalonAdressTextbox = new System.Windows.Forms.TextBox();
            this.AddSalonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddSalonLabel
            // 
            this.AddSalonLabel.AutoSize = true;
            this.AddSalonLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddSalonLabel.Location = new System.Drawing.Point(268, 22);
            this.AddSalonLabel.Name = "AddSalonLabel";
            this.AddSalonLabel.Size = new System.Drawing.Size(219, 59);
            this.AddSalonLabel.TabIndex = 0;
            this.AddSalonLabel.Text = "Add Salon";
            // 
            // SalonNameLabel
            // 
            this.SalonNameLabel.AutoSize = true;
            this.SalonNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalonNameLabel.Location = new System.Drawing.Point(214, 186);
            this.SalonNameLabel.Name = "SalonNameLabel";
            this.SalonNameLabel.Size = new System.Drawing.Size(59, 21);
            this.SalonNameLabel.TabIndex = 2;
            this.SalonNameLabel.Text = "Name :";
            // 
            // SalonAdressLabel
            // 
            this.SalonAdressLabel.AutoSize = true;
            this.SalonAdressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalonAdressLabel.Location = new System.Drawing.Point(214, 234);
            this.SalonAdressLabel.Name = "SalonAdressLabel";
            this.SalonAdressLabel.Size = new System.Drawing.Size(64, 21);
            this.SalonAdressLabel.TabIndex = 3;
            this.SalonAdressLabel.Text = "Adress :";
            // 
            // SalonNameTextbox
            // 
            this.SalonNameTextbox.Location = new System.Drawing.Point(320, 186);
            this.SalonNameTextbox.Name = "SalonNameTextbox";
            this.SalonNameTextbox.Size = new System.Drawing.Size(199, 23);
            this.SalonNameTextbox.TabIndex = 5;
            // 
            // SalonAdressTextbox
            // 
            this.SalonAdressTextbox.Location = new System.Drawing.Point(320, 234);
            this.SalonAdressTextbox.Name = "SalonAdressTextbox";
            this.SalonAdressTextbox.Size = new System.Drawing.Size(199, 23);
            this.SalonAdressTextbox.TabIndex = 6;
            // 
            // AddSalonButton
            // 
            this.AddSalonButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddSalonButton.Location = new System.Drawing.Point(320, 293);
            this.AddSalonButton.Name = "AddSalonButton";
            this.AddSalonButton.Size = new System.Drawing.Size(111, 33);
            this.AddSalonButton.TabIndex = 7;
            this.AddSalonButton.Text = "Create";
            this.AddSalonButton.UseVisualStyleBackColor = true;
            this.AddSalonButton.Click += new System.EventHandler(this.AddSalonButton_Click);
            // 
            // AddSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddSalonButton);
            this.Controls.Add(this.SalonAdressTextbox);
            this.Controls.Add(this.SalonNameTextbox);
            this.Controls.Add(this.SalonAdressLabel);
            this.Controls.Add(this.SalonNameLabel);
            this.Controls.Add(this.AddSalonLabel);
            this.Name = "AddSalon";
            this.Text = "AddSalon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AddSalonLabel;
        private Label SalonNameLabel;
        private Label SalonAdressLabel;
        private TextBox SalonNameTextbox;
        private TextBox SalonAdressTextbox;
        private Button AddSalonButton;
    }
}
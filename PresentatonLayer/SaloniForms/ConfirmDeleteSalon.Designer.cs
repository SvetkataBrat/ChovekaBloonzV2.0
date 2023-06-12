namespace PresentatonLayer.SaloniForms
{
    partial class ConfirmDeleteSalon
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
            this.ConfirmDeleteSalonLabel = new System.Windows.Forms.Label();
            this.ConfirmDeleteSalonYes = new System.Windows.Forms.Button();
            this.ConfirmDeleteSalonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmDeleteSalonLabel
            // 
            this.ConfirmDeleteSalonLabel.AutoSize = true;
            this.ConfirmDeleteSalonLabel.Location = new System.Drawing.Point(125, 36);
            this.ConfirmDeleteSalonLabel.Name = "ConfirmDeleteSalonLabel";
            this.ConfirmDeleteSalonLabel.Size = new System.Drawing.Size(219, 15);
            this.ConfirmDeleteSalonLabel.TabIndex = 0;
            this.ConfirmDeleteSalonLabel.Text = "DO YOU WANT TO DELETE THIS SALON?\r\n";
            // 
            // ConfirmDeleteSalonYes
            // 
            this.ConfirmDeleteSalonYes.Location = new System.Drawing.Point(125, 93);
            this.ConfirmDeleteSalonYes.Name = "ConfirmDeleteSalonYes";
            this.ConfirmDeleteSalonYes.Size = new System.Drawing.Size(84, 27);
            this.ConfirmDeleteSalonYes.TabIndex = 1;
            this.ConfirmDeleteSalonYes.Text = "Yes";
            this.ConfirmDeleteSalonYes.UseVisualStyleBackColor = true;
            this.ConfirmDeleteSalonYes.Click += new System.EventHandler(this.ConfirmDeleteSalonYes_Click);
            // 
            // ConfirmDeleteSalonNo
            // 
            this.ConfirmDeleteSalonNo.Location = new System.Drawing.Point(262, 93);
            this.ConfirmDeleteSalonNo.Name = "ConfirmDeleteSalonNo";
            this.ConfirmDeleteSalonNo.Size = new System.Drawing.Size(82, 27);
            this.ConfirmDeleteSalonNo.TabIndex = 2;
            this.ConfirmDeleteSalonNo.Text = "No";
            this.ConfirmDeleteSalonNo.UseVisualStyleBackColor = true;
            this.ConfirmDeleteSalonNo.Click += new System.EventHandler(this.ConfirmDeleteSalonNo_Click);
            // 
            // ConfirmDeleteSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 173);
            this.Controls.Add(this.ConfirmDeleteSalonNo);
            this.Controls.Add(this.ConfirmDeleteSalonYes);
            this.Controls.Add(this.ConfirmDeleteSalonLabel);
            this.Name = "ConfirmDeleteSalon";
            this.Text = "ConfirmDeleteSalon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ConfirmDeleteSalonLabel;
        private Button ConfirmDeleteSalonYes;
        private Button ConfirmDeleteSalonNo;
    }
}
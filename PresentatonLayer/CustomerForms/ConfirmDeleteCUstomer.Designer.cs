﻿namespace PresentationLayer
{
    partial class ConfirmDeleteCUstomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmDeletUserYes = new System.Windows.Forms.Button();
            this.ConfirmDeleteUserNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DO YOU WANT TO DELETE THIS CUSTOMER?";
            // 
            // ConfirmDeletUserYes
            // 
            this.ConfirmDeletUserYes.Location = new System.Drawing.Point(122, 99);
            this.ConfirmDeletUserYes.Name = "ConfirmDeletUserYes";
            this.ConfirmDeletUserYes.Size = new System.Drawing.Size(75, 23);
            this.ConfirmDeletUserYes.TabIndex = 1;
            this.ConfirmDeletUserYes.Text = "Yes";
            this.ConfirmDeletUserYes.UseVisualStyleBackColor = true;
            this.ConfirmDeletUserYes.Click += new System.EventHandler(this.ConfirmDeletUserYes_Click);
            // 
            // ConfirmDeleteUserNo
            // 
            this.ConfirmDeleteUserNo.Location = new System.Drawing.Point(272, 99);
            this.ConfirmDeleteUserNo.Name = "ConfirmDeleteUserNo";
            this.ConfirmDeleteUserNo.Size = new System.Drawing.Size(75, 23);
            this.ConfirmDeleteUserNo.TabIndex = 2;
            this.ConfirmDeleteUserNo.Text = "No";
            this.ConfirmDeleteUserNo.UseVisualStyleBackColor = true;
            this.ConfirmDeleteUserNo.Click += new System.EventHandler(this.ConfirmDeleteUserNo_Click);
            // 
            // ConfirmDeleteCUstomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 173);
            this.Controls.Add(this.ConfirmDeleteUserNo);
            this.Controls.Add(this.ConfirmDeletUserYes);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmDeleteCUstomer";
            this.Text = "ConfirmDeleteCUstomer";
            this.Load += new System.EventHandler(this.ConfirmDeleteCUstomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button ConfirmDeletUserYes;
        private Button ConfirmDeleteUserNo;
    }
}
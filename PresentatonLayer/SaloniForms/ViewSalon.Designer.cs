namespace PresentatonLayer.SaloniForms
{
    partial class ViewSalon
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
            this.ViewSalonListbox = new System.Windows.Forms.ListBox();
            this.ViewSalonNameLabel = new System.Windows.Forms.Label();
            this.ViewSaloniAdressLabel = new System.Windows.Forms.Label();
            this.ViewSaloniLabel = new System.Windows.Forms.Label();
            this.ViewSaloniNameTextbox = new System.Windows.Forms.TextBox();
            this.ViewSaloniAdressTextbox = new System.Windows.Forms.TextBox();
            this.ViewSaloniChangeName = new System.Windows.Forms.Button();
            this.ViewSaloniChangeAdress = new System.Windows.Forms.Button();
            this.ViewSaloniBack = new System.Windows.Forms.Button();
            this.ViewSaloniUpdate = new System.Windows.Forms.Button();
            this.ViewSaloniDelete = new System.Windows.Forms.Button();
            this.saloniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.saloniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewSalonListbox
            // 
            this.ViewSalonListbox.DataSource = this.saloniBindingSource;
            this.ViewSalonListbox.DisplayMember = "Id";
            this.ViewSalonListbox.FormattingEnabled = true;
            this.ViewSalonListbox.ItemHeight = 15;
            this.ViewSalonListbox.Location = new System.Drawing.Point(32, 139);
            this.ViewSalonListbox.Name = "ViewSalonListbox";
            this.ViewSalonListbox.Size = new System.Drawing.Size(141, 124);
            this.ViewSalonListbox.TabIndex = 0;
            // 
            // ViewSalonNameLabel
            // 
            this.ViewSalonNameLabel.AutoSize = true;
            this.ViewSalonNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewSalonNameLabel.Location = new System.Drawing.Point(258, 172);
            this.ViewSalonNameLabel.Name = "ViewSalonNameLabel";
            this.ViewSalonNameLabel.Size = new System.Drawing.Size(59, 21);
            this.ViewSalonNameLabel.TabIndex = 1;
            this.ViewSalonNameLabel.Text = "Name :";
            // 
            // ViewSaloniAdressLabel
            // 
            this.ViewSaloniAdressLabel.AutoSize = true;
            this.ViewSaloniAdressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewSaloniAdressLabel.Location = new System.Drawing.Point(258, 211);
            this.ViewSaloniAdressLabel.Name = "ViewSaloniAdressLabel";
            this.ViewSaloniAdressLabel.Size = new System.Drawing.Size(64, 21);
            this.ViewSaloniAdressLabel.TabIndex = 2;
            this.ViewSaloniAdressLabel.Text = "Adress :";
            // 
            // ViewSaloniLabel
            // 
            this.ViewSaloniLabel.AutoSize = true;
            this.ViewSaloniLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewSaloniLabel.Location = new System.Drawing.Point(287, 32);
            this.ViewSaloniLabel.Name = "ViewSaloniLabel";
            this.ViewSaloniLabel.Size = new System.Drawing.Size(241, 59);
            this.ViewSaloniLabel.TabIndex = 3;
            this.ViewSaloniLabel.Text = "View Saloni";
            // 
            // ViewSaloniNameTextbox
            // 
            this.ViewSaloniNameTextbox.Location = new System.Drawing.Point(356, 172);
            this.ViewSaloniNameTextbox.Name = "ViewSaloniNameTextbox";
            this.ViewSaloniNameTextbox.Size = new System.Drawing.Size(195, 23);
            this.ViewSaloniNameTextbox.TabIndex = 4;
            // 
            // ViewSaloniAdressTextbox
            // 
            this.ViewSaloniAdressTextbox.Location = new System.Drawing.Point(356, 211);
            this.ViewSaloniAdressTextbox.Name = "ViewSaloniAdressTextbox";
            this.ViewSaloniAdressTextbox.Size = new System.Drawing.Size(195, 23);
            this.ViewSaloniAdressTextbox.TabIndex = 5;
            // 
            // ViewSaloniChangeName
            // 
            this.ViewSaloniChangeName.Location = new System.Drawing.Point(572, 172);
            this.ViewSaloniChangeName.Name = "ViewSaloniChangeName";
            this.ViewSaloniChangeName.Size = new System.Drawing.Size(79, 23);
            this.ViewSaloniChangeName.TabIndex = 6;
            this.ViewSaloniChangeName.Text = "Change";
            this.ViewSaloniChangeName.UseVisualStyleBackColor = true;
            this.ViewSaloniChangeName.Click += new System.EventHandler(this.ViewSaloniChangeName_Click);
            // 
            // ViewSaloniChangeAdress
            // 
            this.ViewSaloniChangeAdress.Location = new System.Drawing.Point(572, 211);
            this.ViewSaloniChangeAdress.Name = "ViewSaloniChangeAdress";
            this.ViewSaloniChangeAdress.Size = new System.Drawing.Size(79, 23);
            this.ViewSaloniChangeAdress.TabIndex = 7;
            this.ViewSaloniChangeAdress.Text = "Change";
            this.ViewSaloniChangeAdress.UseVisualStyleBackColor = true;
            this.ViewSaloniChangeAdress.Click += new System.EventHandler(this.ViewSaloniChangeAdress_Click);
            // 
            // ViewSaloniBack
            // 
            this.ViewSaloniBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewSaloniBack.Location = new System.Drawing.Point(465, 408);
            this.ViewSaloniBack.Name = "ViewSaloniBack";
            this.ViewSaloniBack.Size = new System.Drawing.Size(90, 30);
            this.ViewSaloniBack.TabIndex = 8;
            this.ViewSaloniBack.Text = "Back";
            this.ViewSaloniBack.UseVisualStyleBackColor = true;
            this.ViewSaloniBack.Click += new System.EventHandler(this.ViewSaloniBack_Click);
            // 
            // ViewSaloniUpdate
            // 
            this.ViewSaloniUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewSaloniUpdate.Location = new System.Drawing.Point(561, 408);
            this.ViewSaloniUpdate.Name = "ViewSaloniUpdate";
            this.ViewSaloniUpdate.Size = new System.Drawing.Size(90, 30);
            this.ViewSaloniUpdate.TabIndex = 9;
            this.ViewSaloniUpdate.Text = "Update";
            this.ViewSaloniUpdate.UseVisualStyleBackColor = true;
            this.ViewSaloniUpdate.Click += new System.EventHandler(this.ViewSaloniUpdate_Click);
            // 
            // ViewSaloniDelete
            // 
            this.ViewSaloniDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewSaloniDelete.Location = new System.Drawing.Point(657, 408);
            this.ViewSaloniDelete.Name = "ViewSaloniDelete";
            this.ViewSaloniDelete.Size = new System.Drawing.Size(93, 30);
            this.ViewSaloniDelete.TabIndex = 10;
            this.ViewSaloniDelete.Text = "Delete";
            this.ViewSaloniDelete.UseVisualStyleBackColor = true;
            this.ViewSaloniDelete.Click += new System.EventHandler(this.ViewSaloniDelete_Click);
            // 
            // saloniBindingSource
            // 
            this.saloniBindingSource.DataSource = typeof(BusinessLayer.Saloni);
            // 
            // ViewSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewSaloniDelete);
            this.Controls.Add(this.ViewSaloniUpdate);
            this.Controls.Add(this.ViewSaloniBack);
            this.Controls.Add(this.ViewSaloniChangeAdress);
            this.Controls.Add(this.ViewSaloniChangeName);
            this.Controls.Add(this.ViewSaloniAdressTextbox);
            this.Controls.Add(this.ViewSaloniNameTextbox);
            this.Controls.Add(this.ViewSaloniLabel);
            this.Controls.Add(this.ViewSaloniAdressLabel);
            this.Controls.Add(this.ViewSalonNameLabel);
            this.Controls.Add(this.ViewSalonListbox);
            this.Name = "ViewSalon";
            this.Text = "ViewSalon";
            ((System.ComponentModel.ISupportInitialize)(this.saloniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ViewSalonListbox;
        private Label ViewSalonNameLabel;
        private Label ViewSaloniAdressLabel;
        private Label ViewSaloniLabel;
        private TextBox ViewSaloniNameTextbox;
        private TextBox ViewSaloniAdressTextbox;
        private Button ViewSaloniChangeName;
        private Button ViewSaloniChangeAdress;
        private Button ViewSaloniBack;
        private Button ViewSaloniUpdate;
        private Button ViewSaloniDelete;
        private BindingSource saloniBindingSource;
    }
}
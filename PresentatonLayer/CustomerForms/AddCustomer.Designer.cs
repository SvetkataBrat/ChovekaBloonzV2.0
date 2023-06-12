namespace PresentationLayer
{
    partial class AddCustomer
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
            this.addCustomerTitle = new System.Windows.Forms.Label();
            this.addCustomerFName = new System.Windows.Forms.Label();
            this.addCustomerLName = new System.Windows.Forms.Label();
            this.AddCustomerAge = new System.Windows.Forms.Label();
            this.addCustomerFNameTbox = new System.Windows.Forms.TextBox();
            this.addCustomerLNameTbox = new System.Windows.Forms.TextBox();
            this.addCustomerAgeTbox = new System.Windows.Forms.TextBox();
            this.addCustomerPhone = new System.Windows.Forms.Label();
            this.addCustomerPhoneTbox = new System.Windows.Forms.TextBox();
            this.addCustomerConfirm = new System.Windows.Forms.Button();
            this.addCustomerBack = new System.Windows.Forms.Button();
            this.AddCustomerAddress = new System.Windows.Forms.Label();
            this.AddCustomerAddressTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addCustomerTitle
            // 
            this.addCustomerTitle.AutoSize = true;
            this.addCustomerTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCustomerTitle.Location = new System.Drawing.Point(293, 50);
            this.addCustomerTitle.Name = "addCustomerTitle";
            this.addCustomerTitle.Size = new System.Drawing.Size(214, 32);
            this.addCustomerTitle.TabIndex = 0;
            this.addCustomerTitle.Text = "ADD A CUSTOMER";
            // 
            // addCustomerFName
            // 
            this.addCustomerFName.AutoSize = true;
            this.addCustomerFName.Location = new System.Drawing.Point(145, 157);
            this.addCustomerFName.Name = "addCustomerFName";
            this.addCustomerFName.Size = new System.Drawing.Size(70, 15);
            this.addCustomerFName.TabIndex = 1;
            this.addCustomerFName.Text = "FIrst Name: ";
            // 
            // addCustomerLName
            // 
            this.addCustomerLName.AutoSize = true;
            this.addCustomerLName.Location = new System.Drawing.Point(145, 204);
            this.addCustomerLName.Name = "addCustomerLName";
            this.addCustomerLName.Size = new System.Drawing.Size(69, 15);
            this.addCustomerLName.TabIndex = 2;
            this.addCustomerLName.Text = "Last Name: ";
            // 
            // AddCustomerAge
            // 
            this.AddCustomerAge.AutoSize = true;
            this.AddCustomerAge.Location = new System.Drawing.Point(422, 149);
            this.AddCustomerAge.Name = "AddCustomerAge";
            this.AddCustomerAge.Size = new System.Drawing.Size(34, 15);
            this.AddCustomerAge.TabIndex = 3;
            this.AddCustomerAge.Text = "Age: ";
            // 
            // addCustomerFNameTbox
            // 
            this.addCustomerFNameTbox.Location = new System.Drawing.Point(241, 149);
            this.addCustomerFNameTbox.Name = "addCustomerFNameTbox";
            this.addCustomerFNameTbox.Size = new System.Drawing.Size(132, 23);
            this.addCustomerFNameTbox.TabIndex = 4;
            // 
            // addCustomerLNameTbox
            // 
            this.addCustomerLNameTbox.Location = new System.Drawing.Point(241, 201);
            this.addCustomerLNameTbox.Name = "addCustomerLNameTbox";
            this.addCustomerLNameTbox.Size = new System.Drawing.Size(132, 23);
            this.addCustomerLNameTbox.TabIndex = 5;
            // 
            // addCustomerAgeTbox
            // 
            this.addCustomerAgeTbox.Location = new System.Drawing.Point(491, 141);
            this.addCustomerAgeTbox.Name = "addCustomerAgeTbox";
            this.addCustomerAgeTbox.Size = new System.Drawing.Size(44, 23);
            this.addCustomerAgeTbox.TabIndex = 6;
            // 
            // addCustomerPhone
            // 
            this.addCustomerPhone.AutoSize = true;
            this.addCustomerPhone.Location = new System.Drawing.Point(422, 201);
            this.addCustomerPhone.Name = "addCustomerPhone";
            this.addCustomerPhone.Size = new System.Drawing.Size(47, 15);
            this.addCustomerPhone.TabIndex = 7;
            this.addCustomerPhone.Text = "Phone: ";
            // 
            // addCustomerPhoneTbox
            // 
            this.addCustomerPhoneTbox.Location = new System.Drawing.Point(491, 201);
            this.addCustomerPhoneTbox.Name = "addCustomerPhoneTbox";
            this.addCustomerPhoneTbox.Size = new System.Drawing.Size(127, 23);
            this.addCustomerPhoneTbox.TabIndex = 8;
            // 
            // addCustomerConfirm
            // 
            this.addCustomerConfirm.Location = new System.Drawing.Point(432, 347);
            this.addCustomerConfirm.Name = "addCustomerConfirm";
            this.addCustomerConfirm.Size = new System.Drawing.Size(75, 23);
            this.addCustomerConfirm.TabIndex = 9;
            this.addCustomerConfirm.Text = "ADD";
            this.addCustomerConfirm.UseVisualStyleBackColor = true;
            this.addCustomerConfirm.Click += new System.EventHandler(this.addCustomerConfirm_Click);
            // 
            // addCustomerBack
            // 
            this.addCustomerBack.Location = new System.Drawing.Point(241, 347);
            this.addCustomerBack.Name = "addCustomerBack";
            this.addCustomerBack.Size = new System.Drawing.Size(75, 23);
            this.addCustomerBack.TabIndex = 10;
            this.addCustomerBack.Text = "GO BACK";
            this.addCustomerBack.UseVisualStyleBackColor = true;
            this.addCustomerBack.Click += new System.EventHandler(this.addCustomerBack_Click);
            // 
            // AddCustomerAddress
            // 
            this.AddCustomerAddress.AutoSize = true;
            this.AddCustomerAddress.Location = new System.Drawing.Point(145, 257);
            this.AddCustomerAddress.Name = "AddCustomerAddress";
            this.AddCustomerAddress.Size = new System.Drawing.Size(49, 15);
            this.AddCustomerAddress.TabIndex = 11;
            this.AddCustomerAddress.Text = "Address";
            // 
            // AddCustomerAddressTbox
            // 
            this.AddCustomerAddressTbox.Location = new System.Drawing.Point(241, 257);
            this.AddCustomerAddressTbox.Name = "AddCustomerAddressTbox";
            this.AddCustomerAddressTbox.Size = new System.Drawing.Size(215, 23);
            this.AddCustomerAddressTbox.TabIndex = 12;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCustomerAddressTbox);
            this.Controls.Add(this.AddCustomerAddress);
            this.Controls.Add(this.addCustomerBack);
            this.Controls.Add(this.addCustomerConfirm);
            this.Controls.Add(this.addCustomerPhoneTbox);
            this.Controls.Add(this.addCustomerPhone);
            this.Controls.Add(this.addCustomerAgeTbox);
            this.Controls.Add(this.addCustomerLNameTbox);
            this.Controls.Add(this.addCustomerFNameTbox);
            this.Controls.Add(this.AddCustomerAge);
            this.Controls.Add(this.addCustomerLName);
            this.Controls.Add(this.addCustomerFName);
            this.Controls.Add(this.addCustomerTitle);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label addCustomerTitle;
        private Label addCustomerFName;
        private Label addCustomerLName;
        private Label AddCustomerAge;
        private TextBox addCustomerFNameTbox;
        private TextBox addCustomerLNameTbox;
        private TextBox addCustomerAgeTbox;
        private Label addCustomerPhone;
        private TextBox addCustomerPhoneTbox;
        private Button addCustomerConfirm;
        private Button addCustomerBack;
        private Label AddCustomerAddress;
        private TextBox AddCustomerAddressTbox;
    }
}
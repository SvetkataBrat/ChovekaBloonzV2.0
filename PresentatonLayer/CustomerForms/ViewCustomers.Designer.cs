namespace PresentationLayer
{
    partial class ViewCustomers
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
            this.ViewCustomersList = new System.Windows.Forms.ListBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewCustomerName = new System.Windows.Forms.Label();
            this.ViewCustomerAddress = new System.Windows.Forms.Label();
            this.ViewCustomerAge = new System.Windows.Forms.Label();
            this.ViewCustomerPhone = new System.Windows.Forms.Label();
            this.ViewCustomerGetName = new System.Windows.Forms.TextBox();
            this.ViewCustomerGetAddress = new System.Windows.Forms.TextBox();
            this.ViewCustomerGetAge = new System.Windows.Forms.TextBox();
            this.ViewCustomerGetPhone = new System.Windows.Forms.TextBox();
            this.ViewCustomerUpdate = new System.Windows.Forms.Button();
            this.ViewCustomerDelete = new System.Windows.Forms.Button();
            this.ViewCustomerChangeName = new System.Windows.Forms.Button();
            this.ViewCustomerChangeAddress = new System.Windows.Forms.Button();
            this.ViewCustomerChangeAge = new System.Windows.Forms.Button();
            this.ViewCustomerChagePhone = new System.Windows.Forms.Button();
            this.ViewCustomerBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewCustomersList
            // 
            this.ViewCustomersList.DataSource = this.customerBindingSource;
            this.ViewCustomersList.DisplayMember = "Id";
            this.ViewCustomersList.FormattingEnabled = true;
            this.ViewCustomersList.ItemHeight = 15;
            this.ViewCustomersList.Location = new System.Drawing.Point(39, 178);
            this.ViewCustomersList.Name = "ViewCustomersList";
            this.ViewCustomersList.Size = new System.Drawing.Size(120, 94);
            this.ViewCustomersList.TabIndex = 0;
            this.ViewCustomersList.ValueMember = "Id";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(BusinessLayer.Customer);
            // 
            // ViewCustomerName
            // 
            this.ViewCustomerName.AutoSize = true;
            this.ViewCustomerName.Location = new System.Drawing.Point(262, 88);
            this.ViewCustomerName.Name = "ViewCustomerName";
            this.ViewCustomerName.Size = new System.Drawing.Size(45, 15);
            this.ViewCustomerName.TabIndex = 1;
            this.ViewCustomerName.Text = "Name: ";
            // 
            // ViewCustomerAddress
            // 
            this.ViewCustomerAddress.AutoSize = true;
            this.ViewCustomerAddress.Location = new System.Drawing.Point(262, 168);
            this.ViewCustomerAddress.Name = "ViewCustomerAddress";
            this.ViewCustomerAddress.Size = new System.Drawing.Size(55, 15);
            this.ViewCustomerAddress.TabIndex = 3;
            this.ViewCustomerAddress.Text = "Address: ";
            // 
            // ViewCustomerAge
            // 
            this.ViewCustomerAge.AutoSize = true;
            this.ViewCustomerAge.Location = new System.Drawing.Point(262, 248);
            this.ViewCustomerAge.Name = "ViewCustomerAge";
            this.ViewCustomerAge.Size = new System.Drawing.Size(34, 15);
            this.ViewCustomerAge.TabIndex = 5;
            this.ViewCustomerAge.Text = "Age: ";
            // 
            // ViewCustomerPhone
            // 
            this.ViewCustomerPhone.AutoSize = true;
            this.ViewCustomerPhone.Location = new System.Drawing.Point(262, 328);
            this.ViewCustomerPhone.Name = "ViewCustomerPhone";
            this.ViewCustomerPhone.Size = new System.Drawing.Size(47, 15);
            this.ViewCustomerPhone.TabIndex = 7;
            this.ViewCustomerPhone.Text = "Phone: ";
            // 
            // ViewCustomerGetName
            // 
            this.ViewCustomerGetName.Location = new System.Drawing.Point(345, 81);
            this.ViewCustomerGetName.Name = "ViewCustomerGetName";
            this.ViewCustomerGetName.ReadOnly = true;
            this.ViewCustomerGetName.Size = new System.Drawing.Size(100, 23);
            this.ViewCustomerGetName.TabIndex = 8;
            // 
            // ViewCustomerGetAddress
            // 
            this.ViewCustomerGetAddress.Location = new System.Drawing.Point(345, 165);
            this.ViewCustomerGetAddress.Name = "ViewCustomerGetAddress";
            this.ViewCustomerGetAddress.ReadOnly = true;
            this.ViewCustomerGetAddress.Size = new System.Drawing.Size(100, 23);
            this.ViewCustomerGetAddress.TabIndex = 9;
            // 
            // ViewCustomerGetAge
            // 
            this.ViewCustomerGetAge.Location = new System.Drawing.Point(345, 248);
            this.ViewCustomerGetAge.Name = "ViewCustomerGetAge";
            this.ViewCustomerGetAge.ReadOnly = true;
            this.ViewCustomerGetAge.Size = new System.Drawing.Size(31, 23);
            this.ViewCustomerGetAge.TabIndex = 10;
            // 
            // ViewCustomerGetPhone
            // 
            this.ViewCustomerGetPhone.Location = new System.Drawing.Point(345, 328);
            this.ViewCustomerGetPhone.Name = "ViewCustomerGetPhone";
            this.ViewCustomerGetPhone.ReadOnly = true;
            this.ViewCustomerGetPhone.Size = new System.Drawing.Size(100, 23);
            this.ViewCustomerGetPhone.TabIndex = 11;
            // 
            // ViewCustomerUpdate
            // 
            this.ViewCustomerUpdate.Location = new System.Drawing.Point(614, 415);
            this.ViewCustomerUpdate.Name = "ViewCustomerUpdate";
            this.ViewCustomerUpdate.Size = new System.Drawing.Size(75, 23);
            this.ViewCustomerUpdate.TabIndex = 12;
            this.ViewCustomerUpdate.Text = "UPDATE";
            this.ViewCustomerUpdate.UseVisualStyleBackColor = true;
            this.ViewCustomerUpdate.Click += new System.EventHandler(this.ViewCustomerUpdate_Click);
            // 
            // ViewCustomerDelete
            // 
            this.ViewCustomerDelete.Location = new System.Drawing.Point(713, 415);
            this.ViewCustomerDelete.Name = "ViewCustomerDelete";
            this.ViewCustomerDelete.Size = new System.Drawing.Size(75, 23);
            this.ViewCustomerDelete.TabIndex = 13;
            this.ViewCustomerDelete.Text = "DELETE";
            this.ViewCustomerDelete.UseVisualStyleBackColor = true;
            this.ViewCustomerDelete.Click += new System.EventHandler(this.ViewCustomerDelete_Click);
            // 
            // ViewCustomerChangeName
            // 
            this.ViewCustomerChangeName.Location = new System.Drawing.Point(501, 81);
            this.ViewCustomerChangeName.Name = "ViewCustomerChangeName";
            this.ViewCustomerChangeName.Size = new System.Drawing.Size(75, 23);
            this.ViewCustomerChangeName.TabIndex = 14;
            this.ViewCustomerChangeName.Text = "CHANGE";
            this.ViewCustomerChangeName.UseVisualStyleBackColor = true;
            this.ViewCustomerChangeName.Click += new System.EventHandler(this.ViewCustomerChangeName_Click);
            // 
            // ViewCustomerChangeAddress
            // 
            this.ViewCustomerChangeAddress.Location = new System.Drawing.Point(501, 165);
            this.ViewCustomerChangeAddress.Name = "ViewCustomerChangeAddress";
            this.ViewCustomerChangeAddress.Size = new System.Drawing.Size(75, 23);
            this.ViewCustomerChangeAddress.TabIndex = 15;
            this.ViewCustomerChangeAddress.Text = "CHANGE";
            this.ViewCustomerChangeAddress.UseVisualStyleBackColor = true;
            this.ViewCustomerChangeAddress.Click += new System.EventHandler(this.ViewCustomerChangeAddress_Click);
            // 
            // ViewCustomerChangeAge
            // 
            this.ViewCustomerChangeAge.Location = new System.Drawing.Point(501, 248);
            this.ViewCustomerChangeAge.Name = "ViewCustomerChangeAge";
            this.ViewCustomerChangeAge.Size = new System.Drawing.Size(75, 23);
            this.ViewCustomerChangeAge.TabIndex = 16;
            this.ViewCustomerChangeAge.Text = "CHANGE";
            this.ViewCustomerChangeAge.UseVisualStyleBackColor = true;
            this.ViewCustomerChangeAge.Click += new System.EventHandler(this.ViewCustomerChangeAge_Click);
            // 
            // ViewCustomerChagePhone
            // 
            this.ViewCustomerChagePhone.Location = new System.Drawing.Point(501, 328);
            this.ViewCustomerChagePhone.Name = "ViewCustomerChagePhone";
            this.ViewCustomerChagePhone.Size = new System.Drawing.Size(75, 23);
            this.ViewCustomerChagePhone.TabIndex = 17;
            this.ViewCustomerChagePhone.Text = "CHANGE";
            this.ViewCustomerChagePhone.UseVisualStyleBackColor = true;
            this.ViewCustomerChagePhone.Click += new System.EventHandler(this.ViewCustomerChagePhone_Click);
            // 
            // ViewCustomerBack
            // 
            this.ViewCustomerBack.Location = new System.Drawing.Point(512, 415);
            this.ViewCustomerBack.Name = "ViewCustomerBack";
            this.ViewCustomerBack.Size = new System.Drawing.Size(75, 23);
            this.ViewCustomerBack.TabIndex = 18;
            this.ViewCustomerBack.Text = "GO BACK";
            this.ViewCustomerBack.UseVisualStyleBackColor = true;
            this.ViewCustomerBack.Click += new System.EventHandler(this.ViewCustomerBack_Click);
            // 
            // ViewCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewCustomerBack);
            this.Controls.Add(this.ViewCustomerChagePhone);
            this.Controls.Add(this.ViewCustomerChangeAge);
            this.Controls.Add(this.ViewCustomerChangeAddress);
            this.Controls.Add(this.ViewCustomerChangeName);
            this.Controls.Add(this.ViewCustomerDelete);
            this.Controls.Add(this.ViewCustomerUpdate);
            this.Controls.Add(this.ViewCustomerGetPhone);
            this.Controls.Add(this.ViewCustomerGetAge);
            this.Controls.Add(this.ViewCustomerGetAddress);
            this.Controls.Add(this.ViewCustomerGetName);
            this.Controls.Add(this.ViewCustomerPhone);
            this.Controls.Add(this.ViewCustomerAge);
            this.Controls.Add(this.ViewCustomerAddress);
            this.Controls.Add(this.ViewCustomerName);
            this.Controls.Add(this.ViewCustomersList);
            this.Name = "ViewCustomers";
            this.Text = "ViewCustomers";
            this.Load += new System.EventHandler(this.ViewCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ViewCustomersList;
        private Label ViewCustomerName;
        private Label ViewCustomerAddress;
        private Label ViewCustomerAge;
        private Label ViewCustomerPhone;
        private TextBox ViewCustomerGetName;
        private TextBox ViewCustomerGetAddress;
        private TextBox ViewCustomerGetAge;
        private TextBox ViewCustomerGetPhone;
        private Button ViewCustomerUpdate;
        private Button ViewCustomerDelete;
        private Button ViewCustomerChangeName;
        private Button ViewCustomerChangeAddress;
        private Button ViewCustomerChangeAge;
        private Button ViewCustomerChagePhone;
        private Button ViewCustomerBack;
        private BindingSource customerBindingSource;
    }
}
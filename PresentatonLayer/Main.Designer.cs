namespace PresentatonLayer
{
    partial class Main
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
            this.MainTitle = new System.Windows.Forms.Label();
            this.MainAddCar = new System.Windows.Forms.Button();
            this.MainViewCars = new System.Windows.Forms.Button();
            this.MainAddSalon = new System.Windows.Forms.Button();
            this.MainViewSalons = new System.Windows.Forms.Button();
            this.MainAddCustomer = new System.Windows.Forms.Button();
            this.MainViewCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(308, 84);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(185, 30);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "COLETO GARAGES";
            // 
            // MainAddCar
            // 
            this.MainAddCar.Location = new System.Drawing.Point(131, 188);
            this.MainAddCar.Name = "MainAddCar";
            this.MainAddCar.Size = new System.Drawing.Size(139, 35);
            this.MainAddCar.TabIndex = 1;
            this.MainAddCar.Text = "ADD A CAR";
            this.MainAddCar.UseVisualStyleBackColor = true;
            this.MainAddCar.Click += new System.EventHandler(this.MainAddCar_Click);
            // 
            // MainViewCars
            // 
            this.MainViewCars.Location = new System.Drawing.Point(131, 254);
            this.MainViewCars.Name = "MainViewCars";
            this.MainViewCars.Size = new System.Drawing.Size(139, 35);
            this.MainViewCars.TabIndex = 2;
            this.MainViewCars.Text = "VIEW CARS";
            this.MainViewCars.UseVisualStyleBackColor = true;
            this.MainViewCars.Click += new System.EventHandler(this.MainViewCars_Click);
            // 
            // MainAddSalon
            // 
            this.MainAddSalon.Location = new System.Drawing.Point(331, 188);
            this.MainAddSalon.Name = "MainAddSalon";
            this.MainAddSalon.Size = new System.Drawing.Size(139, 35);
            this.MainAddSalon.TabIndex = 3;
            this.MainAddSalon.Text = "ADD A SALON";
            this.MainAddSalon.UseVisualStyleBackColor = true;
            this.MainAddSalon.Click += new System.EventHandler(this.MainAddSalon_Click);
            // 
            // MainViewSalons
            // 
            this.MainViewSalons.Location = new System.Drawing.Point(331, 254);
            this.MainViewSalons.Name = "MainViewSalons";
            this.MainViewSalons.Size = new System.Drawing.Size(139, 35);
            this.MainViewSalons.TabIndex = 4;
            this.MainViewSalons.Text = "VIEW SALONS";
            this.MainViewSalons.UseVisualStyleBackColor = true;
            this.MainViewSalons.Click += new System.EventHandler(this.MainViewSalons_Click);
            // 
            // MainAddCustomer
            // 
            this.MainAddCustomer.Location = new System.Drawing.Point(531, 188);
            this.MainAddCustomer.Name = "MainAddCustomer";
            this.MainAddCustomer.Size = new System.Drawing.Size(139, 35);
            this.MainAddCustomer.TabIndex = 5;
            this.MainAddCustomer.Text = "ADD A CUSTOMER";
            this.MainAddCustomer.UseVisualStyleBackColor = true;
            this.MainAddCustomer.Click += new System.EventHandler(this.MainAddCustomer_Click);
            // 
            // MainViewCustomers
            // 
            this.MainViewCustomers.Location = new System.Drawing.Point(531, 254);
            this.MainViewCustomers.Name = "MainViewCustomers";
            this.MainViewCustomers.Size = new System.Drawing.Size(139, 35);
            this.MainViewCustomers.TabIndex = 6;
            this.MainViewCustomers.Text = "VIEW CUSTOMERS";
            this.MainViewCustomers.UseVisualStyleBackColor = true;
            this.MainViewCustomers.Click += new System.EventHandler(this.MainViewCustomers_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainViewCustomers);
            this.Controls.Add(this.MainAddCustomer);
            this.Controls.Add(this.MainViewSalons);
            this.Controls.Add(this.MainAddSalon);
            this.Controls.Add(this.MainViewCars);
            this.Controls.Add(this.MainAddCar);
            this.Controls.Add(this.MainTitle);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MainTitle;
        private Button MainAddCar;
        private Button MainViewCars;
        private Button MainAddSalon;
        private Button MainViewSalons;
        private Button MainAddCustomer;
        private Button MainViewCustomers;
    }
}
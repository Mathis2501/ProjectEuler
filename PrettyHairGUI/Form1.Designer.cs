namespace PrettyHairGUI
{
    partial class PrettyHairUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CustListBox = new System.Windows.Forms.ListBox();
            this.CustLabel = new System.Windows.Forms.Label();
            this.CustSearchButton = new System.Windows.Forms.Button();
            this.CustSearchTextBox = new System.Windows.Forms.TextBox();
            this.RegiCustLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.RegiCustButton = new System.Windows.Forms.Button();
            this.OrdersListBox = new System.Windows.Forms.ListBox();
            this.OrderListBoxLabel = new System.Windows.Forms.Label();
            this.NewOrderLabel = new System.Windows.Forms.Label();
            this.ProdTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.OrderDateTextBox = new System.Windows.Forms.TextBox();
            this.DeliveryDateTextBox = new System.Windows.Forms.TextBox();
            this.ProdTypeIDLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.OrderDateLavel = new System.Windows.Forms.Label();
            this.DeliveryDateLabel = new System.Windows.Forms.Label();
            this.InputOrderButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 420);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RegiCustButton);
            this.tabPage1.Controls.Add(this.PhoneLabel);
            this.tabPage1.Controls.Add(this.AddressLabel);
            this.tabPage1.Controls.Add(this.LastNameLabel);
            this.tabPage1.Controls.Add(this.FirstNameLabel);
            this.tabPage1.Controls.Add(this.PhoneTextBox);
            this.tabPage1.Controls.Add(this.AddressTextBox);
            this.tabPage1.Controls.Add(this.LastNameTextBox);
            this.tabPage1.Controls.Add(this.FirstNameTextBox);
            this.tabPage1.Controls.Add(this.RegiCustLabel);
            this.tabPage1.Controls.Add(this.CustSearchTextBox);
            this.tabPage1.Controls.Add(this.CustSearchButton);
            this.tabPage1.Controls.Add(this.CustLabel);
            this.tabPage1.Controls.Add(this.CustListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InputOrderButton);
            this.tabPage2.Controls.Add(this.DeliveryDateLabel);
            this.tabPage2.Controls.Add(this.OrderDateLavel);
            this.tabPage2.Controls.Add(this.QuantityLabel);
            this.tabPage2.Controls.Add(this.ProdTypeIDLabel);
            this.tabPage2.Controls.Add(this.DeliveryDateTextBox);
            this.tabPage2.Controls.Add(this.OrderDateTextBox);
            this.tabPage2.Controls.Add(this.QuantityTextBox);
            this.tabPage2.Controls.Add(this.ProdTypeIdTextBox);
            this.tabPage2.Controls.Add(this.NewOrderLabel);
            this.tabPage2.Controls.Add(this.OrderListBoxLabel);
            this.tabPage2.Controls.Add(this.OrdersListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(534, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(658, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CustListBox
            // 
            this.CustListBox.FormattingEnabled = true;
            this.CustListBox.Location = new System.Drawing.Point(6, 87);
            this.CustListBox.Name = "CustListBox";
            this.CustListBox.Size = new System.Drawing.Size(280, 303);
            this.CustListBox.TabIndex = 0;
            // 
            // CustLabel
            // 
            this.CustLabel.AutoSize = true;
            this.CustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLabel.Location = new System.Drawing.Point(6, 68);
            this.CustLabel.Name = "CustLabel";
            this.CustLabel.Size = new System.Drawing.Size(81, 16);
            this.CustLabel.TabIndex = 1;
            this.CustLabel.Text = "Customers";
            // 
            // CustSearchButton
            // 
            this.CustSearchButton.Location = new System.Drawing.Point(6, 16);
            this.CustSearchButton.Name = "CustSearchButton";
            this.CustSearchButton.Size = new System.Drawing.Size(75, 23);
            this.CustSearchButton.TabIndex = 2;
            this.CustSearchButton.Text = "Search";
            this.CustSearchButton.UseVisualStyleBackColor = true;
            this.CustSearchButton.Click += new System.EventHandler(this.CustSearchButton_Click);
            // 
            // CustSearchTextBox
            // 
            this.CustSearchTextBox.Location = new System.Drawing.Point(6, 45);
            this.CustSearchTextBox.Name = "CustSearchTextBox";
            this.CustSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustSearchTextBox.TabIndex = 3;
            this.CustSearchTextBox.TextChanged += new System.EventHandler(this.CustSearchTextBox_TextChanged);
            // 
            // RegiCustLabel
            // 
            this.RegiCustLabel.AutoSize = true;
            this.RegiCustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegiCustLabel.Location = new System.Drawing.Point(320, 19);
            this.RegiCustLabel.Name = "RegiCustLabel";
            this.RegiCustLabel.Size = new System.Drawing.Size(170, 16);
            this.RegiCustLabel.TabIndex = 4;
            this.RegiCustLabel.Text = "Register New Customer";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(320, 63);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 5;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(426, 63);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 6;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(320, 124);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressTextBox.TabIndex = 7;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(427, 124);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneTextBox.TabIndex = 8;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(320, 44);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(427, 44);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Last Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(320, 105);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "Address";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(426, 105);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(73, 13);
            this.PhoneLabel.TabIndex = 12;
            this.PhoneLabel.Text = "Phonenumber";
            // 
            // RegiCustButton
            // 
            this.RegiCustButton.Location = new System.Drawing.Point(320, 151);
            this.RegiCustButton.Name = "RegiCustButton";
            this.RegiCustButton.Size = new System.Drawing.Size(75, 23);
            this.RegiCustButton.TabIndex = 13;
            this.RegiCustButton.Text = "Register";
            this.RegiCustButton.UseVisualStyleBackColor = true;
            this.RegiCustButton.Click += new System.EventHandler(this.RegiCustButton_Click);
            // 
            // OrdersListBox
            // 
            this.OrdersListBox.FormattingEnabled = true;
            this.OrdersListBox.Location = new System.Drawing.Point(6, 26);
            this.OrdersListBox.Name = "OrdersListBox";
            this.OrdersListBox.Size = new System.Drawing.Size(271, 264);
            this.OrdersListBox.TabIndex = 0;
            // 
            // OrderListBoxLabel
            // 
            this.OrderListBoxLabel.AutoSize = true;
            this.OrderListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListBoxLabel.Location = new System.Drawing.Point(6, 7);
            this.OrderListBoxLabel.Name = "OrderListBoxLabel";
            this.OrderListBoxLabel.Size = new System.Drawing.Size(201, 16);
            this.OrderListBoxLabel.TabIndex = 1;
            this.OrderListBoxLabel.Text = "Orders That Needs Process";
            // 
            // NewOrderLabel
            // 
            this.NewOrderLabel.AutoSize = true;
            this.NewOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderLabel.Location = new System.Drawing.Point(291, 5);
            this.NewOrderLabel.Name = "NewOrderLabel";
            this.NewOrderLabel.Size = new System.Drawing.Size(118, 16);
            this.NewOrderLabel.TabIndex = 2;
            this.NewOrderLabel.Text = "Input New Order";
            // 
            // ProdTypeIdTextBox
            // 
            this.ProdTypeIdTextBox.Location = new System.Drawing.Point(294, 45);
            this.ProdTypeIdTextBox.Name = "ProdTypeIdTextBox";
            this.ProdTypeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProdTypeIdTextBox.TabIndex = 3;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(401, 45);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 4;
            // 
            // OrderDateTextBox
            // 
            this.OrderDateTextBox.Location = new System.Drawing.Point(294, 94);
            this.OrderDateTextBox.Name = "OrderDateTextBox";
            this.OrderDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderDateTextBox.TabIndex = 5;
            // 
            // DeliveryDateTextBox
            // 
            this.DeliveryDateTextBox.Location = new System.Drawing.Point(401, 94);
            this.DeliveryDateTextBox.Name = "DeliveryDateTextBox";
            this.DeliveryDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeliveryDateTextBox.TabIndex = 6;
            // 
            // ProdTypeIDLabel
            // 
            this.ProdTypeIDLabel.AutoSize = true;
            this.ProdTypeIDLabel.Location = new System.Drawing.Point(294, 26);
            this.ProdTypeIDLabel.Name = "ProdTypeIDLabel";
            this.ProdTypeIDLabel.Size = new System.Drawing.Size(85, 13);
            this.ProdTypeIDLabel.TabIndex = 7;
            this.ProdTypeIDLabel.Text = "Product Type ID";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(401, 26);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 8;
            this.QuantityLabel.Text = "Quantity";
            // 
            // OrderDateLavel
            // 
            this.OrderDateLavel.AutoSize = true;
            this.OrderDateLavel.Location = new System.Drawing.Point(294, 75);
            this.OrderDateLavel.Name = "OrderDateLavel";
            this.OrderDateLavel.Size = new System.Drawing.Size(59, 13);
            this.OrderDateLavel.TabIndex = 9;
            this.OrderDateLavel.Text = "Order Date";
            // 
            // DeliveryDateLabel
            // 
            this.DeliveryDateLabel.AutoSize = true;
            this.DeliveryDateLabel.Location = new System.Drawing.Point(401, 75);
            this.DeliveryDateLabel.Name = "DeliveryDateLabel";
            this.DeliveryDateLabel.Size = new System.Drawing.Size(71, 13);
            this.DeliveryDateLabel.TabIndex = 10;
            this.DeliveryDateLabel.Text = "Delivery Date";
            // 
            // InputOrderButton
            // 
            this.InputOrderButton.Location = new System.Drawing.Point(294, 121);
            this.InputOrderButton.Name = "InputOrderButton";
            this.InputOrderButton.Size = new System.Drawing.Size(75, 23);
            this.InputOrderButton.TabIndex = 11;
            this.InputOrderButton.Text = "Input";
            this.InputOrderButton.UseVisualStyleBackColor = true;
            // 
            // PrettyHairUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 435);
            this.Controls.Add(this.tabControl1);
            this.Name = "PrettyHairUI";
            this.Text = "Pretty Hair";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox CustSearchTextBox;
        private System.Windows.Forms.Button CustSearchButton;
        private System.Windows.Forms.Label CustLabel;
        private System.Windows.Forms.ListBox CustListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label RegiCustLabel;
        private System.Windows.Forms.Button RegiCustButton;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox DeliveryDateTextBox;
        private System.Windows.Forms.TextBox OrderDateTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox ProdTypeIdTextBox;
        private System.Windows.Forms.Label NewOrderLabel;
        private System.Windows.Forms.Label OrderListBoxLabel;
        private System.Windows.Forms.ListBox OrdersListBox;
        private System.Windows.Forms.Button InputOrderButton;
        private System.Windows.Forms.Label DeliveryDateLabel;
        private System.Windows.Forms.Label OrderDateLavel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ProdTypeIDLabel;
    }
}


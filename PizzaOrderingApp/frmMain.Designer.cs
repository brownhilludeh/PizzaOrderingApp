namespace PizzaOrderingApp
{
    partial class frmMain
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
            this.tcPizzaOrder = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.lblBusinessMotto = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblBusinessSlogan = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.tpPizza = new System.Windows.Forms.TabPage();
            this.lblToppings = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.rbSpicy = new System.Windows.Forms.RadioButton();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.lblSauceType = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.tpSummary = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.tcPizzaOrder.SuspendLayout();
            this.tpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.tpPizza.SuspendLayout();
            this.tpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPizzaOrder
            // 
            this.tcPizzaOrder.Controls.Add(this.tpHome);
            this.tcPizzaOrder.Controls.Add(this.tpPizza);
            this.tcPizzaOrder.Controls.Add(this.tpSummary);
            this.tcPizzaOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPizzaOrder.Location = new System.Drawing.Point(7, 7);
            this.tcPizzaOrder.Margin = new System.Windows.Forms.Padding(0);
            this.tcPizzaOrder.Name = "tcPizzaOrder";
            this.tcPizzaOrder.Padding = new System.Drawing.Point(16, 6);
            this.tcPizzaOrder.SelectedIndex = 0;
            this.tcPizzaOrder.Size = new System.Drawing.Size(556, 550);
            this.tcPizzaOrder.TabIndex = 16;
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.lblBusinessMotto);
            this.tpHome.Controls.Add(this.imgLogo);
            this.tpHome.Controls.Add(this.lblBusinessSlogan);
            this.tpHome.Controls.Add(this.lblBusinessName);
            this.tpHome.Location = new System.Drawing.Point(4, 35);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpHome.Size = new System.Drawing.Size(548, 511);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // lblBusinessMotto
            // 
            this.lblBusinessMotto.AutoSize = true;
            this.lblBusinessMotto.Font = new System.Drawing.Font("Brush Script MT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessMotto.Location = new System.Drawing.Point(152, 349);
            this.lblBusinessMotto.Name = "lblBusinessMotto";
            this.lblBusinessMotto.Size = new System.Drawing.Size(216, 33);
            this.lblBusinessMotto.TabIndex = 4;
            this.lblBusinessMotto.Text = "... that bottom pot ...";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::PizzaOrderingApp.Properties.Resources.pizza_svgrepo_com;
            this.imgLogo.Location = new System.Drawing.Point(223, 102);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(101, 88);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // lblBusinessSlogan
            // 
            this.lblBusinessSlogan.AutoSize = true;
            this.lblBusinessSlogan.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessSlogan.Location = new System.Drawing.Point(151, 237);
            this.lblBusinessSlogan.Name = "lblBusinessSlogan";
            this.lblBusinessSlogan.Size = new System.Drawing.Size(238, 39);
            this.lblBusinessSlogan.TabIndex = 1;
            this.lblBusinessSlogan.Text = "Pizza On Point";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.Location = new System.Drawing.Point(160, 193);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(208, 49);
            this.lblBusinessName.TabIndex = 0;
            this.lblBusinessName.Text = "Brownhill\'s";
            // 
            // tpPizza
            // 
            this.tpPizza.AllowDrop = true;
            this.tpPizza.Controls.Add(this.lblToppings);
            this.tpPizza.Controls.Add(this.btnAddToOrder);
            this.tpPizza.Controls.Add(this.rbSpicy);
            this.tpPizza.Controls.Add(this.clbToppings);
            this.tpPizza.Controls.Add(this.rbRegular);
            this.tpPizza.Controls.Add(this.lblSauceType);
            this.tpPizza.Controls.Add(this.cmbSize);
            this.tpPizza.Controls.Add(this.lblSize);
            this.tpPizza.Location = new System.Drawing.Point(4, 35);
            this.tpPizza.Name = "tpPizza";
            this.tpPizza.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpPizza.Size = new System.Drawing.Size(548, 511);
            this.tpPizza.TabIndex = 1;
            this.tpPizza.Text = "Pizza";
            this.tpPizza.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(141, 158);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(123, 20);
            this.lblToppings.TabIndex = 34;
            this.lblToppings.Text = "Select Toppings";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(208, 436);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(135, 34);
            this.btnAddToOrder.TabIndex = 33;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // rbSpicy
            // 
            this.rbSpicy.AutoSize = true;
            this.rbSpicy.Location = new System.Drawing.Point(248, 110);
            this.rbSpicy.Name = "rbSpicy";
            this.rbSpicy.Size = new System.Drawing.Size(65, 24);
            this.rbSpicy.TabIndex = 32;
            this.rbSpicy.TabStop = true;
            this.rbSpicy.Text = "Spicy";
            this.rbSpicy.UseVisualStyleBackColor = true;
            // 
            // clbToppings
            // 
            this.clbToppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Location = new System.Drawing.Point(145, 188);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(269, 210);
            this.clbToppings.TabIndex = 30;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Checked = true;
            this.rbRegular.Location = new System.Drawing.Point(248, 80);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(83, 24);
            this.rbRegular.TabIndex = 31;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // lblSauceType
            // 
            this.lblSauceType.AutoSize = true;
            this.lblSauceType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauceType.Location = new System.Drawing.Point(142, 84);
            this.lblSauceType.Name = "lblSauceType";
            this.lblSauceType.Size = new System.Drawing.Size(90, 18);
            this.lblSauceType.TabIndex = 18;
            this.lblSauceType.Text = "Sauce Type";
            // 
            // cmbSize
            // 
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "10\"",
            "12\"",
            "14\""});
            this.cmbSize.Location = new System.Drawing.Point(248, 34);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(122, 26);
            this.cmbSize.TabIndex = 17;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(142, 41);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(81, 18);
            this.lblSize.TabIndex = 16;
            this.lblSize.Text = "Pizza Size";
            // 
            // tpSummary
            // 
            this.tpSummary.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.tpSummary.Controls.Add(this.btnExit);
            this.tpSummary.Controls.Add(this.btnClearOrder);
            this.tpSummary.Controls.Add(this.lblOrderSummary);
            this.tpSummary.Controls.Add(this.lstSummary);
            this.tpSummary.Location = new System.Drawing.Point(4, 35);
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(548, 511);
            this.tpSummary.TabIndex = 2;
            this.tpSummary.Text = "Summary";
            this.tpSummary.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.Location = new System.Drawing.Point(142, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(252, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Close Application";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(124, 250);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(286, 31);
            this.btnClearOrder.TabIndex = 2;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Location = new System.Drawing.Point(9, 24);
            this.lblOrderSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(120, 20);
            this.lblOrderSummary.TabIndex = 1;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // lstSummary
            // 
            this.lstSummary.Enabled = false;
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.ItemHeight = 20;
            this.lstSummary.Location = new System.Drawing.Point(13, 48);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(527, 164);
            this.lstSummary.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 566);
            this.Controls.Add(this.tcPizzaOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Pizza Ordering Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcPizzaOrder.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.tpPizza.ResumeLayout(false);
            this.tpPizza.PerformLayout();
            this.tpSummary.ResumeLayout(false);
            this.tpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcPizzaOrder;
        private System.Windows.Forms.TabPage tpPizza;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpSummary;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.Label lblSauceType;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblBusinessSlogan;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblBusinessMotto;
        private System.Windows.Forms.RadioButton rbSpicy;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearOrder;
    }
}


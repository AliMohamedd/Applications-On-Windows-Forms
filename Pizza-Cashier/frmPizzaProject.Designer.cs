namespace Pizza_Cashier
{
    partial class frmPizzaCashier
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
            this.lblHeadTitle = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkbOlives = new System.Windows.Forms.CheckBox();
            this.chkbOnion = new System.Windows.Forms.CheckBox();
            this.chkbTomatoes = new System.Windows.Forms.CheckBox();
            this.chkbMushrooms = new System.Windows.Forms.CheckBox();
            this.chkbExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.Label();
            this.txtTotalPriceValue = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.txtWhereToEatValue = new System.Windows.Forms.Label();
            this.txtCrustTypeValue = new System.Windows.Forms.Label();
            this.txtWhereToEat = new System.Windows.Forms.Label();
            this.txtCrustType = new System.Windows.Forms.Label();
            this.txtToppingsValue = new System.Windows.Forms.Label();
            this.txtToppings = new System.Windows.Forms.Label();
            this.txtSizeValue = new System.Windows.Forms.Label();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadTitle
            // 
            this.lblHeadTitle.AutoSize = true;
            this.lblHeadTitle.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadTitle.ForeColor = System.Drawing.Color.Red;
            this.lblHeadTitle.Location = new System.Drawing.Point(277, 8);
            this.lblHeadTitle.Name = "lblHeadTitle";
            this.lblHeadTitle.Size = new System.Drawing.Size(616, 79);
            this.lblHeadTitle.TabIndex = 0;
            this.lblHeadTitle.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(58, 128);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 176);
            this.gbSize.TabIndex = 100;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(39, 139);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(70, 24);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(39, 89);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(86, 24);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(39, 39);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(69, 24);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkbGreenPeppers);
            this.gbToppings.Controls.Add(this.chkbOlives);
            this.gbToppings.Controls.Add(this.chkbOnion);
            this.gbToppings.Controls.Add(this.chkbTomatoes);
            this.gbToppings.Controls.Add(this.chkbMushrooms);
            this.gbToppings.Controls.Add(this.chkbExtraCheese);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.Location = new System.Drawing.Point(335, 128);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(328, 139);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkbGreenPeppers
            // 
            this.chkbGreenPeppers.AutoSize = true;
            this.chkbGreenPeppers.Location = new System.Drawing.Point(177, 107);
            this.chkbGreenPeppers.Name = "chkbGreenPeppers";
            this.chkbGreenPeppers.Size = new System.Drawing.Size(141, 24);
            this.chkbGreenPeppers.TabIndex = 5;
            this.chkbGreenPeppers.Tag = "5";
            this.chkbGreenPeppers.Text = "Green Peppers";
            this.chkbGreenPeppers.UseVisualStyleBackColor = true;
            this.chkbGreenPeppers.CheckedChanged += new System.EventHandler(this.chkbGreenPeppers_CheckedChanged);
            // 
            // chkbOlives
            // 
            this.chkbOlives.AutoSize = true;
            this.chkbOlives.Location = new System.Drawing.Point(177, 76);
            this.chkbOlives.Name = "chkbOlives";
            this.chkbOlives.Size = new System.Drawing.Size(75, 24);
            this.chkbOlives.TabIndex = 4;
            this.chkbOlives.Tag = "5";
            this.chkbOlives.Text = "Olives";
            this.chkbOlives.UseVisualStyleBackColor = true;
            this.chkbOlives.CheckedChanged += new System.EventHandler(this.chkbOlives_CheckedChanged);
            // 
            // chkbOnion
            // 
            this.chkbOnion.AutoSize = true;
            this.chkbOnion.Location = new System.Drawing.Point(177, 43);
            this.chkbOnion.Name = "chkbOnion";
            this.chkbOnion.Size = new System.Drawing.Size(72, 24);
            this.chkbOnion.TabIndex = 3;
            this.chkbOnion.Tag = "5";
            this.chkbOnion.Text = "Onion";
            this.chkbOnion.UseVisualStyleBackColor = true;
            this.chkbOnion.CheckedChanged += new System.EventHandler(this.chkbOnion_CheckedChanged);
            // 
            // chkbTomatoes
            // 
            this.chkbTomatoes.AutoSize = true;
            this.chkbTomatoes.Location = new System.Drawing.Point(9, 107);
            this.chkbTomatoes.Name = "chkbTomatoes";
            this.chkbTomatoes.Size = new System.Drawing.Size(102, 24);
            this.chkbTomatoes.TabIndex = 2;
            this.chkbTomatoes.Tag = "5";
            this.chkbTomatoes.Text = "Tomatoes";
            this.chkbTomatoes.UseVisualStyleBackColor = true;
            this.chkbTomatoes.CheckedChanged += new System.EventHandler(this.chkbTomatoes_CheckedChanged);
            // 
            // chkbMushrooms
            // 
            this.chkbMushrooms.AutoSize = true;
            this.chkbMushrooms.Location = new System.Drawing.Point(9, 76);
            this.chkbMushrooms.Name = "chkbMushrooms";
            this.chkbMushrooms.Size = new System.Drawing.Size(116, 24);
            this.chkbMushrooms.TabIndex = 1;
            this.chkbMushrooms.Tag = "5";
            this.chkbMushrooms.Text = "Mushrooms";
            this.chkbMushrooms.UseVisualStyleBackColor = true;
            this.chkbMushrooms.CheckedChanged += new System.EventHandler(this.chkbMushrooms_CheckedChanged);
            // 
            // chkbExtraCheese
            // 
            this.chkbExtraCheese.AutoSize = true;
            this.chkbExtraCheese.Location = new System.Drawing.Point(9, 43);
            this.chkbExtraCheese.Name = "chkbExtraCheese";
            this.chkbExtraCheese.Size = new System.Drawing.Size(129, 24);
            this.chkbExtraCheese.TabIndex = 0;
            this.chkbExtraCheese.Tag = "5";
            this.chkbExtraCheese.Text = "Extra Cheese";
            this.chkbExtraCheese.UseVisualStyleBackColor = true;
            this.chkbExtraCheese.CheckedChanged += new System.EventHandler(this.chkbExtraCheese_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.txtSize);
            this.gbOrderSummary.Controls.Add(this.txtTotalPriceValue);
            this.gbOrderSummary.Controls.Add(this.txtTotalPrice);
            this.gbOrderSummary.Controls.Add(this.txtWhereToEatValue);
            this.gbOrderSummary.Controls.Add(this.txtCrustTypeValue);
            this.gbOrderSummary.Controls.Add(this.txtWhereToEat);
            this.gbOrderSummary.Controls.Add(this.txtCrustType);
            this.gbOrderSummary.Controls.Add(this.txtToppingsValue);
            this.gbOrderSummary.Controls.Add(this.txtToppings);
            this.gbOrderSummary.Controls.Add(this.txtSizeValue);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(730, 128);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(354, 369);
            this.gbOrderSummary.TabIndex = 3;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // txtSize
            // 
            this.txtSize.AutoSize = true;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(19, 43);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(52, 20);
            this.txtSize.TabIndex = 0;
            this.txtSize.Text = "Size:";
            // 
            // txtTotalPriceValue
            // 
            this.txtTotalPriceValue.AutoSize = true;
            this.txtTotalPriceValue.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPriceValue.ForeColor = System.Drawing.Color.Green;
            this.txtTotalPriceValue.Location = new System.Drawing.Point(132, 281);
            this.txtTotalPriceValue.Name = "txtTotalPriceValue";
            this.txtTotalPriceValue.Size = new System.Drawing.Size(108, 74);
            this.txtTotalPriceValue.TabIndex = 9;
            this.txtTotalPriceValue.Text = "$0";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(19, 286);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(107, 20);
            this.txtTotalPrice.TabIndex = 8;
            this.txtTotalPrice.Text = "Total Price:";
            // 
            // txtWhereToEatValue
            // 
            this.txtWhereToEatValue.AutoSize = true;
            this.txtWhereToEatValue.Location = new System.Drawing.Point(130, 227);
            this.txtWhereToEatValue.Name = "txtWhereToEatValue";
            this.txtWhereToEatValue.Size = new System.Drawing.Size(37, 20);
            this.txtWhereToEatValue.TabIndex = 7;
            this.txtWhereToEatValue.Text = "N/A";
            // 
            // txtCrustTypeValue
            // 
            this.txtCrustTypeValue.AutoSize = true;
            this.txtCrustTypeValue.Location = new System.Drawing.Point(132, 174);
            this.txtCrustTypeValue.Name = "txtCrustTypeValue";
            this.txtCrustTypeValue.Size = new System.Drawing.Size(37, 20);
            this.txtCrustTypeValue.TabIndex = 6;
            this.txtCrustTypeValue.Text = "N/A";
            // 
            // txtWhereToEat
            // 
            this.txtWhereToEat.AutoSize = true;
            this.txtWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhereToEat.Location = new System.Drawing.Point(19, 199);
            this.txtWhereToEat.Name = "txtWhereToEat";
            this.txtWhereToEat.Size = new System.Drawing.Size(125, 20);
            this.txtWhereToEat.TabIndex = 5;
            this.txtWhereToEat.Text = "Where to Eat:";
            // 
            // txtCrustType
            // 
            this.txtCrustType.AutoSize = true;
            this.txtCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrustType.Location = new System.Drawing.Point(19, 174);
            this.txtCrustType.Name = "txtCrustType";
            this.txtCrustType.Size = new System.Drawing.Size(107, 20);
            this.txtCrustType.TabIndex = 4;
            this.txtCrustType.Text = "Crust Type:";
            // 
            // txtToppingsValue
            // 
            this.txtToppingsValue.AutoSize = true;
            this.txtToppingsValue.Location = new System.Drawing.Point(65, 107);
            this.txtToppingsValue.MaximumSize = new System.Drawing.Size(289, 70);
            this.txtToppingsValue.Name = "txtToppingsValue";
            this.txtToppingsValue.Size = new System.Drawing.Size(103, 20);
            this.txtToppingsValue.TabIndex = 3;
            this.txtToppingsValue.Text = "No Toppings";
            // 
            // txtToppings
            // 
            this.txtToppings.AutoSize = true;
            this.txtToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToppings.Location = new System.Drawing.Point(19, 76);
            this.txtToppings.Name = "txtToppings";
            this.txtToppings.Size = new System.Drawing.Size(91, 20);
            this.txtToppings.TabIndex = 2;
            this.txtToppings.Text = "Toppings:";
            // 
            // txtSizeValue
            // 
            this.txtSizeValue.AutoSize = true;
            this.txtSizeValue.Location = new System.Drawing.Point(68, 43);
            this.txtSizeValue.Name = "txtSizeValue";
            this.txtSizeValue.Size = new System.Drawing.Size(37, 20);
            this.txtSizeValue.TabIndex = 1;
            this.txtSizeValue.Text = "N/A";
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.Location = new System.Drawing.Point(58, 366);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(200, 117);
            this.gbCrustType.TabIndex = 4;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(24, 85);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(113, 24);
            this.rbThickCrust.TabIndex = 4;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(24, 35);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(105, 24);
            this.rbThinCrust.TabIndex = 3;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(335, 366);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(328, 68);
            this.gbWhereToEat.TabIndex = 5;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(126, 35);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(95, 24);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(20, 35);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(70, 24);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(569, 496);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(126, 48);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(331, 496);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(126, 48);
            this.btnOrderPizza.TabIndex = 7;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // frmPizzaProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1148, 580);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblHeadTitle);
            this.Name = "frmPizzaProject";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.frmPizzaProject_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadTitle;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.Label txtSizeValue;
        private System.Windows.Forms.Label txtSize;
        private System.Windows.Forms.Label txtToppingsValue;
        private System.Windows.Forms.Label txtToppings;
        private System.Windows.Forms.CheckBox chkbExtraCheese;
        private System.Windows.Forms.Label txtCrustType;
        private System.Windows.Forms.CheckBox chkbGreenPeppers;
        private System.Windows.Forms.CheckBox chkbOlives;
        private System.Windows.Forms.CheckBox chkbOnion;
        private System.Windows.Forms.CheckBox chkbTomatoes;
        private System.Windows.Forms.CheckBox chkbMushrooms;
        private System.Windows.Forms.Label txtWhereToEatValue;
        private System.Windows.Forms.Label txtCrustTypeValue;
        private System.Windows.Forms.Label txtWhereToEat;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.Label txtTotalPriceValue;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrderPizza;
    }
}


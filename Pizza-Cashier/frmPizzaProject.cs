using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Pizza_Cashier
{
    public partial class frmPizzaCashier : Form
    {
        public frmPizzaCashier()
        {
            InitializeComponent();
        }
        
        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                txtSizeValue.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                txtSizeValue.Text = "Medium";
                return;
            }
            
            if (rbLarge.Checked) 
            {
                txtSizeValue.Text = "Large";
            }
        }

        private void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                txtCrustTypeValue.Text = "Thin Crust";
                return;
            }
            
            if(rbThickCrust.Checked)
            {
                txtCrustTypeValue.Text = "Thick Crust";
                return;
            }
        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();

            string AllToppings = string.Empty;

            if (chkbExtraCheese.Checked)
            {
                AllToppings += ", ExtraCheese";
            }

            if (chkbOnion.Checked)
            {
                AllToppings += ", Onion";
            }

            if (chkbMushrooms.Checked)
            {
                AllToppings += ", Mushrooms";
            }

            if (chkbOlives.Checked)
            {
                AllToppings += ", Olives";
            }

            if (chkbTomatoes.Checked)
            {
                AllToppings += ", Tomatoes";
            }

            if (chkbGreenPeppers.Checked)
            {
                AllToppings += ", GreenPeppers";
            }

            if (AllToppings.StartsWith(","))
                AllToppings = AllToppings.Substring(1, AllToppings.Length - 1).Trim();

            if (AllToppings == string.Empty)
                AllToppings = "No Topping";

            txtToppingsValue.Text = AllToppings;
        }

        private void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                txtWhereToEatValue.Text = "Eat In";
                return;
            }
            
            if (rbTakeOut.Checked)
            {
                txtWhereToEatValue.Text = "Take Out";
                return;
            }
        }

        private float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            
            if (rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

            return 0;
        }

        private float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }

            if (rbThickCrust.Checked)
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }

            return 0;
        }

        private float CalculateToppingsPrice()
        {
            float TotalPrice = 0;
            if (chkbExtraCheese.Checked)
            {
                TotalPrice += Convert.ToSingle(chkbExtraCheese.Tag);
            }

            if(chkbOnion.Checked)
            {
                TotalPrice += Convert.ToSingle(chkbOnion.Tag);
            }

            if (chkbMushrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(chkbMushrooms.Tag);
            }

            if(chkbOlives.Checked)
            {
                TotalPrice += Convert.ToSingle(chkbOlives.Tag);
            }

            if(chkbTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chkbTomatoes.Tag);
            }

            if(chkbGreenPeppers.Checked)
            {
                TotalPrice += Convert.ToSingle(chkbGreenPeppers.Tag);
            }

            return TotalPrice;
        }

        private float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice();
        }

        private void UpdateTotalPrice()
        {
            txtTotalPriceValue.Text = "$" + Convert.ToString(CalculateTotalPrice());
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrustType();
            UpdateWhereToEat();
        }

        private void ResetForm()
        {
            UpdateOrderSummary();

            // Hide Groups.
            gbSize.Enabled = true;
            //gbSize.Visible = true;
            gbToppings.Enabled = true;
            //gbToppings.Visible = true;
            gbCrustType.Enabled = true;
            //gbCrustType.Visible = true;
            gbWhereToEat.Enabled = true;
            //gbWhereToEat.Visible = true;


            // Reset Size.
            rbMedium.Checked = true;

            // Reset Toppings.
            chkbExtraCheese.Checked = false;
            chkbOnion.Checked = false;
            chkbMushrooms.Checked = false;
            chkbOlives.Checked = false;
            chkbTomatoes.Checked = false;
            chkbGreenPeppers.Checked = false;

            // Reset Crust Type.
            rbThinCrust.Checked = true;

            // Reset Where to Eat.
            rbEatIn.Checked = true;

            // Reset Order Button.
            btnOrderPizza.Enabled = true;
            //btnOrderPizza.Visible = true;
        }

        private void frmPizzaProject_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Confirm Order", "Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==
                DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled = false;
                //gbSize.Visible = false;
                gbToppings.Enabled = false;
                //gbToppings.Visible = false;
                gbCrustType.Enabled = false;    
                //gbCrustType.Visible = false;
                gbWhereToEat.Enabled = false;
                //gbWhereToEat.Visible = false;
                btnOrderPizza.Enabled = false;
                //btnOrderPizza.Visible = false;
            }
            else
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

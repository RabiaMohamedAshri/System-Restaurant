using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsForm
{
    public partial class the_list : Form
    {
        public the_list()
        {
            InitializeComponent();
        }

        private void labClose_Click(object sender, EventArgs e)
        { 
            this.Close();   
           
        }
       
        void UpdateSize()
        {
            UpdateTotalPrice();

            if(rbSmall.Checked)
            {
                lbSize.Text = "Small";
                return;
            }
            if(rbMeduim.Checked)
            {
                lbSize.Text = "Meduim";
                return;
            }
            if(rbLarg.Checked)
            {
                lbSize.Text = "Larg";
                return;
            }

        }
        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "Total Toppings ";

            if(chkExtraChees.Checked)
            {
                Toppings += "\n\nExtra Chees";
            }
            if(chkMushrooms.Checked)
            {
                Toppings += "\n\nMushrooms";
            }
            if(chkTomatoes.Checked)
            {
                Toppings += "\n\nTomatoes";
            }
            if(chkOnion.Checked)
            {
                Toppings += "\n\nOnion";
            }
            if (chkOlives.Checked)
            {
                Toppings += "\n\nOlives";
            }
            if(chkGreenPeppers.Checked)
            {
                Toppings += "\n\nGreen Peppers";
            }

            if (Toppings == "")
                Toppings = "No Toppings";

            grbTotalToppings.Text = Toppings;
        }
        void UpdateCrust()
        {
            UpdateTotalPrice() ;
            if(rbThinCrust.Checked)
            {
                lbCrustType.Text = "Thin Crust";
                return;
            }
            if(rbThinkCrust.Checked)
            {
                lbCrustType.Text = "Think Crust";
                return;
            }
        }
        void UpdateWhereToEat()
        {
            if(rbEatin.Checked)
            {
                lbWheretoeat.Text = "Eat In";
                return;
            }
            if(rbTakeOut.Checked)
            {
                lbWheretoeat.Text = "Take Out";
                return;
            }
        }
        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            
              return Convert.ToSingle(rbSmall.Tag);
            
             else if (rbMeduim.Checked)
            
              return Convert.ToSingle(rbMeduim.Tag);
            
             else 
            
                return Convert.ToSingle(rbLarg.Tag);
            
        }
        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrince = 0; 

            if(chkExtraChees.Checked)
            {
                ToppingsTotalPrince += Convert.ToSingle(chkExtraChees.Tag);

            }
            if(chkOnion.Checked)
            {
                ToppingsTotalPrince += Convert.ToSingle(chkOnion.Tag);
            }
            if(chkMushrooms.Checked)
            {
                ToppingsTotalPrince += Convert.ToSingle(chkMushrooms.Tag);
            }
           
            if(chkOlives.Checked)
            {
                ToppingsTotalPrince += Convert.ToSingle(chkOlives.Tag);
            }
           
            if(chkTomatoes.Checked)
            {
                ToppingsTotalPrince += Convert.ToSingle(chkTomatoes.Tag);
            }
            if(chkGreenPeppers.Checked)
            {
                ToppingsTotalPrince += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return ToppingsTotalPrince;

        }
        float GetSelectedCrustPrice()
        {
            if(rbThinCrust.Checked)
            
              return Convert.ToSingle(rbThinCrust.Tag);
            
            else
                return Convert.ToSingle(rbThinkCrust.Tag);
            
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice() ;
        }
        void UpdateTotalPrice()
        {
            lbtotalprice.Text = "EG." + CalculateToppingsPrice().ToString();
        }
       
        void UpdateOrderSummory()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }
        void ResetForm()
        {
            grbCustType.Enabled = true;
            grbToppings.Enabled=true;
            grbSize.Enabled=true;
            grbWhereToEat.Enabled=true;

            rbSmall.Checked=true;

            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;

            rbThinCrust.Checked = true;

            rbEatin.Checked= true;

            btOrderpizza.Enabled = true;
        }
        private void btOrderpizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confrim Order", "Confrim", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {

                btOrderpizza.Enabled = false;
                grbSize.Enabled = false;
                grbCustType.Enabled = false;
                grbToppings.Enabled = false;
                grbWhereToEat.Enabled = false;

            }

            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void the_list_Load(object sender, EventArgs e)
        {
            UpdateOrderSummory();
        }

        private void botResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

       
    }
}

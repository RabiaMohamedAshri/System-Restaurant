using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsForm
{
    public partial class Form_Crepe : Form
    {
        public Form_Crepe()
        {
            InitializeComponent();
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void UpdateGropyCrepe()
        {
            UpdateTotalPrice();
            if (rbchickenZinger.Checked)
            {
                lbCrepeis.Text = "Chechen Zinger";
                return;
            }
            if(rbChickenFajita.Checked)
            {
                lbCrepeis.Text = "Chicken Fajita";
                return;
            }
            if(rbChickenShawarma.Checked)
            {
                lbCrepeis.Text = "Chicken Shawarma";
                return;
            }
            if(rbCrepeBurger.Checked)
            {
                lbCrepeis.Text = "Crepe Burger";
                return;
            }
            if(rbCrepeFries.Checked)
            {
                lbCrepeis.Text = "Crepe Fries";
                return;
            }
            if(rbMixChicken.Checked)
            {
                lbCrepeis.Text = "Mix Chicken";
                return;
            }
       
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();
            string Toppings = " ";

            if (chkOlives.Checked)
            {
                Toppings += "Olives";
            }
            if(chkOnion.Checked)
            {
                Toppings += "\nOnion";
            }
            if(chkMozzarella.Checked)
            {
                Toppings += "\nMozzarella";
            }

            if (Toppings == "")
                Toppings = "No Toppings";
            lbTotelToppings.Text = Toppings;
        }
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();
            if (rbEatin.Checked)
            {
               lbWhereToEat.Text = "Eat In";
                return;
            }
            if (rbTakeOut.Checked)
            {
                lbWhereToEat.Text = "Take Out";
                return;
            }
            
        }
        float GetSelectedGropyCrepe()
        {
            if (rbchickenZinger.Checked)
                return Convert.ToSingle(rbchickenZinger.Tag);
            else if (rbChickenShawarma.Checked)
                return Convert.ToSingle(rbChickenShawarma.Tag);
            else if (rbChickenFajita.Checked)
                return Convert.ToSingle(rbChickenFajita.Tag);
            else if (rbCrepeBurger.Checked)
                return Convert.ToSingle(rbCrepeBurger.Tag);
            else if (rbCrepeFries.Checked)
                return Convert.ToSingle(rbCrepeFries.Tag);
            else 
                return Convert.ToSingle(rbMixChicken.Tag);
        }
        float CalculateToppingsPrice()
        {
            float ToppingsTotalPlice = 0;
            if(chkOlives.Checked)
            {
                ToppingsTotalPlice += Convert.ToSingle(chkOlives.Tag);
            }
            if(chkOnion.Checked)
            {
                ToppingsTotalPlice += Convert.ToSingle(chkOnion.Tag);
            }
            if(chkMozzarella.Checked)
            {
                ToppingsTotalPlice += Convert.ToSingle(chkMozzarella.Tag);
            }
            return ToppingsTotalPlice;

        }
        float CalculateTotalPrice()
        {
            return CalculateToppingsPrice() + GetSelectedGropyCrepe();
        }
        void UpdateTotalPrice()
        {
            lbTotelPrice.Text = "EG." + CalculateTotalPrice().ToString();
        }
        void UpdateOrderSummory()
        {
            UpdateGropyCrepe();
            UpdateToppings();
            UpdateWhereToEat();
        }
        void ResetForm()
        {
            gbgropyCrepe.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            rbchickenZinger.Checked = false;
            rbChickenShawarma.Checked = false;
            rbChickenFajita.Checked = false;
            rbCrepeBurger.Checked = false;  
            rbCrepeFries.Checked = false;
            rbMixChicken.Checked = false;

            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkMozzarella.Checked = false;

            rbTakeOut.Checked = false;
            rbEatin.Checked = false;

            btOrder.Enabled = true;


        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confrim Order", "Confrim",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question)==DialogResult.OK)
            {
                gbgropyCrepe.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                
            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void rbchickenZinger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGropyCrepe();
        }

        private void rbChickenFajita_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGropyCrepe();
        }

        private void rbChickenShawarma_CheckedChanged(object sender, EventArgs e)
        {

            UpdateGropyCrepe();
        }

        private void rbCrepeFries_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGropyCrepe();
        }

        private void rbCrepeBurger_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGropyCrepe();
        }

        private void rbMixChicken_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGropyCrepe();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMozzarellaCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Department_is_Pizza_Load(object sender, EventArgs e)
        {
            UpdateOrderSummory();
        }

        private void btRestorForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

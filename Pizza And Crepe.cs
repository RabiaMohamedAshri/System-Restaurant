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
    public partial class Frm_This_is_my_projects : Form
    {
        public Frm_This_is_my_projects()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Form form = new the_list();

            form.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form form = new Form_Crepe();
            form.ShowDialog();
        }

       
    }
}

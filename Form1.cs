using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finaldelivery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Kontrollerar så att åtminstonde en av checkboxarna är markerade 
            if (!gurkaBox.Checked && !äppleBox.Checked && !spenatBox.Checked && !tomatBox.Checked && !bananBox.Checked && !gubbeBox.Checked && !potatisBox.Checked
                && !pastaBox.Checked && !havreBox.Checked && !risBox.Checked && !checkBox11.Checked && !colaBox.Checked && !fantabox.Checked && !sevenBox.Checked && !celBox.Checked)
            {
                MessageBox.Show("Please choose your food before you place an order.");
                return;
            }

            // if sats som kollar så att alla textboxar är i fyllda

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAdd.Text) || string.IsNullOrEmpty(txtCon.Text))
            {
                MessageBox.Show("Vänligen fyll i alla rader", "Felmeddelande", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // om alla textboxar är i fyllda så läggs order och detta visas 

            MessageBox.Show("Your order has now been placed and you will soon get your groceries!" +
             "You may now exit the page!");
            
        }
    }
    
}

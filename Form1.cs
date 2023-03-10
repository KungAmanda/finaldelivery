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
            // Kontrollera om alla obligatoriska kryssrutor är markerade
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked && !checkBox7.Checked
                && !checkBox8.Checked && !checkBox9.Checked && !checkBox10.Checked && !checkBox11.Checked && !checkBox12.Checked && !checkBox13.Checked && !checkBox14.Checked && !checkBox15.Checked)
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

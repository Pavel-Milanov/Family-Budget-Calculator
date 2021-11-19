using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget
{
    public partial class RemoveMoney : Form
    {
        public RemoveMoney()
        {
            InitializeComponent();
        }

        private void RemoveMoney_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;

            firstTextBoxNumber = int.Parse(textBox1.Text);
            //MessageBox.Show(firstTextBoxNumber.ToString());

            Global.Money = Global.Money - firstTextBoxNumber;

            this.Close();
        }
    }
}

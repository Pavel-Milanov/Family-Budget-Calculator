using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;






namespace FamilyBudget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_add(object sender, EventArgs e)
        {
            AddMoney settingsForm = new AddMoney();
            settingsForm.Show();
        }

        private void button_remove(object sender, EventArgs e)
        {
            RemoveMoney settingsForm = new RemoveMoney();
            settingsForm.Show();
        }

        private void button_add_repeat(object sender, EventArgs e)
        {
            AddMoney settingsForm = new AddMoney();
            settingsForm.Show();
        }

        private void button_remove_repeat(object sender, EventArgs e)
        {
            RemoveMoney settingsForm = new RemoveMoney();
            settingsForm.Show();
        } 
    
 


        private void Text_Box(object sender, EventArgs e)
        {

            //TextBox Mytextbox = new TextBox();

            textBox1.Text = Global.Money.ToString();
            //MessageBox.Show(textBox1.Text);
            //this.Controls.Add(Mytextbox);

            //string str = Global.Money.ToString(Mytextbox);
            //Mytextbox = Global.Money ;

        }

        private void button_edit(object sender, EventArgs e)
        {
            Edit settingsForm = new Edit();
            settingsForm.Show();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }

   

}





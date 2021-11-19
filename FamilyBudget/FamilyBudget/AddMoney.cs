using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FamilyBudget
{
    public partial class AddMoney : Form
    {
        public AddMoney()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseForm;Integrated Security=True");


        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }



            private void button1_Click(object sender, EventArgs e)
            {

            //

           






            //




                            
            ControlID.Money = textBox1.Text;
            
            int firstTextBoxNumber;
            
            firstTextBoxNumber = int.Parse(textBox1.Text);
            //MessageBox.Show(firstTextBoxNumber.ToString());

            Global.Money = Global.Money + firstTextBoxNumber ;

            //System.Windows.Forms.Application.ExitThread();

            ControlID.Day = textBox2.Text;
            ControlID.Month = textBox3.Text;


            textBox1.Text = Global.Money.ToString();//last


            //basedata


            con.Open();
            String query = "INSERT INTO Table_Insert (Day,Month,Money) VALUES('" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox1.Text + "',)";
            SqlDataAdapter SDA = new SqlDataAdapter ( query , con );
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("INSERTED SUCCESS");




            //
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }




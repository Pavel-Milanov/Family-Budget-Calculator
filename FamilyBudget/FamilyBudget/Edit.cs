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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet1.Table1' table. You can move, or remove it, as needed.
           // DataTable dt = new DataTable();

           //dt.Columns.Add("Година");
           // dt.Columns.Add("Месец");
           // dt.Columns.Add("Ден");
           // dt.Columns.Add("Приход");
           // dt.Columns.Add("Разход");

           // string text = ControlID.Day;

           // string text1 = ControlID.Month;

           // string text2 = ControlID.Money;

            //for (int i = 1; i < 13; i++)
            //{
            //     for (int j = 1; j < 31; j++)
            //    {
            //        dt.Rows.Add("2020", i , j );
            //
            //
            //    }
            // }

           // dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string text = ControlID.Day;

            //string text1 = ControlID.Month;

            //string text2 = ControlID.Money;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            





        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SqlConnection sc = new SqlConnection("Data Source=localhost;Initial Catalog=LoginScreen;Integrated Security=True");
            //SqlCommand com = new SqlCommand();
            //com.Connection = sc;
            //sc.Open();
            //SqlDataReader read = (null);
            //com.CommandText = ("select * from Pending_Tasks");
            //read = com.ExecuteReader();
            //ControlID.Day = (read["Day"].ToString());
            //ControlID.Month = (read["Customer_Name"].ToString());
            //ControlID.Money = (read["Address_1"].ToString());

            //sc.Close();



            //String str;
            //SqlConnection myConn = new SqlConnection(SampleDatabase.mdf;Integrated Security=True);

            //str = "CREATE DATABASE MyDatabase ON PRIMARY " +
            // "(NAME = MyDatabase_Data, " +
            // "FILENAME = 'C:\\MyDatabaseData.mdf', " +
            // "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
            // "LOG ON (NAME = MyDatabase_Log, " +
            // "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
            // "SIZE = 1MB, " +
            // "MAXSIZE = 5MB, " +
            // "FILEGROWTH = 10%)";

           // SqlCommand myCommand = new SqlCommand(str, myConn);
           // try
           // {
            //    myConn.Open();
            //    myCommand.ExecuteNonQuery();
            //    MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // }
           // catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // }
            //finally
            //{
            //    if (myConn.State == ConnectionState.Open)
            //    {
             //       myConn.Close();
             //   }
            //}





        }
   
        


    
    
    
    }


}

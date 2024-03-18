using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMangaementSystem
{
    public partial class MangementUser : Form
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=PRAMEELA-GUTTUL;Initial Catalog=Inventorydb;Integrated Security=True");
        public MangementUser()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                sqlConnection.Open();

                string query = $"insert into UserTable values('{UsertextBox.Text}','{FullnametextBox.Text}','{PasswordtextBox.Text}','{TelephonetextBox.Text}')";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    //executing a query
                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
                MessageBox.Show("Data added successfully");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



        }
        private void populate()
        {
            sqlConnection.Open();
            string query = "select * from UserTable";
            dataGridInventory.Rows.Clear();
            dataGridInventory.Columns.Clear();
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                dataGridInventory.Columns.Add("username", "user");
                dataGridInventory.Columns.Add("userfullname", "fullname");
                dataGridInventory.Columns.Add("userpassword", "password");
                dataGridInventory.Columns.Add("userphone", "phone");
                while (reader.Read())
                {
                    dataGridInventory.Rows.Add(reader["Username"], reader["Ufullname"], reader["Upassword"], reader["Uphone"]);
                }


            }
            sqlConnection.Close();
        }




        //private void populate()
        //{
        //    sqlConnection.Open();
        //    string query = "select * from UserTable";
        //    using (SqlDataAdapter sqlAdaptor = new SqlDataAdapter(query, sqlConnection))
        //    {

        //        DataSet ds = new DataSet();
        //        sqlAdaptor.Fill(ds);
        //        dataGridInventory.DataSource = ds.Tables[];
        //    }
        //    sqlConnection.Close();
        //}

        private void MangementUser_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = $"delete from UserTable where Uphone ='{TelephonetextBox.Text}'";
                if (string.IsNullOrEmpty(TelephonetextBox.Text))
            {
                MessageBox.Show("Enter user phone number");
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"deleted successfully with{TelephonetextBox.Text}");
                

            }
            sqlConnection.Close();
            populate();

        }
        

        public void dataGridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = dataGridInventory.Rows[e.RowIndex];
                UsertextBox.Text = (string)data.Cells[0].Value;
                FullnametextBox.Text = (string)data.Cells[1].Value;
                PasswordtextBox.Text = (string)data.Cells[2].Value;
                TelephonetextBox.Text = (string)data.Cells[3].Value;
            }
            

            // DataGridViewCell dataGridViewCell0 = dataGridInventory.Rows[0].Cells[0];
            //UsertextBox.Text= (string)dataGridViewCell0.Value;
            // DataGridViewCell dataGridViewCell1 = dataGridInventory.Rows[0].Cells[1];
            // FullnametextBox.Text = (string)dataGridViewCell1.Value;
            // DataGridViewCell dataGridViewCell2 = dataGridInventory.Rows[0].Cells[2];
            // PasswordtextBox.Text = (string)dataGridViewCell2.Value;
            // DataGridViewCell dataGridViewCell3 = dataGridInventory.Rows[0].Cells[3];
            // TelephonetextBox.Text = (string)dataGridViewCell3.Value;

        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            
            string query = $"update  UserTable set Username='{UsertextBox.Text}' ,Ufullname='{FullnametextBox.Text}',Upassword='{PasswordtextBox.Text}',Uphone='{TelephonetextBox.Text}' where( Uphone='{TelephonetextBox.Text}'or Uphone='' ) ";
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                sqlCommand.ExecuteNonQuery();
            }
            MessageBox.Show("Updated Sucessfully");
            sqlConnection.Close();
            populate();
            

        }
    }      
}

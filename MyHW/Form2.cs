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

namespace MyHW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadComList(object sender, EventArgs e)
        {
            //表單的Load事件
            SqlConnection conn=null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                SqlCommand command = new SqlCommand("select*from Categories", conn);
                //SqlCommand command = new SqlCommand("select categoryname from categories", conn);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    //comboBox1.Items.Add(dataReader.GetString(0));
                    this.comboBox1.Items.Add(dataReader["CategoryName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ii = comboBox1.SelectedIndex + 1;
            //索引從0開始, ii要加1
            SqlConnection conn=null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                conn.Open();
                //where的值=comBox索引值+1
                SqlCommand command = new SqlCommand("select ProductName from Categories c join Products p on c.CategoryID=p.CategoryID " +
                    "where c.CategoryID =" + ii ,conn );
                SqlDataReader reader = command.ExecuteReader();
                listBox1.Items.Clear();
                while (reader.Read())
                {
                    this.listBox1.Items.Add(reader["ProductName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}

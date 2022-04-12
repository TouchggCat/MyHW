using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SQL中被'OOO'單引號包住的東西為字串,$"%{textBox3.Text}%"本身即為字串屬性，所以不用加單引號
            this.productsTableAdapter1.Test1(this.hwnWdataSet1.Products, $"%{textBox3.Text}%");
            //下面為在dataSet中用單引號'%'+@vb+'%'的方式
            //this.productsTableAdapter1.FillByanyProduct(this.hwnWdataSet1.Products,textBox3.Text);
            this.lblResult.Text = "結果:" + this.bindingSource1.Count + "筆";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.FillByUniPrice(this.hwnWdataSet1.Products, Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text));
            this.lblResult.Text = "結果:" + this.bindingSource1.Count + "筆";
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.hwnWdataSet1.Products);
            this.bindingSource1.DataSource = this.hwnWdataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.lblResult.Text = "結果:" + this.bindingSource1.Count + "筆";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.label2.Text = $"{this.bindingSource1.Position+1} / {this.bindingSource1.Count}";
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }
    }
}

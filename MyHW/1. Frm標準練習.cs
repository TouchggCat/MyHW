
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm標準練習 : Form
    {
        public Frm標準練習()
        {
            InitializeComponent();
        }


        string[] names = { "GoodMorning", "China", "IceCream", "Ready123", "\n2weekslater", "TheFastAndTheFurious9", "JohnCena" };
        private void button14_Click(object sender, EventArgs e)
        {
            int a = 0,y=0;
            string result = "";
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > a)
                {
                    a  = names[i].Length;
                    y = i;
                }
            }
            result = string.Join("  ", names);
            lblResult.Text = "int陣列ArrStr[" + result + "]" + "\n最長字串:" + names[y];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100,150, 33,55};

            int max =  scores.Max();
            MessageBox.Show("Max = " + max);

            Array.Sort(scores);
            MessageBox.Show("Max =" + scores[scores.Length - 1]);

            int min = scores.Min();
            MessageBox.Show("Min = " + min);
            MessageBox.Show("Min =" + scores[0]);
            //================================

            //Point[] points = new Point[3];
            //points[0].X = 3;
            //points[0].Y = 4;
            ////System.InvalidOperationException: '無法比較陣列中的兩個元素。'

            //Array.Sort(points);

            //================================
        }

        int MyMinScore(int[] nums)
        {
            return 10;
        }

        private void btnOddandEven_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("請輸入正確數值");
                txtInput.Focus();
            }
            else
            {
                int sum = int.Parse(txtInput.Text);
                if (sum % 2 == 0)
                {
                    lblResult.Text = sum + " 是偶數";
                }
                else
                {
                    lblResult.Text = sum + " 是奇數";
                }
            }
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            int a = 44, b = 100, c = 88;
            if(a > b && a > c)
            {
                lblResult.Text = "a = 44, b = 100, c = 88  ," + a + " 是最大的";
            }else if(b > a && b > c)
            {
                lblResult.Text = "a = 44, b = 100, c = 88  ," + b + " 是最大的";
            }
            else
            {
                lblResult.Text = "a = 44, b = 100, c = 88  ," + c + " 是最大的";
            }
        }

        private void btnNinetyNine_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            for (int i = 1;i < 10; i++)
            {
                lblResult.Text += "\n";
                for (int j = 1;j < 10; j++)
                {
                    if(i * j < 10)
                    {
                        lblResult.Text += j + "*" + i + "=" + " " + i * j + " ";
                    }
                    else
                    {
                        lblResult.Text += j + "*" + i + "=" + i * j + " ";
                    }

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(100, 2);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            foreach(int i in nums)
            {
                if (i % 2 == 0)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }
            lblResult.Text = " 33, 4, 5, 11, 222, 34 " + "\n偶數有 " + a + "\n奇數有 " + b ;
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            bool aa = int.TryParse(textBox1.Text, out int f);
            bool bb = int.TryParse(textBox2.Text, out int t);
            bool cc = int.TryParse(textBox3.Text, out int s);
            if (aa && bb && cc)
            {

                for (int i = 0; x < int.MaxValue; i++)
                {
                    x = f + i * s;
                    if (x <= t)
                    {
                        y += x;
                        lblResult.Text = f + " 到 " + t + " 相隔 " + (s - 1) + "\n加總為: " + y;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            bool aa = int.TryParse(textBox1.Text, out int f);
            bool bb = int.TryParse(textBox2.Text, out int t);
            bool cc = int.TryParse(textBox3.Text, out int s);

            if (aa && bb && cc)
            {
                int i = 0;
                while (x < int.MaxValue)
                {
                    x = f + i * s;
                    if (x <= t)
                    {
                        y += x;
                        lblResult.Text = f + " 到 " + t + " 相隔 " + (s - 1) + "\n加總為: " + y;
                    }
                    else
                    {
                        break;
                    }
                    i++;
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            bool aa = int.TryParse(textBox1.Text, out int f);
            bool bb = int.TryParse(textBox2.Text, out int t);
            bool cc = int.TryParse(textBox3.Text, out int s);

            if (aa && bb && cc)
            {
                int i = 0;
                do
                {
                    x = f + i * s;
                    if (x <= t)
                    {
                        y += x;
                        lblResult.Text = f + " 到 " + t + " 相隔 " + (s - 1) + "\n加總為: " + y;
                    }
                    else
                    {
                        break;
                    }
                    i++;
                } while (x < int.MaxValue);
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string result = "";
            int x = 0;
            for (int i = 0; i < names.Length ; i++)
            {
                if (names[i].Contains("C") || names[i].Contains("c"))
                {
                    x += 1;
                }
            }
            //使用 string.Join(",",OOO) 用逗號分隔陣列
            result = string.Join(",", names);
            lblResult.Text = "陣列: [" + result + "] \n有C及c的字串者有:" + x + "個";

        }

        private void button19_Click(object sender, EventArgs e)
        {
                var lotoNumbers = new List<int> { }; //中獎號碼
                var random = new Random();
                while (lotoNumbers.Count() <= 5)
                {
                    var number = random.Next(1, 49); //抽一個號碼
                    if (lotoNumbers.Any(x => x == number)) //如果抽中已經抽到過的號碼 重新loop
                    {
                        continue;
                    }
                    else
                    {
                        lotoNumbers.Add(number); //沒抽到過的號碼 放到lotoNumbers內
                    }
                }
                var result = string.Join(",", lotoNumbers.OrderBy(x => x)); //串接中獎號碼
            lblResult.Text=result;
            
        }

        int max(params int[] arr)
        {
            int max = arr[0];
            foreach (int i in arr)
            {
                max = i > max ? i : max;
            }
            return max;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100, 150, 33, 55 };
            lblResult.Text = "陣列 { 2, 3, 46, 33, 22, 100, 150, 33, 55 }\n的最大值是 " + max(scores);
        }
    } 
}

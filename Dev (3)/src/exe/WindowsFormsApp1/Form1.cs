using ClassLibrary1.Calculate;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void excuteButton_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            int first;
            int second;

            try
            {
                first = Convert.ToInt32(firstParam.Text);
                second = Convert.ToInt32(secondParam.Text);

                this.Textresult.Text = (CalcMode.Checked ?
                calculate.Plus(first, second) :
                calculate.Minus(first, second)).ToString();
            }
            catch
            {
                MessageBox.Show("input error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();

            //form.Show();
            MessageBox.Show("a");
        }
    }
}

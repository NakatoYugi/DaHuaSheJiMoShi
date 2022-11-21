using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Client : Form
    {
        double total = 0d;
        public Client()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashContext csuper = new CashContext(comboBox1.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csuper.GetResult(Convert.ToDouble(PriceTextBox.Text) * Convert.ToDouble(CountTextBox.Text));
            total += totalPrices;
            listBox1.Items.Add("单价：" + PriceTextBox.Text + " 数量：" + CountTextBox.Text + " " + comboBox1.SelectedItem + " 合计：" + totalPrices.ToString());
            TotalNumberLabel.Text = total.ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Typelabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "正常收费","打八折","满300返100"});
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sink
{
    public partial class SinkForm : Form
    {
        public SinkForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ввод в textBox только цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text, System.Globalization.NumberStyles.Number);
                textBox1.Text = num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text, System.Globalization.NumberStyles.Number);
                textBox1.Text = num.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректные данные", "Ошибка");
            }
        }
    }
    }

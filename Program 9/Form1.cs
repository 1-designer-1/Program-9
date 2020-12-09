using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_9
{
    public partial class Form1 : Form
    {
        Bagage[] bagages;
        public Form1()
        {
            InitializeComponent();
            bagages = new Bagage[10];
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = 10;
        }

        /* Заполнение таблицы*/
        private void button1_Click(object sender, EventArgs e)
        {
            int pos = (int)numericUpDown1.Value - 1;
            bagages[pos].CountItem = Convert.ToInt32(textBox1.Text);
            bagages[pos].Weight = Convert.ToInt32(textBox2.Text);
            dataGridView1[0, pos].Value = pos + 1;
            dataGridView1[1, pos].Value = textBox1.Text;
            dataGridView1[2, pos].Value = textBox2.Text;
            


        }

        /*Поиск по коду*/
        private void button2_Click(object sender, EventArgs e)
        {
            int pos = (int)numericUpDown2.Value;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (pos == (int)dataGridView1[0, i].Value)
                {
                    dataGridView1.Rows[i].Selected = true;
                    break;
                }
            }

        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа 9 \n" +
               "Серегин Денис\n" +
               "Задание \n" +
               "Багаж пассажира характеризуется количеством вещей и общим весом вещей. " +
               "Сведения о багаже каждого пассажира представляют собой структуру с двумя полями: одно поле целого типа (количество вещей) и одно - действительное (вес в килограммах). " +
               "Вывести результат на экран." +
               "Найти багаж по вессу. ", "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*Найти багаж по вессу*/ 
        private void Button3_Click(object sender, EventArgs e)
        {
            int pos = (int)numericUpDown3.Value;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (pos == (int)dataGridView1[2, i].Value)
                {
                    dataGridView1.Rows[i].Selected = true;//не работает
                    break;
                }
            }
        }
    }
}

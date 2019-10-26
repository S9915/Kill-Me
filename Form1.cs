using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewCell id0 = new DataGridViewTextBoxCell();
            DataGridViewCell brand0 = new DataGridViewTextBoxCell();
            DataGridViewCell image0 = new DataGridViewImageCell();
            DataGridViewRow row0 = new DataGridViewRow();
            row0.Cells.AddRange(id0, brand0, image0);
            dataGridView1.Rows.Add(row0);

            DataGridViewCell id1 = new DataGridViewTextBoxCell();
            DataGridViewCell brand1 = new DataGridViewTextBoxCell();
            DataGridViewCell image1 = new DataGridViewImageCell();
            DataGridViewRow row1 = new DataGridViewRow();
            row1.Cells.AddRange(id1, brand1, image1);
            dataGridView1.Rows.Add(row1);
        }

        private void tB_Click(object sender, EventArgs e)
        {
            MyMatrix matrix2 = new MyMatrix();
            MyMatrix matrix3;
            matrix2.Zapoln(dataGridView1);
            matrix3 = matrix2.Trans();
            matrix3.FullVisual(dataGridView3);
        }

        private void sum_Click(object sender, EventArgs e)
        {
            MyMatrix matrix1 = new MyMatrix();
            MyMatrix matrix2 = new MyMatrix();
            MyMatrix matrix3;
            matrix1.Zapoln(dataGridView1);
            matrix2.Zapoln(dataGridView2);
            matrix3 = (matrix1 + matrix2);
            matrix3.FullVisual(dataGridView3);
        }

        private void raz_Click(object sender, EventArgs e)
        {
            MyMatrix matrix1 = new MyMatrix();
            MyMatrix matrix2 = new MyMatrix();
            MyMatrix matrix3;
            matrix1.Zapoln(dataGridView1);
            matrix2.Zapoln(dataGridView2);
            matrix3 = (matrix1 - matrix2);
            matrix3.FullVisual(dataGridView3);
        }

        private void TA_Click(object sender, EventArgs e)
        {
            MyMatrix matrix1 = new MyMatrix();
            MyMatrix matrix3;
            matrix1.Zapoln(dataGridView1);
            matrix3 = matrix1.Trans();
            matrix3.FullVisual(dataGridView3);
        }

        private void um_Click(object sender, EventArgs e)
        {
            MyMatrix matrix1 = new MyMatrix();
            MyMatrix matrix2 = new MyMatrix();
            MyMatrix matrix3;
            matrix1.Zapoln(dataGridView1);
            matrix2.Zapoln(dataGridView2);
            matrix3 = (matrix1 * matrix2);
            matrix3.FullVisual(dataGridView3);
        }

        private void detA_Click(object sender, EventArgs e)
        {
            MyMatrix matrix1 = new MyMatrix();
            matrix1.Zapoln(dataGridView1);
            textBox1.Text = matrix1.determinantA(matrix1).ToString();
        }

        private void detB_Click(object sender, EventArgs e)
        {
            MyMatrix matrix2 = new MyMatrix();
            matrix2.Zapoln(dataGridView1);
            textBox2.Text = matrix2.determinantB(matrix2).ToString();
        }
    }
}

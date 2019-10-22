using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pain
{
    public partial class Form1 : Form
    {
    public Form1()
        {
            InitializeComponent();
        }

        protected void Build_matrix_Click_1(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2(int.Parse(matrixsize.Text));
            fm2.Show();
        }
    }
}

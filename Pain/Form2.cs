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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        internal Form2(int textBoxesCount)
        {
            InitializeComponent();
            TextBox[] textBoxes = new TextBox[textBoxesCount];
            int counter = 0;
            int range = 0;
            for (int i = 0; i < textBoxesCount; i++)
            {
                for (int j = 0; j < textBoxesCount; j++)
                {
                    textBoxes[i] = new TextBox();
                    textBoxes[i].Top = counter * 30;
                    textBoxes[i].Width = 50;
                    this.Controls.Add(textBoxes[i]);
                    textBoxes[i].Left = range *60;
                    range += 1;
                }
                counter++;
                range = 0;
            }
        }

        private void determinant_MouseClick(object sender, MouseEventArgs e)
        {
            CalculateDeterminant();
            int i = Convert.ToInt32(textBox1.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstRowNum.Value = 3;
            firstColumnNum.Value = 3;
            secondRowNum.Value = 3;
            secondColumnNum.Value = 3;
            _first = new double[3, 3];
            _second = new double[3, 3];
            ResizeArray(ref _first, 3, 3);
            PutArrayToDataGridView(_first, firstDgv);
            ResizeArray(ref _second, 3, 3);
            PutArrayToDataGridView(_second, secondDgv);
        }

        private double[,] _first, _second;

        private void secondRowsNum_ValueChanged(object sender, EventArgs e)
        {
            ResizeArray(ref _second, (int)secondRowNum.Value, (int)secondColumnNum.Value);
            PutArrayToDataGridView(_second, secondDgv);
        }

        private void secondColumnsNum_ValueChanged(object sender, EventArgs e)
        {
            ResizeArray(ref _second, (int)secondRowNum.Value, (int)secondColumnNum.Value);
            PutArrayToDataGridView(_second, secondDgv);
        }

        private void firstColumnNum_ValueChanged(object sender, EventArgs e)
        {
            ResizeArray(ref _first, (int)firstRowNum.Value, (int)firstColumnNum.Value);
            PutArrayToDataGridView(_first, firstDgv);
        }

        private void firstRowsNum_ValueChanged(object sender, EventArgs e)
        {
            ResizeArray(ref _first, (int)firstRowNum.Value, (int)firstColumnNum.Value);
            PutArrayToDataGridView(_first, firstDgv);
        }

        private void firstDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _first[e.RowIndex, e.ColumnIndex] = double.Parse(firstDgv[e.ColumnIndex, e.RowIndex].Value.ToString());

        }

        private void secondDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _second[e.RowIndex, e.ColumnIndex] = double.Parse(secondDgv[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private static void ResizeArray(ref double[,] ar, int rows, int columns)
        {
            if (ar == null)
            {
                ar = new double[rows, columns];
                return;
            }
            var arClone = ar.Clone() as double[,];
            var n = rows < ar.GetLength(0) ? rows : ar.GetLength(0);
            var m = columns < ar.GetLength(1) ? columns : ar.GetLength(1);
            ar = new double[rows, columns];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ar[i, j] = arClone[i, j];
                }
            }
        }

        private void PutArrayToDataGridView(double[,] ar, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.ColumnCount = ar.GetLength(1);
            dgv.RowCount = ar.GetLength(0);
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                
                    dgv[j, i].Value = Math.Round(ar[i, j], 3);
                }
            }
            evaluateButton.Enabled = firstColumnNum.Value.Equals(secondRowNum.Value);
            detA.Enabled = firstColumnNum.Value.Equals(firstRowNum.Value);
            detB.Enabled = secondColumnNum.Value.Equals(secondRowNum.Value);
            minusButton.Enabled = (firstRowNum.Value.Equals(secondRowNum.Value) && (firstColumnNum.Value.Equals(secondColumnNum.Value)));
            summButton.Enabled = (firstRowNum.Value.Equals(secondRowNum.Value) && (firstColumnNum.Value.Equals(secondColumnNum.Value)));
        }

        private void summButton_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(Summary(_first, _second), resultDgv);
        }

        private double[,] Summary(double[,] ar1, double[,] ar2)
        {
            MyMatrix matrix1 = new MyMatrix(ar1.GetLength(1), ar1.GetLength(0));
            MyMatrix matrix2 = new MyMatrix(ar2.GetLength(1), ar2.GetLength(0));
            MyMatrix matrix3;
            matrix1.Zapoln(firstDgv);
            matrix2.Zapoln(secondDgv);
            matrix3 = (matrix1 + matrix2);
            return matrix3.Output(ar2.GetLength(1), ar2.GetLength(0));
        }

        private void evaluateButton_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(Multiply(_first, _second), resultDgv);
        }

        private double[,] Multiply(double[,] ar1, double[,] ar2)
        {
            MyMatrix matrix1 = new MyMatrix(ar1.GetLength(1), ar1.GetLength(0));
            MyMatrix matrix2 = new MyMatrix(ar2.GetLength(1), ar2.GetLength(0));
            MyMatrix matrix3;
            matrix1.Zapoln(firstDgv);
            matrix2.Zapoln(secondDgv);
            matrix3 = (matrix1 * matrix2);
            return matrix3.Output(ar1.GetLength(0), ar2.GetLength(1));
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(Minus(_first, _second), resultDgv);
        }

        private double[,] Minus(double[,] ar1, double[,] ar2)
        {
            MyMatrix matrix1 = new MyMatrix(ar1.GetLength(1), ar1.GetLength(0));
            MyMatrix matrix2 = new MyMatrix(ar2.GetLength(1), ar2.GetLength(0));
            MyMatrix matrix3;
            matrix1.Zapoln(firstDgv);
            matrix2.Zapoln(secondDgv);
            matrix3 = (matrix1 - matrix2);
            return matrix3.Output(ar2.GetLength(1), ar2.GetLength(0));
        }

        private void transposeAButton_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(TransA(_first), firstDgv);
        }

        private double[,] TransA(double[,] ar1)
        {
            MyMatrix matrix1 = new MyMatrix(ar1.GetLength(1), ar1.GetLength(0));
            matrix1.Zapoln(firstDgv);
            matrix1.Trans();
            var d = firstColumnNum.Value;
            firstColumnNum.Value = firstRowNum.Value;
            firstRowNum.Value = d;
            return matrix1.Output(ar1.GetLength(1), ar1.GetLength(0));
        }

        private void transposeBButton_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(TransB(_second), secondDgv);
        }

        private double[,] TransB(double[,] ar2)
        {
            MyMatrix matrix2 = new MyMatrix(ar2.GetLength(1), ar2.GetLength(0));
            matrix2.Zapoln(secondDgv);
            matrix2.Trans();
            var t = secondColumnNum.Value;
            secondColumnNum.Value = secondRowNum.Value;
            secondRowNum.Value = t;
            return matrix2.Output(ar2.GetLength(1), ar2.GetLength(0));
        }

        private void detB_Click(object sender, EventArgs e)
        {
            DB(_second);
        }

        private void DB(double[,] ar2)
        {
            MyMatrix matrix2 = new MyMatrix(ar2.GetLength(1), ar2.GetLength(0));
            matrix2.Zapoln(secondDgv);
            textBox2.Text = Convert.ToString(matrix2.Determinant(matrix2));
        }

        private void detA_Click(object sender, EventArgs e)
        {
            DA(_first);
        }

        private void DA(double[,] ar1)
        {
            MyMatrix matrix1 = new MyMatrix(ar1.GetLength(1), ar1.GetLength(0));
            matrix1.Zapoln(firstDgv);
            textBox1.Text = Convert.ToString(matrix1.Determinant(matrix1));
        }

        private void mA_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(MultA(_first), firstDgv);
        }

        private double[,] MultA(double[,] ar1)
        {
            MyMatrix matrix1 = new MyMatrix(ar1.GetLength(1), ar1.GetLength(0));
            matrix1.Zapoln(firstDgv);
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                int num = Convert.ToInt32(textBox3.Text);
                return matrix1.Multiplayer(matrix1, num);
            }
            else
                return matrix1.Multiplayer(matrix1, 1);
 
        }

        private void mB_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(MultB(_second), secondDgv);
        }

        private double[,] MultB(double[,] ar2)
        {
            MyMatrix matrix2 = new MyMatrix(ar2.GetLength(1), ar2.GetLength(0));
            matrix2.Zapoln(secondDgv);
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                int num = Convert.ToInt32(textBox4.Text);
                return matrix2.Multiplayer(matrix2, num);
            }
            else
                return matrix2.Multiplayer(matrix2, 1);
        }

        private void inverseA_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(InverseA(_first), firstDgv);
        }

        private double[,] InverseA(double[,] ar1)
        {
            MyMatrix matrix1 = new MyMatrix(ar1.GetLength(1), ar1.GetLength(0));
            matrix1.Zapoln(firstDgv);
            return matrix1.Inverse(matrix1);
        }

        private void inverseB_Click(object sender, EventArgs e)
        {
            PutArrayToDataGridView(InverseB(_second), secondDgv);
        }

        private void rangA_Click(object sender, EventArgs e)
        {
            rankA(_first);
        }

        private void rankA(double[,] ar1)
        {
            MyMatrix matrix1 = new MyMatrix(ar1.GetLength(1), ar1.GetLength(0));
            matrix1.Zapoln(firstDgv);
            textBox5.Text = Convert.ToString(matrix1.Rank(matrix1));
        }

        private void rangB_Click(object sender, EventArgs e)
        {
            rankB(_second);
        }

        private void rankB(double[,] ar2)
        {
            MyMatrix matrix2 = new MyMatrix(ar2.GetLength(1), ar2.GetLength(0));
            matrix2.Zapoln(secondDgv);
            textBox6.Text = Convert.ToString(matrix2.Rank(matrix2));
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox3.Text.Length >= 1)
            {
                if (textBox3.Text.Contains("0"))
                {
                    if (e.KeyChar == (char)Keys.Back)
                        return;
                    else
                        e.Handled = true;
                }
                else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox4.Text.Length >= 1)
            {
                if (textBox4.Text.Contains("0"))
                {
                    if (e.KeyChar == (char)Keys.Back) 
                        return; 
                    else 
                        e.Handled = true; 
                }
                else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) 
                    e.Handled = true;
            }
        }

        private void firstDgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Cell_KeyPress);
            if (firstDgv.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Cell_KeyPress);
                }
            }

        }

        private void Cell_KeyPress(object Sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsNumber(e.KeyChar) && (e.KeyChar != '-') &&(e.KeyChar != ',')) && number != 8)
                e.Handled = true;
            if (e.KeyChar == ',' && (Sender as TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
            if (e.KeyChar == '-' && (Sender as TextBox).Text.IndexOf('-') > -1 && (!Char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void secondDgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Cell_KeyPress);
        }

        private double[,] InverseB(double[,] ar2)
        {
            MyMatrix matrix2 = new MyMatrix(ar2.GetLength(1), ar2.GetLength(0));
            matrix2.Zapoln(secondDgv);
            return matrix2.Inverse(matrix2);
        }
    }
}

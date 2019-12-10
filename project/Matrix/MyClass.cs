using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    class MyMatrix
    {
        int V , G;
        double[,] a = new double[20, 20];

        public MyMatrix(int v, int g)
        {
            this.V = v;
            this.G = g;
        }

        public MyMatrix()
        {

        }

        //заполнение
        public void Zapoln(DataGridView grid)
        {
            if (V < G)
            {
                for (int i = 0; i < V++; i++)
                {
                    for (int j = 0; j < G--; j++)
                        a[i, j] = Convert.ToDouble(grid.Rows[j].Cells[i].Value);
                }
            }
               
            if (V > G)
            {
                for (int i = 0; i < V--; i++)
                {
                    for (int j = 0; j < G++; j++)
                        a[i, j] = Convert.ToDouble(grid.Rows[j].Cells[i].Value);
                }
            }

            else
            {
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < G; j++)
                        a[i, j] = Convert.ToDouble(grid.Rows[j].Cells[i].Value);
                }
            }   
        }

        //сложение
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            MyMatrix NewMatrix = new MyMatrix();
            for (int i = 0; i < matrix1.V; i++)
            {
                for (int j = 0; j < matrix1.G; j++)
                {
                    NewMatrix.a[j, i] = matrix1.a[i, j] + matrix2.a[i, j];
                }
            }
            return NewMatrix;
        }

        //вычитание
        public static MyMatrix operator -(MyMatrix matrix1, MyMatrix matrix2)
        {
            MyMatrix NewMatrix = new MyMatrix();
            for (int i = 0; i < matrix1.V; i++)
            {
                for (int j = 0; j < matrix1.G; j++)
                {
                    NewMatrix.a[j, i] = matrix1.a[i, j] - matrix2.a[i, j];
                }
            }
            return NewMatrix;
        }

        //умножение
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            MyMatrix NewMatrix = new MyMatrix();
            int n = matrix1.V;
            int m = matrix1.G;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < matrix2.G; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        NewMatrix.a[j, i] += (matrix1.a[i, k] * matrix2.a[k, j]);
                    }
                }
            }
            return NewMatrix;
        }

        //транспонирование
        public MyMatrix Trans()
        {
            MyMatrix NewMatrix = new MyMatrix();
            for (int i = 0; i < NewMatrix.V; i++)
            {
                for (int j = 0; j < NewMatrix.G; j++)
                {
                    NewMatrix.a[i, j] = a[j, i];
                }
            }
            return NewMatrix;
        }

        //возврат
        public double [,] Output(int V, int G)
        {
            double[,] chlen = new double[V,G];
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < G; j++)
                {
                    chlen[i, j] = a[i, j];
                }
            }
            return chlen;
        }

        public double Determinant(MyMatrix input)
        {
            if (input.V > 2)
            {
                double value = 0;
                for (int j = 0; j < input.V; j++)
                {
                    MyMatrix Temp = CreateSmallerMatrix(input, 0, j);
                    value = value + input.a[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                }
                return value;
            }

            else if (input.V == 2)
            {
                return ((input.a[0, 0] * input.a[1, 1]) - (input.a[1, 0] * input.a[0, 1]));
            }

            else 
                return (input.a[0, 0]);
        }

        private static MyMatrix CreateSmallerMatrix(MyMatrix input, int i, int j)
        {
            MyMatrix output;
            output = new MyMatrix(input.V - 1, input.G - 1);
            int x = 0, y = 0;
            for (int m = 0; m < input.V; m++, x++)
            {
                if (m != i)
                {
                    y = 0;
                    for (int n = 0; n < input.V; n++)
                    {
                        if (n != j)
                        {
                            output.a[x, y] = input.a[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }

        private static int SignOfElement(int i, int j)
        {
            int sign = ((i + j) % 2 == 0) ? 1 : -1;
            return sign;
        }

        public double[,] Multiplayer(MyMatrix temp, double n)
        {
            double[,] Mat = new double[temp.G, temp.V];
            for (int i = 0; i < temp.G; i++)
            {
                for (int j = 0; j < temp.V; j++)
                {
                    Mat[j, i] = temp.a[i, j] * n;
                }
            }
            return Mat;
        }

        public MyMatrix Minor(MyMatrix input, int row, int col)
        {
            MyMatrix mm = new MyMatrix(input.V - 1, input.G - 1);
            int ii = 0;
            int jj = 0;
            for (int r = 0; r < input.V; r++)
            {
                if (r == row) continue;
                jj = 0;
                for (int c = 0; c < input.G; c++)
                {
                    if (c == col) continue;
                    mm.a[ii, jj] = input.a[r, c];
                    jj++;
                }
                ii++;
            }
            return mm;
        }

        public double [,] Inverse(MyMatrix m)
        {
            MyMatrix ma = new MyMatrix(m.G, m.V);
            for (int r = 0; r < m.V; r++)
            {
                for (int c = 0; c < m.G; c++)
                {
                    ma.a[r, c] = Math.Pow(-1, r + c) * Determinant(Minor(m, r, c));
                }
            }
            ma.Trans();

            double[,] NewMatrix = new double[m.G, m.V];
            for (int i = 0; i < m.V; i++)
            {
                for (int j = 0; j < m.G; j++)
                {
                    NewMatrix[i, j] = (ma.a[i,j] / Determinant(m));
                }
            }
            return NewMatrix;
        }
    }
}
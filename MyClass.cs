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
        int[,] a = new int[3, 3];

        //передача значений
        public void Set(int i, int j, int znach)
        {
            a[i, j] = znach;
        }

        //сложение
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            MyMatrix NewMatrix = new MyMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    NewMatrix.a[i, j] = matrix1.a[i, j] + matrix2.a[i, j];
                }
            }
            return NewMatrix;
        }

        //вывод матрицы
        public string Visual(int i, int j)
        {
            return a[i, j].ToString();
        }

        //вывод всей и сразу.Хд
        public DataGridView FullVisual(DataGridView dt)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dt.Rows[j].Cells[i].Value = a[i, j];
                }
            }
            return dt;
        }
        //вычитание
        public static MyMatrix operator -(MyMatrix matrix1, MyMatrix matrix2)
        {
            MyMatrix NewMatrix = new MyMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    NewMatrix.a[i, j] = matrix1.a[i, j] - matrix2.a[i, j];
                }
            }
            return NewMatrix;
        }

        //транспонирование
        public MyMatrix Trans()
        {
            MyMatrix NewMatrix = new MyMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    NewMatrix.a[i, j] = a[j, i];
                }
            }
            return NewMatrix;
        }

        //умножение
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            MyMatrix NewMatrix = new MyMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    //int a = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        //a += matrix1.a[j,k] * matrix2.a[i, j];
                        NewMatrix.a[i, k] += matrix1.a[j, k] * matrix2.a[i, j];
                    }
                    //NewMatrix.a[i, k] = a;
                }
            }
            return NewMatrix;
        }

        public int determinantA(MyMatrix matrix1)
        {
            int a = matrix1.a[2,2] * matrix1.a[3, 3] - matrix1.a[3, 2] * matrix1.a[2, 3];
            int b = matrix1.a[2, 1] * matrix1.a[3, 3] - matrix1.a[3, 1] * matrix1.a[2, 3];
            int c = matrix1.a[2, 1] * matrix1.a[3, 2] - matrix1.a[3, 1] * matrix1.a[2, 2];
            int det = matrix1.a[1, 1] * a - matrix1.a[1, 2] * b + matrix1.a[1, 3] * c;
            return det;
        }

        public int determinantB(MyMatrix matrix2)
        {
            int a = matrix2.a[2, 2] * matrix2.a[3, 3] - matrix2.a[3, 2] * matrix2.a[2, 3];
            int b = matrix2.a[2, 1] * matrix2.a[3, 3] - matrix2.a[3, 1] * matrix2.a[2, 3];
            int c = matrix2.a[2, 1] * matrix2.a[3, 2] - matrix2.a[3, 1] * matrix2.a[2, 2];
            int det = matrix2.a[1, 1] * a - matrix2.a[1, 2] * b + matrix2.a[1, 3] * c;
            return det;
        }

        //заполнение
        public void Zapoln(DataGridView grid)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(grid.Rows[j].Cells[i].Value);
                }
            }
        }
    }
}

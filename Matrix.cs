using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    public class Matrix<T> where T : struct
    {
        private T[,] _matrix;
        private const int _DefaultSize = 8;
        private int _row;
        private int _col;

        public int Row
        {
            get
            {
                _row = _matrix.GetLength(0);
                return _row;
            }
            private set { _row = value; }
        }

        public int Col
        {
            get
            {
                _col = _matrix.GetLength(0);
                return _col;
            }
            private set { _col = value; }
        }

        public Matrix()
        {
            _matrix = new T[_DefaultSize, _DefaultSize];
        }

        public Matrix(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentOutOfRangeException("Negative row or col value");
            }
            _matrix = new T[row, col];
        }

        public Matrix(T[,] matrix)
        {
            _matrix = matrix;
            Row = matrix.GetLength(0);
            Col = matrix.GetLength(1);
        }

        public int GetLength(int dimension)
        {
            if (dimension < 0 || dimension > 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            int result = _matrix.GetLength(dimension);
            return result;
        }

        public T this[int row, int col]
        {
            get
            {
                return _matrix[row, col];
            }
            set
            {
                if ((row < 0 || col < 0) || row >= _matrix.GetLength(0) || col >= _matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("Incorrect row or col value");
                }
                _matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row == second.Row && first.Col == second.Col)
            {
                Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Col; j++)
                    {
                        tempArr[i, j] = (dynamic)first[i, j] + second[i, j];
                    }
                }
                return tempArr;
            }
            else throw new Exception();
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row == second.Row && first.Col == second.Col)
            {
                Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Col; j++)
                    {
                        tempArr[i, j] = (dynamic)first[i, j] - second[i, j];
                    }
                }
                return tempArr;
            }
            else throw new Exception();
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Row == second.Row && first.Col == second.Col)
            {
                Matrix<T> tempArr = new Matrix<T>(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                {
                    for (int j = 0; j < first.Col; j++)
                    {
                        for (int k = 0; k < first.Col; k++)
                        {
                            tempArr[i, j] += (dynamic)first[i, j] * second[i, j];
                        }
                    }
                }
                return tempArr;
            }
            else throw new Exception();
        }
    }
}

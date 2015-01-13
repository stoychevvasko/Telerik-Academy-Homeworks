namespace _08.MatrixOfT
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class GenericMatrix<T>
        where T : struct, IComparable, IComparable<T>, IConvertible
    {
        // fields

        private T[,] data;
        private int width;
        private int height;

        // properties

        //public T[,] Data
        //{            
        //    get { return (T[,])this.data.Clone(); }
        //    private set { this.data = value; }
        //}

        public int Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        // constructors

        public GenericMatrix()
            : this(3, 3)
        {
        }

        public GenericMatrix(int w, int h)
        {
            this.data = new T[h, w];
            this.Width = w;
            this.Height = h;
        }

        // indexer for <Problem 09>        

        public T this[int row, int col]
        {
            get { return this.data[row, col]; }
            set { this.data[row, col] = value; }
        }

        // operator overloads for <Problem 10>

        public void Print()
        {
            for (int row = 0; row < this.Height; row++)
            {
                for (int col = 0; col < this.Width; col++)
                {
                    Console.Write("{0, 9:F} ", this[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static GenericMatrix<T> operator +(GenericMatrix<T> matrix1, GenericMatrix<T> matrix2)
        {
            GenericMatrix<T> result = new GenericMatrix<T>(matrix1.Height, matrix1.Width);

            if (matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width)
            {
                throw new System.InvalidOperationException("Cannot add matrices of incompatible dimensions!");
            }

            for (int row = 0; row < result.Height; row++)
            {
                for (int col = 0; col < result.Width; col++)
                {
                    result[row, col] = (T)((dynamic)matrix1[row, col] + (dynamic)matrix2[row, col]);
                }
            }

            return result;
        }

        public static GenericMatrix<T> operator -(GenericMatrix<T> matrix1, GenericMatrix<T> matrix2)
        {
            GenericMatrix<T> result = new GenericMatrix<T>(matrix1.Height, matrix1.Width);

            if (matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width)
            {
                throw new System.InvalidOperationException("Cannot subtract matrices of incompatible dimensionss!");
            }

            for (int row = 0; row < result.Height; row++)
            {
                for (int col = 0; col < result.Width; col++)
                {
                    result[row, col] = (T)((dynamic)matrix1[row, col] - (dynamic)matrix2[row, col]);
                }
            }

            return result;
        }

        public static GenericMatrix<T> operator *(GenericMatrix<T> matrix1, GenericMatrix<T> matrix2)
        {
            if (((matrix1.Height != matrix2.Width) || (matrix1.Width != matrix2.Height)))
            {
                throw new System.InvalidOperationException("Cannot multiply matrices of incompatible dimensions!");
            }

            int resultHeight = (matrix1.Height <= matrix2.Height) ? matrix1.Height : matrix2.Height;
            int resultWidth = (matrix1.Width <= matrix2.Width) ? matrix1.Width : matrix2.Width;
            dynamic resultElement = 0;

            GenericMatrix<T> result = new GenericMatrix<T>(resultHeight, resultWidth);

            for (int resRow = 0; resRow < resultHeight; resRow++)
            {
                for (int resCol = 0; resCol < resultWidth; resCol++)
                {
                    resultElement = 0;

                    for (int i = 0; i < matrix1.Width; i++)
                    {
                        resultElement += (dynamic)matrix1[resRow, i] * (dynamic)matrix2[i, resCol];
                    }

                    result[resRow, resCol] = resultElement;
                }
            }

            return result;
        }

        public static bool operator true(GenericMatrix<T> matrix)
        {
            if (matrix.Height <= 0 || matrix.Width <= 0)
            {
                return false;
            }

            for (int row = 0; row < matrix.Height; row++)
            {
                for (int col = 0; col < matrix.Width; col++)
                {
                    int zero = 0;
                    if (matrix[row, col].CompareTo((T)Convert.ChangeType(zero, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(GenericMatrix<T> matrix)
        {
            for (int row = 0; row < matrix.Height; row++)
            {
                for (int col = 0; col < matrix.Width; col++)
                {
                    if (matrix[row, col].CompareTo(new T()) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}

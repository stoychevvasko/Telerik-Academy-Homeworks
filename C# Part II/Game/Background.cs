using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderProject
{
    class Background
    {
        private char[,] matrix;

        // constructor 
        public Background(int sizeRows, int sizeCols)
        {
            this.matrix = new char[sizeRows, sizeCols];
        }

        // property to get how many rows are there
        public int RowsLength
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        // property to get how many cols are there
        public int ColsLength
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        // redefining what the square brackets mean --> []
        public char this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        public void Draw()
        {
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < this.ColsLength; col++)
                {
                    Console.Write(this[row, col]);
                }
            }
        }
    }
}

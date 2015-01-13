namespace _05.DefineClassBitArray64
{
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64
        : IEnumerable<int>
    {
        #region fields

        private ulong number;

        #endregion

        #region properties

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int[] Bits
        {
            get { return this.GetBits(); }
        }

        #endregion

        #region constructors

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        #endregion

        #region methods

        private int[] GetBits()
        {
            ulong value = this.Number;

            int[] bits = new int[64];
            int counter = 63;

            while (value != 0)
            {
                bits[counter] = (int)value % 2;
                value /= 2;
                counter--;
            }

            while (counter != 0)
            {
                bits[counter] = 0;
                counter--;
            }            

            return bits;
        }

        #endregion

        #region IENumerable<int> implementation

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.GetBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        #endregion

        #region methods

        public bool Equals(BitArray64 value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }
            if (ReferenceEquals(this, value))
            {
                return true;
            }

            return this.number == value.number;
        }

        public override bool Equals(object obj)
        {
            BitArray64 temp = obj as BitArray64;
            if (temp == null)
            {
                return false;
            }
            else
            {
                return this.Equals(temp);
            }
        }

        public override int GetHashCode()
        {
            {
                return this.Number.GetHashCode();
            }
        }

        #endregion

        #region operator overrides

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        #endregion

        #region indexers

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index <= 63)
                {
                    return this.Bits[index];
                }
                else
                {
                    throw new System.IndexOutOfRangeException("Index out of range! Valid positions are in the range [0, 63].");
                }
            }
        }

        #endregion
    }
}

namespace _01.SubStringBuilder
{
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder source, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            if (source.Length < 1 || index < 0 || index > source.Length - 1 || length < 1)
            {
                return result;
            }

            for (int i = index; i < index + length + 1; i++)
            {
                result.Append(source[i]);
                
                if (i >= source.Length - 1)
                {
                    break;          
                }
            }

            return result;
        }
    }
}

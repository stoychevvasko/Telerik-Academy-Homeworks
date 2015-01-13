// <copyright file="StringProcessor.cs" company="telerikacademy.com">
// telerikacademy.com For educational purposes only.</copyright>
// <author>My name is Legion: for we are many.</author>

namespace CohesionAndCoupling
{
    using System;
    using System.Text;

    /// <summary>A static class that contains string processing functionality.</summary>
    public static class StringProcessor
    {
        /// <summary>Extracts the file extension from a full file name.</summary>
        /// <param name="fileName">full file name</param>
        /// <returns>string value containing file extension</returns>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Cannot extract file extension. File name invalid!");
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>Returns a full file name with the file extension removed.</summary>
        /// <param name="fileName">full file name</param>
        /// <returns>string value containing file name with file extension removed</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Cannot trim file extension. File name invalid!");
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}

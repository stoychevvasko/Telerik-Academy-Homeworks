// <copyright file="CommandReader.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve.Classes.CommandUtilities
{
    using System;
    using System.Text;

    /// <summary>Contains ready-made functionality to perform reading from console input or file.</summary>
    public class CommandReader
    {
        /// <summary>Reads a command from an input string.</summary>
        /// <param name="command">source command as string input value</param>
        public static void ReadCommand(string command)
        {
            var commands = command.Split(' ');
            switch (commands[0])
            {
                case "complete":
                    {
                    }

                    break;
                default:
                    {
                    }

                    break;
            }
        }
    }
}

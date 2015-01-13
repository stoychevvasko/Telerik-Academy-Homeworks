// <copyright file="CommandUtility.cs" company="sworn to secrecy">*</copyright>
// <author>My name is Legion: for we are many.</author>

namespace TrackAndAchieve.Classes.CommandUtilities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>Provides command issuance, transmission and execution functionality.</summary>
    public class CommandUtility
    {
        /// <summary>Holds logs of command handling.</summary>
        private StringBuilder commandLog;
        
        /// <summary>Initializes a new instance of the CommandUtility class.</summary>
        protected CommandUtility()
        {
            this.commandLog = new StringBuilder();
        }

        /// <summary>Gets a value for all log entries.</summary>
        public string Log
        {
            get
            {
                return this.commandLog.ToString();
            }

            private set
            {
                if (value == null || value.Length == 0)
                {
                    this.commandLog = new StringBuilder();
                }

                this.commandLog = new StringBuilder(value);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL.Operations
{
    /// <summary>
    /// Class for parsing sql-scripts
    /// </summary>
    public class Parser
    {
        public Parser()
        {

        }

        /// <summary>
        /// Method to parse sql-script from file
        /// </summary>
        /// <param name="path">path to sql file</param>
        /// <returns>query in string</returns>
        public string ParseScript(string path)
        {
            string query = string.Empty;
            if (File.Exists(path))
            {
                using (StreamReader fs = new StreamReader(path))
                {
                    query = fs.ReadToEnd();
                }
            }
            return query; 
        }
    }
}

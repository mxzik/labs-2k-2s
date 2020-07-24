using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Header
    {
        private static Header instance;

        private Header()
        { }

        public string Name { get; set; } = "H1";

        public static Header getInstance()
        {
            if (instance == null)
                instance = new Header();
            return instance;
        }
    }
}

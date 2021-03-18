using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Memory
    {
        public int Address { get; set; }

        public string AddressHex { get; set; }

        public string Value { get; set; }

        public int ValueInt { get; set; }

        public bool isCommand { get; set; }
    }
}

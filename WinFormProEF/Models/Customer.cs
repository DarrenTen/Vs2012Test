using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProEF.Models
{
    class Customers
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string FirstAddress { get; set; }
        public string SecondAddress { get; set; }
        public string City { get; set; }
        public string State_Province { get; set; }
        public string Region_Country { get; set; }
        public int Age { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeFirstinWin.Model
{
    class Admins
    {
        [Key]
        public Guid AdminID { get; set; }
        public string Name { get; set; }
        public int dept{get;set;}
        public DateTime? Birthday { get; set; }
    }
}

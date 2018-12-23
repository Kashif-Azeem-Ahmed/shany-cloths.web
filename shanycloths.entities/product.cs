using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shanycloths.entities
{
    public class product : baseclass
    {
        public Category Category { get; set; }
        public decimal price { get; set; }   
    }
}

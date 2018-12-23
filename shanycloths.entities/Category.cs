using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shanycloths.entities
{
    public class Category : baseclass
    {
        public List<product> products { get; set; }
    }
}

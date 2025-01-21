using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

//field-variable-property

/* field *
 * 
 * int x;
 */

/* property *
 * 
 * public int y { get; set; }
 */

/* variable
 * 
 * void test()
 * {
 *      int z;
 * }
 */
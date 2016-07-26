using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTry.DTO.Product
{
    public class ProductAddDTO
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public short ProductStock { get; set; }
        public int iCategoryID { get; set; }
        public int iSupplierID { get; set; }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascon
{
   public class ExportEntity
    {
        public string product { get; set; }

        public List<ExportEntity> childProduct { get; set; }
        public ExportEntity(string product, List<ExportEntity> childProduct)
        {
            this.product = product;
            this.childProduct = childProduct;
        }
    }
}

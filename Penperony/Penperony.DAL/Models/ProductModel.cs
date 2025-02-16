using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penperony.DAL.Models
{
    internal class ProductModel
    {
        internal int Id { get; set; }
        public string Name { get; set; }
        public List Triggers { get; set; }

    }
}

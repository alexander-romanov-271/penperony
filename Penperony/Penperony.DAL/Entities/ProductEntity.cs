using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penperony.DAL.Entities
{
    public class ProductEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<TriggerEntity> Triggers { get; set; } = [];

    }
}

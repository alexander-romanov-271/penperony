using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penperony.DAL.Models
{
    internal class Seller
    {
        internal int Id { get; set; }
        internal string Name { get; set; } = "set default through config";
        internal string Description { get; set; } = "set dafeult through config";
        internal List<Trigger> Trigger = new List<Trigger>();
    }
}

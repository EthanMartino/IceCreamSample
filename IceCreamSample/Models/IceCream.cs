using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamSample
{
    public class IceCream
    {
        /// <summary>
        /// The flavor of the Ice Cream
        /// </summary>
        public string Flavor { get; set; }

        /// <summary>
        /// The number of scoops of Ice Cream
        /// </summary>
        public byte Scoops { get; set; }

        /// <summary>
        /// The type of container for the Ice Cream (Cone or Cup)
        /// </summary>
        public string Container { get; set; }
    }
}

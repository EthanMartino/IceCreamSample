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
        string Flavor { get; set; }

        /// <summary>
        /// The number of scoops of Ice Cream
        /// </summary>
        byte Scoops { get; set; }

        /// <summary>
        /// The type of container for the Ice Cream (Cone or Cup)
        /// </summary>
        string Container { get; set; }
    }
}

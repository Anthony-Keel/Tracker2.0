using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker2._0.Domain
{
    public class Trip

    {
        public float MileageDriven { get; set; }
        public float GallonsUsed { get; set; }

        public float CalculateMilesPerGallon()
        {
            return (MileageDriven / GallonsUsed);
        }
    }
}

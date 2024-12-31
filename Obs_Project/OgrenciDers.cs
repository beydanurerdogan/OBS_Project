using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obs_Project
{
    internal class OgrenciDers
    {
        public int DersID { get; set; }

        public int OgrenciID { get; set; }

        public virtual Ogrenci Ogrenciler { get; set; }
        public virtual Dersler Dersler { get; set; }
    }
}

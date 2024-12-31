using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obs_Project
{
    internal class Siniflar
    {
        [Key]
        public int SinifID { get; set; }

        [Column(TypeName = "varchar")
            , MaxLength(30)
            , Required]
        public string SinifAd { get; set; }

        [Column(TypeName = "varchar"), MaxLength(15), Required]
        public string Kontenjan { get; set; }

        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}

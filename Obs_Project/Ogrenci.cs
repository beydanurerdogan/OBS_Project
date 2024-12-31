using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obs_Project
{
    internal class Ogrenci
    {
        [Key]
        public int OgrenciID { get; set; }
        [Column(TypeName = "varchar")
            , MaxLength(50)
            , Required]
        public string Ad { get; set; }

        [Column(TypeName = "varchar")
            , MaxLength(50)
            , Required]
        public string Soyad { get; set; }

        [Required]
        public string Numara { get; set; }

        public int SinifID { get; set; }
        public virtual Siniflar Siniflar { get; set; }

        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }
    }
}

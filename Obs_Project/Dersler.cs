using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obs_Project
{
    internal class Dersler
    {
        [Key]
        public int DersId { get; set; }
        [Required]
        public int DersKod { get; set; }

        [Column(TypeName = "varchar")
            , MaxLength(50)
            , Required]
        public string DersAd { get; set; }

        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }
    }
}

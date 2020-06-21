using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class MusicLabel
    {
        [Required]
        public int IdMusicLabel { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}

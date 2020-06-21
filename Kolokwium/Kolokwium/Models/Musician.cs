using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Musician
    {
        [Required]
        public int IdMusician { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Nickname { get; set; }

        public ICollection<MusicianTrack> MusicianTracks { get; set; }
        public ICollection<Track>Tracks { get; set; }
    }
}

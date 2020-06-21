using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Track
    {
		[Required]
		public int IdTrack { get; set; }
		[MaxLength(20)]
		public string TrackName { get; set; }

		public float Duration { get; set; }

		// wartość może być null
		public int? IdMusicAlbum { get; set; }

		public Album Album { get; set; }

		public ICollection<MusicianTrack> MusicianTracks { get; set; }
	}
}

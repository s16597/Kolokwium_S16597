using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Album
    {
		[Required]
		public int IdAlbum { get; set; }

		[MaxLength(30)]
		public string AlbumName { get; set; }

		public DateTime PublishDate { get; set; }

		public int IdMusicLabel { get; set; }

		public MusicLabel MusicLabel { get; set; }

		public ICollection<Track> Tracks { get; set; }
	}
}

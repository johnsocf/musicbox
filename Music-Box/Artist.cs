using System;

namespace MusicBox
{
	public class Artist
	{
		public string Name { get; set;}
		public string Genre { get; set;}
		public DateTime DateAppeared {get; set;}

		public Artist GetArtist() {
			return Artist;
		}
	}
}


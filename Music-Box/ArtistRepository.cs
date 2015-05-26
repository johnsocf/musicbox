using System;
using System.Collections.Generic;


namespace MusicBox
{
	public class ArtistRepository
	{
		private iArtistRepository<Artist>  _artists;
		public ArtistRepository ()
		{
			_artists = new List<Artist> ();
		}
		public Artist AddArtists(Artist artist) {
			_artists.Add(artist);
			return _artists;
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public virtual int AlbumId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual int ArtistId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string AlbumArtUrl { get; set; }

        //Navigation props
        // We call the Artist property a navigational property, because given an album, you can navigate to the album’s associated artist using the dot operator (favoriteAlbum.Artist)
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
using BertoniSolutions.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniSolutions.Models
{
    public class PhotoViewModel
    {
        public PhotoViewModel(PhotoDto photo)
        {
            this.Id = photo.id;
            this.Title = photo.title;
            this.AlbumId = photo.albumId;
            this.Url = photo.url;
            this.ThumbnailUrl = photo.thumbnailUrl;
        }

        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}

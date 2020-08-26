using BertoniSolutions.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniSolutions.Models
{
    public class AlbumViewModel
    {
        public AlbumViewModel(AlbumDto album)
        {
            this.Id = album.id;
            this.Title = album.title;
            this.UserId = album.userId;
        }

        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}

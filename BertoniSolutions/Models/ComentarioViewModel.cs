using BertoniSolutions.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniSolutions.Models
{
    public class ComentarioViewModel
    {
        public ComentarioViewModel(ComentarioDto comentario)
        {
            this.Id = comentario.id;
            this.PostId = comentario.postId;
            this.Body = comentario.body;
            this.Name = comentario.name;
            this.Email = comentario.email;
        }

        public int PostId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
    }
}

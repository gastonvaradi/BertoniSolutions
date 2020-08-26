using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniSolutions.Services.DTOs
{
    public class ComentarioDto
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}

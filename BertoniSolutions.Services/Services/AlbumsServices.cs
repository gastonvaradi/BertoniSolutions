using BertoniSolutions.Services.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BertoniSolutions.Services.Services
{
    public class AlbumsServices
    {
        public List<AlbumDto> GetAlbums()
        {
            List<AlbumDto> albumsList = new List<AlbumDto>();

            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync("https://jsonplaceholder.typicode.com/albums").Result)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    albumsList = JsonConvert.DeserializeObject<List<AlbumDto>>(apiResponse);
                }
            }

            return albumsList;
        }

        public List<PhotoDto> GetPhotos(int albumId)
        {
            List<PhotoDto> photosList = new List<PhotoDto>();

            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync("https://jsonplaceholder.typicode.com/photos/").Result)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    photosList = JsonConvert.DeserializeObject<List<PhotoDto>>(apiResponse);
                }
            }

            return photosList.Where(p => p.albumId == albumId).ToList();
        }

        public List<ComentarioDto> GetComentarios(int albumId)
        {
            List<ComentarioDto> comanteriosList = new List<ComentarioDto>();

            using (var httpClient = new HttpClient())
            {
                using (var response = httpClient.GetAsync("https://jsonplaceholder.typicode.com/comments/").Result)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    comanteriosList = JsonConvert.DeserializeObject<List<ComentarioDto>>(apiResponse);
                }
            }

            return comanteriosList.Where(p => p.postId == albumId).ToList();
        }

    }
}

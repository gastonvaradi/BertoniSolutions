using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using BertoniSolutions.Models;
using BertoniSolutions.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BertoniSolutions.Controllers
{
    public class AlbumsController : Controller
    {
        private AlbumsServices _albumsServices;


        public AlbumsController(AlbumsServices albumsServices)
        {
            this._albumsServices = albumsServices;
        }

        // GET: AlbumsController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Fotos(int id)
        {
            var photos = this._albumsServices.GetPhotos(id);
            return PartialView("_TablePhotos", photos.Select(p => new PhotoViewModel(p)).ToList());
        }

        [HttpGet]
        public ActionResult Comentarios(int id)
        {
            var comentarios = this._albumsServices.GetComentarios(id);
            return PartialView("_TableComents", comentarios.Select(p => new ComentarioViewModel(p)).ToList());
        }


    }
}

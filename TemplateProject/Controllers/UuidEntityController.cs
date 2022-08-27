using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace TemplateProject.Controllers
{
    public class UuidEntityController : Controller
    {
        private readonly IUuidEntityService _uuidEntityService;

        public UuidEntityController(IUuidEntityService uuidEntityService)
        {
            _uuidEntityService = uuidEntityService;
        }

        public IActionResult Index()
        {
            UuidEntity uuid = new()
            {
                Name = "Deneme",
                Description = "Deneme Descrpiption",
                CreateDate = DateTime.Now,
                Status = true,
            };
            _uuidEntityService.Add(uuid);
            var data = _uuidEntityService.GetAll();
            var result = data.Where(x=>x.Status == true).ToList();
            return View(result);
        }
    }
}

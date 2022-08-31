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
            //var result2 = _uuidEntityService.Add(uuid);
            var result = _uuidEntityService.GetAll();
            if (result.IsSuccess)
            {
                return View(result.Data);
            }
            return View();
        }
    }
}

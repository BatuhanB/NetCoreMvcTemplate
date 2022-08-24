using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace TemplateProject.Controllers
{
    public class SampleEntityController : Controller
    {
        ISampleEntityService _sampleEntityService;

        public SampleEntityController(ISampleEntityService sampleEntityService)
        {
            _sampleEntityService = sampleEntityService;
        }

        public IActionResult Index()
        {
            SampleEntity sample = new()
            {
                Name = "Test Project 3",
                Description = "This is a test project descripton",
                CreateDate = DateTime.Now,
                Status = true
            };
            //List<SampleEntity> entities = new List<SampleEntity>();
            //entities.Add(sample);
            _sampleEntityService.Add(sample);
            List<SampleEntity> entities = _sampleEntityService.GetAll();
            return View(entities);
        }
        public IActionResult Add()
        {
            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return RedirectToAction("Index");
        }
        public IActionResult Delete()
        {
            return RedirectToAction("Index");
        }
    }
}

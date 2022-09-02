using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateProject.Controllers
{
    public class SampleEntityController : Controller
    {
        private readonly ISampleEntityService _sampleEntityService;

        public SampleEntityController(ISampleEntityService sampleEntityService)
        {
            _sampleEntityService = sampleEntityService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var entities = _sampleEntityService.GetAll();
            ViewBag.responseMessage = entities.Message;
            if (entities.IsSuccess)
            {
                Response.StatusCode = 200;
                return View(entities.Data);    
            }
            Response.StatusCode = 400;
            return View("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DataTableIndex()
        {
            var entities = _sampleEntityService.GetAll();
            ViewBag.responseMessage = entities.Message;
            if (entities.IsSuccess)
            {
                Response.StatusCode = 200;
                return View(entities.Data);    
            }
            Response.StatusCode = 400;
            return View("DataTableIndex");
        }

        [HttpPost]
        public IActionResult Add(SampleEntity sampleEntity)
        {
                sampleEntity.CreateDate = DateTime.Now;
                sampleEntity.Status = true;
                var result = _sampleEntityService.Add(sampleEntity);
                ViewBag.message = result.Message;
                return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _sampleEntityService.GetById(id);
            ViewBag.responseMessage = result.Message;
            if (result.IsSuccess)
            {
                Response.StatusCode = 200;
                return View("Update",result.Data);
            }
            Response.StatusCode = 400;
            return View("Index");
        }

        [HttpPost]
        public IActionResult Update(SampleEntity sampleEntity)
        {
            sampleEntity.CreateDate = DateTime.Now;
            _sampleEntityService.Update(sampleEntity);
            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int id)
        {
            var result = _sampleEntityService.Delete(id);
            if (result.IsSuccess)
            {
                Response.StatusCode = 200;
                return RedirectToAction("Index");    
            }
            Response.StatusCode = 500;
            return View("Index");
        }

        
        public IActionResult ChangeFalse(int id)
        {
            var result = _sampleEntityService.GetById(id);
            result.Data.Status = false;
            var result2 = _sampleEntityService.Update(result.Data);
            if (result2.IsSuccess)
            {
                Response.StatusCode = 200;
                return RedirectToAction("Index");
            }
            Response.StatusCode = 400;
            return View("Index");
        }

        public IActionResult ChangeStatus(int id)
        {
            var result = _sampleEntityService.ChangeStatus(id);
            if (result.IsSuccess)
            {
                Response.StatusCode = 200;
                return RedirectToAction("Index");
            }
            Response.StatusCode = 400;
            return View("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using TreeStructuresSystem.Models;
using TreeStructuresSystem.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TreeStructuresSystem.Controllers
{
    public class TreeStructureController : Controller
    {
        private readonly NodeService _service;

        public TreeStructureController(NodeService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            try
            {
                var categoryTree = _service.GetTree();
                return View(categoryTree);
            } catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Node node)
        {
            if (!ModelState.IsValid)
            {
                return View(node);
            }
            try
            {
                var categoryToAdd = new Node
                {
                    Name = node.Name,
                    ParentID = node.ParentID,
                };

                _service.AddNode(node);
                return new JsonResult(node);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }

        public IActionResult Delete(int id)
        {
            var node = _service.GetById(id); 
            _service.Delete(node);
            return new JsonResult(node);
        }

        public IActionResult Edit(Node node)
        {
            try
            {
                var nodeUpdated = new Node
                {
                    Id = node.Id,
                    Name = node.Name,
                    ParentID = node.ParentID,
                };
                _service.Update(nodeUpdated);

                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }

        public IActionResult EditPartial(int id)
        {
            var categories = _service.GetAll();
            var category = _service.GetById(id);
            ViewBag.catId = id;
            ViewBag.categoriesList = new SelectList(categories, "Id", "Name");

            return PartialView("EditModalPartial");
        }

    }
}


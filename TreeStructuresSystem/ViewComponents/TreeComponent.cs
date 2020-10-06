using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeStructuresSystem.Models;
using TreeStructuresSystem.Services;
using TreeStructuresSystem.ViewModels;

namespace TreeStructuresSystem.ViewComponents
{
    [ViewComponent]
    public class TreeComponent : ViewComponent
    {
        private readonly NodeService _service;

        public TreeComponent (NodeService service)
        {
            _service = service;
        }
        public Task<IViewComponentResult> InvokeAsync(List<Node> nodes, bool isFirstCall)
        {
            if (isFirstCall)
            {
                nodes = _service.GetTree();
            }
            var viewModel = new TreeViewModel { IsFirstCall = isFirstCall, Nodes = nodes };
            return Task.FromResult<IViewComponentResult>(View(viewModel));
        }

    }
}

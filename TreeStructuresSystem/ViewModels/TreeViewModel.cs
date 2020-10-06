using System;
using System.Collections.Generic;
using TreeStructuresSystem.Models;

namespace TreeStructuresSystem.ViewModels
{
    public class TreeViewModel
    {
        public List<Node> Nodes { get; set; }
        public bool IsFirstCall { get; set; }
    }
}

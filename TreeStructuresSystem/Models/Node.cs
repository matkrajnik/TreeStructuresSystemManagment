﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TreeStructuresSystem.Models
{
    public class Node
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 1)]
        public string Name { get; set; }
        [DisplayName("Parent")]
        public int? ParentID { get; set; }
        public Node Parent { get; set; }
        public List<Node> Children { get; set; }
    }
}

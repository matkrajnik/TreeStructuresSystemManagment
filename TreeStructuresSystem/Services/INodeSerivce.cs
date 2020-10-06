using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeStructuresSystem.Models;

namespace TreeStructuresSystem.Services
{
    interface ICategoryService
    {
        List<Node> GetAll();
        Node GetById(int id);
        List<Node> GetChildren(int id);
        List<Node> GetTree();
        void AddNode(Node node);
        void Update(Node node);
        void Delete(Node node);
    }
}

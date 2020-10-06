using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TreeStructuresSystem.Data;
using TreeStructuresSystem.Models;

namespace TreeStructuresSystem.Services
{
    public class NodeService : ICategoryService
    {
        private readonly Context _context;

        public NodeService(Context context)
        {
            _context = context;
        }

        public List<Node> GetAll()
        {
            return _context.Nodes.ToList();
        }

        public Node GetById(int id)
        {
            return _context.Nodes.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Node> GetChildren(int id)
        {
            var tree = _context.Nodes.ToList();
            return tree;
        }
        
        public List<Node> GetTree()
        {
            var tree = _context.Nodes
                .Include(c => c.Children)
                .AsEnumerable()
                .Where(x => x.Parent == null)
                .ToList();

            return tree;
        }

        public void AddNode(Node node)
        {
            _context.Nodes.Add(node);
            _context.SaveChanges();
        }

        public void Update(Node node)
        {
            _context.Entry(_context.Nodes.FirstOrDefault(n => n.Id == node.Id)).CurrentValues.SetValues(node);
            _context.SaveChanges();
        }
 
        public void Delete(Node node)
        {
            var nodeChild = _context.Nodes.Where(c => c.ParentID == node.Id).ToList();
            node.Children = nodeChild;

            if(node.Children.Count == 0 )
            {
                _context.Nodes.Remove(node);

            } else{
                _context.Nodes.Remove(node);

                foreach ( var children in node.Children)
                {
                    this.Delete(children);
                }
            }
            _context.SaveChanges();
        }
    }
}

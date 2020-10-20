using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTree
{
    public class Node
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Node> Childs { get; set; }

        public Node(string _name, int _id)
        {
            this.Name = _name;
            this.Id = _id;

            Childs = new List<Node>();            
        }
        
    }
}

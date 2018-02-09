using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversals
{
    public abstract class TreeVisitor
    {
        protected List<Node> nodesList;
        protected abstract void VisitTreeInternal(Node node);        

        public IEnumerable<Node> VisitTree(Node root)
        {
            nodesList = new List<Node>();
            VisitTreeInternal(root);
            return nodesList;
        }

        protected bool IsLeaf(Node node)
        {
            return node.Left == null && node.Right == null;
        }
        
    }
}

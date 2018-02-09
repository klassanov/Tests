using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversals
{
    public class PreOrderTreeVisitor:OrderTreeVisitor
    {
        //DFS: Depth first search       
        protected override void VisitSubtree(Node node)
        {
            nodesList.Add(node);
            VisitTreeInternal(node.Left);
            VisitTreeInternal(node.Right);
        }
    }
}

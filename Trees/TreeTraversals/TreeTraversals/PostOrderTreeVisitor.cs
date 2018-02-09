using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversals
{
    public class PostOrderTreeVisitor: OrderTreeVisitor
    {        
        protected override void VisitSubtree(Node node)
        {
            VisitTreeInternal(node.Left);
            VisitTreeInternal(node.Right);
            nodesList.Add(node);
        }
    }
}

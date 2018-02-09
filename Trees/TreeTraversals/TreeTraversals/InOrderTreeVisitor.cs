using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversals
{
    public class InOrderTreeVisitor : OrderTreeVisitor
    {       
        protected override void VisitSubtree(Node node)
        {
            VisitTreeInternal(node.Left);
            nodesList.Add(node);
            VisitTreeInternal(node.Right);
        }
    }
}

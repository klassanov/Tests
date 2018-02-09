using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversals
{
    public abstract class OrderTreeVisitor: TreeVisitor
    {
        protected override void VisitTreeInternal(Node node)
        {
            if (node != null)
            {
                //Leaf
                if (IsLeaf(node))
                {
                    nodesList.Add(node);
                }
                //Has subtree(s)        
                else
                {
                    VisitSubtree(node);
                }
            }
        }

        protected abstract void VisitSubtree(Node node);
    }
}

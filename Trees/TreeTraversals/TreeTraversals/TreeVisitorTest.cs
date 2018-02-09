using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversals
{
    public class TreeVisitorTest
    {
        static void Main(string[] args)
        {
            Node root = CreateTree();

            PrintResults(root, new InOrderTreeVisitor());
            PrintResults(root, new PostOrderTreeVisitor());
            PrintResults(root, new PreOrderTreeVisitor());
            
            Console.ReadKey();
        }

        static void PrintResults(Node root, TreeVisitor visitor)
        {
            IEnumerable<Node> nodesList = visitor.VisitTree(root);
            Console.WriteLine(string.Format("{0}: {1}",visitor.GetType().Name,  string.Join(" ", nodesList.Select(x => x.Data))));
        }

        static Node CreateTree()
        {
            Node root = new Node()
            {
                Data=4,
                Left = new Node
                {
                    Data=2,
                    Left = new Node
                    {
                        Data=1
                    },
                    Right = new Node
                    {
                        Data=3
                    }
                },
                Right = new Node
                {
                    Data=6,
                    Left = new Node
                    {
                        Data=5
                    },
                    Right = new Node
                    {
                        Data=7
                    }
                }
            };
            return root;
        }
    }
}

#undef DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryTree
{
    class Tree
    {

        public class Element 
        {
            public int Data;
            public Element pLeft;
            public Element pRight;
            public Element(int Data, Element pLeft = null, Element pRight = null)
            {
                this.Data = Data;
                this.pLeft = pLeft;
                this.pRight = pRight;
                Console.WriteLine($"Econstructor:\t{GetHashCode()}");
            }
            ~Element()
            {
                Console.WriteLine($"Edestructor:\t{GetHashCode()}");
            }




        }
        public Element Root;
        public Tree()
        {

#if DEBUG
            Console.WriteLine($"Tconstructor:\t{GetHashCode()}"); 
#endif
        }
        ~Tree()
        {
#if DEBUG
            Console.WriteLine($"Tdestructor:\t{GetHashCode()}"); 
#endif
        }

        public void Insert(int Data)
        {
            Insert(Data, Root);
        }

        public void Insert(int Data, Element Root)
        {
            if (this.Root == null) this.Root = new Element(Data);
            if (Root == null) return;
            if (Data < Root.Data)
            {
                if (Root.pLeft == null) Root.pLeft = new Element(Data);
                else Insert(Data, Root.pLeft);
            }
            else
            {
                if (Root.pRight == null) Root.pRight = new Element(Data);
                else Insert(Data, Root.pRight);
            }

        }
        public int Min()
        {
            if (Root == null) throw new Exception("No Tree in Min");
            return Min(Root);
        }

        int Min(Element Root)
        {
            return Root.pLeft == null ? Root.Data : Min(Root.pLeft);
            //if (Root.pLeft == null) return Root.Data;
            //else return Min(Root.pLeft);
        }

        public int Max()
        {
            if (Root == null) throw new Exception("No Tree in Min");
            return Max(Root);
        }



        int Max(Element Root)
        {
            return Root.pRight == null ? Root.Data : Max(Root.pRight);
            //if (Root.pLeft == null) return Root.Data;
            //else return Min(Root.pLeft);
        }

        int Count(Element Root)
        {
            return Root == null ? 0 : Count(Root.pLeft) + Count(Root.pRight) + 1;
        }
        public int Count()
        {
            return Count(Root);
        }

        int Sum(Element Root)
        {
            return Root == null ? 0 : Sum(Root.pLeft) + Sum(Root.pRight) + Root.Data;

        }

        public void Print()
        {
            Print(Root);
            Console.WriteLine();
        }
        public double AVG(Element Root)
        {
            return Sum(Root) / Count(Root);
        }

        public void Print(Element Root)
        {
            if (Root == null) return;
            Print(Root.pLeft);
            Console.Write($"{Root.Data}\t");
            Print(Root.pRight);


        }
    }
}


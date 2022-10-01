using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10
{
    class node
    {
        int data;
        node left;
        node right;
        public node(int n)
        {
            data = n;
            left = null;
            right = null;
        }
        public int getData()
        {
            return data;
        }
        public node getLeft()
        {
            return left;
        }
        public node getRight()
        {
            return right;
        }
        public void setData(int n)
        {
            data = n;
        }
        public void setLeft(node d)
        {
            left = d;
        }
        public void setRight(node d)
        {
            right = d;
        }
    }
}

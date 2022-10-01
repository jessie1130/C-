using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw9
{
    class node
    {
        int data;
        node next;
        public node(int n)
        {
            data = n;
            next = null;
        }
        public int getData()
        {
            return data;
        }
        public node getNext()
        {
            return next;
        }
        public void setData(int n)
        {
            data = n;
        }
        public void setNext(node d)
        {
            next = d;
        }
    }
}

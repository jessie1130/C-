using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw8
{
    class Queue
    {
        const int MAX = 8;
        int[] queue = new int[MAX];
        public int front = 7, rear = 7;
        public void enqueue(int item)
        {
            if (front == (rear + 1) % MAX)
                MessageBox.Show("空間已滿", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                rear = (rear + 1) % MAX;
                queue[rear] = item;
            }
        }
        public int dequeue()
        {
            if (front == rear)
            {
                MessageBox.Show("沒有資料", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }   
            else
            {
                front = (front + 1) % MAX;
                return queue[front];
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class PriorityQueue : IQueue
    {
        private Kisi[] Queue;
        private int front = -1;
        //Not1: rear değeri hep 0 olduğu için değişmez.
        //Not2: size ve count değişkenlerinden birisi
        //istenirse kullanılmayabilir
        private int size = 0;
        private int count = 0;

        public PriorityQueue(int size)
        {
            this.size = size;
            Queue = new Kisi[size];
        }
        public void Insert(Kisi o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                //Not3:
                //Son elemandan başlayarak geriye doğru kuyruk kontrol ediliyor
                //Eklenecek elemanın pozisyonu belirleniyor
                //Var olan elemanlar kaydırılıyor
                for (i = count - 1; i >= 0; i--)
                {
                    if ((int)o.beklemeSuresi > (int)Queue[i].beklemeSuresi)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public Kisi Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            Kisi temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

        public Kisi Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
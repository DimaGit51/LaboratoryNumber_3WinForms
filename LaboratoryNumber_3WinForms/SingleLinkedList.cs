using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryNumber_3WinForms
{
    public class SingleLinkedList// Класс «Односвязные списки»
    {
        private Node first; // ссылка на первый узел списка
        public SingleLinkedList() // конструктор: инициализация пустого списка
        {
            first = null;
        }
        public void InsertBeforeFirst(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            {
                p.Link = first;
                first = p;
            }
        }
        public void InsertAfterNodeP(Node p, int date)
        {
            Node q;
            if (p != null)
            {
                q = new Node(date);
                q.Link = p.Link;
                p.Link = q;
            }
        }
        public void InsertAfterEnd(int data)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
            }
            else
            {
                Node q = first;
                while (q.Link != null)
                {
                    q = q.Link;
                }
                q.Link = p;
            }
        }
        public void Destroy()
        {
            first = null;
        }
        public void Print(ListBox listbox)
        {
            Node p = first;
            while (p != null)
            {
                int num = p.Info;
                listbox.Items.Add(num.ToString());
                p = p.Link;
            }
        }
        public void ForeachForSinglList(int d_log)
        {
            Node p = first;
            while (p != null)
            {
                if (d_log == 11) {  BalancedTree.l11.SortList(p.Info, d_log);  }

                if (d_log == 22) {  BalancedTree.l22.SortList(p.Info, d_log); }
                p = p.Link;
            }
        }
        public void SortList(int data, int d_log)
        {
            Node p = new Node(data);
            if (first == null)
            {
                first = p;
                //MessageBox.Show("Только Только создаем " + p.Info);
            }
            else
            {
                Node q = first;
                Node k = null;
                if (q.Info > p.Info)
                {
                    InsertBeforeFirst(data);
                    //MessageBox.Show("Добавляем перед " + q.Info + " элемент " + p.Info);
                }
                else
                {
                    bool logic = false;
                    bool logic1 = false;
                    while (q != null)
                    {
                        if (q.Link != null && q.Info < p.Info && q.Link.Info > p.Info)
                        {
                            //MessageBox.Show("Добавляем после элемента " + q.Info + " элемент "+ p.Info);
                            InsertAfterNodeP(q, data);
                            q = q.Link;
                            logic = true;
                        }
                        else if(q.Link != null && q.Info == p.Info && q.Link.Info > p.Info)
                        {
                            //MessageBox.Show("Добавляем посде одинаков " + p.Info);
                            p.Link = q.Link;
                            q.Link = p;
                            q = q.Link;
                            logic = true;
                        }
                        q = q.Link;
                    }
                    if (!logic)
                    {
                        //MessageBox.Show("Добавляем в конец " + p.Info);

                        InsertAfterEnd(data);
                        logic = true;
                    }


                }
            }
        }

    }
}

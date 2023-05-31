using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryNumber_3WinForms
{
    public class DTreeNode // Класс «Узел бинарного дерева»
    {
        private int info; // информационное поле
        private DTreeNode left; // ссылка на левое поддерево
        private DTreeNode right; // ссылка на правое поддерево
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public DTreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public DTreeNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public DTreeNode() { } // конструкторы
        public DTreeNode(int info)
        {
            Info = info;
        }
        public DTreeNode(int info, DTreeNode left, DTreeNode right)
        {
            Info = info; Left = left; Right = right;
        }
    }
}

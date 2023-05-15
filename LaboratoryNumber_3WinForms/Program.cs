using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaboratoryNumber_3WinForms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Index());
        }
    }
    public class Node
    {
        private int info;
        private Node link;
        // Класс «Узел односвязного списка»
        // информационное поле узла
        // поле связи узла
        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        // свойства
        public Node Link
        {
            get { return link; }
            set { link = value; }
        }
        public Node() { }

        public Node(int info) // конструкторы
        {
            Info = info;
        }
        public Node(int info, Node link)
        {
            Info = info; Link = link;
        }
    }
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
    }
    public class TreeNode // Класс «Узел бинарного дерева»
    {
        private int info; // информационное поле
        private TreeNode left; // ссылка на левое поддерево
        private TreeNode right; // ссылка на правое поддерево
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public TreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public TreeNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public TreeNode() { } // конструкторы
        public TreeNode(int info)
        {
            Info = info;
        }
        public TreeNode(int info, TreeNode left, TreeNode right)
        {
            Info = info; Left = left; Right = right;
        }
    }

    public class BalancedTree // Класс «Бинарное дерево произвольного вида»
    {
        static public BalancedTree T = new BalancedTree();

        private TreeNode root; // ссылка на корень дерева
        public TreeNode Root // свойство, открывающее доступ к корню дерева
        {
            get { return root; }
            set { root = value; }
        }
        public BalancedTree() // инициализация пустого дерева
        {
            root = null;
        }
        public void KLP(TextBox textbox, TreeNode root) // root – ссылка на корень дерева и любого из деревьев
        {
            if (root != null) // дерево не пусто?
            {
                textbox.Text += root.Info.ToString()+" ";// распечатать информ. поле корневого узла
                KLP(textbox, root.Left); // обойти левое поддерево в нисходящем порядке
                KLP(textbox, root.Right); // обойти правое поддерево в нисходящем порядке
            }
        }
        public void LPK(TextBox textbox, TreeNode root) // root – ссылка на корень дерева и любого из деревьев
        {
            if (root != null) // дерево не пусто?
            {
                LPK(textbox, root.Left); // обойти левое поддерево в нисходящем порядке
                LPK(textbox, root.Right); // обойти правое поддерево в нисходящем порядке
                textbox.Text += root.Info.ToString() + " ";// распечатать информ. поле корневого узла
            }
        }
        public void LKP(TextBox textbox, TreeNode root) // root – ссылка на корень дерева и любого из деревьев
        {
            if (root != null) // дерево не пусто?
            {
                LKP(textbox, root.Left); // обойти левое поддерево в нисходящем порядке
                textbox.Text += root.Info.ToString() + " ";// распечатать информ. поле корневого узла
                LKP(textbox, root.Right); // обойти правое поддерево в нисходящем порядке
            }

        }
        public static void CreatMassT(TextBox textbox1, TextBox textbox2, TextBox textbox3, int[] dates)
        {
            int count = 0;
            T.Root = T.CreateRecursive(dates.Length, dates, ref count);
            T.KLP(textbox1, T.Root);
            T.LPK(textbox2, T.Root);
            T.LKP(textbox3, T.Root);

        }
        public int RecursionCount(TreeNode root)
        {
            int count;
            if (root == null) count = 0;
            else count = 1 + RecursionCount(root.Left) + RecursionCount(root.Right);
            return count;
        }
        public TreeNode CreateRecursive(int n, int[] dates, ref int count)
        {
            int x; TreeNode root;
            if (n == 0) { root = null;}
            else
            {
                x = dates[count];
                root = new TreeNode(x);
                count++;
                root.Left = CreateRecursive(n / 2, dates, ref count);
                root.Right = CreateRecursive(n - n / 2 - 1, dates, ref count);            }
            return root;
        }

        public void Destroy() // разрушение дерева
        {
            root = null;
        }

        public static SingleLinkedList l1 = new SingleLinkedList();
        public static SingleLinkedList l2 = new SingleLinkedList();

        public static void KLPing(TreeNode root, int number) // root – ссылка на корень дерева и любого из деревьев
        {
            if (root != null) // дерево не пусто?
            {
                if (root.Info > number) l1.InsertBeforeFirst(root.Info);
                else l2.InsertBeforeFirst(root.Info);
                KLPing(root.Left, number); // обойти левое поддерево в нисходящем порядке
                KLPing(root.Right, number); // обойти правое поддерево в нисходящем порядке
            }
        }
        public static void Task(ListBox listbox1, ListBox listbox2, int number)
        {
            l1.Destroy();
            l2.Destroy();
            KLPing(T.Root, number);
            l1.Print(listbox1);
            l2.Print(listbox2);
        }
    }
}

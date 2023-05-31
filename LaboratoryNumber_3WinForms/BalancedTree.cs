using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaboratoryNumber_3WinForms
{
    public class BalancedTree // Класс «Бинарное дерево произвольного вида»
    {
        static public BalancedTree T = new BalancedTree();

        private DTreeNode root; // ссылка на корень дерева
        public DTreeNode Root // свойство, открывающее доступ к корню дерева
        {
            get { return root; }
            set { root = value; }
        }
        public BalancedTree() // инициализация пустого дерева
        {
            root = null;
        }
        public void KLP(TextBox textbox, DTreeNode root) // root – ссылка на корень дерева и любого из деревьев
        {
            if (root != null) // дерево не пусто?
            {
                textbox.Text += root.Info.ToString() + " ";// распечатать информ. поле корневого узла
                KLP(textbox, root.Left); // обойти левое поддерево в нисходящем порядке
                KLP(textbox, root.Right); // обойти правое поддерево в нисходящем порядке
            }
        }
        public void LPK(TextBox textbox, DTreeNode root) // root – ссылка на корень дерева и любого из деревьев
        {
            if (root != null) // дерево не пусто?
            {
                LPK(textbox, root.Left); // обойти левое поддерево в нисходящем порядке
                LPK(textbox, root.Right); // обойти правое поддерево в нисходящем порядке
                textbox.Text += root.Info.ToString() + " ";// распечатать информ. поле корневого узла
            }
        }
        public void LKP(TextBox textbox, DTreeNode root) // root – ссылка на корень дерева и любого из деревьев
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
        public int RecursionCount(DTreeNode root)
        {
            int count;
            if (root == null) count = 0;
            else count = 1 + RecursionCount(root.Left) + RecursionCount(root.Right);
            return count;
        }
        public DTreeNode CreateRecursive(int n, int[] dates, ref int count)
        {
            int x; DTreeNode root;
            if (n == 0) { root = null; }
            else
            {
                x = dates[count];
                root = new DTreeNode(x);
                count++;
                root.Left = CreateRecursive(n / 2, dates, ref count);
                root.Right = CreateRecursive(n - n / 2 - 1, dates, ref count);
            }
            return root;
        }



        static public void PrintTreeView(DTreeNode p, TreeNode T)
        {
            if (p != null)
            {
                T.Text = p.Info.ToString();
                if (p.Left != null)
                {
                    TreeNode leftNode = new TreeNode();
                    T.Nodes.Add(leftNode);
                    PrintTreeView(p.Left, leftNode);
                }
                if(p.Right != null)
                {
                    TreeNode rightNode = new TreeNode();
                    T.Nodes.Add(rightNode);
                    PrintTreeView(p.Right, rightNode);
                }
            }
        }
        static public void DisplayTree(TreeView J)
        {
            J.Nodes.Clear();
            if (T.Root != null)
            {
                TreeNode NV = new TreeNode();
                J.Nodes.Add(NV);
                PrintTreeView(T.Root, NV);
            }
        }


        public void Destroy() // разрушение дерева
        {
            root = null;
        }

        public static SingleLinkedList l1 = new SingleLinkedList();
        public static SingleLinkedList l2 = new SingleLinkedList();

        public static SingleLinkedList l11 = new SingleLinkedList();
        public static SingleLinkedList l22 = new SingleLinkedList();

        public static void KLPing(DTreeNode root, int number) // root – ссылка на корень дерева и любого из деревьев
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
            l11.Destroy();
            l22.Destroy();
            KLPing(T.Root, number);
            //MessageBox.Show("Спиосок 1");
            l1.ForeachForSinglList(11);
            //MessageBox.Show("Спиосок 2");
            l2.ForeachForSinglList(22);

            l11.Print(listbox1);
            l22.Print(listbox2);
        }
    }
}

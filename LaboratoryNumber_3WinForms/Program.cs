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
            Application.Run(new Form1());
        }
    }

    public class TreeNode // Класс «Узел бинарного дерева»
    {
        private char info; // информационное поле
        private TreeNode left; // ссылка на левое поддерево
        private TreeNode right; // ссылка на правое поддерево
        public char Info
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
        public TreeNode(char info)
        {
            Info = info;
        }
        public TreeNode(char info, TreeNode left, TreeNode right)
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
        public static void CreatMassT(TextBox textbox1, TextBox textbox2, TextBox textbox3, char[] dates)
        {
            int count = 0;
            T.Root = T.CreateRecursive(dates.Length, dates, count);
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
        public TreeNode CreateRecursive(int n, char[] dates, int count)
        {
            char x; TreeNode root;
            if (n == 0) root = null;
            else
            {
                x = dates[count];
                count++;
                root = new TreeNode(x);
                root.Left = CreateRecursive(n / 2, dates, count);
                root.Right = CreateRecursive(n - n / 2 - 1, dates, count);
            }
            return root;
        }

        public void Destroy() // разрушение дерева
        {
            root = null;
        }
    }
}

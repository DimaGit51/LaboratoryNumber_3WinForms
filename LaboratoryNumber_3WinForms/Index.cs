using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaboratoryNumber_3WinForms
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }



        private void buttonInputElement_Click(object sender, EventArgs e)
        {
            int number;
            if ((!int.TryParse(textBoxInputElement.Text, out number)))
            {
                MessageBox.Show("Вы ввели не int!!!");
            }
            else
            {
                listBoxElements.Items.Add(number);
                textBoxInputElement.Clear();
            }
        }
        private void созданиеДереваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
            textBox2.Clear();
            textBox3.Clear();

            int[] dates = new int[listBoxElements.Items.Count];
            for (int i = 0; i < listBoxElements.Items.Count; i++) dates[i] = int.Parse(listBoxElements.Items[i].ToString());
            BalancedTree.CreatMassT(textBox1, textBox2, textBox3, dates);
            BalancedTree.DisplayTree(treeView);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы точно хотите выйти из программы?", "Проверка выхода", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonRemoveElement_Click(object sender, EventArgs e)
        {
            if (listBoxElements.SelectedIndex > -1) listBoxElements.Items.RemoveAt(listBoxElements.SelectedIndex);
        }

        private void разрушениеДереваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxElements.Items.Clear();
            BalancedTree.T.Destroy();
        }

        private void обработкаДереваВСоответствииСЗаданиемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task Tsk = new Task();
            Tsk.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramInfo Prgrm = new ProgramInfo();
            Prgrm.Show();
        }
    }
}


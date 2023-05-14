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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonInputElement_Click(object sender, EventArgs e)
        {
            char number;
            if ((!char.TryParse(textBoxInputElement.Text, out number)))
            {
                MessageBox.Show("Вы ввели не char!!!");
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

            char[] dates = new char[listBoxElements.Items.Count];
            for (int i = 0; i < listBoxElements.Items.Count; i++) dates[i] = char.Parse(listBoxElements.Items[i].ToString());
            BalancedTree.CreatMassT(textBox1, textBox2, textBox3, dates);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


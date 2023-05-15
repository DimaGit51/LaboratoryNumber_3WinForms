using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratoryNumber_3WinForms
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int number;
            if ((!int.TryParse(textBoxN.Text, out number)))
            {
                MessageBox.Show("Вы ввели не int!!!");
            }
            else
            {
                textBoxN.Clear();
                BalancedTree.Task(listBox1, listBox2, number);
            }
        }
    }
}

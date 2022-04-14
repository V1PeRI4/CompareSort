using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Info : Form
    {
        int IndexCBChooseSort = 0;

        public Info()
        {
            InitializeComponent();
        }

        private void CBChooseSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexCBChooseSort = CBChooseSort.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RTBDescription.Text = "Сортировка пузырьком — один из самых известных алгоритмов сортировки. Здесь нужно последовательно сравнивать значения соседних элементов и менять числа местами, если предыдущее оказывается больше последующего. Таким образом элементы с большими значениями оказываются в конце списка, а с меньшими остаются в начале.\nЭтот алгоритм считается учебным и почти не применяется на практике из - за низкой эффективности: он медленно работает на тестах, в которых маленькие элементы(их называют «черепахами») стоят в конце массива. Однако на нём основаны многие другие методы, например, шейкерная сортировка и сортировка расчёской.";
        }
        
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}

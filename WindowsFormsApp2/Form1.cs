using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        /*--------------------------Обьявление переменных--------------------------*/

        int[] array;       // Изначальный массив
        int size;

        TimeSpan tsBubble; // пузырек время начала
        TimeSpan tsIns;    // вставка
        TimeSpan tsSel;    // выбор
        TimeSpan tsShaker; // шейкер



        protected bool fCancelBubSort = false; // булы для стопа сортировок
        protected bool fCancelInsSort = false;
        protected bool fCancelSelSort = false;
        protected bool fCancelShakerSort = false;


        private int IndexCBChooseSort = 0;



        /*--------------------------Обьявление формы--------------------------*/

        public Form1()
        {
            InitializeComponent();

            ClearProgressBar();
            // Деактивировать панель результатов
            panelResult.Enabled = false;
        }


        /*--------------------------Место для кнопок--------------------------*/

        // Кнопка Создания массива
        private void btnCreateMass_Click(object sender, EventArgs e)
        {
            btnSortMass.Enabled = true;
            CleanResultValue();

            // Запустить генерирование массива в потоке
            if (!BWGenerateMass.IsBusy)
                BWGenerateMass.RunWorkerAsync(); // сгенерировать событие DoWork
        }
        


        // Кнопка Сортировки - запустить потоки на выполнение
        private void btnSortMass_Click(object sender, EventArgs e)
        {
            btnCreateMass.Enabled = false;

            // Запуск методов сортировки в потоках
            if (!BWBubSort.IsBusy)
                BWBubSort.RunWorkerAsync();
            if (!BWInsertSort.IsBusy)
                BWInsertSort.RunWorkerAsync();
            if (!BWSelectSort.IsBusy)
                BWSelectSort.RunWorkerAsync();
            if (!BWShakerSort.IsBusy)
                BWShakerSort.RunWorkerAsync();
        }


        // Кнопка Остановки - отменить выполнение всех потоков
        private void btnStopSort_Click(object sender, EventArgs e)
        {
            try
            {
                BWBubSort.CancelAsync(); // остановить сортировку пузырьком
                BWInsertSort.CancelAsync(); // остановить сортировку вставками
                BWSelectSort.CancelAsync(); // остановить сортировку выбором
                BWShakerSort.CancelAsync();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Кнопка Очистки listBox'ов
        private void btnClearListBox_Click(object sender, EventArgs e)
        {
            CleanResultValue();
        }


        /*--------------------------Дополнительные методы--------------------------*/

        // Обнуление значений в progressBar'ах
        private void ClearProgressBar()
        {
            ProgressBarBubbleSort.Value = 0;
            ProgressBarInsertSort.Value = 0;
            ProgressBarSelectionSort.Value = 0;
            ProgressBarShakerSort.Value = 0;
        }

        // Метод очистки результатов к кнопке создания
        private void CleanResultValue()
        {
            labelProgressBubSort.Text = "";
            labelProgressInsertSort.Text = "";
            labelProgressSelectionSort.Text = "";
            labelProgressShakerSort.Text = "";
            LBBubbleSort.Items.Clear();
            LBInsertSort.Items.Clear();
            LBSelectSort.Items.Clear();
            LBShakerSort.Items.Clear();
        }

        // Внутренний метод, который отображает массив в элементе управления типа ListBox
        private void DisplayArray(string A, ListBox LB)
        {
            LB.Items.Add(A);
        }

        // Остановка метода сортировки и возвращение времени выполнения
        private string StopTime(TimeSpan methodTime)
        {
            TimeSpan time = new TimeSpan(DateTime.Now.Ticks) - methodTime;
            string result = String.Format("{0}:{1}:{2}", time.Minutes, time.Seconds, time.Milliseconds);
            return result;
        }


        // Получение количества элементов в массиве
        private int GetMassLenght()
        {
            int n = 0;
            if (RBNum1000.Checked == true) { n = 1000; }
            if (RBNum10000.Checked == true) { n = 10000; }
            if (RBNum100000.Checked == true) { n = 100000; }
            if (RBNum1000000.Checked == true) { n = 1000000; }
            return n;
        }

        private int[] FillArray(int[] array)
        {
            Random rnd = new Random();



            if (IndexCBChooseSort == 0) 
                for (int i = 0; i < array.Length; i++)
                    array[i] = rnd.Next(1, array.Length);

            if (IndexCBChooseSort == 1) 
                for (int i = 0; i < array.Length; i++)
                    array[i] = i;

            if (IndexCBChooseSort == 2) 
                for (int i = 0; i < array.Length; i++)
                    array[i] = array.Length - i;

            if (IndexCBChooseSort == 3)
                for (int i = 0; i < array.Length; i++)
                    array[i] = array.Length - i;

            if (IndexCBChooseSort == 4) 
            {
                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, array.Length);
                    if (array[i] % 3 == 0) array[i - 1] = array[i];
                }
            }

            return array;
        }

        private void CBChooseSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexCBChooseSort = CBChooseSort.SelectedIndex;
        }

        private void ViewProgressChange(BackgroundWorker backgroundWorker, int[] array, int i)
        {
            try
            {
                backgroundWorker.ReportProgress((i * 100) / array.Length);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /*--------------------------Background work'еры (кнопки и сортировки)--------------------------*/

        ////////////////// Генерация массива
        private void BWGenerateMass_DoWork(object sender, DoWorkEventArgs e)
        {
            int n = size = GetMassLenght();
            array = new int[n];

            array = FillArray(array);
        }
        // После завершения Генерации массива
        private void BWGenerateMass_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (array.Length > 0)
                panelResult.Enabled = true;
            else MessageBox.Show("Выберите длинну массива");

        }


        ////////////////// Сортировка методом пузырька - поток
        private void BWBubbleSort_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] arrayBub = new int[size];
            array.CopyTo(arrayBub, 0);

            tsBubble = new TimeSpan(DateTime.Now.Ticks);

            for (int i = 0; i < arrayBub.Length; i++)
            {
                for (int j = arrayBub.Length - 1; j > i; j--)
                {
                    if (arrayBub[j - 1] > arrayBub[j]) // сортировка по возрастанию
                    {
                        int temp;
                        temp = arrayBub[j - 1];
                        arrayBub[j - 1] = arrayBub[j];
                        arrayBub[j] = temp;
                    }
                }

                // Отобразить изменение прогресса
                ViewProgressChange(BWBubSort, arrayBub, i);
                
                // Проверка, был ли остановлен поток
                if (BWBubSort.CancellationPending)
                {
                    fCancelBubSort = true;
                    break;
                }
            }
        }


        ////////////////// Сортировка вставками
        private void BWInsertSort_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] arrayIns = new int[size];
            array.CopyTo(arrayIns, 0);

            tsIns = new TimeSpan(DateTime.Now.Ticks);

            int temp, j;

            for (int i = 0; i < arrayIns.Length; i++)
            {
                temp = arrayIns[i];

                for (j = i - 1; j >= 0 && arrayIns[j] > temp; j--)
                    arrayIns[j + 1] = arrayIns[j]; // сдвинуть элемент вправо
                arrayIns[j + 1] = temp;

                // Отобразить изменение прогресса
                ViewProgressChange(BWInsertSort, arrayIns, i);

                // Проверка, был ли остановлен поток
                if (BWInsertSort.CancellationPending)
                {
                    fCancelInsSort = true;
                    break;
                }

            }

        }
        

        // Сортировка выбором
        private void BWSelectSort_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] arraySel = new int[size];
            array.CopyTo(arraySel, 0);

            tsSel = new TimeSpan(DateTime.Now.Ticks);

            int k;
            int x;

            for (int i = 0; i < arraySel.Length; i++)
            {
                k = i;

                // поиск наименьшего элемента
                x = arraySel[i];

                for (int j = i + 1; j < arraySel.Length; j++)
                    if (arraySel[j] < x)
                    {
                        k = j; // k - индекс наименьшего элемента
                        x = arraySel[j];
                    }
                // поменять местами наименьший элемент с arraySel[i]
                arraySel[k] = arraySel[i];
                arraySel[i] = x;

                // Отобразить изменение прогресса
                ViewProgressChange(BWSelectSort, arraySel, i);

                // Проверка, был ли остановлен поток
                if (BWSelectSort.CancellationPending)
                {
                    fCancelSelSort = true;
                    break;
                }
            }
        }


        // Шейкерная сортировка
        private void BWShakerSort_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] arrayShaker = new int[size];
            array.CopyTo(arrayShaker, 0);

            tsShaker = new TimeSpan(DateTime.Now.Ticks);

            int count = 0;
            int leftMark = 1;
            int rightMark = size - 1;
            bool work = true;

            while (work)
            {
                work = false;
                for (int i = rightMark; i >= leftMark; i--)
                {
                    if (arrayShaker[i - 1] > arrayShaker[i])
                    {
                        int temp;
                        temp = arrayShaker[i - 1];
                        arrayShaker[i - 1] = arrayShaker[i];
                        arrayShaker[i] = temp;
                        work = true;
                    }
                }
                leftMark++;
                count++;



                for (int i = leftMark; i <= rightMark; i++)
                {
                    if (arrayShaker[i - 1] > arrayShaker[i])
                    {
                        int temp;
                        temp = arrayShaker[i - 1];
                        arrayShaker[i - 1] = arrayShaker[i];
                        arrayShaker[i] = temp;
                        work = true;
                    }
                }
                rightMark--;
                count++;


                ViewProgressChange(BWShakerSort, arrayShaker, count);

                // Проверка, был ли остановлен поток
                if (BWShakerSort.CancellationPending)
                {
                    fCancelShakerSort = true;
                    break;
                }
            }
        }





        // Изменение прогресса в методе сортировки пузырьком
        private void BWBubbleSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgressBubSort.Text = Convert.ToString(e.ProgressPercentage) + " %";
            ProgressBarBubbleSort.Value = e.ProgressPercentage;
        }

        // Прогресс для метода сортировки вставками
        private void BWInsertSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgressInsertSort.Text = Convert.ToString(e.ProgressPercentage) + " %";
            ProgressBarInsertSort.Value = e.ProgressPercentage;
        }

        // Изменение прогресса для алгоритма сортировки выбором
        private void BWSelectSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgressSelectionSort.Text = Convert.ToString(e.ProgressPercentage) + " %";
            ProgressBarSelectionSort.Value = e.ProgressPercentage;
        }

        private void BWShakerSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgressShakerSort.Text = Convert.ToString(e.ProgressPercentage) + " %";
            ProgressBarShakerSort.Value = e.ProgressPercentage;
        }


        // Завершение сортировки методом пузырька - выполнить конечные операции
        private void BWBubbleSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Если была отмена сортировки
            if (fCancelBubSort)
            {
                labelProgressBubSort.Text = "";
                fCancelBubSort = false;
            }
            else
            {
                labelProgressBubSort.Text = StopTime(tsBubble);
                DisplayArray(labelProgressBubSort.Text, LBBubbleSort);
            }

            // Настроить другие элементы управления
            ProgressBarBubbleSort.Value = 0;
            btnCreateMass.Enabled = true;
        }

        // Завершение потока сортировки вставками
        private void BWInsertSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Если была отмена сортировки
            if (fCancelInsSort)
            {
                labelProgressInsertSort.Text = "";
                fCancelInsSort = false;
            }
            else
            {
                labelProgressInsertSort.Text = StopTime(tsIns);
                DisplayArray(labelProgressInsertSort.Text, LBInsertSort);
            }

            // Настроить другие элементы управления
            ProgressBarInsertSort.Value = 0;
            btnCreateMass.Enabled = true;
        }

        // Завершение сортировки выбором
        private void BWSelectSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Если была отмена сортировки
            if (fCancelSelSort)
            {
                labelProgressSelectionSort.Text = "";
                fCancelSelSort = false;
            }
            else
            {
                labelProgressSelectionSort.Text = StopTime(tsSel);
                DisplayArray(labelProgressSelectionSort.Text, LBSelectSort);
            }

            // Настроить другие элементы управления
            ProgressBarSelectionSort.Value = 0;
            btnCreateMass.Enabled = true;
        }


        // Завершение шейкерной сортировки
        private void BWShakerSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Если была отмена сортировки
            if (fCancelShakerSort)
            {
                labelProgressShakerSort.Text = "";
                fCancelShakerSort = false;
            }
            else
            {
                labelProgressShakerSort.Text = StopTime(tsShaker);
                DisplayArray(labelProgressShakerSort.Text, LBShakerSort);
            }

            // Настроить другие элементы управления
            ProgressBarShakerSort.Value = 0;
            btnCreateMass.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();

        }

        private void labelBubbleSort_Click(object sender, EventArgs e)
        {

        }

        
    }
}

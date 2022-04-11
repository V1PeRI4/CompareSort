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
        //int[] arrayBub;
        //int[] arrayIns;    // сортировки вставкой
        //int[] arraySel;    // сортировки выбором
        int countElOfMass;

        TimeSpan tsBubble; // пузырька время начала
        TimeSpan tsIns;    // вставка
        TimeSpan tsSel;    // выбор

        bool fCancelBubSort = false; // булы для стопа сортировок
        bool fCancelInsSort = false;
        bool fCancelSelSort = false;

        /*--------------------------Обьявление формы--------------------------*/
        public Form1()
        {
            InitializeComponent();

            ClearProgressBar();
            // Деактивировать панель результатов
            panelResult.Enabled = false;
        }

        // Обнуление значений в progressBar'ах
        private void ClearProgressBar()
        {
            ProgressBarBubSort.Value = 0;
            ProgressBarInsertSort.Value = 0;
            ProgressBarSelectionSort.Value = 0;
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
        // Метод очистки результатов к кнопке создания
        private void CleanResultValue()
        {
            labelProgressBubSort.Text = "";
            labelProgressInsertSort.Text = "";
            labelProgressSelectionSort.Text = "";
            LBBubSort.Items.Clear();
            LBInsertSort.Items.Clear();
            LBSelectSort.Items.Clear();
        }


        // Кнопка Сортировки - запустить потоки на выполнение
        private void btnSortMass_Click(object sender, EventArgs e)
        {
            btnCreateMass.Enabled = false;

            // Запуск методов сортировки в потоках
            if (!backgroundWorker2.IsBusy)
                backgroundWorker2.RunWorkerAsync();
            if (!backgroundWorker3.IsBusy)
                backgroundWorker3.RunWorkerAsync();
            if (!backgroundWorker4.IsBusy)
                backgroundWorker4.RunWorkerAsync();
        }

        // Кнопка Остановки - отменить выполнение всех потоков
        private void btnStopSort_Click(object sender, EventArgs e)
        {
            try
            {
                backgroundWorker2.CancelAsync(); // остановить сортировку пузырьком
                backgroundWorker3.CancelAsync(); // остановить сортировку вставками
                backgroundWorker4.CancelAsync(); // остановить сортировку выбором
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

        // Внутренний метод, который отображает массив в элементе управления типа ListBox
        private void DisplayArray(string A, ListBox LB)
        {
            LB.Items.Add(A);
        }

        // Остановка метода и возвращение времени выполнения
        private string StopTime(TimeSpan methodTime)
        {
            //Зафиксировать время и вывести его 
            TimeSpan time = new TimeSpan(DateTime.Now.Ticks) - methodTime;
            string result = String.Format("{0}:{1}:{2}", time.Minutes,
                time.Seconds, time.Milliseconds);
            return result;

        }


        /*--------------------------Background work'еры (кнопки и сортировки)--------------------------*/

        ////////////////// Генерация массива
        private void BWGenerateMass_DoWork(object sender, DoWorkEventArgs e)
        {
            // 2. Получить количество элементов в массиве
            int n;
            if (RBNum1000.Checked == true) { n = 1000; }
            else if (RBNum10000.Checked == true) { n = 10000; }
            else if (RBNum100000.Checked == true) { n = 100000; }
            else if (RBNum1000000.Checked == true) { n = 1000000; }
            else { n = 0; }
            countElOfMass = n;

            array = new int[n];
            //arrayBub = new int[n];
            //arrayIns = new int[n];
            //arraySel = new int[n];

            // 1. Объявление внутренних переменных
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, n); // случайное число
                /*arrayBub[i] = arraySel[i] = arrayIns[i] = array[i]; */ // скопировать это число

                // Вызвать отображение прогресса (изменения) выполнения потока
                try
                {
                    BWGenerateMass.ReportProgress((i * 100) / n);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            
        }
        // После завершения Генерации массива
        private void BWGenerateMass_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (array.Length > 0)
                panelResult.Enabled = true;
            else MessageBox.Show("Выберите длинну массива");

        }


        ////////////////// Сортировка методом пузырька - поток
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] arrayBub = new int[countElOfMass];
            array.CopyTo(arrayBub, 0);
            // Сортируется массив arrayBub

            int x;

            tsBubble = new TimeSpan(DateTime.Now.Ticks);

            for (int i = 0; i < arrayBub.Length; i++)
            {

                for (int j = arrayBub.Length - 1; j > i; j--)
                {
                    if (arrayBub[j - 1] > arrayBub[j]) // сортировка по возрастанию
                    {
                        x = arrayBub[j];
                        arrayBub[j] = arrayBub[j - 1];
                        arrayBub[j - 1] = x;
                    }
                }

                // Отобразить изменение прогресса
                try
                {
                    backgroundWorker2.ReportProgress((i * 100) / arrayBub.Length);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                // Проверка, был ли остановлен поток
                if (backgroundWorker2.CancellationPending)
                {
                    fCancelBubSort = true;
                    break;
                }
            }
        }


        ////////////////// Сортировка вставками
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] arrayIns = new int[countElOfMass];
            array.CopyTo(arrayIns, 0);

            int x, j;

            tsIns = new TimeSpan(DateTime.Now.Ticks);

            for (int i = 0; i < arrayIns.Length; i++)
            {
                x = arrayIns[i];

                for (j = i - 1; j >= 0 && arrayIns[j] > x; j--)
                    arrayIns[j + 1] = arrayIns[j]; // сдвинуть элемент вправо
                arrayIns[j + 1] = x;

                // Отобразить изменение прогресса
                try
                {
                    backgroundWorker3.ReportProgress((i * 100) / arrayIns.Length);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                // Проверка, был ли остановлен поток
                if (backgroundWorker3.CancellationPending)
                {
                    fCancelInsSort = true;
                    break;
                }
            }


        }

        // Сортировка выбором
        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] arraySel = new int[countElOfMass];
            array.CopyTo(arraySel, 0);

            int j, k;
            int x;

            tsSel = new TimeSpan(DateTime.Now.Ticks);

            for (int i = 0; i < arraySel.Length; i++)
            {
                k = i;

                // поиск наименьшего элемента
                x = arraySel[i];

                for (j = i + 1; j < arraySel.Length; j++)
                    if (arraySel[j] < x)
                    {
                        k = j; // k - индекс наименьшего элемента
                        x = arraySel[j];
                    }
                // поменять местами наименьший элемент с arraySel[i]
                arraySel[k] = arraySel[i];
                arraySel[i] = x;




                // Отобразить изменение прогресса
                //ViewProgressChange(backgroundWorker4, arraySel, i);
                try
                {
                    backgroundWorker4.ReportProgress((i * 100) / arraySel.Length);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                // Проверка, был ли остановлен поток
                if (backgroundWorker4.CancellationPending)
                {
                    fCancelSelSort = true;
                    break;
                }
            }
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

        // Изменение прогресса в методе сортировки пузырьком
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgressBubSort.Text = Convert.ToString(e.ProgressPercentage) + " %";
            ProgressBarBubSort.Value = e.ProgressPercentage;
        }


        // Прогресс для метода сортировки вставками
        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgressInsertSort.Text = Convert.ToString(e.ProgressPercentage) + " %";
            ProgressBarInsertSort.Value = e.ProgressPercentage;
        }

        // Изменение прогресса для алгоритма сортировки выбором
        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelProgressSelectionSort.Text = Convert.ToString(e.ProgressPercentage) + " %";
            ProgressBarSelectionSort.Value = e.ProgressPercentage;
        }

        

        // Завершение сортировки методом пузырька - выполнить конечные операции
        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
                DisplayArray(labelProgressBubSort.Text, LBBubSort);
            }

            // Настроить другие элементы управления
            ProgressBarBubSort.Value = 0;
            btnCreateMass.Enabled = true;
        }

        // Завершение потока сортировки вставками
        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
    }
}

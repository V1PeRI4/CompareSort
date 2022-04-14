namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelQuantityElMass = new System.Windows.Forms.Label();
            this.labelBubbleSort = new System.Windows.Forms.Label();
            this.labelInsertSort = new System.Windows.Forms.Label();
            this.labelSelectSort = new System.Windows.Forms.Label();
            this.labelProgressBubSort = new System.Windows.Forms.Label();
            this.labelProgressInsertSort = new System.Windows.Forms.Label();
            this.labelProgressSelectionSort = new System.Windows.Forms.Label();
            this.LBBubbleSort = new System.Windows.Forms.ListBox();
            this.LBInsertSort = new System.Windows.Forms.ListBox();
            this.LBSelectSort = new System.Windows.Forms.ListBox();
            this.btnCreateMass = new System.Windows.Forms.Button();
            this.btnSortMass = new System.Windows.Forms.Button();
            this.btnStopSort = new System.Windows.Forms.Button();
            this.ProgressBarBubbleSort = new System.Windows.Forms.ProgressBar();
            this.ProgressBarInsertSort = new System.Windows.Forms.ProgressBar();
            this.ProgressBarSelectionSort = new System.Windows.Forms.ProgressBar();
            this.BWGenerateMass = new System.ComponentModel.BackgroundWorker();
            this.BWBubSort = new System.ComponentModel.BackgroundWorker();
            this.BWInsertSort = new System.ComponentModel.BackgroundWorker();
            this.BWSelectSort = new System.ComponentModel.BackgroundWorker();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelProgressShakerSort = new System.Windows.Forms.Label();
            this.LBShakerSort = new System.Windows.Forms.ListBox();
            this.ProgressBarShakerSort = new System.Windows.Forms.ProgressBar();
            this.labelShakerSort = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.CBSelectSort = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RBRandomNum = new System.Windows.Forms.RadioButton();
            this.RBSortMass = new System.Windows.Forms.RadioButton();
            this.RBReverseSortMass = new System.Windows.Forms.RadioButton();
            this.RBChangeInPermutation = new System.Windows.Forms.RadioButton();
            this.RBSwapsMass = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RBNum1000 = new System.Windows.Forms.RadioButton();
            this.RBNum10000 = new System.Windows.Forms.RadioButton();
            this.RBNum100000 = new System.Windows.Forms.RadioButton();
            this.RBNum1000000 = new System.Windows.Forms.RadioButton();
            this.labelTypeData = new System.Windows.Forms.Label();
            this.BWShakerSort = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.panelResult.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuantityElMass
            // 
            this.labelQuantityElMass.AutoSize = true;
            this.labelQuantityElMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelQuantityElMass.Location = new System.Drawing.Point(32, 23);
            this.labelQuantityElMass.Name = "labelQuantityElMass";
            this.labelQuantityElMass.Size = new System.Drawing.Size(259, 20);
            this.labelQuantityElMass.TabIndex = 0;
            this.labelQuantityElMass.Text = "Количество элементов массива:";
            // 
            // labelBubbleSort
            // 
            this.labelBubbleSort.AutoSize = true;
            this.labelBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBubbleSort.Location = new System.Drawing.Point(15, 21);
            this.labelBubbleSort.Name = "labelBubbleSort";
            this.labelBubbleSort.Size = new System.Drawing.Size(201, 20);
            this.labelBubbleSort.TabIndex = 1;
            this.labelBubbleSort.Text = "Пузырьковая сортировка";
            this.labelBubbleSort.Click += new System.EventHandler(this.labelBubbleSort_Click);
            // 
            // labelInsertSort
            // 
            this.labelInsertSort.AutoSize = true;
            this.labelInsertSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInsertSort.Location = new System.Drawing.Point(241, 21);
            this.labelInsertSort.Name = "labelInsertSort";
            this.labelInsertSort.Size = new System.Drawing.Size(185, 20);
            this.labelInsertSort.TabIndex = 2;
            this.labelInsertSort.Text = "Сортировка вставками";
            // 
            // labelSelectSort
            // 
            this.labelSelectSort.AutoSize = true;
            this.labelSelectSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelectSort.Location = new System.Drawing.Point(449, 21);
            this.labelSelectSort.Name = "labelSelectSort";
            this.labelSelectSort.Size = new System.Drawing.Size(171, 20);
            this.labelSelectSort.TabIndex = 3;
            this.labelSelectSort.Text = "Сортировка выбором";
            // 
            // labelProgressBubSort
            // 
            this.labelProgressBubSort.AutoSize = true;
            this.labelProgressBubSort.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressBubSort.Location = new System.Drawing.Point(98, 158);
            this.labelProgressBubSort.Name = "labelProgressBubSort";
            this.labelProgressBubSort.Size = new System.Drawing.Size(25, 13);
            this.labelProgressBubSort.TabIndex = 4;
            this.labelProgressBubSort.Text = "123";
            // 
            // labelProgressInsertSort
            // 
            this.labelProgressInsertSort.AutoSize = true;
            this.labelProgressInsertSort.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressInsertSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProgressInsertSort.Location = new System.Drawing.Point(317, 158);
            this.labelProgressInsertSort.Name = "labelProgressInsertSort";
            this.labelProgressInsertSort.Size = new System.Drawing.Size(25, 13);
            this.labelProgressInsertSort.TabIndex = 5;
            this.labelProgressInsertSort.Text = "123";
            // 
            // labelProgressSelectionSort
            // 
            this.labelProgressSelectionSort.AutoSize = true;
            this.labelProgressSelectionSort.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressSelectionSort.Location = new System.Drawing.Point(518, 158);
            this.labelProgressSelectionSort.Name = "labelProgressSelectionSort";
            this.labelProgressSelectionSort.Size = new System.Drawing.Size(25, 13);
            this.labelProgressSelectionSort.TabIndex = 6;
            this.labelProgressSelectionSort.Text = "123";
            // 
            // LBBubbleSort
            // 
            this.LBBubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBBubbleSort.FormattingEnabled = true;
            this.LBBubbleSort.ItemHeight = 20;
            this.LBBubbleSort.Location = new System.Drawing.Point(52, 58);
            this.LBBubbleSort.Name = "LBBubbleSort";
            this.LBBubbleSort.Size = new System.Drawing.Size(120, 84);
            this.LBBubbleSort.TabIndex = 7;
            // 
            // LBInsertSort
            // 
            this.LBInsertSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBInsertSort.FormattingEnabled = true;
            this.LBInsertSort.ItemHeight = 20;
            this.LBInsertSort.Location = new System.Drawing.Point(268, 58);
            this.LBInsertSort.Name = "LBInsertSort";
            this.LBInsertSort.Size = new System.Drawing.Size(120, 84);
            this.LBInsertSort.TabIndex = 8;
            // 
            // LBSelectSort
            // 
            this.LBSelectSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBSelectSort.FormattingEnabled = true;
            this.LBSelectSort.ItemHeight = 20;
            this.LBSelectSort.Location = new System.Drawing.Point(472, 58);
            this.LBSelectSort.Name = "LBSelectSort";
            this.LBSelectSort.Size = new System.Drawing.Size(120, 84);
            this.LBSelectSort.TabIndex = 9;
            // 
            // btnCreateMass
            // 
            this.btnCreateMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateMass.Location = new System.Drawing.Point(3, 3);
            this.btnCreateMass.Name = "btnCreateMass";
            this.btnCreateMass.Size = new System.Drawing.Size(168, 32);
            this.btnCreateMass.TabIndex = 10;
            this.btnCreateMass.Text = "Создать массив";
            this.btnCreateMass.UseVisualStyleBackColor = true;
            this.btnCreateMass.Click += new System.EventHandler(this.btnCreateMass_Click);
            // 
            // btnSortMass
            // 
            this.btnSortMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSortMass.Location = new System.Drawing.Point(177, 3);
            this.btnSortMass.Name = "btnSortMass";
            this.btnSortMass.Size = new System.Drawing.Size(132, 32);
            this.btnSortMass.TabIndex = 11;
            this.btnSortMass.Text = "Сортировать";
            this.btnSortMass.UseVisualStyleBackColor = true;
            this.btnSortMass.Click += new System.EventHandler(this.btnSortMass_Click);
            // 
            // btnStopSort
            // 
            this.btnStopSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStopSort.Location = new System.Drawing.Point(3, 41);
            this.btnStopSort.Name = "btnStopSort";
            this.btnStopSort.Size = new System.Drawing.Size(217, 32);
            this.btnStopSort.TabIndex = 12;
            this.btnStopSort.Text = "Остановить сортировку";
            this.btnStopSort.UseVisualStyleBackColor = true;
            this.btnStopSort.Click += new System.EventHandler(this.btnStopSort_Click);
            // 
            // ProgressBarBubbleSort
            // 
            this.ProgressBarBubbleSort.Location = new System.Drawing.Point(52, 148);
            this.ProgressBarBubbleSort.Name = "ProgressBarBubbleSort";
            this.ProgressBarBubbleSort.Size = new System.Drawing.Size(120, 30);
            this.ProgressBarBubbleSort.TabIndex = 13;
            // 
            // ProgressBarInsertSort
            // 
            this.ProgressBarInsertSort.Location = new System.Drawing.Point(268, 148);
            this.ProgressBarInsertSort.Name = "ProgressBarInsertSort";
            this.ProgressBarInsertSort.Size = new System.Drawing.Size(119, 32);
            this.ProgressBarInsertSort.TabIndex = 14;
            // 
            // ProgressBarSelectionSort
            // 
            this.ProgressBarSelectionSort.Location = new System.Drawing.Point(472, 148);
            this.ProgressBarSelectionSort.Name = "ProgressBarSelectionSort";
            this.ProgressBarSelectionSort.Size = new System.Drawing.Size(120, 32);
            this.ProgressBarSelectionSort.TabIndex = 15;
            // 
            // BWGenerateMass
            // 
            this.BWGenerateMass.WorkerReportsProgress = true;
            this.BWGenerateMass.WorkerSupportsCancellation = true;
            this.BWGenerateMass.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWGenerateMass_DoWork);
            this.BWGenerateMass.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWGenerateMass_RunWorkerCompleted);
            // 
            // BWBubSort
            // 
            this.BWBubSort.WorkerReportsProgress = true;
            this.BWBubSort.WorkerSupportsCancellation = true;
            this.BWBubSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWBubbleSort_DoWork);
            this.BWBubSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWBubbleSort_ProgressChanged);
            this.BWBubSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWBubbleSort_RunWorkerCompleted);
            // 
            // BWInsertSort
            // 
            this.BWInsertSort.WorkerReportsProgress = true;
            this.BWInsertSort.WorkerSupportsCancellation = true;
            this.BWInsertSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWInsertSort_DoWork);
            this.BWInsertSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWInsertSort_ProgressChanged);
            this.BWInsertSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWInsertSort_RunWorkerCompleted);
            // 
            // BWSelectSort
            // 
            this.BWSelectSort.WorkerReportsProgress = true;
            this.BWSelectSort.WorkerSupportsCancellation = true;
            this.BWSelectSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWSelectSort_DoWork);
            this.BWSelectSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWSelectSort_ProgressChanged);
            this.BWSelectSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWSelectSort_RunWorkerCompleted);
            // 
            // panelResult
            // 
            this.panelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelResult.Controls.Add(this.labelProgressSelectionSort);
            this.panelResult.Controls.Add(this.ProgressBarSelectionSort);
            this.panelResult.Controls.Add(this.labelProgressShakerSort);
            this.panelResult.Controls.Add(this.LBShakerSort);
            this.panelResult.Controls.Add(this.labelShakerSort);
            this.panelResult.Controls.Add(this.labelProgressInsertSort);
            this.panelResult.Controls.Add(this.ProgressBarShakerSort);
            this.panelResult.Controls.Add(this.labelProgressBubSort);
            this.panelResult.Controls.Add(this.LBSelectSort);
            this.panelResult.Controls.Add(this.labelBubbleSort);
            this.panelResult.Controls.Add(this.labelInsertSort);
            this.panelResult.Controls.Add(this.ProgressBarInsertSort);
            this.panelResult.Controls.Add(this.labelSelectSort);
            this.panelResult.Controls.Add(this.ProgressBarBubbleSort);
            this.panelResult.Controls.Add(this.LBBubbleSort);
            this.panelResult.Controls.Add(this.LBInsertSort);
            this.panelResult.Location = new System.Drawing.Point(14, 256);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(851, 231);
            this.panelResult.TabIndex = 17;
            // 
            // labelProgressShakerSort
            // 
            this.labelProgressShakerSort.AutoSize = true;
            this.labelProgressShakerSort.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressShakerSort.Location = new System.Drawing.Point(729, 158);
            this.labelProgressShakerSort.Name = "labelProgressShakerSort";
            this.labelProgressShakerSort.Size = new System.Drawing.Size(25, 13);
            this.labelProgressShakerSort.TabIndex = 17;
            this.labelProgressShakerSort.Text = "123";
            // 
            // LBShakerSort
            // 
            this.LBShakerSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBShakerSort.FormattingEnabled = true;
            this.LBShakerSort.ItemHeight = 20;
            this.LBShakerSort.Location = new System.Drawing.Point(681, 58);
            this.LBShakerSort.Name = "LBShakerSort";
            this.LBShakerSort.Size = new System.Drawing.Size(120, 84);
            this.LBShakerSort.TabIndex = 18;
            // 
            // ProgressBarShakerSort
            // 
            this.ProgressBarShakerSort.Location = new System.Drawing.Point(681, 148);
            this.ProgressBarShakerSort.Name = "ProgressBarShakerSort";
            this.ProgressBarShakerSort.Size = new System.Drawing.Size(120, 32);
            this.ProgressBarShakerSort.TabIndex = 19;
            // 
            // labelShakerSort
            // 
            this.labelShakerSort.AutoSize = true;
            this.labelShakerSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelShakerSort.Location = new System.Drawing.Point(646, 21);
            this.labelShakerSort.Name = "labelShakerSort";
            this.labelShakerSort.Size = new System.Drawing.Size(185, 20);
            this.labelShakerSort.TabIndex = 16;
            this.labelShakerSort.Text = "Шейкерная сортировка";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.CBSelectSort);
            this.panelMain.Controls.Add(this.flowLayoutPanel3);
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Controls.Add(this.labelTypeData);
            this.panelMain.Controls.Add(this.labelQuantityElMass);
            this.panelMain.Location = new System.Drawing.Point(14, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(851, 204);
            this.panelMain.TabIndex = 18;
            // 
            // CBSelectSort
            // 
            this.CBSelectSort.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CBSelectSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CBSelectSort.FormattingEnabled = true;
            this.CBSelectSort.Items.AddRange(new object[] {
            "Случайные числа",
            "Отсортированный массив",
            "Обратно отсортированный",
            "Изменения в перестановке",
            "Свопы"});
            this.CBSelectSort.Location = new System.Drawing.Point(339, 58);
            this.CBSelectSort.Name = "CBSelectSort";
            this.CBSelectSort.Size = new System.Drawing.Size(359, 28);
            this.CBSelectSort.TabIndex = 30;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnCreateMass);
            this.flowLayoutPanel3.Controls.Add(this.btnSortMass);
            this.flowLayoutPanel3.Controls.Add(this.btnStopSort);
            this.flowLayoutPanel3.Controls.Add(this.btnClearListBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(36, 102);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(522, 80);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearListBox.Location = new System.Drawing.Point(226, 41);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(287, 32);
            this.btnClearListBox.TabIndex = 17;
            this.btnClearListBox.Text = "Очистить списки результатов";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.btnClearListBox_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.RBRandomNum);
            this.flowLayoutPanel2.Controls.Add(this.RBSortMass);
            this.flowLayoutPanel2.Controls.Add(this.RBReverseSortMass);
            this.flowLayoutPanel2.Controls.Add(this.RBChangeInPermutation);
            this.flowLayoutPanel2.Controls.Add(this.RBSwapsMass);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(891, 111);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(535, 105);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // RBRandomNum
            // 
            this.RBRandomNum.AutoSize = true;
            this.RBRandomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RBRandomNum.Location = new System.Drawing.Point(3, 3);
            this.RBRandomNum.Name = "RBRandomNum";
            this.RBRandomNum.Size = new System.Drawing.Size(112, 17);
            this.RBRandomNum.TabIndex = 23;
            this.RBRandomNum.TabStop = true;
            this.RBRandomNum.Text = "Случайные числа";
            this.RBRandomNum.UseVisualStyleBackColor = true;
            // 
            // RBSortMass
            // 
            this.RBSortMass.AutoSize = true;
            this.RBSortMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RBSortMass.Location = new System.Drawing.Point(121, 3);
            this.RBSortMass.Name = "RBSortMass";
            this.RBSortMass.Size = new System.Drawing.Size(158, 17);
            this.RBSortMass.TabIndex = 22;
            this.RBSortMass.TabStop = true;
            this.RBSortMass.Text = "Отсортированный массив";
            this.RBSortMass.UseVisualStyleBackColor = true;
            // 
            // RBReverseSortMass
            // 
            this.RBReverseSortMass.AutoSize = true;
            this.RBReverseSortMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RBReverseSortMass.Location = new System.Drawing.Point(285, 3);
            this.RBReverseSortMass.Name = "RBReverseSortMass";
            this.RBReverseSortMass.Size = new System.Drawing.Size(161, 17);
            this.RBReverseSortMass.TabIndex = 26;
            this.RBReverseSortMass.TabStop = true;
            this.RBReverseSortMass.Text = "Обратно отсортированный";
            this.RBReverseSortMass.UseVisualStyleBackColor = true;
            // 
            // RBChangeInPermutation
            // 
            this.RBChangeInPermutation.AutoSize = true;
            this.RBChangeInPermutation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RBChangeInPermutation.Location = new System.Drawing.Point(3, 26);
            this.RBChangeInPermutation.Name = "RBChangeInPermutation";
            this.RBChangeInPermutation.Size = new System.Drawing.Size(166, 17);
            this.RBChangeInPermutation.TabIndex = 24;
            this.RBChangeInPermutation.TabStop = true;
            this.RBChangeInPermutation.Text = "Изменения в перестановке";
            this.RBChangeInPermutation.UseVisualStyleBackColor = true;
            // 
            // RBSwapsMass
            // 
            this.RBSwapsMass.AutoSize = true;
            this.RBSwapsMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.RBSwapsMass.Location = new System.Drawing.Point(175, 26);
            this.RBSwapsMass.Name = "RBSwapsMass";
            this.RBSwapsMass.Size = new System.Drawing.Size(58, 17);
            this.RBSwapsMass.TabIndex = 25;
            this.RBSwapsMass.TabStop = true;
            this.RBSwapsMass.Text = "Свопы";
            this.RBSwapsMass.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RBNum1000);
            this.flowLayoutPanel1.Controls.Add(this.RBNum10000);
            this.flowLayoutPanel1.Controls.Add(this.RBNum100000);
            this.flowLayoutPanel1.Controls.Add(this.RBNum1000000);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(339, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 33);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // RBNum1000
            // 
            this.RBNum1000.AutoSize = true;
            this.RBNum1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RBNum1000.Location = new System.Drawing.Point(3, 3);
            this.RBNum1000.Name = "RBNum1000";
            this.RBNum1000.Size = new System.Drawing.Size(63, 24);
            this.RBNum1000.TabIndex = 18;
            this.RBNum1000.Text = "1000";
            this.RBNum1000.UseVisualStyleBackColor = true;
            // 
            // RBNum10000
            // 
            this.RBNum10000.AutoSize = true;
            this.RBNum10000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RBNum10000.Location = new System.Drawing.Point(72, 3);
            this.RBNum10000.Name = "RBNum10000";
            this.RBNum10000.Size = new System.Drawing.Size(72, 24);
            this.RBNum10000.TabIndex = 19;
            this.RBNum10000.Text = "10000";
            this.RBNum10000.UseVisualStyleBackColor = true;
            // 
            // RBNum100000
            // 
            this.RBNum100000.AutoSize = true;
            this.RBNum100000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RBNum100000.Location = new System.Drawing.Point(150, 3);
            this.RBNum100000.Name = "RBNum100000";
            this.RBNum100000.Size = new System.Drawing.Size(61, 24);
            this.RBNum100000.TabIndex = 20;
            this.RBNum100000.Text = "10^5";
            this.RBNum100000.UseVisualStyleBackColor = true;
            // 
            // RBNum1000000
            // 
            this.RBNum1000000.AutoSize = true;
            this.RBNum1000000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RBNum1000000.Location = new System.Drawing.Point(217, 3);
            this.RBNum1000000.Name = "RBNum1000000";
            this.RBNum1000000.Size = new System.Drawing.Size(61, 24);
            this.RBNum1000000.TabIndex = 21;
            this.RBNum1000000.TabStop = true;
            this.RBNum1000000.Text = "10^6";
            this.RBNum1000000.UseVisualStyleBackColor = true;
            // 
            // labelTypeData
            // 
            this.labelTypeData.AutoSize = true;
            this.labelTypeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTypeData.Location = new System.Drawing.Point(32, 57);
            this.labelTypeData.Name = "labelTypeData";
            this.labelTypeData.Size = new System.Drawing.Size(178, 20);
            this.labelTypeData.TabIndex = 26;
            this.labelTypeData.Text = "Тип входящих данных:";
            // 
            // BWShakerSort
            // 
            this.BWShakerSort.WorkerReportsProgress = true;
            this.BWShakerSort.WorkerSupportsCancellation = true;
            this.BWShakerSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWShakerSort_DoWork);
            this.BWShakerSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWShakerSort_ProgressChanged);
            this.BWShakerSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWShakerSort_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(701, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 61);
            this.button1.TabIndex = 20;
            this.button1.Text = "Справка по сортировкам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 509);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelResult);
            this.MinimumSize = new System.Drawing.Size(895, 512);
            this.Name = "Form1";
            this.Text = "Сортировка массивов";
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuantityElMass;
        private System.Windows.Forms.Label labelBubbleSort;
        private System.Windows.Forms.Label labelInsertSort;
        private System.Windows.Forms.Label labelSelectSort;
        private System.Windows.Forms.Label labelProgressBubSort;
        private System.Windows.Forms.Label labelProgressInsertSort;
        private System.Windows.Forms.Label labelProgressSelectionSort;
        private System.Windows.Forms.ListBox LBBubbleSort;
        private System.Windows.Forms.ListBox LBInsertSort;
        private System.Windows.Forms.ListBox LBSelectSort;
        private System.Windows.Forms.Button btnCreateMass;
        private System.Windows.Forms.Button btnSortMass;
        private System.Windows.Forms.Button btnStopSort;
        private System.Windows.Forms.ProgressBar ProgressBarBubbleSort;
        private System.Windows.Forms.ProgressBar ProgressBarInsertSort;
        private System.Windows.Forms.ProgressBar ProgressBarSelectionSort;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnClearListBox;
        private System.Windows.Forms.RadioButton RBNum10000;
        private System.Windows.Forms.RadioButton RBNum1000;
        private System.Windows.Forms.RadioButton RBNum100000;
        private System.Windows.Forms.Label labelProgressShakerSort;
        private System.Windows.Forms.ListBox LBShakerSort;
        private System.Windows.Forms.ProgressBar ProgressBarShakerSort;
        private System.Windows.Forms.Label labelShakerSort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton RBRandomNum;
        private System.Windows.Forms.RadioButton RBSortMass;
        private System.Windows.Forms.RadioButton RBChangeInPermutation;
        private System.Windows.Forms.RadioButton RBSwapsMass;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RBNum1000000;
        private System.Windows.Forms.Label labelTypeData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        protected System.ComponentModel.BackgroundWorker BWGenerateMass;
        protected System.ComponentModel.BackgroundWorker BWBubSort;
        protected System.ComponentModel.BackgroundWorker BWInsertSort;
        protected System.ComponentModel.BackgroundWorker BWSelectSort;
        protected System.ComponentModel.BackgroundWorker BWShakerSort;
        private System.Windows.Forms.RadioButton RBReverseSortMass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBSelectSort;
    }
}


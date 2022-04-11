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
            this.LabelShakerSort = new System.Windows.Forms.Label();
            this.LBShakerSort = new System.Windows.Forms.ListBox();
            this.ProgressBarShakerSort = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RBRandomNum = new System.Windows.Forms.RadioButton();
            this.RBPartialSortMass = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.RBSwapsMass = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RBNum1000 = new System.Windows.Forms.RadioButton();
            this.RBNum10000 = new System.Windows.Forms.RadioButton();
            this.RBNum100000 = new System.Windows.Forms.RadioButton();
            this.RBNum1000000 = new System.Windows.Forms.RadioButton();
            this.labelTypeData = new System.Windows.Forms.Label();
            this.BWShakerSort = new System.ComponentModel.BackgroundWorker();
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
            this.labelQuantityElMass.Location = new System.Drawing.Point(32, 23);
            this.labelQuantityElMass.Name = "labelQuantityElMass";
            this.labelQuantityElMass.Size = new System.Drawing.Size(174, 13);
            this.labelQuantityElMass.TabIndex = 0;
            this.labelQuantityElMass.Text = "Количество элементов массива:";
            // 
            // labelBubbleSort
            // 
            this.labelBubbleSort.AutoSize = true;
            this.labelBubbleSort.Location = new System.Drawing.Point(36, 26);
            this.labelBubbleSort.Name = "labelBubbleSort";
            this.labelBubbleSort.Size = new System.Drawing.Size(138, 13);
            this.labelBubbleSort.TabIndex = 1;
            this.labelBubbleSort.Text = "Пузырьковая сортировка";
            // 
            // labelInsertSort
            // 
            this.labelInsertSort.AutoSize = true;
            this.labelInsertSort.Location = new System.Drawing.Point(193, 26);
            this.labelInsertSort.Name = "labelInsertSort";
            this.labelInsertSort.Size = new System.Drawing.Size(125, 13);
            this.labelInsertSort.TabIndex = 2;
            this.labelInsertSort.Text = "Сортировка вставками";
            // 
            // labelSelectSort
            // 
            this.labelSelectSort.AutoSize = true;
            this.labelSelectSort.Location = new System.Drawing.Point(347, 26);
            this.labelSelectSort.Name = "labelSelectSort";
            this.labelSelectSort.Size = new System.Drawing.Size(116, 13);
            this.labelSelectSort.TabIndex = 3;
            this.labelSelectSort.Text = "Сортировка выбором";
            // 
            // labelProgressBubSort
            // 
            this.labelProgressBubSort.AutoSize = true;
            this.labelProgressBubSort.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressBubSort.Location = new System.Drawing.Point(81, 168);
            this.labelProgressBubSort.Name = "labelProgressBubSort";
            this.labelProgressBubSort.Size = new System.Drawing.Size(0, 13);
            this.labelProgressBubSort.TabIndex = 4;
            // 
            // labelProgressInsertSort
            // 
            this.labelProgressInsertSort.AutoSize = true;
            this.labelProgressInsertSort.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressInsertSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelProgressInsertSort.Location = new System.Drawing.Point(237, 168);
            this.labelProgressInsertSort.Name = "labelProgressInsertSort";
            this.labelProgressInsertSort.Size = new System.Drawing.Size(0, 13);
            this.labelProgressInsertSort.TabIndex = 5;
            // 
            // labelProgressSelectionSort
            // 
            this.labelProgressSelectionSort.AutoSize = true;
            this.labelProgressSelectionSort.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressSelectionSort.Location = new System.Drawing.Point(392, 168);
            this.labelProgressSelectionSort.Name = "labelProgressSelectionSort";
            this.labelProgressSelectionSort.Size = new System.Drawing.Size(0, 13);
            this.labelProgressSelectionSort.TabIndex = 6;
            // 
            // LBBubbleSort
            // 
            this.LBBubbleSort.FormattingEnabled = true;
            this.LBBubbleSort.Location = new System.Drawing.Point(39, 57);
            this.LBBubbleSort.Name = "LBBubbleSort";
            this.LBBubbleSort.Size = new System.Drawing.Size(120, 95);
            this.LBBubbleSort.TabIndex = 7;
            // 
            // LBInsertSort
            // 
            this.LBInsertSort.FormattingEnabled = true;
            this.LBInsertSort.Location = new System.Drawing.Point(196, 57);
            this.LBInsertSort.Name = "LBInsertSort";
            this.LBInsertSort.Size = new System.Drawing.Size(120, 95);
            this.LBInsertSort.TabIndex = 8;
            // 
            // LBSelectSort
            // 
            this.LBSelectSort.FormattingEnabled = true;
            this.LBSelectSort.Location = new System.Drawing.Point(350, 57);
            this.LBSelectSort.Name = "LBSelectSort";
            this.LBSelectSort.Size = new System.Drawing.Size(120, 95);
            this.LBSelectSort.TabIndex = 9;
            // 
            // btnCreateMass
            // 
            this.btnCreateMass.Location = new System.Drawing.Point(3, 3);
            this.btnCreateMass.Name = "btnCreateMass";
            this.btnCreateMass.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMass.TabIndex = 10;
            this.btnCreateMass.Text = "Создать массив";
            this.btnCreateMass.UseVisualStyleBackColor = true;
            this.btnCreateMass.Click += new System.EventHandler(this.btnCreateMass_Click);
            // 
            // btnSortMass
            // 
            this.btnSortMass.Location = new System.Drawing.Point(84, 3);
            this.btnSortMass.Name = "btnSortMass";
            this.btnSortMass.Size = new System.Drawing.Size(90, 23);
            this.btnSortMass.TabIndex = 11;
            this.btnSortMass.Text = "Сортировать";
            this.btnSortMass.UseVisualStyleBackColor = true;
            this.btnSortMass.Click += new System.EventHandler(this.btnSortMass_Click);
            // 
            // btnStopSort
            // 
            this.btnStopSort.Location = new System.Drawing.Point(180, 3);
            this.btnStopSort.Name = "btnStopSort";
            this.btnStopSort.Size = new System.Drawing.Size(75, 23);
            this.btnStopSort.TabIndex = 12;
            this.btnStopSort.Text = "Остановить сортировку";
            this.btnStopSort.UseVisualStyleBackColor = true;
            this.btnStopSort.Click += new System.EventHandler(this.btnStopSort_Click);
            // 
            // ProgressBarBubbleSort
            // 
            this.ProgressBarBubbleSort.Location = new System.Drawing.Point(49, 158);
            this.ProgressBarBubbleSort.Name = "ProgressBarBubbleSort";
            this.ProgressBarBubbleSort.Size = new System.Drawing.Size(100, 30);
            this.ProgressBarBubbleSort.TabIndex = 13;
            // 
            // ProgressBarInsertSort
            // 
            this.ProgressBarInsertSort.Location = new System.Drawing.Point(206, 158);
            this.ProgressBarInsertSort.Name = "ProgressBarInsertSort";
            this.ProgressBarInsertSort.Size = new System.Drawing.Size(100, 32);
            this.ProgressBarInsertSort.TabIndex = 14;
            // 
            // ProgressBarSelectionSort
            // 
            this.ProgressBarSelectionSort.Location = new System.Drawing.Point(359, 158);
            this.ProgressBarSelectionSort.Name = "ProgressBarSelectionSort";
            this.ProgressBarSelectionSort.Size = new System.Drawing.Size(100, 32);
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
            this.panelResult.Controls.Add(this.LabelShakerSort);
            this.panelResult.Controls.Add(this.LBShakerSort);
            this.panelResult.Controls.Add(this.ProgressBarShakerSort);
            this.panelResult.Controls.Add(this.label8);
            this.panelResult.Controls.Add(this.labelProgressInsertSort);
            this.panelResult.Controls.Add(this.labelProgressSelectionSort);
            this.panelResult.Controls.Add(this.labelProgressBubSort);
            this.panelResult.Controls.Add(this.LBSelectSort);
            this.panelResult.Controls.Add(this.labelBubbleSort);
            this.panelResult.Controls.Add(this.ProgressBarSelectionSort);
            this.panelResult.Controls.Add(this.labelInsertSort);
            this.panelResult.Controls.Add(this.ProgressBarInsertSort);
            this.panelResult.Controls.Add(this.labelSelectSort);
            this.panelResult.Controls.Add(this.ProgressBarBubbleSort);
            this.panelResult.Controls.Add(this.LBBubbleSort);
            this.panelResult.Controls.Add(this.LBInsertSort);
            this.panelResult.Location = new System.Drawing.Point(34, 210);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(802, 231);
            this.panelResult.TabIndex = 17;
            // 
            // LabelShakerSort
            // 
            this.LabelShakerSort.AutoSize = true;
            this.LabelShakerSort.BackColor = System.Drawing.Color.Transparent;
            this.LabelShakerSort.Location = new System.Drawing.Point(549, 168);
            this.LabelShakerSort.Name = "LabelShakerSort";
            this.LabelShakerSort.Size = new System.Drawing.Size(0, 13);
            this.LabelShakerSort.TabIndex = 17;
            // 
            // LBShakerSort
            // 
            this.LBShakerSort.FormattingEnabled = true;
            this.LBShakerSort.Location = new System.Drawing.Point(505, 57);
            this.LBShakerSort.Name = "LBShakerSort";
            this.LBShakerSort.Size = new System.Drawing.Size(120, 95);
            this.LBShakerSort.TabIndex = 18;
            // 
            // ProgressBarShakerSort
            // 
            this.ProgressBarShakerSort.Location = new System.Drawing.Point(515, 158);
            this.ProgressBarShakerSort.Name = "ProgressBarShakerSort";
            this.ProgressBarShakerSort.Size = new System.Drawing.Size(100, 32);
            this.ProgressBarShakerSort.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Шейкерная сортировка";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.flowLayoutPanel3);
            this.panelMain.Controls.Add(this.flowLayoutPanel2);
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Controls.Add(this.labelTypeData);
            this.panelMain.Controls.Add(this.labelQuantityElMass);
            this.panelMain.Location = new System.Drawing.Point(34, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(802, 180);
            this.panelMain.TabIndex = 18;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnCreateMass);
            this.flowLayoutPanel3.Controls.Add(this.btnSortMass);
            this.flowLayoutPanel3.Controls.Add(this.btnStopSort);
            this.flowLayoutPanel3.Controls.Add(this.btnClearListBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(35, 138);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(687, 28);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.Location = new System.Drawing.Point(261, 3);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(187, 23);
            this.btnClearListBox.TabIndex = 17;
            this.btnClearListBox.Text = "Очистить списки результатов";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.btnClearListBox_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.RBRandomNum);
            this.flowLayoutPanel2.Controls.Add(this.RBPartialSortMass);
            this.flowLayoutPanel2.Controls.Add(this.radioButton6);
            this.flowLayoutPanel2.Controls.Add(this.RBSwapsMass);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(209, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(450, 52);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // RBRandomNum
            // 
            this.RBRandomNum.AutoSize = true;
            this.RBRandomNum.Location = new System.Drawing.Point(3, 3);
            this.RBRandomNum.Name = "RBRandomNum";
            this.RBRandomNum.Size = new System.Drawing.Size(112, 17);
            this.RBRandomNum.TabIndex = 23;
            this.RBRandomNum.TabStop = true;
            this.RBRandomNum.Text = "Случайные числа";
            this.RBRandomNum.UseVisualStyleBackColor = true;
            // 
            // RBPartialSortMass
            // 
            this.RBPartialSortMass.AutoSize = true;
            this.RBPartialSortMass.Location = new System.Drawing.Point(121, 3);
            this.RBPartialSortMass.Name = "RBPartialSortMass";
            this.RBPartialSortMass.Size = new System.Drawing.Size(181, 17);
            this.RBPartialSortMass.TabIndex = 22;
            this.RBPartialSortMass.TabStop = true;
            this.RBPartialSortMass.Text = "Частичная отсортированность";
            this.RBPartialSortMass.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 26);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(166, 17);
            this.radioButton6.TabIndex = 24;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Изменения в перестановке";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // RBSwapsMass
            // 
            this.RBSwapsMass.AutoSize = true;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(209, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 29);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // RBNum1000
            // 
            this.RBNum1000.AutoSize = true;
            this.RBNum1000.Location = new System.Drawing.Point(3, 3);
            this.RBNum1000.Name = "RBNum1000";
            this.RBNum1000.Size = new System.Drawing.Size(49, 17);
            this.RBNum1000.TabIndex = 18;
            this.RBNum1000.Text = "1000";
            this.RBNum1000.UseVisualStyleBackColor = true;
            // 
            // RBNum10000
            // 
            this.RBNum10000.AutoSize = true;
            this.RBNum10000.Location = new System.Drawing.Point(58, 3);
            this.RBNum10000.Name = "RBNum10000";
            this.RBNum10000.Size = new System.Drawing.Size(55, 17);
            this.RBNum10000.TabIndex = 19;
            this.RBNum10000.Text = "10000";
            this.RBNum10000.UseVisualStyleBackColor = true;
            // 
            // RBNum100000
            // 
            this.RBNum100000.AutoSize = true;
            this.RBNum100000.Location = new System.Drawing.Point(119, 3);
            this.RBNum100000.Name = "RBNum100000";
            this.RBNum100000.Size = new System.Drawing.Size(49, 17);
            this.RBNum100000.TabIndex = 20;
            this.RBNum100000.Text = "10^4";
            this.RBNum100000.UseVisualStyleBackColor = true;
            // 
            // RBNum1000000
            // 
            this.RBNum1000000.AutoSize = true;
            this.RBNum1000000.Location = new System.Drawing.Point(174, 3);
            this.RBNum1000000.Name = "RBNum1000000";
            this.RBNum1000000.Size = new System.Drawing.Size(49, 17);
            this.RBNum1000000.TabIndex = 21;
            this.RBNum1000000.TabStop = true;
            this.RBNum1000000.Text = "10^5";
            this.RBNum1000000.UseVisualStyleBackColor = true;
            // 
            // labelTypeData
            // 
            this.labelTypeData.AutoSize = true;
            this.labelTypeData.Location = new System.Drawing.Point(32, 57);
            this.labelTypeData.Name = "labelTypeData";
            this.labelTypeData.Size = new System.Drawing.Size(121, 13);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 473);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelResult);
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
        private System.Windows.Forms.Label LabelShakerSort;
        private System.Windows.Forms.ListBox LBShakerSort;
        private System.Windows.Forms.ProgressBar ProgressBarShakerSort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton RBRandomNum;
        private System.Windows.Forms.RadioButton RBPartialSortMass;
        private System.Windows.Forms.RadioButton radioButton6;
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
    }
}


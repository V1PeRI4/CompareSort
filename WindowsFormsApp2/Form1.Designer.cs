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
            this.labelBubSort = new System.Windows.Forms.Label();
            this.labelInsertSort = new System.Windows.Forms.Label();
            this.labelSelectSort = new System.Windows.Forms.Label();
            this.labelProgressBubSort = new System.Windows.Forms.Label();
            this.labelProgressInsertSort = new System.Windows.Forms.Label();
            this.labelProgressSelectionSort = new System.Windows.Forms.Label();
            this.LBBubSort = new System.Windows.Forms.ListBox();
            this.LBInsertSort = new System.Windows.Forms.ListBox();
            this.LBSelectSort = new System.Windows.Forms.ListBox();
            this.btnCreateMass = new System.Windows.Forms.Button();
            this.btnSortMass = new System.Windows.Forms.Button();
            this.btnStopSort = new System.Windows.Forms.Button();
            this.ProgressBarBubSort = new System.Windows.Forms.ProgressBar();
            this.ProgressBarInsertSort = new System.Windows.Forms.ProgressBar();
            this.ProgressBarSelectionSort = new System.Windows.Forms.ProgressBar();
            this.BWGenerateMass = new System.ComponentModel.BackgroundWorker();
            this.BWBubSort = new System.ComponentModel.BackgroundWorker();
            this.BWInsertSort = new System.ComponentModel.BackgroundWorker();
            this.BWSelectSort = new System.ComponentModel.BackgroundWorker();
            this.panelResult = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RBNum1000 = new System.Windows.Forms.RadioButton();
            this.RBNum10000 = new System.Windows.Forms.RadioButton();
            this.RBNum100000 = new System.Windows.Forms.RadioButton();
            this.RBNum1000000 = new System.Windows.Forms.RadioButton();
            this.labelTypeData = new System.Windows.Forms.Label();
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
            // labelBubSort
            // 
            this.labelBubSort.AutoSize = true;
            this.labelBubSort.Location = new System.Drawing.Point(36, 26);
            this.labelBubSort.Name = "labelBubSort";
            this.labelBubSort.Size = new System.Drawing.Size(138, 13);
            this.labelBubSort.TabIndex = 1;
            this.labelBubSort.Text = "Пузырьковая сортировка";
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
            // LBBubSort
            // 
            this.LBBubSort.FormattingEnabled = true;
            this.LBBubSort.Location = new System.Drawing.Point(39, 57);
            this.LBBubSort.Name = "LBBubSort";
            this.LBBubSort.Size = new System.Drawing.Size(120, 95);
            this.LBBubSort.TabIndex = 7;
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
            // ProgressBarBubSort
            // 
            this.ProgressBarBubSort.Location = new System.Drawing.Point(49, 158);
            this.ProgressBarBubSort.Name = "ProgressBarBubSort";
            this.ProgressBarBubSort.Size = new System.Drawing.Size(100, 30);
            this.ProgressBarBubSort.TabIndex = 13;
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
            this.BWBubSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.BWBubSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.BWBubSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // BWInsertSort
            // 
            this.BWInsertSort.WorkerReportsProgress = true;
            this.BWInsertSort.WorkerSupportsCancellation = true;
            this.BWInsertSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.BWInsertSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.BWInsertSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // BWSelectSort
            // 
            this.BWSelectSort.WorkerReportsProgress = true;
            this.BWSelectSort.WorkerSupportsCancellation = true;
            this.BWSelectSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            this.BWSelectSort.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker4_ProgressChanged);
            this.BWSelectSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker4_RunWorkerCompleted);
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.label1);
            this.panelResult.Controls.Add(this.listBox4);
            this.panelResult.Controls.Add(this.progressBar4);
            this.panelResult.Controls.Add(this.label8);
            this.panelResult.Controls.Add(this.labelProgressInsertSort);
            this.panelResult.Controls.Add(this.labelProgressSelectionSort);
            this.panelResult.Controls.Add(this.labelProgressBubSort);
            this.panelResult.Controls.Add(this.LBSelectSort);
            this.panelResult.Controls.Add(this.labelBubSort);
            this.panelResult.Controls.Add(this.ProgressBarSelectionSort);
            this.panelResult.Controls.Add(this.labelInsertSort);
            this.panelResult.Controls.Add(this.ProgressBarInsertSort);
            this.panelResult.Controls.Add(this.labelSelectSort);
            this.panelResult.Controls.Add(this.ProgressBarBubSort);
            this.panelResult.Controls.Add(this.LBBubSort);
            this.panelResult.Controls.Add(this.LBInsertSort);
            this.panelResult.Location = new System.Drawing.Point(34, 210);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(802, 231);
            this.panelResult.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(549, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(505, 57);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 95);
            this.listBox4.TabIndex = 18;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(515, 158);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(100, 32);
            this.progressBar4.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
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
            this.flowLayoutPanel2.Controls.Add(this.radioButton5);
            this.flowLayoutPanel2.Controls.Add(this.radioButton4);
            this.flowLayoutPanel2.Controls.Add(this.radioButton6);
            this.flowLayoutPanel2.Controls.Add(this.radioButton8);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(209, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(450, 52);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(112, 17);
            this.radioButton5.TabIndex = 23;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Случайные числа";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(121, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(181, 17);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Частичная отсортированность";
            this.radioButton4.UseVisualStyleBackColor = true;
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
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(175, 26);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(58, 17);
            this.radioButton8.TabIndex = 25;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Свопы";
            this.radioButton8.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label labelBubSort;
        private System.Windows.Forms.Label labelInsertSort;
        private System.Windows.Forms.Label labelSelectSort;
        private System.Windows.Forms.Label labelProgressBubSort;
        private System.Windows.Forms.Label labelProgressInsertSort;
        private System.Windows.Forms.Label labelProgressSelectionSort;
        private System.Windows.Forms.ListBox LBBubSort;
        private System.Windows.Forms.ListBox LBInsertSort;
        private System.Windows.Forms.ListBox LBSelectSort;
        private System.Windows.Forms.Button btnCreateMass;
        private System.Windows.Forms.Button btnSortMass;
        private System.Windows.Forms.Button btnStopSort;
        private System.Windows.Forms.ProgressBar ProgressBarBubSort;
        private System.Windows.Forms.ProgressBar ProgressBarInsertSort;
        private System.Windows.Forms.ProgressBar ProgressBarSelectionSort;
        private System.ComponentModel.BackgroundWorker BWGenerateMass;
        private System.ComponentModel.BackgroundWorker BWBubSort;
        private System.ComponentModel.BackgroundWorker BWInsertSort;
        private System.ComponentModel.BackgroundWorker BWSelectSort;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnClearListBox;
        private System.Windows.Forms.RadioButton RBNum10000;
        private System.Windows.Forms.RadioButton RBNum1000;
        private System.Windows.Forms.RadioButton RBNum100000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RBNum1000000;
        private System.Windows.Forms.Label labelTypeData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}


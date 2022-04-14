namespace WindowsFormsApp2
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RTBDescription = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBChooseSort = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите сортировку: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(554, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показать справку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RTBDescription
            // 
            this.RTBDescription.BackColor = System.Drawing.SystemColors.Menu;
            this.RTBDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RTBDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RTBDescription.Location = new System.Drawing.Point(24, 90);
            this.RTBDescription.Name = "RTBDescription";
            this.RTBDescription.Size = new System.Drawing.Size(574, 439);
            this.RTBDescription.TabIndex = 6;
            this.RTBDescription.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBChooseSort);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 81);
            this.panel1.TabIndex = 7;
            // 
            // CBChooseSort
            // 
            this.CBChooseSort.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CBChooseSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CBChooseSort.FormattingEnabled = true;
            this.CBChooseSort.Items.AddRange(new object[] {
            "Случайные числа",
            "Отсортированный массив",
            "Обратно отсортированный",
            "Изменения в перестановке",
            "Свопы"});
            this.CBChooseSort.Location = new System.Drawing.Point(189, 29);
            this.CBChooseSort.Name = "CBChooseSort";
            this.CBChooseSort.Size = new System.Drawing.Size(359, 28);
            this.CBChooseSort.TabIndex = 31;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(595, 110);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(538, 439);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.orig;
            this.pictureBox1.Location = new System.Drawing.Point(181, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 260);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RTBDescription);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Info";
            this.Text = "Справка по сортировкам";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.RichTextBox RTBDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBChooseSort;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
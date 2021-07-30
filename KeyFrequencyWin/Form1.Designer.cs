
namespace KeyFrequencyWin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.listViewKey = new System.Windows.Forms.ListView();
            this.chASCII = new System.Windows.Forms.ColumnHeader();
            this.chKey = new System.Windows.Forms.ColumnHeader();
            this.chClickedCount = new System.Windows.Forms.ColumnHeader();
            this.chClickedPercent = new System.Windows.Forms.ColumnHeader();
            this.chPressedCount = new System.Windows.Forms.ColumnHeader();
            this.chPressedPercent = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAscii = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelClickedTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelChar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPressedTotal = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialogRecord = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialogRecord = new System.Windows.Forms.SaveFileDialog();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Location = new System.Drawing.Point(12, 28);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(118, 21);
            this.checkBoxStart.TabIndex = 0;
            this.checkBoxStart.Text = "Start Recording";
            this.checkBoxStart.UseVisualStyleBackColor = true;
            this.checkBoxStart.CheckedChanged += new System.EventHandler(this.checkBoxStart_CheckedChanged);
            // 
            // listViewKey
            // 
            this.listViewKey.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chASCII,
            this.chKey,
            this.chClickedCount,
            this.chClickedPercent,
            this.chPressedCount,
            this.chPressedPercent});
            this.listViewKey.HideSelection = false;
            this.listViewKey.Location = new System.Drawing.Point(128, 0);
            this.listViewKey.Name = "listViewKey";
            this.listViewKey.Size = new System.Drawing.Size(584, 664);
            this.listViewKey.TabIndex = 1;
            this.listViewKey.UseCompatibleStateImageBehavior = false;
            this.listViewKey.View = System.Windows.Forms.View.Details;
            // 
            // chASCII
            // 
            this.chASCII.Text = "ASCII";
            // 
            // chKey
            // 
            this.chKey.Text = "Key";
            this.chKey.Width = 100;
            // 
            // chClickedCount
            // 
            this.chClickedCount.Text = "Clicked Count";
            this.chClickedCount.Width = 100;
            // 
            // chClickedPercent
            // 
            this.chClickedPercent.Text = "Clicked Percent";
            this.chClickedPercent.Width = 110;
            // 
            // chPressedCount
            // 
            this.chPressedCount.Text = "Pressed Count";
            this.chPressedCount.Width = 100;
            // 
            // chPressedPercent
            // 
            this.chPressedPercent.Text = "Pressed Percent";
            this.chPressedPercent.Width = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clicked ASCII:";
            // 
            // labelAscii
            // 
            this.labelAscii.AutoSize = true;
            this.labelAscii.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAscii.ForeColor = System.Drawing.Color.Crimson;
            this.labelAscii.Location = new System.Drawing.Point(12, 78);
            this.labelAscii.Name = "labelAscii";
            this.labelAscii.Size = new System.Drawing.Size(15, 17);
            this.labelAscii.TabIndex = 3;
            this.labelAscii.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 190);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 17);
            this.label.TabIndex = 4;
            this.label.Text = "Clicked Total:";
            // 
            // labelClickedTotal
            // 
            this.labelClickedTotal.AutoSize = true;
            this.labelClickedTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClickedTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelClickedTotal.Location = new System.Drawing.Point(12, 207);
            this.labelClickedTotal.Name = "labelClickedTotal";
            this.labelClickedTotal.Size = new System.Drawing.Size(15, 17);
            this.labelClickedTotal.TabIndex = 5;
            this.labelClickedTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clicked Key:";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKey.ForeColor = System.Drawing.Color.Brown;
            this.labelKey.Location = new System.Drawing.Point(12, 112);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(34, 17);
            this.labelKey.TabIndex = 7;
            this.labelKey.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clicked Char:";
            // 
            // labelChar
            // 
            this.labelChar.AutoSize = true;
            this.labelChar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChar.ForeColor = System.Drawing.Color.IndianRed;
            this.labelChar.Location = new System.Drawing.Point(12, 146);
            this.labelChar.Name = "labelChar";
            this.labelChar.Size = new System.Drawing.Size(34, 17);
            this.labelChar.TabIndex = 9;
            this.labelChar.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pressed Total:";
            // 
            // labelPressedTotal
            // 
            this.labelPressedTotal.AutoSize = true;
            this.labelPressedTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPressedTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPressedTotal.Location = new System.Drawing.Point(12, 241);
            this.labelPressedTotal.Name = "labelPressedTotal";
            this.labelPressedTotal.Size = new System.Drawing.Size(15, 17);
            this.labelPressedTotal.TabIndex = 11;
            this.labelPressedTotal.Text = "0";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 27);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save Record";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Start time:";
            // 
            // openFileDialogRecord
            // 
            this.openFileDialogRecord.FileName = " Record.csv";
            this.openFileDialogRecord.Filter = "CSV File|*.csv";
            this.openFileDialogRecord.Title = " Load a record(CSV file).";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 379);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(101, 30);
            this.buttonLoad.TabIndex = 15;
            this.buttonLoad.Text = "Load Record";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tung-te Lin\r\n2021/07/16";
            // 
            // saveFileDialogRecord
            // 
            this.saveFileDialogRecord.DefaultExt = "Record";
            this.saveFileDialogRecord.Filter = "CSV File|*.csv";
            this.saveFileDialogRecord.Title = "Save the record is a CSV file.";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelStartTime.Location = new System.Drawing.Point(13, 279);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(106, 17);
            this.labelStartTime.TabIndex = 17;
            this.labelStartTime.Text = "00000000000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "End time:";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.ForeColor = System.Drawing.Color.Olive;
            this.labelEndTime.Location = new System.Drawing.Point(13, 317);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(106, 17);
            this.labelEndTime.TabIndex = 19;
            this.labelEndTime.Text = "00000000000000";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(714, 661);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPressedTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelChar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClickedTotal);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelAscii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewKey);
            this.Controls.Add(this.checkBoxStart);
            this.Name = "Form1";
            this.Text = "Key Frequency";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAscii;
        private System.Windows.Forms.ListView listViewKey;
        private System.Windows.Forms.Label labelClickedTotal;
        private System.Windows.Forms.CheckBox checkBoxStart;
        private System.Windows.Forms.ColumnHeader chASCII;
        private System.Windows.Forms.ColumnHeader chClickedCount;
        private System.Windows.Forms.ColumnHeader chClickedPercent;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ColumnHeader chKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelChar;
        private System.Windows.Forms.ColumnHeader chPressedCount;
        private System.Windows.Forms.ColumnHeader chPressedPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPressedTotal;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.OpenFileDialog openFileDialogRecord;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialogRecord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEndTime;
    }
}


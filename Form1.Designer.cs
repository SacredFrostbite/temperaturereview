namespace Program4A
{
    partial class Form1
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
            btnFileSelect = new Button();
            btnResults = new Button();
            grpbxStatistics = new GroupBox();
            lblAverageTemp = new Label();
            lblHighTemp = new Label();
            lblLowTemp = new Label();
            lblPathName = new Label();
            openFile = new OpenFileDialog();
            grpbxStatistics.SuspendLayout();
            SuspendLayout();
            // 
            // btnFileSelect
            // 
            btnFileSelect.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFileSelect.Location = new Point(62, 75);
            btnFileSelect.Margin = new Padding(4, 3, 4, 3);
            btnFileSelect.Name = "btnFileSelect";
            btnFileSelect.Size = new Size(109, 34);
            btnFileSelect.TabIndex = 0;
            btnFileSelect.Text = "Select a File";
            btnFileSelect.UseVisualStyleBackColor = true;
            btnFileSelect.Click += btnFileSelect_Click;
            // 
            // btnResults
            // 
            btnResults.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnResults.Location = new Point(62, 115);
            btnResults.Margin = new Padding(4, 3, 4, 3);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(135, 26);
            btnResults.TabIndex = 1;
            btnResults.Text = "Report Results";
            btnResults.UseVisualStyleBackColor = true;
            btnResults.Click += btnResults_Click;
            // 
            // grpbxStatistics
            // 
            grpbxStatistics.Controls.Add(lblAverageTemp);
            grpbxStatistics.Controls.Add(lblHighTemp);
            grpbxStatistics.Controls.Add(lblLowTemp);
            grpbxStatistics.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            grpbxStatistics.Location = new Point(95, 184);
            grpbxStatistics.Margin = new Padding(4, 3, 4, 3);
            grpbxStatistics.Name = "grpbxStatistics";
            grpbxStatistics.Padding = new Padding(4, 3, 4, 3);
            grpbxStatistics.Size = new Size(433, 166);
            grpbxStatistics.TabIndex = 2;
            grpbxStatistics.TabStop = false;
            grpbxStatistics.Text = "Month Statistics";
            // 
            // lblAverageTemp
            // 
            lblAverageTemp.AutoSize = true;
            lblAverageTemp.Location = new Point(43, 111);
            lblAverageTemp.Margin = new Padding(4, 0, 4, 0);
            lblAverageTemp.Name = "lblAverageTemp";
            lblAverageTemp.Size = new Size(196, 15);
            lblAverageTemp.TabIndex = 6;
            lblAverageTemp.Text = "Average temperature was xx.xx";
            // 
            // lblHighTemp
            // 
            lblHighTemp.AutoSize = true;
            lblHighTemp.Location = new Point(43, 75);
            lblHighTemp.Margin = new Padding(4, 0, 4, 0);
            lblHighTemp.Name = "lblHighTemp";
            lblHighTemp.Size = new Size(260, 15);
            lblHighTemp.TabIndex = 5;
            lblHighTemp.Text = "Month high temperature was xx on day xx";
            // 
            // lblLowTemp
            // 
            lblLowTemp.AutoSize = true;
            lblLowTemp.Location = new Point(43, 40);
            lblLowTemp.Margin = new Padding(4, 0, 4, 0);
            lblLowTemp.Name = "lblLowTemp";
            lblLowTemp.Size = new Size(254, 15);
            lblLowTemp.TabIndex = 4;
            lblLowTemp.Text = "Month low temperature was xx on day xx";
            // 
            // lblPathName
            // 
            lblPathName.AutoSize = true;
            lblPathName.Location = new Point(267, 85);
            lblPathName.Margin = new Padding(4, 0, 4, 0);
            lblPathName.Name = "lblPathName";
            lblPathName.Size = new Size(0, 15);
            lblPathName.TabIndex = 3;
            // 
            // openFile
            // 
            openFile.FileName = "openFile";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 426);
            Controls.Add(lblPathName);
            Controls.Add(grpbxStatistics);
            Controls.Add(btnResults);
            Controls.Add(btnFileSelect);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Temperature Review";
            grpbxStatistics.ResumeLayout(false);
            grpbxStatistics.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFileSelect;
        private Button btnResults;
        private GroupBox grpbxStatistics;
        private Label lblAverageTemp;
        private Label lblHighTemp;
        private Label lblLowTemp;
        private Label lblPathName;
        private OpenFileDialog openFile;
    }
}

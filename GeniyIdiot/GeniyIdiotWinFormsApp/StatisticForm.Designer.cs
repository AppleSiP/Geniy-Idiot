namespace GeniyIdiotWinFormsApp
{
    partial class StatisticForm
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
            statisticDataGridView = new DataGridView();
            UserNameColumn = new DataGridViewTextBoxColumn();
            CountAnswersColumn = new DataGridViewTextBoxColumn();
            DiagnoseColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)statisticDataGridView).BeginInit();
            SuspendLayout();
            // 
            // statisticDataGridView
            // 
            statisticDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            statisticDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statisticDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserNameColumn, CountAnswersColumn, DiagnoseColumn });
            statisticDataGridView.Location = new Point(0, 0);
            statisticDataGridView.Name = "statisticDataGridView";
            statisticDataGridView.Size = new Size(483, 361);
            statisticDataGridView.TabIndex = 3;
            // 
            // UserNameColumn
            // 
            UserNameColumn.HeaderText = "Имя";
            UserNameColumn.Name = "UserNameColumn";
            // 
            // CountAnswersColumn
            // 
            CountAnswersColumn.HeaderText = "Кол-во правильных ответов";
            CountAnswersColumn.Name = "CountAnswersColumn";
            // 
            // DiagnoseColumn
            // 
            DiagnoseColumn.HeaderText = "Диагноз";
            DiagnoseColumn.Name = "DiagnoseColumn";
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(484, 361);
            Controls.Add(statisticDataGridView);
            Name = "StatisticForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ГенийИдиот";
            Load += StatisticForm_Load;
            ((System.ComponentModel.ISupportInitialize)statisticDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView statisticDataGridView;
        private DataGridViewTextBoxColumn UserNameColumn;
        private DataGridViewTextBoxColumn CountAnswersColumn;
        private DataGridViewTextBoxColumn DiagnoseColumn;
    }
}
namespace GeniyIdiotWinFormsApp
{
    partial class QuestionsManagerForm
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
            questionsManagerAddButton = new Button();
            questionsManagerDeleteButton = new Button();
            newQuestionTextBox = new TextBox();
            questionsManagerDataGridView = new DataGridView();
            index = new DataGridViewTextBoxColumn();
            Questions = new DataGridViewTextBoxColumn();
            questionsManagerExitButton = new Button();
            newQuestionLabel = new Label();
            newAnswerLabel = new Label();
            newAnswerTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)questionsManagerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsManagerAddButton
            // 
            questionsManagerAddButton.AutoSize = true;
            questionsManagerAddButton.Font = new Font("Arial Narrow", 14.25F);
            questionsManagerAddButton.Location = new Point(22, 473);
            questionsManagerAddButton.Name = "questionsManagerAddButton";
            questionsManagerAddButton.Size = new Size(90, 33);
            questionsManagerAddButton.TabIndex = 0;
            questionsManagerAddButton.Text = "Добавить";
            questionsManagerAddButton.UseVisualStyleBackColor = true;
            questionsManagerAddButton.Click += QuestionsManagerAddButton_Click;
            // 
            // questionsManagerDeleteButton
            // 
            questionsManagerDeleteButton.AutoSize = true;
            questionsManagerDeleteButton.Font = new Font("Arial Narrow", 14.25F);
            questionsManagerDeleteButton.Location = new Point(149, 473);
            questionsManagerDeleteButton.Name = "questionsManagerDeleteButton";
            questionsManagerDeleteButton.Size = new Size(81, 33);
            questionsManagerDeleteButton.TabIndex = 1;
            questionsManagerDeleteButton.Text = "Удалить";
            questionsManagerDeleteButton.UseVisualStyleBackColor = true;
            questionsManagerDeleteButton.Click += QuestionsManagerDeleteButton_Click;
            // 
            // newQuestionTextBox
            // 
            newQuestionTextBox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newQuestionTextBox.Location = new Point(22, 301);
            newQuestionTextBox.Name = "newQuestionTextBox";
            newQuestionTextBox.Size = new Size(602, 29);
            newQuestionTextBox.TabIndex = 2;
            // 
            // questionsManagerDataGridView
            // 
            questionsManagerDataGridView.AllowUserToAddRows = false;
            questionsManagerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            questionsManagerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsManagerDataGridView.Columns.AddRange(new DataGridViewColumn[] { index, Questions });
            questionsManagerDataGridView.Location = new Point(0, 0);
            questionsManagerDataGridView.Name = "questionsManagerDataGridView";
            questionsManagerDataGridView.RowHeadersVisible = false;
            questionsManagerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            questionsManagerDataGridView.Size = new Size(657, 245);
            questionsManagerDataGridView.TabIndex = 3;
            // 
            // index
            // 
            index.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            index.HeaderText = "№";
            index.Name = "index";
            index.ReadOnly = true;
            index.Width = 45;
            // 
            // Questions
            // 
            Questions.HeaderText = "Вопрос";
            Questions.Name = "Questions";
            Questions.ReadOnly = true;
            // 
            // questionsManagerExitButton
            // 
            questionsManagerExitButton.AutoSize = true;
            questionsManagerExitButton.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionsManagerExitButton.Location = new Point(547, 473);
            questionsManagerExitButton.Name = "questionsManagerExitButton";
            questionsManagerExitButton.Size = new Size(77, 33);
            questionsManagerExitButton.TabIndex = 4;
            questionsManagerExitButton.Text = "Отмена";
            questionsManagerExitButton.UseVisualStyleBackColor = true;
            questionsManagerExitButton.Click += QuestionsManagerExitButton_Click;
            // 
            // newQuestionLabel
            // 
            newQuestionLabel.AutoSize = true;
            newQuestionLabel.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newQuestionLabel.Location = new Point(22, 266);
            newQuestionLabel.Name = "newQuestionLabel";
            newQuestionLabel.Size = new Size(376, 23);
            newQuestionLabel.TabIndex = 5;
            newQuestionLabel.Text = "Введите текст вопроса, который хотите добавить:";
            // 
            // newAnswerLabel
            // 
            newAnswerLabel.AutoSize = true;
            newAnswerLabel.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newAnswerLabel.Location = new Point(22, 349);
            newAnswerLabel.Name = "newAnswerLabel";
            newAnswerLabel.Size = new Size(200, 23);
            newAnswerLabel.TabIndex = 6;
            newAnswerLabel.Text = "Введите ответ на вопрос :";
            // 
            // newAnswerTextBox
            // 
            newAnswerTextBox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newAnswerTextBox.Location = new Point(22, 390);
            newAnswerTextBox.Name = "newAnswerTextBox";
            newAnswerTextBox.Size = new Size(602, 29);
            newAnswerTextBox.TabIndex = 7;
            // 
            // QuestionsManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 529);
            Controls.Add(newAnswerTextBox);
            Controls.Add(newAnswerLabel);
            Controls.Add(newQuestionLabel);
            Controls.Add(questionsManagerExitButton);
            Controls.Add(questionsManagerDataGridView);
            Controls.Add(newQuestionTextBox);
            Controls.Add(questionsManagerDeleteButton);
            Controls.Add(questionsManagerAddButton);
            Name = "QuestionsManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджер вопросов";
            FormClosed += QuestionsManagerForm_FormClosed;
            Load += QuestionsManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsManagerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button questionsManagerAddButton;
        private Button questionsManagerDeleteButton;
        private TextBox newQuestionTextBox;
        private Button questionsManagerExitButton;
        private DataGridView questionsManagerDataGridView;
        private Label newQuestionLabel;
        private Label newAnswerLabel;
        private TextBox newAnswerTextBox;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn Questions;
    }
}
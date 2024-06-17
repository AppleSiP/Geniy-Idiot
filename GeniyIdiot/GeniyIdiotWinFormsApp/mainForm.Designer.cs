namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            sendAnswerButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            statisticToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            managerQuestionsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mainFormTimer = new System.Windows.Forms.Timer(components);
            mainFormTimerLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sendAnswerButton
            // 
            sendAnswerButton.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sendAnswerButton.Location = new Point(150, 290);
            sendAnswerButton.Name = "sendAnswerButton";
            sendAnswerButton.Size = new Size(200, 50);
            sendAnswerButton.TabIndex = 0;
            sendAnswerButton.Text = "Ответить";
            sendAnswerButton.UseVisualStyleBackColor = true;
            sendAnswerButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            questionNumberLabel.Location = new Point(150, 52);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(200, 39);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1:";
            questionNumberLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // questionTextLabel
            // 
            questionTextLabel.Font = new Font("Segoe Print", 14F);
            questionTextLabel.Location = new Point(50, 100);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(400, 130);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userAnswerTextBox.Location = new Point(100, 240);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(300, 29);
            userAnswerTextBox.TabIndex = 3;
            userAnswerTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(484, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statisticToolStripMenuItem, restartToolStripMenuItem, managerQuestionsToolStripMenuItem, exitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // statisticToolStripMenuItem
            // 
            statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            statisticToolStripMenuItem.Size = new Size(188, 22);
            statisticToolStripMenuItem.Text = "Результаты";
            statisticToolStripMenuItem.Click += StatisticToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(188, 22);
            restartToolStripMenuItem.Text = "Перезапустить";
            restartToolStripMenuItem.Click += RestartToolStripMenuItem_Click;
            // 
            // managerQuestionsToolStripMenuItem
            // 
            managerQuestionsToolStripMenuItem.Name = "managerQuestionsToolStripMenuItem";
            managerQuestionsToolStripMenuItem.Size = new Size(188, 22);
            managerQuestionsToolStripMenuItem.Text = "Менеджер вопросов";
            managerQuestionsToolStripMenuItem.Click += ManagerQuestionsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(188, 22);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // mainFormTimer
            // 
            mainFormTimer.Tick += MainFormTimer_Tick;
            // 
            // mainFormTimerLabel
            // 
            mainFormTimerLabel.AutoSize = true;
            mainFormTimerLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mainFormTimerLabel.Location = new Point(391, 33);
            mainFormTimerLabel.Name = "mainFormTimerLabel";
            mainFormTimerLabel.Size = new Size(72, 29);
            mainFormTimerLabel.TabIndex = 5;
            mainFormTimerLabel.Text = "00:00";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(mainFormTimerLabel);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(sendAnswerButton);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений Идиот";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendAnswerButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem statisticToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem managerQuestionsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer mainFormTimer;
        private Label mainFormTimerLabel;
    }
}

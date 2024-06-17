
namespace GeniyIdiotWinFormsApp
{
    partial class WelcomeForm
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
            welcomeLabel = new Label();
            manualUserNameLabel = new Label();
            userNameTextBox = new TextBox();
            startButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.Font = new Font("Segoe Print", 18F);
            welcomeLabel.Location = new Point(50, 10);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(400, 100);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Добро пожаловать в тестирование ГенийИдиот!";
            welcomeLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // manualUserNameLabel
            // 
            manualUserNameLabel.Font = new Font("Segoe Print", 14F);
            manualUserNameLabel.Location = new Point(50, 150);
            manualUserNameLabel.Name = "manualUserNameLabel";
            manualUserNameLabel.Size = new Size(400, 50);
            manualUserNameLabel.TabIndex = 1;
            manualUserNameLabel.Text = "Введите имя пользователя";
            manualUserNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameTextBox.Location = new Point(100, 220);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(300, 35);
            userNameTextBox.TabIndex = 2;
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe Print", 18F);
            startButton.Location = new Point(150, 270);
            startButton.Name = "startButton";
            startButton.Size = new Size(200, 50);
            startButton.TabIndex = 3;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(startButton);
            Controls.Add(userNameTextBox);
            Controls.Add(manualUserNameLabel);
            Controls.Add(welcomeLabel);
            KeyPreview = true;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ГенийИдиот";
            FormClosing += WelcomeForm_FormClosing;
            Load += WelcomeForm_Load;
            KeyDown += WelcomeForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label manualUserNameLabel;
        public TextBox userNameTextBox;
        private Button startButton;
    }
}
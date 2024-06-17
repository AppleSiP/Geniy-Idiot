namespace GeniyIdiotWinFormsApp
{
    partial class ResultForm
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
            resultTextLabel = new Label();
            resultButton = new Button();
            SuspendLayout();
            // 
            // resultTextLabel
            // 
            resultTextLabel.AutoSize = true;
            resultTextLabel.Font = new Font("Segoe Print", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultTextLabel.ForeColor = SystemColors.ControlText;
            resultTextLabel.Location = new Point(46, 31);
            resultTextLabel.Name = "resultTextLabel";
            resultTextLabel.Size = new Size(343, 42);
            resultTextLabel.TabIndex = 0;
            resultTextLabel.Text = "тут будут результаты";
            resultTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultButton
            // 
            resultButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resultButton.AutoSize = true;
            resultButton.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultButton.Location = new Point(192, 307);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(100, 33);
            resultButton.TabIndex = 1;
            resultButton.Text = "Ок";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += CloseFormButton_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(484, 361);
            Controls.Add(resultButton);
            Controls.Add(resultTextLabel);
            KeyPreview = true;
            Name = "ResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ГенийИдиот";
            Load += ResultForm_Load;
            KeyDown += ResultForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label resultTextLabel;
        private Button resultButton;
    }
}
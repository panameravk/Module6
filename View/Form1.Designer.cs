namespace Module6
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
            this.components = new System.ComponentModel.Container();
            this.sendResultButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getDataButton = new System.Windows.Forms.Button();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendResultButton
            // 
            this.sendResultButton.Location = new System.Drawing.Point(42, 208);
            this.sendResultButton.Name = "sendResultButton";
            this.sendResultButton.Size = new System.Drawing.Size(300, 40);
            this.sendResultButton.TabIndex = 1;
            this.sendResultButton.Text = "Отправить результаты теста";
            this.sendResultButton.UseVisualStyleBackColor = true;
            this.sendResultButton.Click += new System.EventHandler(this.sendResultButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(42, 59);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(300, 40);
            this.getDataButton.TabIndex = 2;
            this.getDataButton.Text = "Получить данные";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(451, 70);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(278, 20);
            this.dataTextBox.TabIndex = 3;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(451, 219);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(278, 20);
            this.resultTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.sendResultButton);
            this.MinimumSize = new System.Drawing.Size(800, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Валидация данных ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendResultButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}



namespace ООАиД_ЛР10
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
            this.StartMarketButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.CurrStateTextBox = new System.Windows.Forms.TextBox();
            this.CountActTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartMarketButton
            // 
            this.StartMarketButton.Location = new System.Drawing.Point(12, 12);
            this.StartMarketButton.Name = "StartMarketButton";
            this.StartMarketButton.Size = new System.Drawing.Size(94, 46);
            this.StartMarketButton.TabIndex = 0;
            this.StartMarketButton.Text = "Начать";
            this.StartMarketButton.UseVisualStyleBackColor = true;
            this.StartMarketButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(12, 66);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(94, 46);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(149, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Количество активаций";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(355, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(161, 21);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Текущее состояние";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CurrStateTextBox
            // 
            this.CurrStateTextBox.Location = new System.Drawing.Point(355, 36);
            this.CurrStateTextBox.Name = "CurrStateTextBox";
            this.CurrStateTextBox.Size = new System.Drawing.Size(180, 22);
            this.CurrStateTextBox.TabIndex = 5;
            // 
            // CountActTextBox
            // 
            this.CountActTextBox.Location = new System.Drawing.Point(149, 36);
            this.CountActTextBox.Name = "CountActTextBox";
            this.CountActTextBox.Size = new System.Drawing.Size(181, 22);
            this.CountActTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 141);
            this.Controls.Add(this.CountActTextBox);
            this.Controls.Add(this.CurrStateTextBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.StartMarketButton);
            this.MaximumSize = new System.Drawing.Size(567, 188);
            this.MinimumSize = new System.Drawing.Size(567, 188);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartMarketButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox CurrStateTextBox;
        private System.Windows.Forms.TextBox CountActTextBox;
    }
}


namespace Exam2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.FromFileButton = new System.Windows.Forms.Button();
            this.WriteToFileButton = new System.Windows.Forms.Button();
            this.MatrixLabel = new System.Windows.Forms.Label();
            this.Textbox123 = new System.Windows.Forms.RichTextBox();
            this.FromFormButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // FromFileButton
            // 
            this.FromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromFileButton.Location = new System.Drawing.Point(11, 208);
            this.FromFileButton.Name = "FromFileButton";
            this.FromFileButton.Size = new System.Drawing.Size(134, 38);
            this.FromFileButton.TabIndex = 1;
            this.FromFileButton.Text = "Чтение из файла";
            this.FromFileButton.UseVisualStyleBackColor = true;
            this.FromFileButton.Click += new System.EventHandler(this.DoSomething_Click);
            // 
            // WriteToFileButton
            // 
            this.WriteToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteToFileButton.Location = new System.Drawing.Point(9, 208);
            this.WriteToFileButton.Name = "WriteToFileButton";
            this.WriteToFileButton.Size = new System.Drawing.Size(134, 38);
            this.WriteToFileButton.TabIndex = 2;
            this.WriteToFileButton.Text = "Запись в файл";
            this.WriteToFileButton.UseVisualStyleBackColor = true;
            this.WriteToFileButton.Click += new System.EventHandler(this.DoSomething_Click);
            // 
            // MatrixLabel
            // 
            this.MatrixLabel.AutoSize = true;
            this.MatrixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixLabel.Location = new System.Drawing.Point(26, 20);
            this.MatrixLabel.Name = "MatrixLabel";
            this.MatrixLabel.Size = new System.Drawing.Size(0, 18);
            this.MatrixLabel.TabIndex = 3;
            this.MatrixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Textbox123
            // 
            this.Textbox123.Location = new System.Drawing.Point(9, 19);
            this.Textbox123.Name = "Textbox123";
            this.Textbox123.Size = new System.Drawing.Size(134, 134);
            this.Textbox123.TabIndex = 4;
            this.Textbox123.Text = "";
            // 
            // FromFormButton
            // 
            this.FromFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromFormButton.Location = new System.Drawing.Point(9, 164);
            this.FromFormButton.Name = "FromFormButton";
            this.FromFormButton.Size = new System.Drawing.Size(134, 38);
            this.FromFormButton.TabIndex = 5;
            this.FromFormButton.Text = "Чтение из формы";
            this.FromFormButton.UseVisualStyleBackColor = true;
            this.FromFormButton.Click += new System.EventHandler(this.DoSomething_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MatrixLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(173, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 257);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходный граф";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FromFileButton);
            this.groupBox2.Controls.Add(this.Textbox123);
            this.groupBox2.Controls.Add(this.FromFormButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 257);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод матрицы";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.WriteToFileButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(379, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 257);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 278);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Алгоритм Прима";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FromFileButton;
        private System.Windows.Forms.Button WriteToFileButton;
        private System.Windows.Forms.Label MatrixLabel;
        private System.Windows.Forms.RichTextBox Textbox123;
        private System.Windows.Forms.Button FromFormButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


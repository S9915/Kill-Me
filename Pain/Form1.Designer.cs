namespace Pain
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
            this.label1 = new System.Windows.Forms.Label();
            this.matrixsize = new System.Windows.Forms.NumericUpDown();
            this.build_matrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixsize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите размер квадратной матрицы";
            // 
            // matrixsize
            // 
            this.matrixsize.Location = new System.Drawing.Point(15, 44);
            this.matrixsize.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.matrixsize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixsize.Name = "matrixsize";
            this.matrixsize.Size = new System.Drawing.Size(69, 22);
            this.matrixsize.TabIndex = 4;
            this.matrixsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixsize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // build_matrix
            // 
            this.build_matrix.Location = new System.Drawing.Point(104, 43);
            this.build_matrix.Name = "build_matrix";
            this.build_matrix.Size = new System.Drawing.Size(166, 23);
            this.build_matrix.TabIndex = 5;
            this.build_matrix.Text = "Построить матрицу";
            this.build_matrix.UseVisualStyleBackColor = true;
            this.build_matrix.Click += new System.EventHandler(this.Build_matrix_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 86);
            this.Controls.Add(this.build_matrix);
            this.Controls.Add(this.matrixsize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrixsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button build_matrix;
        public System.Windows.Forms.NumericUpDown matrixsize;
    }
}


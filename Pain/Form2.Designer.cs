namespace Pain
{
    partial class Form2
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
            this.transpose = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.determinant = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // transpose
            // 
            this.transpose.Location = new System.Drawing.Point(12, 401);
            this.transpose.Name = "transpose";
            this.transpose.Size = new System.Drawing.Size(137, 37);
            this.transpose.TabIndex = 0;
            this.transpose.Text = "Транспонировать";
            this.transpose.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(155, 401);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(124, 37);
            this.multiply.TabIndex = 1;
            this.multiply.Text = "Умножить на:";
            this.multiply.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 22);
            this.textBox1.TabIndex = 2;
            // 
            // determinant
            // 
            this.determinant.Location = new System.Drawing.Point(351, 401);
            this.determinant.Name = "determinant";
            this.determinant.Size = new System.Drawing.Size(115, 37);
            this.determinant.TabIndex = 3;
            this.determinant.Text = "Определитель";
            this.determinant.UseVisualStyleBackColor = true;
            this.determinant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.determinant_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 408);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(57, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.determinant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.transpose);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transpose;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button determinant;
        private System.Windows.Forms.TextBox textBox2;
    }
}
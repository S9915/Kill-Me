namespace Matrix
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
            this.sum = new System.Windows.Forms.Button();
            this.raz = new System.Windows.Forms.Button();
            this.TA = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.tB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.detA = new System.Windows.Forms.Button();
            this.detB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(484, 16);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(128, 45);
            this.sum.TabIndex = 1;
            this.sum.Text = "Summ";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // raz
            // 
            this.raz.Location = new System.Drawing.Point(484, 89);
            this.raz.Name = "raz";
            this.raz.Size = new System.Drawing.Size(128, 45);
            this.raz.TabIndex = 2;
            this.raz.Text = "Razn";
            this.raz.UseVisualStyleBackColor = true;
            this.raz.Click += new System.EventHandler(this.raz_Click);
            // 
            // TA
            // 
            this.TA.Location = new System.Drawing.Point(484, 163);
            this.TA.Name = "TA";
            this.TA.Size = new System.Drawing.Size(128, 45);
            this.TA.TabIndex = 3;
            this.TA.Text = "Trans";
            this.TA.UseVisualStyleBackColor = true;
            this.TA.Click += new System.EventHandler(this.TA_Click);
            // 
            // um
            // 
            this.um.Location = new System.Drawing.Point(484, 298);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(128, 45);
            this.um.TabIndex = 4;
            this.um.Text = "Umn";
            this.um.UseVisualStyleBackColor = true;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(484, 228);
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(128, 45);
            this.tB.TabIndex = 8;
            this.tB.Text = "Trans";
            this.tB.UseVisualStyleBackColor = true;
            this.tB.Click += new System.EventHandler(this.tB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 78);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(415, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 298);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(415, 150);
            this.dataGridView3.TabIndex = 11;
            // 
            // detA
            // 
            this.detA.Location = new System.Drawing.Point(484, 359);
            this.detA.Name = "detA";
            this.detA.Size = new System.Drawing.Size(128, 50);
            this.detA.TabIndex = 12;
            this.detA.Text = "determinant A";
            this.detA.UseVisualStyleBackColor = true;
            this.detA.Click += new System.EventHandler(this.detA_Click);
            // 
            // detB
            // 
            this.detB.Location = new System.Drawing.Point(484, 415);
            this.detB.Name = "detB";
            this.detB.Size = new System.Drawing.Size(128, 50);
            this.detB.TabIndex = 13;
            this.detB.Text = "determinant B";
            this.detB.UseVisualStyleBackColor = true;
            this.detB.Click += new System.EventHandler(this.detB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(618, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(69, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(618, 429);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(69, 22);
            this.textBox2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 507);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.detB);
            this.Controls.Add(this.detA);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.um);
            this.Controls.Add(this.TA);
            this.Controls.Add(this.raz);
            this.Controls.Add(this.sum);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button raz;
        private System.Windows.Forms.Button TA;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button tB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button detA;
        private System.Windows.Forms.Button detB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}


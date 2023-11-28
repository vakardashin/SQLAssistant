namespace SQLAssistant
{
    partial class FrmMain
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtSql = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(512, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // TxtSql
            // 
            this.TxtSql.Location = new System.Drawing.Point(12, 46);
            this.TxtSql.Multiline = true;
            this.TxtSql.Name = "TxtSql";
            this.TxtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSql.Size = new System.Drawing.Size(641, 184);
            this.TxtSql.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 266);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(832, 183);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Test Connection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Execute SQL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(717, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Service";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(717, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "Execute File";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 461);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TxtSql);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmMain";
            this.Text = "SQLAssistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtSql;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


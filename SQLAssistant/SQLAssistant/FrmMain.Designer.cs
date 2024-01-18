﻿namespace SQLAssistant
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
            this.CboDbServers = new System.Windows.Forms.ComboBox();
            this.TxtSql = new System.Windows.Forms.TextBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnExecuteSql = new System.Windows.Forms.Button();
            this.BtnService = new System.Windows.Forms.Button();
            this.BtnExecuteFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboDbServers
            // 
            this.CboDbServers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboDbServers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboDbServers.FormattingEnabled = true;
            this.CboDbServers.Location = new System.Drawing.Point(118, 12);
            this.CboDbServers.Name = "CboDbServers";
            this.CboDbServers.Size = new System.Drawing.Size(580, 28);
            this.CboDbServers.TabIndex = 0;
            // 
            // TxtSql
            // 
            this.TxtSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSql.Location = new System.Drawing.Point(12, 65);
            this.TxtSql.Multiline = true;
            this.TxtSql.Name = "TxtSql";
            this.TxtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSql.Size = new System.Drawing.Size(686, 184);
            this.TxtSql.TabIndex = 1;
            // 
            // TxtResult
            // 
            this.TxtResult.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtResult.Location = new System.Drawing.Point(12, 287);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtResult.Size = new System.Drawing.Size(832, 243);
            this.TxtResult.TabIndex = 2;
            this.TxtResult.WordWrap = false;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(717, 12);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(128, 50);
            this.BtnTest.TabIndex = 3;
            this.BtnTest.Text = "Test Connection";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnExecuteSql
            // 
            this.BtnExecuteSql.Location = new System.Drawing.Point(717, 68);
            this.BtnExecuteSql.Name = "BtnExecuteSql";
            this.BtnExecuteSql.Size = new System.Drawing.Size(128, 50);
            this.BtnExecuteSql.TabIndex = 4;
            this.BtnExecuteSql.Text = "Execute SQL";
            this.BtnExecuteSql.UseVisualStyleBackColor = true;
            this.BtnExecuteSql.Click += new System.EventHandler(this.BtnExecuteSql_Click);
            // 
            // BtnService
            // 
            this.BtnService.Location = new System.Drawing.Point(717, 124);
            this.BtnService.Name = "BtnService";
            this.BtnService.Size = new System.Drawing.Size(128, 50);
            this.BtnService.TabIndex = 5;
            this.BtnService.Text = "Service";
            this.BtnService.UseVisualStyleBackColor = true;
            this.BtnService.Visible = false;
            this.BtnService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // BtnExecuteFile
            // 
            this.BtnExecuteFile.Location = new System.Drawing.Point(717, 180);
            this.BtnExecuteFile.Name = "BtnExecuteFile";
            this.BtnExecuteFile.Size = new System.Drawing.Size(128, 50);
            this.BtnExecuteFile.TabIndex = 6;
            this.BtnExecuteFile.Text = "Execute File";
            this.BtnExecuteFile.UseVisualStyleBackColor = true;
            this.BtnExecuteFile.Click += new System.EventHandler(this.BtnExecuteFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "SQL";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExecuteFile);
            this.Controls.Add(this.BtnService);
            this.Controls.Add(this.BtnExecuteSql);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.TxtSql);
            this.Controls.Add(this.CboDbServers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLAssistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboDbServers;
        private System.Windows.Forms.TextBox TxtSql;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnExecuteSql;
        private System.Windows.Forms.Button BtnService;
        private System.Windows.Forms.Button BtnExecuteFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


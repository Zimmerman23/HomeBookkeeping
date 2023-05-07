namespace ProjectUI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.расходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.показатьСтатистикуToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomeToolStripMenuItem1,
            this.расходToolStripMenuItem1});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить отчет";
            // 
            // incomeToolStripMenuItem1
            // 
            this.incomeToolStripMenuItem1.Name = "incomeToolStripMenuItem1";
            this.incomeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.incomeToolStripMenuItem1.Text = "Доход";
            this.incomeToolStripMenuItem1.Click += new System.EventHandler(this.AddIncomeReportToolStripMenuItem1_Click);
            // 
            // расходToolStripMenuItem1
            // 
            this.расходToolStripMenuItem1.Name = "расходToolStripMenuItem1";
            this.расходToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.расходToolStripMenuItem1.Text = "Расход";
            this.расходToolStripMenuItem1.Click += new System.EventHandler(this.AddExpenseReportToolStripMenuItem1_Click);
            // 
            // показатьСтатистикуToolStripMenuItem
            // 
            this.показатьСтатистикуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доходToolStripMenuItem,
            this.расходToolStripMenuItem});
            this.показатьСтатистикуToolStripMenuItem.Name = "показатьСтатистикуToolStripMenuItem";
            this.показатьСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.показатьСтатистикуToolStripMenuItem.Text = "Показать статистику";
            // 
            // доходToolStripMenuItem
            // 
            this.доходToolStripMenuItem.Name = "доходToolStripMenuItem";
            this.доходToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.доходToolStripMenuItem.Text = "Доход";
            this.доходToolStripMenuItem.Click += new System.EventHandler(this.ShowIncomeStatToolStripMenuItem_Click);
            // 
            // расходToolStripMenuItem
            // 
            this.расходToolStripMenuItem.Name = "расходToolStripMenuItem";
            this.расходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.расходToolStripMenuItem.Text = "Расход";
            this.расходToolStripMenuItem.Click += new System.EventHandler(this.расходToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 231);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem расходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem доходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходToolStripMenuItem;
    }
}


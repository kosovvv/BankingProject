namespace BankingProject
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesearchaccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транзакцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изгледToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.транзакцииToolStripMenuItem,
            this.изгледToolStripMenuItem,
            this.другиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem1,
            this.updatesearchaccountToolStripMenuItem,
            this.AllCustomersToolStripMenuItem});
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.newAccountToolStripMenuItem.Text = "Акаунт";
            // 
            // newAccountToolStripMenuItem1
            // 
            this.newAccountToolStripMenuItem1.Name = "newAccountToolStripMenuItem1";
            this.newAccountToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newAccountToolStripMenuItem1.Text = "Нов акаунт";
            this.newAccountToolStripMenuItem1.Click += new System.EventHandler(this.newAccountToolStripMenuItem1_Click);
            // 
            // updatesearchaccountToolStripMenuItem
            // 
            this.updatesearchaccountToolStripMenuItem.Name = "updatesearchaccountToolStripMenuItem";
            this.updatesearchaccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updatesearchaccountToolStripMenuItem.Text = "Обнови акаунт";
            this.updatesearchaccountToolStripMenuItem.Click += new System.EventHandler(this.updatesearchaccountToolStripMenuItem_Click);
            // 
            // AllCustomersToolStripMenuItem
            // 
            this.AllCustomersToolStripMenuItem.Name = "AllCustomersToolStripMenuItem";
            this.AllCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AllCustomersToolStripMenuItem.Text = "Всички клиенти";
            this.AllCustomersToolStripMenuItem.Click += new System.EventHandler(this.AllCustomersToolStripMenuItem_Click);
            // 
            // транзакцииToolStripMenuItem
            // 
            this.транзакцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawlToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.транзакцииToolStripMenuItem.Name = "транзакцииToolStripMenuItem";
            this.транзакцииToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.транзакцииToolStripMenuItem.Text = "Транзакции";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.depositToolStripMenuItem.Text = "Депозит";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawlToolStripMenuItem
            // 
            this.withdrawlToolStripMenuItem.Name = "withdrawlToolStripMenuItem";
            this.withdrawlToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.withdrawlToolStripMenuItem.Text = "Теглене";
            this.withdrawlToolStripMenuItem.Click += new System.EventHandler(this.withdrawlToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.transferToolStripMenuItem.Text = "Превод";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // изгледToolStripMenuItem
            // 
            this.изгледToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceToolStripMenuItem});
            this.изгледToolStripMenuItem.Name = "изгледToolStripMenuItem";
            this.изгледToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.изгледToolStripMenuItem.Text = "Изглед";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.balanceToolStripMenuItem.Text = "Баланс";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // другиToolStripMenuItem
            // 
            this.другиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.другиToolStripMenuItem.Name = "другиToolStripMenuItem";
            this.другиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.другиToolStripMenuItem.Text = "Други";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Затвори";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 582);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updatesearchaccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транзакцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изгледToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
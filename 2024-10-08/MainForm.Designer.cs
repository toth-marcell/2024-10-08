
namespace _2024_10_08
{
    partial class MainForm
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
            this.catsTable = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // catsTable
            // 
            this.catsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.age,
            this.name});
            this.catsTable.FullRowSelect = true;
            this.catsTable.GridLines = true;
            this.catsTable.HideSelection = false;
            this.catsTable.Location = new System.Drawing.Point(12, 27);
            this.catsTable.Name = "catsTable";
            this.catsTable.Size = new System.Drawing.Size(776, 411);
            this.catsTable.TabIndex = 0;
            this.catsTable.UseCompatibleStateImageBehavior = false;
            this.catsTable.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 25;
            // 
            // age
            // 
            this.age.Text = "Age";
            this.age.Width = 31;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 716;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editSelectedToolStripMenuItem,
            this.duplicateSelectedToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem1,
            this.deleteAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectAllToolStripMenuItem});
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.deleteSelectedToolStripMenuItem.Text = "Edit";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editSelectedToolStripMenuItem
            // 
            this.editSelectedToolStripMenuItem.Name = "editSelectedToolStripMenuItem";
            this.editSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editSelectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editSelectedToolStripMenuItem.Text = "Edit selected";
            this.editSelectedToolStripMenuItem.Click += new System.EventHandler(this.editSelectedToolStripMenuItem_Click);
            // 
            // deleteSelectedToolStripMenuItem1
            // 
            this.deleteSelectedToolStripMenuItem1.Name = "deleteSelectedToolStripMenuItem1";
            this.deleteSelectedToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteSelectedToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteSelectedToolStripMenuItem1.Text = "Delete selected";
            this.deleteSelectedToolStripMenuItem1.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem1_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete all";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // duplicateSelectedToolStripMenuItem
            // 
            this.duplicateSelectedToolStripMenuItem.Name = "duplicateSelectedToolStripMenuItem";
            this.duplicateSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.duplicateSelectedToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.duplicateSelectedToolStripMenuItem.Text = "Duplicate selected";
            this.duplicateSelectedToolStripMenuItem.Click += new System.EventHandler(this.duplicateSelectedToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catsTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cats";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView catsTable;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateSelectedToolStripMenuItem;
    }
}


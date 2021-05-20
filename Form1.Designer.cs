
namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cutStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStripMenu,
            this.EditStripMenu,
            this.toolsStripMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileStripMenu
            // 
            this.fileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStripMenu,
            this.openStripMenu,
            this.toolStripSeparator2,
            this.saveStripMenu,
            this.saveAsStripMenu,
            this.toolStripSeparator1,
            this.exitStripMenu});
            this.fileStripMenu.Name = "fileStripMenu";
            this.fileStripMenu.Size = new System.Drawing.Size(37, 20);
            this.fileStripMenu.Text = "&File";
            // 
            // newStripMenu
            // 
            this.newStripMenu.Name = "newStripMenu";
            this.newStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newStripMenu.Size = new System.Drawing.Size(146, 22);
            this.newStripMenu.Text = "&New";
            this.newStripMenu.Click += new System.EventHandler(this.newStripMenu_Click);
            // 
            // openStripMenu
            // 
            this.openStripMenu.Name = "openStripMenu";
            this.openStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openStripMenu.Size = new System.Drawing.Size(146, 22);
            this.openStripMenu.Text = "&Open";
            this.openStripMenu.Click += new System.EventHandler(this.openStripMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // saveStripMenu
            // 
            this.saveStripMenu.Name = "saveStripMenu";
            this.saveStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveStripMenu.Size = new System.Drawing.Size(146, 22);
            this.saveStripMenu.Text = "&Save";
            this.saveStripMenu.Click += new System.EventHandler(this.saveStripMenu_Click);
            // 
            // saveAsStripMenu
            // 
            this.saveAsStripMenu.Name = "saveAsStripMenu";
            this.saveAsStripMenu.Size = new System.Drawing.Size(146, 22);
            this.saveAsStripMenu.Text = "&Save As";
            this.saveAsStripMenu.Click += new System.EventHandler(this.saveAsStripMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitStripMenu
            // 
            this.exitStripMenu.Name = "exitStripMenu";
            this.exitStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitStripMenu.Size = new System.Drawing.Size(146, 22);
            this.exitStripMenu.Text = "&Exit";
            this.exitStripMenu.Click += new System.EventHandler(this.exitStripMenu_Click);
            // 
            // EditStripMenu
            // 
            this.EditStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoStripMenu,
            this.copyStripMenu,
            this.cutStripMenu,
            this.pasteStripMenu});
            this.EditStripMenu.Name = "EditStripMenu";
            this.EditStripMenu.Size = new System.Drawing.Size(39, 20);
            this.EditStripMenu.Text = "&Edit";
            // 
            // undoStripMenu
            // 
            this.undoStripMenu.Name = "undoStripMenu";
            this.undoStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoStripMenu.Size = new System.Drawing.Size(144, 22);
            this.undoStripMenu.Text = "&Undo";
            this.undoStripMenu.Click += new System.EventHandler(this.undoStripMenu_Click);
            // 
            // copyStripMenu
            // 
            this.copyStripMenu.Name = "copyStripMenu";
            this.copyStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyStripMenu.Size = new System.Drawing.Size(144, 22);
            this.copyStripMenu.Text = "&Copy";
            this.copyStripMenu.Click += new System.EventHandler(this.copyStripMenu_Click);
            // 
            // cutStripMenu
            // 
            this.cutStripMenu.Name = "cutStripMenu";
            this.cutStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutStripMenu.Size = new System.Drawing.Size(144, 22);
            this.cutStripMenu.Text = "&Cut";
            this.cutStripMenu.Click += new System.EventHandler(this.cutStripMenu_Click);
            // 
            // pasteStripMenu
            // 
            this.pasteStripMenu.Name = "pasteStripMenu";
            this.pasteStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteStripMenu.Size = new System.Drawing.Size(144, 22);
            this.pasteStripMenu.Text = "&Paste";
            this.pasteStripMenu.Click += new System.EventHandler(this.pasteStripMenu_Click);
            // 
            // toolsStripMenu
            // 
            this.toolsStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontStripMenu});
            this.toolsStripMenu.Name = "toolsStripMenu";
            this.toolsStripMenu.Size = new System.Drawing.Size(46, 20);
            this.toolsStripMenu.Text = "&Tools";
            // 
            // fontStripMenu
            // 
            this.fontStripMenu.Name = "fontStripMenu";
            this.fontStripMenu.Size = new System.Drawing.Size(98, 22);
            this.fontStripMenu.Text = "&Font";
            this.fontStripMenu.Click += new System.EventHandler(this.fontStripMenu_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 422);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileStripMenu;
        private System.Windows.Forms.ToolStripMenuItem newStripMenu;
        private System.Windows.Forms.ToolStripMenuItem openStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsStripMenu;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem undoStripMenu;
        private System.Windows.Forms.ToolStripMenuItem copyStripMenu;
        private System.Windows.Forms.ToolStripMenuItem cutStripMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fontStripMenu;
        private System.Windows.Forms.Label lbluseronly;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}


namespace MdiApplication
{
    partial class ParentForm
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
            FileMenuItem = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            WindowMenuItem = new ToolStripMenuItem();
            WindowCascadeMenuItem = new ToolStripMenuItem();
            WindowTileMenuItem = new ToolStripMenuItem();
            FileMenuItem.SuspendLayout();
            SuspendLayout();
            // 
            // FileMenuItem
            // 
            FileMenuItem.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, WindowMenuItem });
            FileMenuItem.Location = new Point(0, 0);
            FileMenuItem.MdiWindowListItem = WindowMenuItem;
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(420, 24);
            FileMenuItem.TabIndex = 1;
            FileMenuItem.Text = "MdiMenu";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewMenuItem, ExitMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // NewMenuItem
            // 
            NewMenuItem.Name = "NewMenuItem";
            NewMenuItem.Size = new Size(180, 22);
            NewMenuItem.Text = "&New";
            NewMenuItem.Click += NewMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(98, 22);
            ExitMenuItem.Text = "&Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // WindowMenuItem
            // 
            WindowMenuItem.DropDownItems.AddRange(new ToolStripItem[] { WindowCascadeMenuItem, WindowTileMenuItem });
            WindowMenuItem.Name = "WindowMenuItem";
            WindowMenuItem.Size = new Size(63, 20);
            WindowMenuItem.Text = "&Window";
            // 
            // WindowCascadeMenuItem
            // 
            WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            WindowCascadeMenuItem.Size = new Size(180, 22);
            WindowCascadeMenuItem.Text = "&Cascade";
            WindowCascadeMenuItem.Click += WindowCascadeMenuItem_Click;
            // 
            // WindowTileMenuItem
            // 
            WindowTileMenuItem.Name = "WindowTileMenuItem";
            WindowTileMenuItem.Size = new Size(180, 22);
            WindowTileMenuItem.Text = "&Tile";
            WindowTileMenuItem.Click += WindowTileMenuItem_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 320);
            Controls.Add(FileMenuItem);
            IsMdiContainer = true;
            MainMenuStrip = FileMenuItem;
            Name = "ParentForm";
            Text = "ParentForm";
            FileMenuItem.ResumeLayout(false);
            FileMenuItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip FileMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem WindowMenuItem;
        private ToolStripMenuItem WindowCascadeMenuItem;
        private ToolStripMenuItem WindowTileMenuItem;
    }
}
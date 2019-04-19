namespace Honyr
{
    partial class Form1
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
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakozóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letrehozHelyseg1 = new Honyr.LetrehozHelyseg();
            this.eszközToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helységToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakozóToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.portToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.itemsToolStripMenuItem.Text = "Szerkeszt";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.locationToolStripMenuItem1,
            this.faliCsatlakozóToolStripMenuItem});
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newItemToolStripMenuItem.Text = "Létrehoz";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eszközToolStripMenuItem,
            this.helységToolStripMenuItem,
            this.faliCsatlakozóToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Keresés";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.portToolStripMenuItem.Text = "Kilépés";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.passiveToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemToolStripMenuItem.Text = "Eszköz";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activeToolStripMenuItem.Text = "Aktív";
            // 
            // passiveToolStripMenuItem
            // 
            this.passiveToolStripMenuItem.Name = "passiveToolStripMenuItem";
            this.passiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passiveToolStripMenuItem.Text = "Passzív";
            // 
            // locationToolStripMenuItem1
            // 
            this.locationToolStripMenuItem1.Name = "locationToolStripMenuItem1";
            this.locationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.locationToolStripMenuItem1.Text = "Helység";
            // 
            // faliCsatlakozóToolStripMenuItem
            // 
            this.faliCsatlakozóToolStripMenuItem.Name = "faliCsatlakozóToolStripMenuItem";
            this.faliCsatlakozóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faliCsatlakozóToolStripMenuItem.Text = "Fali csatlakozó";
            // 
            // letrehozHelyseg1
            // 
            this.letrehozHelyseg1.Location = new System.Drawing.Point(0, 27);
            this.letrehozHelyseg1.Name = "letrehozHelyseg1";
            this.letrehozHelyseg1.Size = new System.Drawing.Size(903, 544);
            this.letrehozHelyseg1.TabIndex = 1;
            // 
            // eszközToolStripMenuItem
            // 
            this.eszközToolStripMenuItem.Name = "eszközToolStripMenuItem";
            this.eszközToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eszközToolStripMenuItem.Text = "Eszköz";
            // 
            // helységToolStripMenuItem
            // 
            this.helységToolStripMenuItem.Name = "helységToolStripMenuItem";
            this.helységToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helységToolStripMenuItem.Text = "Helység";
            // 
            // faliCsatlakozóToolStripMenuItem1
            // 
            this.faliCsatlakozóToolStripMenuItem1.Name = "faliCsatlakozóToolStripMenuItem1";
            this.faliCsatlakozóToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.faliCsatlakozóToolStripMenuItem1.Text = "Fali csatlakozó";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 570);
            this.Controls.Add(this.letrehozHelyseg1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "HONYR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faliCsatlakozóToolStripMenuItem;
        private LetrehozHelyseg letrehozHelyseg1;
        private System.Windows.Forms.ToolStripMenuItem eszközToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helységToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faliCsatlakozóToolStripMenuItem1;
    }
}


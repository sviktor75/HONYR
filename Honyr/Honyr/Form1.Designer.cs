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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helységToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakozóToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocation1 = new Honyr.addLocationCtrl();
            this.defaultMain1 = new Honyr.defaultMainCtrl();
            this.mountWall1 = new Honyr.mountWall();
            this.itemActiveCtrl1 = new Honyr.ItemActiveCtrl();
            this.aktívToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passzívToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helységToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakozóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.helységToolStripMenuItem1,
            this.faliCsatlakozóToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.itemsToolStripMenuItem.Text = "Szerkeszt";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktívToolStripMenuItem,
            this.passzívToolStripMenuItem});
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newItemToolStripMenuItem.Text = "Eszköz";
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
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.portToolStripMenuItem.Text = "Kilépés";
            this.portToolStripMenuItem.Click += new System.EventHandler(this.portToolStripMenuItem_Click);
            // 
            // addLocation1
            // 
            this.addLocation1.Location = new System.Drawing.Point(0, 27);
            this.addLocation1.Name = "addLocation1";
            this.addLocation1.Size = new System.Drawing.Size(903, 544);
            this.addLocation1.TabIndex = 2;
            // 
            // defaultMain1
            // 
            this.defaultMain1.Location = new System.Drawing.Point(0, 27);
            this.defaultMain1.Name = "defaultMain1";
            this.defaultMain1.Size = new System.Drawing.Size(903, 544);
            this.defaultMain1.TabIndex = 1;
            // 
            // mountWall1
            // 
            this.mountWall1.Location = new System.Drawing.Point(0, 27);
            this.mountWall1.Name = "mountWall1";
            this.mountWall1.Size = new System.Drawing.Size(903, 544);
            this.mountWall1.TabIndex = 3;
            // 
            // itemActiveCtrl1
            // 
            this.itemActiveCtrl1.Location = new System.Drawing.Point(0, 27);
            this.itemActiveCtrl1.Name = "itemActiveCtrl1";
            this.itemActiveCtrl1.Size = new System.Drawing.Size(903, 544);
            this.itemActiveCtrl1.TabIndex = 4;
            // 
            // aktívToolStripMenuItem
            // 
            this.aktívToolStripMenuItem.Name = "aktívToolStripMenuItem";
            this.aktívToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aktívToolStripMenuItem.Text = "Aktív";
            // 
            // passzívToolStripMenuItem
            // 
            this.passzívToolStripMenuItem.Name = "passzívToolStripMenuItem";
            this.passzívToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passzívToolStripMenuItem.Text = "Passzív";
            // 
            // helységToolStripMenuItem1
            // 
            this.helységToolStripMenuItem1.Name = "helységToolStripMenuItem1";
            this.helységToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helységToolStripMenuItem1.Text = "Helység";
            // 
            // faliCsatlakozóToolStripMenuItem
            // 
            this.faliCsatlakozóToolStripMenuItem.Name = "faliCsatlakozóToolStripMenuItem";
            this.faliCsatlakozóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faliCsatlakozóToolStripMenuItem.Text = "Fali csatlakozó";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 570);
            this.Controls.Add(this.itemActiveCtrl1);
            this.Controls.Add(this.mountWall1);
            this.Controls.Add(this.addLocation1);
            this.Controls.Add(this.defaultMain1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "HONYR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem helységToolStripMenuItem;
        public defaultMainCtrl defaultMain1;
        public addLocationCtrl addLocation1;
        public System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem eszközToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem faliCsatlakozóToolStripMenuItem1;
        private mountWall mountWall1;
        private ItemActiveCtrl itemActiveCtrl1;
        private System.Windows.Forms.ToolStripMenuItem aktívToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passzívToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helységToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faliCsatlakozóToolStripMenuItem;
    }
}


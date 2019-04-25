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
            this.aktívToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passzívToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helységToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakozóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakzóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helyésgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóiFelületToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocation1 = new Honyr.addLocationCtrl();
            this.defaultMain1 = new Honyr.defaultMainCtrl();
            this.mountWall1 = new Honyr.WallMount();
            this.itemActiveCtrl1 = new Honyr.ItemActiveCtrl();
            this.passiveItemCtrl1 = new Honyr.ItemPassiveCtrl();
            this.szimbólumokFelviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.keresésToolStripMenuItem,
            this.beállításokToolStripMenuItem,
            this.portToolStripMenuItem,
            this.súgóToolStripMenuItem});
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
            this.faliCsatlakozóToolStripMenuItem});
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
            // aktívToolStripMenuItem
            // 
            this.aktívToolStripMenuItem.Name = "aktívToolStripMenuItem";
            this.aktívToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aktívToolStripMenuItem.Text = "Aktív";
            this.aktívToolStripMenuItem.Click += new System.EventHandler(this.aktívToolStripMenuItem_Click);
            // 
            // passzívToolStripMenuItem
            // 
            this.passzívToolStripMenuItem.Name = "passzívToolStripMenuItem";
            this.passzívToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passzívToolStripMenuItem.Text = "Passzív";
            this.passzívToolStripMenuItem.Click += new System.EventHandler(this.passzívToolStripMenuItem_Click);
            // 
            // helységToolStripMenuItem1
            // 
            this.helységToolStripMenuItem1.Name = "helységToolStripMenuItem1";
            this.helységToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helységToolStripMenuItem1.Text = "Helység";
            this.helységToolStripMenuItem1.Click += new System.EventHandler(this.helységToolStripMenuItem1_Click);
            // 
            // faliCsatlakozóToolStripMenuItem
            // 
            this.faliCsatlakozóToolStripMenuItem.Name = "faliCsatlakozóToolStripMenuItem";
            this.faliCsatlakozóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faliCsatlakozóToolStripMenuItem.Text = "Fali csatlakozó";
            this.faliCsatlakozóToolStripMenuItem.Click += new System.EventHandler(this.faliCsatlakozóToolStripMenuItem_Click_1);
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eszközToolStripMenuItem,
            this.faliCsatlakzóToolStripMenuItem,
            this.helyésgToolStripMenuItem});
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.keresésToolStripMenuItem.Text = "Keresés";
            // 
            // eszközToolStripMenuItem
            // 
            this.eszközToolStripMenuItem.Name = "eszközToolStripMenuItem";
            this.eszközToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eszközToolStripMenuItem.Text = "Eszköz";
            // 
            // faliCsatlakzóToolStripMenuItem
            // 
            this.faliCsatlakzóToolStripMenuItem.Name = "faliCsatlakzóToolStripMenuItem";
            this.faliCsatlakzóToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faliCsatlakzóToolStripMenuItem.Text = "Fali csatlakzó";
            // 
            // helyésgToolStripMenuItem
            // 
            this.helyésgToolStripMenuItem.Name = "helyésgToolStripMenuItem";
            this.helyésgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helyésgToolStripMenuItem.Text = "Helyésg";
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhasználóiFelületToolStripMenuItem,
            this.szimbólumokFelviteleToolStripMenuItem,
            this.szerverToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // felhasználóiFelületToolStripMenuItem
            // 
            this.felhasználóiFelületToolStripMenuItem.Name = "felhasználóiFelületToolStripMenuItem";
            this.felhasználóiFelületToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.felhasználóiFelületToolStripMenuItem.Text = "Felhasználói felület";
            // 
            // szerverToolStripMenuItem
            // 
            this.szerverToolStripMenuItem.Name = "szerverToolStripMenuItem";
            this.szerverToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.szerverToolStripMenuItem.Text = "Szerver";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.portToolStripMenuItem.Text = "Kilépés";
            this.portToolStripMenuItem.Click += new System.EventHandler(this.portToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "Súgó";
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
            // passiveItemCtrl1
            // 
            this.passiveItemCtrl1.Location = new System.Drawing.Point(0, 27);
            this.passiveItemCtrl1.Name = "passiveItemCtrl1";
            this.passiveItemCtrl1.Size = new System.Drawing.Size(903, 544);
            this.passiveItemCtrl1.TabIndex = 5;
            this.passiveItemCtrl1.Load += new System.EventHandler(this.passiveItemCtrl1_Load);
            // 
            // szimbólumokFelviteleToolStripMenuItem
            // 
            this.szimbólumokFelviteleToolStripMenuItem.Name = "szimbólumokFelviteleToolStripMenuItem";
            this.szimbólumokFelviteleToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.szimbólumokFelviteleToolStripMenuItem.Text = "Szimbólumok felvitele";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 570);
            this.Controls.Add(this.passiveItemCtrl1);
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
        public defaultMainCtrl defaultMain1;
        public addLocationCtrl addLocation1;
        public System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private WallMount mountWall1;
        private ItemActiveCtrl itemActiveCtrl1;
        private System.Windows.Forms.ToolStripMenuItem aktívToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passzívToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helységToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faliCsatlakozóToolStripMenuItem;
        private ItemPassiveCtrl passiveItemCtrl1;
        private System.Windows.Forms.ToolStripMenuItem keresésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszközToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faliCsatlakzóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helyésgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóiFelületToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szimbólumokFelviteleToolStripMenuItem;
    }
}


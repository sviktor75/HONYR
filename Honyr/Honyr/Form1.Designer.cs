namespace PresentationLayer
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
            this.akt�vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passz�vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helys�gToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakoz�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.t�pusokMeghat�roz�saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keres�sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszk�zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakz�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hely�sgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.be�ll�t�sokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhaszn�l�iFel�letToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szimb�lumokFelviteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s�g�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocation1 = new PresentationLayer.addLocationCtrl();
            this.defaultMain1 = new PresentationLayer.defaultMainCtrl();
            this.mountWall1 = new PresentationLayer.WallMount();
            this.itemActiveCtrl1 = new PresentationLayer.ItemActiveCtrl();
            this.passiveItemCtrl1 = new PresentationLayer.ItemPassiveCtrl();
            this.typeDeclareCtrl11 = new PresentationLayer.typeDeclareCtrl1();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.keres�sToolStripMenuItem,
            this.be�ll�t�sokToolStripMenuItem,
            this.portToolStripMenuItem,
            this.s�g�ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1354, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.helys�gToolStripMenuItem1,
            this.faliCsatlakoz�ToolStripMenuItem,
            this.t�pusokMeghat�roz�saToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.itemsToolStripMenuItem.Text = "Szerkeszt";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akt�vToolStripMenuItem,
            this.passz�vToolStripMenuItem});
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.newItemToolStripMenuItem.Text = "Eszk�z";
            // 
            // akt�vToolStripMenuItem
            // 
            this.akt�vToolStripMenuItem.Name = "akt�vToolStripMenuItem";
            this.akt�vToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.akt�vToolStripMenuItem.Text = "Akt�v";
            this.akt�vToolStripMenuItem.Click += new System.EventHandler(this.AktivToolStripMenuItem_Click);
            // 
            // passz�vToolStripMenuItem
            // 
            this.passz�vToolStripMenuItem.Name = "passz�vToolStripMenuItem";
            this.passz�vToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
            this.passz�vToolStripMenuItem.Text = "Passz�v";
            this.passz�vToolStripMenuItem.Click += new System.EventHandler(this.passz�vToolStripMenuItem_Click);
            // 
            // helys�gToolStripMenuItem1
            // 
            this.helys�gToolStripMenuItem1.Name = "helys�gToolStripMenuItem1";
            this.helys�gToolStripMenuItem1.Size = new System.Drawing.Size(228, 30);
            this.helys�gToolStripMenuItem1.Text = "Helys�g";
            this.helys�gToolStripMenuItem1.Click += new System.EventHandler(this.HelyisegToolStripMenuItem1_Click);
            // 
            // faliCsatlakoz�ToolStripMenuItem
            // 
            this.faliCsatlakoz�ToolStripMenuItem.Name = "faliCsatlakoz�ToolStripMenuItem";
            this.faliCsatlakoz�ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.faliCsatlakoz�ToolStripMenuItem.Text = "Fali csatlakoz�";
            this.faliCsatlakoz�ToolStripMenuItem.Click += new System.EventHandler(this.FaliCsatlakozoToolStripMenuItem_Click_1);
            // 
            // t�pusokMeghat�roz�saToolStripMenuItem
            // 
            this.t�pusokMeghat�roz�saToolStripMenuItem.Name = "t�pusokMeghat�roz�saToolStripMenuItem";
            this.t�pusokMeghat�roz�saToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.t�pusokMeghat�roz�saToolStripMenuItem.Text = "T�pusok kezel�se";
            this.t�pusokMeghat�roz�saToolStripMenuItem.Click += new System.EventHandler(this.t�pusokMeghat�roz�saToolStripMenuItem_Click);
            // 
            // keres�sToolStripMenuItem
            // 
            this.keres�sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eszk�zToolStripMenuItem,
            this.faliCsatlakz�ToolStripMenuItem,
            this.hely�sgToolStripMenuItem});
            this.keres�sToolStripMenuItem.Name = "keres�sToolStripMenuItem";
            this.keres�sToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.keres�sToolStripMenuItem.Text = "Keres�s";
            // 
            // eszk�zToolStripMenuItem
            // 
            this.eszk�zToolStripMenuItem.Name = "eszk�zToolStripMenuItem";
            this.eszk�zToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.eszk�zToolStripMenuItem.Text = "Eszk�z";
            // 
            // faliCsatlakz�ToolStripMenuItem
            // 
            this.faliCsatlakz�ToolStripMenuItem.Name = "faliCsatlakz�ToolStripMenuItem";
            this.faliCsatlakz�ToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.faliCsatlakz�ToolStripMenuItem.Text = "Fali csatlakz�";
            // 
            // hely�sgToolStripMenuItem
            // 
            this.hely�sgToolStripMenuItem.Name = "hely�sgToolStripMenuItem";
            this.hely�sgToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.hely�sgToolStripMenuItem.Text = "Hely�sg";
            // 
            // be�ll�t�sokToolStripMenuItem
            // 
            this.be�ll�t�sokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felhaszn�l�iFel�letToolStripMenuItem,
            this.szimb�lumokFelviteleToolStripMenuItem,
            this.szerverToolStripMenuItem});
            this.be�ll�t�sokToolStripMenuItem.Name = "be�ll�t�sokToolStripMenuItem";
            this.be�ll�t�sokToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.be�ll�t�sokToolStripMenuItem.Text = "Be�ll�t�sok";
            // 
            // felhaszn�l�iFel�letToolStripMenuItem
            // 
            this.felhaszn�l�iFel�letToolStripMenuItem.Name = "felhaszn�l�iFel�letToolStripMenuItem";
            this.felhaszn�l�iFel�letToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.felhaszn�l�iFel�letToolStripMenuItem.Text = "Felhaszn�l�i fel�let";
            // 
            // szimb�lumokFelviteleToolStripMenuItem
            // 
            this.szimb�lumokFelviteleToolStripMenuItem.Name = "szimb�lumokFelviteleToolStripMenuItem";
            this.szimb�lumokFelviteleToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.szimb�lumokFelviteleToolStripMenuItem.Text = "Szimb�lumok felvitele";
            // 
            // szerverToolStripMenuItem
            // 
            this.szerverToolStripMenuItem.Name = "szerverToolStripMenuItem";
            this.szerverToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.szerverToolStripMenuItem.Text = "Szerver";
            this.szerverToolStripMenuItem.Click += new System.EventHandler(this.szerverToolStripMenuItem_Click);
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.portToolStripMenuItem.Text = "Kil�p�s";
            this.portToolStripMenuItem.Click += new System.EventHandler(this.portToolStripMenuItem_Click);
            // 
            // s�g�ToolStripMenuItem
            // 
            this.s�g�ToolStripMenuItem.Name = "s�g�ToolStripMenuItem";
            this.s�g�ToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.s�g�ToolStripMenuItem.Text = "S�g�";
            // 
            // addLocation1
            // 
            this.addLocation1.Location = new System.Drawing.Point(0, 42);
            this.addLocation1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.addLocation1.Name = "addLocation1";
            this.addLocation1.Size = new System.Drawing.Size(1354, 837);
            this.addLocation1.TabIndex = 2;
            // 
            // defaultMain1
            // 
            this.defaultMain1.Location = new System.Drawing.Point(0, 42);
            this.defaultMain1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.defaultMain1.Name = "defaultMain1";
            this.defaultMain1.Size = new System.Drawing.Size(1354, 837);
            this.defaultMain1.TabIndex = 1;
            // 
            // mountWall1
            // 
            this.mountWall1.Location = new System.Drawing.Point(0, 42);
            this.mountWall1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.mountWall1.Name = "mountWall1";
            this.mountWall1.Size = new System.Drawing.Size(1354, 837);
            this.mountWall1.TabIndex = 3;
            // 
            // itemActiveCtrl1
            // 
            this.itemActiveCtrl1.Location = new System.Drawing.Point(0, 42);
            this.itemActiveCtrl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.itemActiveCtrl1.Name = "itemActiveCtrl1";
            this.itemActiveCtrl1.Size = new System.Drawing.Size(1354, 837);
            this.itemActiveCtrl1.TabIndex = 4;
            // 
            // passiveItemCtrl1
            // 
            this.passiveItemCtrl1.Location = new System.Drawing.Point(0, 42);
            this.passiveItemCtrl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.passiveItemCtrl1.Name = "passiveItemCtrl1";
            this.passiveItemCtrl1.Size = new System.Drawing.Size(1354, 837);
            this.passiveItemCtrl1.TabIndex = 5;
            // 
            // typeDeclareCtrl11
            // 
            this.typeDeclareCtrl11.Location = new System.Drawing.Point(0, 42);
            this.typeDeclareCtrl11.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.typeDeclareCtrl11.Name = "typeDeclareCtrl11";
            this.typeDeclareCtrl11.Size = new System.Drawing.Size(1354, 837);
            this.typeDeclareCtrl11.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 877);
            this.Controls.Add(this.typeDeclareCtrl11);
            this.Controls.Add(this.passiveItemCtrl1);
            this.Controls.Add(this.itemActiveCtrl1);
            this.Controls.Add(this.mountWall1);
            this.Controls.Add(this.addLocation1);
            this.Controls.Add(this.defaultMain1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem akt�vToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passz�vToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helys�gToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem faliCsatlakoz�ToolStripMenuItem;
        private ItemPassiveCtrl passiveItemCtrl1;
        private System.Windows.Forms.ToolStripMenuItem keres�sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszk�zToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faliCsatlakz�ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hely�sgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem be�ll�t�sokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhaszn�l�iFel�letToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s�g�ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szimb�lumokFelviteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem t�pusokMeghat�roz�saToolStripMenuItem;
        private typeDeclareCtrl1 typeDeclareCtrl11;
    }
}


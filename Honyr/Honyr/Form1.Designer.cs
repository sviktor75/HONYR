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
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakoz�ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszk�zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helys�gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faliCsatlakoz�ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocation1 = new Honyr.addLocationCtrl();
            this.defaultMain1 = new Honyr.defaultMainCtrl();
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
            this.faliCsatlakoz�ToolStripMenuItem});
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newItemToolStripMenuItem.Text = "L�trehoz";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeToolStripMenuItem,
            this.passiveToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemToolStripMenuItem.Text = "Eszk�z";
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.activeToolStripMenuItem.Text = "Akt�v";
            // 
            // passiveToolStripMenuItem
            // 
            this.passiveToolStripMenuItem.Name = "passiveToolStripMenuItem";
            this.passiveToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.passiveToolStripMenuItem.Text = "Passz�v";
            // 
            // locationToolStripMenuItem1
            // 
            this.locationToolStripMenuItem1.Name = "locationToolStripMenuItem1";
            this.locationToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.locationToolStripMenuItem1.Text = "Helys�g";
            this.locationToolStripMenuItem1.Click += new System.EventHandler(this.locationToolStripMenuItem1_Click);
            // 
            // faliCsatlakoz�ToolStripMenuItem
            // 
            this.faliCsatlakoz�ToolStripMenuItem.Name = "faliCsatlakoz�ToolStripMenuItem";
            this.faliCsatlakoz�ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.faliCsatlakoz�ToolStripMenuItem.Text = "Fali csatlakoz�";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eszk�zToolStripMenuItem,
            this.helys�gToolStripMenuItem,
            this.faliCsatlakoz�ToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Keres�s";
            // 
            // eszk�zToolStripMenuItem
            // 
            this.eszk�zToolStripMenuItem.Name = "eszk�zToolStripMenuItem";
            this.eszk�zToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.eszk�zToolStripMenuItem.Text = "Eszk�z";
            // 
            // helys�gToolStripMenuItem
            // 
            this.helys�gToolStripMenuItem.Name = "helys�gToolStripMenuItem";
            this.helys�gToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.helys�gToolStripMenuItem.Text = "Helys�g";
            // 
            // faliCsatlakoz�ToolStripMenuItem1
            // 
            this.faliCsatlakoz�ToolStripMenuItem1.Name = "faliCsatlakoz�ToolStripMenuItem1";
            this.faliCsatlakoz�ToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.faliCsatlakoz�ToolStripMenuItem1.Text = "Fali csatlakoz�";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.portToolStripMenuItem.Text = "Kil�p�s";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 570);
            this.Controls.Add(this.addLocation1);
            this.Controls.Add(this.defaultMain1);
            this.Controls.Add(this.menuStrip1);
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
        public System.Windows.Forms.ToolStripMenuItem helys�gToolStripMenuItem;
        public defaultMainCtrl defaultMain1;
        public addLocationCtrl addLocation1;
        public System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem passiveToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem faliCsatlakoz�ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem eszk�zToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem faliCsatlakoz�ToolStripMenuItem1;
    }
}


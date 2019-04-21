namespace Honyr
{
    partial class ItemActiveCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemActiveLocationComboBox = new System.Windows.Forms.ComboBox();
            this.ItemActiveLbl = new System.Windows.Forms.Label();
            this.itemActiveSaveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.itemActiveNameTextbox = new System.Windows.Forms.TextBox();
            this.itemActiveLocationIdTextbox = new System.Windows.Forms.TextBox();
            this.locationDescriptionLbl = new System.Windows.Forms.Label();
            this.locationParentLbl = new System.Windows.Forms.Label();
            this.locationNameLbl = new System.Windows.Forms.Label();
            this.locationIdLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemActiveIpTextBox = new System.Windows.Forms.TextBox();
            this.itemActiveMacTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemActivePortsListBox = new System.Windows.Forms.ListBox();
            this.itemActiveDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.itemActiveaddPortBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itemActiveSymbolComboBox = new System.Windows.Forms.ComboBox();
            this.itemActivePortIdTextBox = new System.Windows.Forms.TextBox();
            this.itemActivePortNameTextBox = new System.Windows.Forms.TextBox();
            this.itemActivePortConfigRichTextBox = new System.Windows.Forms.RichTextBox();
            this.itemActivePortTypeComboBox = new System.Windows.Forms.ComboBox();
            this.itemActiveAddBtn = new System.Windows.Forms.Button();
            this.itemActiveSearchBtm = new System.Windows.Forms.Button();
            this.itemActiveModifyBtn = new System.Windows.Forms.Button();
            this.itemActiveDeleteBtn = new System.Windows.Forms.Button();
            this.itemActiveDeletePortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemActiveLocationComboBox
            // 
            this.itemActiveLocationComboBox.FormattingEnabled = true;
            this.itemActiveLocationComboBox.Location = new System.Drawing.Point(189, 154);
            this.itemActiveLocationComboBox.Name = "itemActiveLocationComboBox";
            this.itemActiveLocationComboBox.Size = new System.Drawing.Size(169, 21);
            this.itemActiveLocationComboBox.TabIndex = 20;
            // 
            // ItemActiveLbl
            // 
            this.ItemActiveLbl.AutoSize = true;
            this.ItemActiveLbl.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemActiveLbl.Location = new System.Drawing.Point(362, 37);
            this.ItemActiveLbl.Name = "ItemActiveLbl";
            this.ItemActiveLbl.Size = new System.Drawing.Size(178, 34);
            this.ItemActiveLbl.TabIndex = 17;
            this.ItemActiveLbl.Text = "Aktív eszköz";
            // 
            // itemActiveSaveBtn
            // 
            this.itemActiveSaveBtn.Location = new System.Drawing.Point(242, 488);
            this.itemActiveSaveBtn.Name = "itemActiveSaveBtn";
            this.itemActiveSaveBtn.Size = new System.Drawing.Size(97, 27);
            this.itemActiveSaveBtn.TabIndex = 15;
            this.itemActiveSaveBtn.Text = "Mentés";
            this.itemActiveSaveBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(670, 488);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 27);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Mégse";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // itemActiveNameTextbox
            // 
            this.itemActiveNameTextbox.Location = new System.Drawing.Point(189, 127);
            this.itemActiveNameTextbox.Name = "itemActiveNameTextbox";
            this.itemActiveNameTextbox.Size = new System.Drawing.Size(220, 20);
            this.itemActiveNameTextbox.TabIndex = 13;
            // 
            // itemActiveLocationIdTextbox
            // 
            this.itemActiveLocationIdTextbox.Location = new System.Drawing.Point(189, 100);
            this.itemActiveLocationIdTextbox.Name = "itemActiveLocationIdTextbox";
            this.itemActiveLocationIdTextbox.Size = new System.Drawing.Size(220, 20);
            this.itemActiveLocationIdTextbox.TabIndex = 14;
            // 
            // locationDescriptionLbl
            // 
            this.locationDescriptionLbl.AutoSize = true;
            this.locationDescriptionLbl.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationDescriptionLbl.Location = new System.Drawing.Point(20, 250);
            this.locationDescriptionLbl.Name = "locationDescriptionLbl";
            this.locationDescriptionLbl.Size = new System.Drawing.Size(141, 17);
            this.locationDescriptionLbl.TabIndex = 7;
            this.locationDescriptionLbl.Text = "Elhelyezkedés leírása:";
            // 
            // locationParentLbl
            // 
            this.locationParentLbl.AutoSize = true;
            this.locationParentLbl.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationParentLbl.Location = new System.Drawing.Point(20, 158);
            this.locationParentLbl.Name = "locationParentLbl";
            this.locationParentLbl.Size = new System.Drawing.Size(172, 17);
            this.locationParentLbl.TabIndex = 9;
            this.locationParentLbl.Text = "Épület/helység azonosítója:";
            // 
            // locationNameLbl
            // 
            this.locationNameLbl.AutoSize = true;
            this.locationNameLbl.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationNameLbl.Location = new System.Drawing.Point(20, 130);
            this.locationNameLbl.Name = "locationNameLbl";
            this.locationNameLbl.Size = new System.Drawing.Size(80, 17);
            this.locationNameLbl.TabIndex = 11;
            this.locationNameLbl.Text = "Megnevezés:";
            // 
            // locationIdLbl
            // 
            this.locationIdLbl.AutoSize = true;
            this.locationIdLbl.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationIdLbl.Location = new System.Drawing.Point(20, 103);
            this.locationIdLbl.Name = "locationIdLbl";
            this.locationIdLbl.Size = new System.Drawing.Size(71, 17);
            this.locationIdLbl.TabIndex = 12;
            this.locationIdLbl.Text = "Azonosító:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP cím:";
            // 
            // itemActiveIpTextBox
            // 
            this.itemActiveIpTextBox.Location = new System.Drawing.Point(189, 183);
            this.itemActiveIpTextBox.Name = "itemActiveIpTextBox";
            this.itemActiveIpTextBox.Size = new System.Drawing.Size(220, 20);
            this.itemActiveIpTextBox.TabIndex = 14;
            // 
            // itemActiveMacTextBox
            // 
            this.itemActiveMacTextBox.Location = new System.Drawing.Point(189, 213);
            this.itemActiveMacTextBox.Name = "itemActiveMacTextBox";
            this.itemActiveMacTextBox.Size = new System.Drawing.Size(220, 20);
            this.itemActiveMacTextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "MAC cím:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Portok";
            // 
            // itemActivePortsListBox
            // 
            this.itemActivePortsListBox.FormattingEnabled = true;
            this.itemActivePortsListBox.Location = new System.Drawing.Point(539, 100);
            this.itemActivePortsListBox.Name = "itemActivePortsListBox";
            this.itemActivePortsListBox.Size = new System.Drawing.Size(54, 355);
            this.itemActivePortsListBox.TabIndex = 24;
            // 
            // itemActiveDescriptionRichTextBox
            // 
            this.itemActiveDescriptionRichTextBox.Location = new System.Drawing.Point(189, 250);
            this.itemActiveDescriptionRichTextBox.Name = "itemActiveDescriptionRichTextBox";
            this.itemActiveDescriptionRichTextBox.Size = new System.Drawing.Size(328, 96);
            this.itemActiveDescriptionRichTextBox.TabIndex = 25;
            this.itemActiveDescriptionRichTextBox.Text = "";
            // 
            // itemActiveaddPortBtn
            // 
            this.itemActiveaddPortBtn.Location = new System.Drawing.Point(657, 355);
            this.itemActiveaddPortBtn.Name = "itemActiveaddPortBtn";
            this.itemActiveaddPortBtn.Size = new System.Drawing.Size(96, 27);
            this.itemActiveaddPortBtn.TabIndex = 15;
            this.itemActiveaddPortBtn.Text = "Port hozzáadása";
            this.itemActiveaddPortBtn.UseVisualStyleBackColor = true;
            this.itemActiveaddPortBtn.Click += new System.EventHandler(this.addPortBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Azonosító:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Megnevezés:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Konfiguráció:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(614, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Típus:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rajzjel:";
            // 
            // itemActiveSymbolComboBox
            // 
            this.itemActiveSymbolComboBox.FormattingEnabled = true;
            this.itemActiveSymbolComboBox.Location = new System.Drawing.Point(189, 361);
            this.itemActiveSymbolComboBox.Name = "itemActiveSymbolComboBox";
            this.itemActiveSymbolComboBox.Size = new System.Drawing.Size(169, 21);
            this.itemActiveSymbolComboBox.TabIndex = 26;
            // 
            // itemActivePortIdTextBox
            // 
            this.itemActivePortIdTextBox.Location = new System.Drawing.Point(711, 97);
            this.itemActivePortIdTextBox.Name = "itemActivePortIdTextBox";
            this.itemActivePortIdTextBox.Size = new System.Drawing.Size(169, 20);
            this.itemActivePortIdTextBox.TabIndex = 14;
            // 
            // itemActivePortNameTextBox
            // 
            this.itemActivePortNameTextBox.Location = new System.Drawing.Point(711, 124);
            this.itemActivePortNameTextBox.Name = "itemActivePortNameTextBox";
            this.itemActivePortNameTextBox.Size = new System.Drawing.Size(169, 20);
            this.itemActivePortNameTextBox.TabIndex = 13;
            // 
            // itemActivePortConfigRichTextBox
            // 
            this.itemActivePortConfigRichTextBox.Location = new System.Drawing.Point(712, 153);
            this.itemActivePortConfigRichTextBox.Name = "itemActivePortConfigRichTextBox";
            this.itemActivePortConfigRichTextBox.Size = new System.Drawing.Size(168, 145);
            this.itemActivePortConfigRichTextBox.TabIndex = 27;
            this.itemActivePortConfigRichTextBox.Text = "";
            // 
            // itemActivePortTypeComboBox
            // 
            this.itemActivePortTypeComboBox.FormattingEnabled = true;
            this.itemActivePortTypeComboBox.Location = new System.Drawing.Point(711, 304);
            this.itemActivePortTypeComboBox.Name = "itemActivePortTypeComboBox";
            this.itemActivePortTypeComboBox.Size = new System.Drawing.Size(169, 21);
            this.itemActivePortTypeComboBox.TabIndex = 28;
            // 
            // itemActiveAddBtn
            // 
            this.itemActiveAddBtn.Location = new System.Drawing.Point(135, 488);
            this.itemActiveAddBtn.Name = "itemActiveAddBtn";
            this.itemActiveAddBtn.Size = new System.Drawing.Size(97, 27);
            this.itemActiveAddBtn.TabIndex = 15;
            this.itemActiveAddBtn.Text = "Új";
            this.itemActiveAddBtn.UseVisualStyleBackColor = true;
            // 
            // itemActiveSearchBtm
            // 
            this.itemActiveSearchBtm.Location = new System.Drawing.Point(349, 488);
            this.itemActiveSearchBtm.Name = "itemActiveSearchBtm";
            this.itemActiveSearchBtm.Size = new System.Drawing.Size(97, 27);
            this.itemActiveSearchBtm.TabIndex = 15;
            this.itemActiveSearchBtm.Text = "Keresés";
            this.itemActiveSearchBtm.UseVisualStyleBackColor = true;
            // 
            // itemActiveModifyBtn
            // 
            this.itemActiveModifyBtn.Location = new System.Drawing.Point(456, 488);
            this.itemActiveModifyBtn.Name = "itemActiveModifyBtn";
            this.itemActiveModifyBtn.Size = new System.Drawing.Size(97, 27);
            this.itemActiveModifyBtn.TabIndex = 16;
            this.itemActiveModifyBtn.Text = "Módosít";
            this.itemActiveModifyBtn.UseVisualStyleBackColor = true;
            // 
            // itemActiveDeleteBtn
            // 
            this.itemActiveDeleteBtn.Location = new System.Drawing.Point(563, 488);
            this.itemActiveDeleteBtn.Name = "itemActiveDeleteBtn";
            this.itemActiveDeleteBtn.Size = new System.Drawing.Size(97, 27);
            this.itemActiveDeleteBtn.TabIndex = 16;
            this.itemActiveDeleteBtn.Text = "Töröl";
            this.itemActiveDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // itemActiveDeletePortBtn
            // 
            this.itemActiveDeletePortBtn.Location = new System.Drawing.Point(759, 355);
            this.itemActiveDeletePortBtn.Name = "itemActiveDeletePortBtn";
            this.itemActiveDeletePortBtn.Size = new System.Drawing.Size(96, 27);
            this.itemActiveDeletePortBtn.TabIndex = 15;
            this.itemActiveDeletePortBtn.Text = "Port törlése";
            this.itemActiveDeletePortBtn.UseVisualStyleBackColor = true;
            this.itemActiveDeletePortBtn.Click += new System.EventHandler(this.addPortBtn_Click);
            // 
            // ItemActiveCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemActivePortTypeComboBox);
            this.Controls.Add(this.itemActivePortConfigRichTextBox);
            this.Controls.Add(this.itemActiveSymbolComboBox);
            this.Controls.Add(this.itemActiveDescriptionRichTextBox);
            this.Controls.Add(this.itemActivePortsListBox);
            this.Controls.Add(this.itemActiveMacTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemActiveLocationComboBox);
            this.Controls.Add(this.ItemActiveLbl);
            this.Controls.Add(this.itemActiveDeletePortBtn);
            this.Controls.Add(this.itemActiveaddPortBtn);
            this.Controls.Add(this.itemActiveAddBtn);
            this.Controls.Add(this.itemActiveSearchBtm);
            this.Controls.Add(this.itemActiveSaveBtn);
            this.Controls.Add(this.itemActiveDeleteBtn);
            this.Controls.Add(this.itemActiveModifyBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.itemActivePortNameTextBox);
            this.Controls.Add(this.itemActiveNameTextbox);
            this.Controls.Add(this.itemActiveIpTextBox);
            this.Controls.Add(this.itemActivePortIdTextBox);
            this.Controls.Add(this.itemActiveLocationIdTextbox);
            this.Controls.Add(this.locationDescriptionLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationParentLbl);
            this.Controls.Add(this.locationNameLbl);
            this.Controls.Add(this.locationIdLbl);
            this.Name = "ItemActiveCtrl";
            this.Size = new System.Drawing.Size(903, 544);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox itemActiveLocationComboBox;
        private System.Windows.Forms.Label ItemActiveLbl;
        private System.Windows.Forms.Button itemActiveSaveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox itemActiveNameTextbox;
        private System.Windows.Forms.TextBox itemActiveLocationIdTextbox;
        private System.Windows.Forms.Label locationDescriptionLbl;
        private System.Windows.Forms.Label locationParentLbl;
        private System.Windows.Forms.Label locationNameLbl;
        private System.Windows.Forms.Label locationIdLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemActiveIpTextBox;
        private System.Windows.Forms.TextBox itemActiveMacTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox itemActivePortsListBox;
        private System.Windows.Forms.RichTextBox itemActiveDescriptionRichTextBox;
        private System.Windows.Forms.Button itemActiveaddPortBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox itemActiveSymbolComboBox;
        private System.Windows.Forms.TextBox itemActivePortIdTextBox;
        private System.Windows.Forms.TextBox itemActivePortNameTextBox;
        private System.Windows.Forms.RichTextBox itemActivePortConfigRichTextBox;
        private System.Windows.Forms.ComboBox itemActivePortTypeComboBox;
        private System.Windows.Forms.Button itemActiveAddBtn;
        private System.Windows.Forms.Button itemActiveSearchBtm;
        private System.Windows.Forms.Button itemActiveModifyBtn;
        private System.Windows.Forms.Button itemActiveDeleteBtn;
        private System.Windows.Forms.Button itemActiveDeletePortBtn;
    }
}

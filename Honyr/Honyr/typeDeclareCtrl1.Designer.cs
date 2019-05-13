namespace PresentationLayer
{
    partial class typeDeclareCtrl1
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
            this.lblTipusDeklaralas = new System.Windows.Forms.Label();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnKeres = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.comboGeneral = new System.Windows.Forms.ComboBox();
            this.lblTipus = new System.Windows.Forms.Label();
            this.txtTipus = new System.Windows.Forms.TextBox();
            this.txtKeresNev = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblKeresesNevSzerint = new System.Windows.Forms.Label();
            this.btnMentesMint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipusDeklaralas
            // 
            this.lblTipusDeklaralas.AutoSize = true;
            this.lblTipusDeklaralas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipusDeklaralas.Location = new System.Drawing.Point(299, 42);
            this.lblTipusDeklaralas.Name = "lblTipusDeklaralas";
            this.lblTipusDeklaralas.Size = new System.Drawing.Size(262, 37);
            this.lblTipusDeklaralas.TabIndex = 18;
            this.lblTipusDeklaralas.Text = "Típusok kezelése";
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(123, 482);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(97, 27);
            this.btnUj.TabIndex = 19;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(337, 482);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(97, 27);
            this.btnKeres.TabIndex = 20;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(230, 482);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(97, 27);
            this.btnMentes.TabIndex = 21;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(551, 482);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(97, 27);
            this.btnTorol.TabIndex = 22;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(444, 482);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(97, 27);
            this.btnModosit.TabIndex = 23;
            this.btnModosit.Text = "Módosít";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(658, 482);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(97, 27);
            this.btnMegse.TabIndex = 24;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // comboGeneral
            // 
            this.comboGeneral.FormattingEnabled = true;
            this.comboGeneral.Location = new System.Drawing.Point(230, 300);
            this.comboGeneral.Name = "comboGeneral";
            this.comboGeneral.Size = new System.Drawing.Size(160, 21);
            this.comboGeneral.TabIndex = 25;
            // 
            // lblTipus
            // 
            this.lblTipus.AutoSize = true;
            this.lblTipus.Location = new System.Drawing.Point(292, 264);
            this.lblTipus.Name = "lblTipus";
            this.lblTipus.Size = new System.Drawing.Size(31, 13);
            this.lblTipus.TabIndex = 26;
            this.lblTipus.Text = "típus";
            // 
            // txtTipus
            // 
            this.txtTipus.Location = new System.Drawing.Point(433, 300);
            this.txtTipus.Name = "txtTipus";
            this.txtTipus.Size = new System.Drawing.Size(215, 20);
            this.txtTipus.TabIndex = 27;
            // 
            // txtKeresNev
            // 
            this.txtKeresNev.Location = new System.Drawing.Point(433, 403);
            this.txtKeresNev.Name = "txtKeresNev";
            this.txtKeresNev.Size = new System.Drawing.Size(215, 20);
            this.txtKeresNev.TabIndex = 73;
            this.txtKeresNev.Visible = false;
            this.txtKeresNev.TextChanged += new System.EventHandler(this.txtKeresNev_TextChanged);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(402, 113);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(119, 20);
            this.txtIndex.TabIndex = 72;
            this.txtIndex.Visible = false;
            // 
            // lblKeresesNevSzerint
            // 
            this.lblKeresesNevSzerint.AutoSize = true;
            this.lblKeresesNevSzerint.Location = new System.Drawing.Point(339, 406);
            this.lblKeresesNevSzerint.Name = "lblKeresesNevSzerint";
            this.lblKeresesNevSzerint.Size = new System.Drawing.Size(51, 13);
            this.lblKeresesNevSzerint.TabIndex = 74;
            this.lblKeresesNevSzerint.Text = "Keresés :";
            // 
            // btnMentesMint
            // 
            this.btnMentesMint.Location = new System.Drawing.Point(230, 514);
            this.btnMentesMint.Name = "btnMentesMint";
            this.btnMentesMint.Size = new System.Drawing.Size(97, 27);
            this.btnMentesMint.TabIndex = 75;
            this.btnMentesMint.Text = "Mentés mint";
            this.btnMentesMint.UseVisualStyleBackColor = true;
            // 
            // typeDeclareCtrl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMentesMint);
            this.Controls.Add(this.lblKeresesNevSzerint);
            this.Controls.Add(this.txtKeresNev);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtTipus);
            this.Controls.Add(this.lblTipus);
            this.Controls.Add(this.comboGeneral);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.lblTipusDeklaralas);
            this.Name = "typeDeclareCtrl1";
            this.Size = new System.Drawing.Size(903, 544);
            this.Load += new System.EventHandler(this.typeDeclareCtrl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipusDeklaralas;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnMegse;
        private System.Windows.Forms.ComboBox comboGeneral;
        private System.Windows.Forms.Label lblTipus;
        private System.Windows.Forms.TextBox txtTipus;
        private System.Windows.Forms.TextBox txtKeresNev;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblKeresesNevSzerint;
        private System.Windows.Forms.Button btnMentesMint;
    }
}

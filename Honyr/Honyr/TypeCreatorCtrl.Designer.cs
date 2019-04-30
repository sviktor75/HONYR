namespace PresentationLayer
{
    partial class TypeCreatorCtrl
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
            this.ItemActiveLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemActiveLbl
            // 
            this.ItemActiveLbl.AutoSize = true;
            this.ItemActiveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemActiveLbl.Location = new System.Drawing.Point(276, 25);
            this.ItemActiveLbl.Name = "ItemActiveLbl";
            this.ItemActiveLbl.Size = new System.Drawing.Size(361, 37);
            this.ItemActiveLbl.TabIndex = 49;
            this.ItemActiveLbl.Text = "Típusok meghatározása";
            // 
            // TypeCreatorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemActiveLbl);
            this.Name = "TypeCreatorCtrl";
            this.Size = new System.Drawing.Size(903, 544);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemActiveLbl;
    }
}

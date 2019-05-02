namespace PresentationLayer.DBConnectionSettings
{
    partial class DBConnectionSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatabaseSchema = new System.Windows.Forms.TextBox();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.txtDbUsername = new System.Windows.Forms.TextBox();
            this.txtDbServerPort = new System.Windows.Forms.TextBox();
            this.txtDbServer = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnMegse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szerver:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Felhasználónév:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(39, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jelszó:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(39, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alapértelmezet séma:";
            // 
            // txtDatabaseSchema
            // 
            this.txtDatabaseSchema.Location = new System.Drawing.Point(246, 163);
            this.txtDatabaseSchema.Name = "txtDatabaseSchema";
            this.txtDatabaseSchema.Size = new System.Drawing.Size(294, 26);
            this.txtDatabaseSchema.TabIndex = 1;
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(246, 127);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.PasswordChar = '*';
            this.txtDbPassword.Size = new System.Drawing.Size(294, 26);
            this.txtDbPassword.TabIndex = 1;
            this.txtDbPassword.UseSystemPasswordChar = true;
            // 
            // txtDbUsername
            // 
            this.txtDbUsername.Location = new System.Drawing.Point(246, 88);
            this.txtDbUsername.Name = "txtDbUsername";
            this.txtDbUsername.Size = new System.Drawing.Size(294, 26);
            this.txtDbUsername.TabIndex = 1;
            // 
            // txtDbServerPort
            // 
            this.txtDbServerPort.Location = new System.Drawing.Point(246, 52);
            this.txtDbServerPort.Name = "txtDbServerPort";
            this.txtDbServerPort.Size = new System.Drawing.Size(107, 26);
            this.txtDbServerPort.TabIndex = 1;
            // 
            // txtDbServer
            // 
            this.txtDbServer.Location = new System.Drawing.Point(246, 18);
            this.txtDbServer.Name = "txtDbServer";
            this.txtDbServer.Size = new System.Drawing.Size(294, 26);
            this.txtDbServer.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(193, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMegse
            // 
            this.btnMegse.Location = new System.Drawing.Point(299, 205);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(87, 35);
            this.btnMegse.TabIndex = 2;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // DBConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 259);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDbServer);
            this.Controls.Add(this.txtDbServerPort);
            this.Controls.Add(this.txtDbUsername);
            this.Controls.Add(this.txtDbPassword);
            this.Controls.Add(this.txtDatabaseSchema);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DBConnectionSettings";
            this.Text = "DBConnectionSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatabaseSchema;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.TextBox txtDbUsername;
        private System.Windows.Forms.TextBox txtDbServerPort;
        private System.Windows.Forms.TextBox txtDbServer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnMegse;
    }
}
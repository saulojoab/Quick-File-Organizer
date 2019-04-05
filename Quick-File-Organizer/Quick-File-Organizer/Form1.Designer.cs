namespace Quick_File_Organizer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.lblFilesFound = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muli ExtraLight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(165, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quickly organize your files easely:";
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSelectFolder.Font = new System.Drawing.Font("Muli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectFolder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btSelectFolder.Location = new System.Drawing.Point(214, 84);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(367, 58);
            this.btSelectFolder.TabIndex = 1;
            this.btSelectFolder.Text = "Select Your Folder";
            this.btSelectFolder.UseVisualStyleBackColor = false;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // lblFilesFound
            // 
            this.lblFilesFound.AutoSize = true;
            this.lblFilesFound.BackColor = System.Drawing.Color.Black;
            this.lblFilesFound.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesFound.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFilesFound.Location = new System.Drawing.Point(318, 162);
            this.lblFilesFound.Name = "lblFilesFound";
            this.lblFilesFound.Size = new System.Drawing.Size(152, 26);
            this.lblFilesFound.TabIndex = 2;
            this.lblFilesFound.Text = "Files Found: 100";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMusic.Location = new System.Drawing.Point(188, 194);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(92, 26);
            this.lblMusic.TabIndex = 3;
            this.lblMusic.Text = "Music: 10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(346, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Videos: 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(498, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documents: 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(794, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblFilesFound);
            this.Controls.Add(this.btSelectFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QFO - Quick File Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.Label lblFilesFound;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


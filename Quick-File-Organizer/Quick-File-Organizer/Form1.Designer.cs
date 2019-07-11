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
            this.lblVideos = new System.Windows.Forms.Label();
            this.lblDocuments = new System.Windows.Forms.Label();
            this.lblExecutables = new System.Windows.Forms.Label();
            this.pgProgress = new System.Windows.Forms.ProgressBar();
            this.lblImages = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
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
            this.lblFilesFound.Location = new System.Drawing.Point(336, 235);
            this.lblFilesFound.Name = "lblFilesFound";
            this.lblFilesFound.Size = new System.Drawing.Size(130, 26);
            this.lblFilesFound.TabIndex = 2;
            this.lblFilesFound.Text = "Files Found: 0";
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusic.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMusic.Location = new System.Drawing.Point(232, 277);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(81, 26);
            this.lblMusic.TabIndex = 3;
            this.lblMusic.Text = "Music: 0";
            // 
            // lblVideos
            // 
            this.lblVideos.AutoSize = true;
            this.lblVideos.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblVideos.Location = new System.Drawing.Point(360, 277);
            this.lblVideos.Name = "lblVideos";
            this.lblVideos.Size = new System.Drawing.Size(90, 26);
            this.lblVideos.TabIndex = 4;
            this.lblVideos.Text = "Videos: 0";
            // 
            // lblDocuments
            // 
            this.lblDocuments.AutoSize = true;
            this.lblDocuments.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocuments.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDocuments.Location = new System.Drawing.Point(497, 277);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(129, 26);
            this.lblDocuments.TabIndex = 5;
            this.lblDocuments.Text = "Documents: 0";
            // 
            // lblExecutables
            // 
            this.lblExecutables.AutoSize = true;
            this.lblExecutables.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecutables.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblExecutables.Location = new System.Drawing.Point(48, 277);
            this.lblExecutables.Name = "lblExecutables";
            this.lblExecutables.Size = new System.Drawing.Size(134, 26);
            this.lblExecutables.TabIndex = 6;
            this.lblExecutables.Text = "Executables: 0";
            // 
            // pgProgress
            // 
            this.pgProgress.Location = new System.Drawing.Point(214, 170);
            this.pgProgress.Name = "pgProgress";
            this.pgProgress.Size = new System.Drawing.Size(367, 44);
            this.pgProgress.TabIndex = 7;
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImages.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblImages.Location = new System.Drawing.Point(657, 277);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(93, 26);
            this.lblImages.TabIndex = 8;
            this.lblImages.Text = "Images: 0";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Muli ExtraLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCode.Location = new System.Drawing.Point(364, 314);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(77, 26);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Code: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(794, 349);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblImages);
            this.Controls.Add(this.pgProgress);
            this.Controls.Add(this.lblExecutables);
            this.Controls.Add(this.lblDocuments);
            this.Controls.Add(this.lblVideos);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblFilesFound);
            this.Controls.Add(this.btSelectFolder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QFO - Quick File Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.Label lblFilesFound;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lblVideos;
        private System.Windows.Forms.Label lblDocuments;
        private System.Windows.Forms.Label lblExecutables;
        private System.Windows.Forms.ProgressBar pgProgress;
        private System.Windows.Forms.Label lblImages;
        private System.Windows.Forms.Label lblCode;
    }
}


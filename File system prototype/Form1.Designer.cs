namespace Laba4_OS
{
    partial class FormFileSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView = new System.Windows.Forms.TreeView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAddCatalog = new System.Windows.Forms.Button();
            this.textBoxName_Catalog = new System.Windows.Forms.TextBox();
            this.textBoxName_File = new System.Windows.Forms.TextBox();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonPaste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView.Location = new System.Drawing.Point(6, 11);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(349, 250);
            this.treeView.TabIndex = 0;
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(361, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(951, 777);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonAddCatalog
            // 
            this.buttonAddCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCatalog.Location = new System.Drawing.Point(212, 270);
            this.buttonAddCatalog.Name = "buttonAddCatalog";
            this.buttonAddCatalog.Size = new System.Drawing.Size(94, 31);
            this.buttonAddCatalog.TabIndex = 5;
            this.buttonAddCatalog.Text = "Добавить";
            this.buttonAddCatalog.UseVisualStyleBackColor = true;
            this.buttonAddCatalog.Click += new System.EventHandler(this.ButtonAddCatalog_Click);
            // 
            // textBoxName_Catalog
            // 
            this.textBoxName_Catalog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName_Catalog.Location = new System.Drawing.Point(53, 270);
            this.textBoxName_Catalog.Name = "textBoxName_Catalog";
            this.textBoxName_Catalog.Size = new System.Drawing.Size(106, 27);
            this.textBoxName_Catalog.TabIndex = 6;
            // 
            // textBoxName_File
            // 
            this.textBoxName_File.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName_File.Location = new System.Drawing.Point(53, 342);
            this.textBoxName_File.Name = "textBoxName_File";
            this.textBoxName_File.Size = new System.Drawing.Size(106, 27);
            this.textBoxName_File.TabIndex = 9;
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFile.Location = new System.Drawing.Point(212, 342);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(94, 32);
            this.buttonAddFile.TabIndex = 10;
            this.buttonAddFile.Text = "Добавить";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteFile.Location = new System.Drawing.Point(129, 402);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(109, 41);
            this.buttonDeleteFile.TabIndex = 11;
            this.buttonDeleteFile.Text = "Удалить";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(56, 300);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(103, 20);
            this.label.TabIndex = 12;
            this.label.Text = "Имя каталога";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Имя файла";
            // 
            // buttonCopy
            // 
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.Location = new System.Drawing.Point(12, 451);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(111, 41);
            this.buttonCopy.TabIndex = 15;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaste.Location = new System.Drawing.Point(244, 451);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(111, 41);
            this.buttonPaste.TabIndex = 16;
            this.buttonPaste.Text = "Вставить";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // FormFileSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 783);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonDeleteFile);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.textBoxName_File);
            this.Controls.Add(this.textBoxName_Catalog);
            this.Controls.Add(this.buttonAddCatalog);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.treeView);
            this.Name = "FormFileSystem";
            this.Text = "Файловая система";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView;
        private PictureBox pictureBox;
        private Button buttonAddCatalog;
        private TextBox textBoxName_Catalog;
        private TextBox textBoxName_File;
        private Button buttonAddFile;
        private Button buttonDeleteFile;
        private Label label;
        private Label label2;
        private Button buttonCopy;
        private Button buttonPaste;
    }
}
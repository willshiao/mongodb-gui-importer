namespace MongoImporter
{
    partial class MainWindow
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
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.filePathLbl = new System.Windows.Forms.Label();
            this.fieldsListBox = new System.Windows.Forms.ListBox();
            this.delimiterLbl = new System.Windows.Forms.Label();
            this.delimiterBox = new System.Windows.Forms.TextBox();
            this.importBtn = new System.Windows.Forms.Button();
            this.databaseLbl = new System.Windows.Forms.Label();
            this.collectionLbl = new System.Windows.Forms.Label();
            this.databaseBox = new System.Windows.Forms.TextBox();
            this.collectionBox = new System.Windows.Forms.TextBox();
            this.fieldNameBox = new System.Windows.Forms.TextBox();
            this.addFieldBtn = new System.Windows.Forms.Button();
            this.batchSizeLbl = new System.Windows.Forms.Label();
            this.batchSizeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(12, 12);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseFileBtn.TabIndex = 0;
            this.chooseFileBtn.Text = "Choose File";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // filePathLbl
            // 
            this.filePathLbl.AutoSize = true;
            this.filePathLbl.Location = new System.Drawing.Point(93, 17);
            this.filePathLbl.Name = "filePathLbl";
            this.filePathLbl.Size = new System.Drawing.Size(33, 13);
            this.filePathLbl.TabIndex = 1;
            this.filePathLbl.Text = "None";
            // 
            // fieldsListBox
            // 
            this.fieldsListBox.FormattingEnabled = true;
            this.fieldsListBox.Location = new System.Drawing.Point(460, 12);
            this.fieldsListBox.Name = "fieldsListBox";
            this.fieldsListBox.Size = new System.Drawing.Size(224, 316);
            this.fieldsListBox.TabIndex = 2;
            // 
            // delimiterLbl
            // 
            this.delimiterLbl.AutoSize = true;
            this.delimiterLbl.Location = new System.Drawing.Point(12, 69);
            this.delimiterLbl.Name = "delimiterLbl";
            this.delimiterLbl.Size = new System.Drawing.Size(50, 13);
            this.delimiterLbl.TabIndex = 3;
            this.delimiterLbl.Text = "Delimiter:";
            // 
            // delimiterBox
            // 
            this.delimiterBox.Location = new System.Drawing.Point(85, 66);
            this.delimiterBox.MaxLength = 1;
            this.delimiterBox.Name = "delimiterBox";
            this.delimiterBox.Size = new System.Drawing.Size(100, 20);
            this.delimiterBox.TabIndex = 4;
            this.delimiterBox.Text = ":";
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(12, 200);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(75, 23);
            this.importBtn.TabIndex = 5;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // databaseLbl
            // 
            this.databaseLbl.AutoSize = true;
            this.databaseLbl.Location = new System.Drawing.Point(12, 97);
            this.databaseLbl.Name = "databaseLbl";
            this.databaseLbl.Size = new System.Drawing.Size(56, 13);
            this.databaseLbl.TabIndex = 6;
            this.databaseLbl.Text = "Database:";
            // 
            // collectionLbl
            // 
            this.collectionLbl.AutoSize = true;
            this.collectionLbl.Location = new System.Drawing.Point(12, 127);
            this.collectionLbl.Name = "collectionLbl";
            this.collectionLbl.Size = new System.Drawing.Size(56, 13);
            this.collectionLbl.TabIndex = 7;
            this.collectionLbl.Text = "Collection:";
            // 
            // databaseBox
            // 
            this.databaseBox.Location = new System.Drawing.Point(85, 94);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(100, 20);
            this.databaseBox.TabIndex = 8;
            // 
            // collectionBox
            // 
            this.collectionBox.Location = new System.Drawing.Point(85, 124);
            this.collectionBox.Name = "collectionBox";
            this.collectionBox.Size = new System.Drawing.Size(100, 20);
            this.collectionBox.TabIndex = 9;
            // 
            // fieldNameBox
            // 
            this.fieldNameBox.Location = new System.Drawing.Point(460, 334);
            this.fieldNameBox.Name = "fieldNameBox";
            this.fieldNameBox.Size = new System.Drawing.Size(143, 20);
            this.fieldNameBox.TabIndex = 10;
            this.fieldNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fieldNameBox_KeyDown);
            // 
            // addFieldBtn
            // 
            this.addFieldBtn.Location = new System.Drawing.Point(609, 331);
            this.addFieldBtn.Name = "addFieldBtn";
            this.addFieldBtn.Size = new System.Drawing.Size(75, 23);
            this.addFieldBtn.TabIndex = 11;
            this.addFieldBtn.Text = "Add Field";
            this.addFieldBtn.UseVisualStyleBackColor = true;
            this.addFieldBtn.Click += new System.EventHandler(this.addFieldBtn_Click);
            // 
            // batchSizeLbl
            // 
            this.batchSizeLbl.AutoSize = true;
            this.batchSizeLbl.Location = new System.Drawing.Point(12, 152);
            this.batchSizeLbl.Name = "batchSizeLbl";
            this.batchSizeLbl.Size = new System.Drawing.Size(61, 13);
            this.batchSizeLbl.TabIndex = 12;
            this.batchSizeLbl.Text = "Batch Size:";
            // 
            // batchSizeBox
            // 
            this.batchSizeBox.Location = new System.Drawing.Point(85, 149);
            this.batchSizeBox.MaxLength = 100;
            this.batchSizeBox.Name = "batchSizeBox";
            this.batchSizeBox.Size = new System.Drawing.Size(100, 20);
            this.batchSizeBox.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 522);
            this.Controls.Add(this.batchSizeBox);
            this.Controls.Add(this.batchSizeLbl);
            this.Controls.Add(this.addFieldBtn);
            this.Controls.Add(this.fieldNameBox);
            this.Controls.Add(this.collectionBox);
            this.Controls.Add(this.databaseBox);
            this.Controls.Add(this.collectionLbl);
            this.Controls.Add(this.databaseLbl);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.delimiterBox);
            this.Controls.Add(this.delimiterLbl);
            this.Controls.Add(this.fieldsListBox);
            this.Controls.Add(this.filePathLbl);
            this.Controls.Add(this.chooseFileBtn);
            this.Name = "MainWindow";
            this.Text = "Mongo Importer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.Label filePathLbl;
        private System.Windows.Forms.ListBox fieldsListBox;
        private System.Windows.Forms.Label delimiterLbl;
        private System.Windows.Forms.TextBox delimiterBox;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Label databaseLbl;
        private System.Windows.Forms.Label collectionLbl;
        private System.Windows.Forms.TextBox databaseBox;
        private System.Windows.Forms.TextBox collectionBox;
        private System.Windows.Forms.TextBox fieldNameBox;
        private System.Windows.Forms.Button addFieldBtn;
        private System.Windows.Forms.Label batchSizeLbl;
        private System.Windows.Forms.TextBox batchSizeBox;
    }
}


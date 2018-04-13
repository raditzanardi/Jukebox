namespace Jukebox
{
    partial class SetupForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnDeleteTrack = new System.Windows.Forms.Button();
            this.listImport = new System.Windows.Forms.ListBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClearImport = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNextGenre = new System.Windows.Forms.Button();
            this.btnPreviousGenre = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelSetup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearImport);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.listImport);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imported Tracks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPreviousGenre);
            this.groupBox2.Controls.Add(this.btnNextGenre);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(519, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 477);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Present Genre Track List";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(369, 130);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(144, 36);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy Track >>";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(369, 172);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(144, 34);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "Move Track >>";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTrack
            // 
            this.btnDeleteTrack.Location = new System.Drawing.Point(393, 283);
            this.btnDeleteTrack.Name = "btnDeleteTrack";
            this.btnDeleteTrack.Size = new System.Drawing.Size(95, 73);
            this.btnDeleteTrack.TabIndex = 4;
            this.btnDeleteTrack.Text = "Delete Track from Genre";
            this.btnDeleteTrack.UseVisualStyleBackColor = true;
            // 
            // listImport
            // 
            this.listImport.FormattingEnabled = true;
            this.listImport.ItemHeight = 16;
            this.listImport.Location = new System.Drawing.Point(6, 21);
            this.listImport.Name = "listImport";
            this.listImport.Size = new System.Drawing.Size(339, 356);
            this.listImport.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(7, 391);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(338, 36);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import Tracks from Directory";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnClearImport
            // 
            this.btnClearImport.Location = new System.Drawing.Point(6, 433);
            this.btnClearImport.Name = "btnClearImport";
            this.btnClearImport.Size = new System.Drawing.Size(339, 38);
            this.btnClearImport.TabIndex = 2;
            this.btnClearImport.Text = "Clear Import Tracks";
            this.btnClearImport.UseVisualStyleBackColor = true;
            this.btnClearImport.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 324);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genre Title";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "General";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(142, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNextGenre
            // 
            this.btnNextGenre.Location = new System.Drawing.Point(244, 389);
            this.btnNextGenre.Name = "btnNextGenre";
            this.btnNextGenre.Size = new System.Drawing.Size(98, 82);
            this.btnNextGenre.TabIndex = 5;
            this.btnNextGenre.Text = "Next >>";
            this.btnNextGenre.UseVisualStyleBackColor = true;
            // 
            // btnPreviousGenre
            // 
            this.btnPreviousGenre.Location = new System.Drawing.Point(22, 391);
            this.btnPreviousGenre.Name = "btnPreviousGenre";
            this.btnPreviousGenre.Size = new System.Drawing.Size(99, 82);
            this.btnPreviousGenre.TabIndex = 6;
            this.btnPreviousGenre.Text = "<<Previous";
            this.btnPreviousGenre.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(721, 536);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelSetup
            // 
            this.btnCancelSetup.Location = new System.Drawing.Point(802, 536);
            this.btnCancelSetup.Name = "btnCancelSetup";
            this.btnCancelSetup.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSetup.TabIndex = 6;
            this.btnCancelSetup.Text = "Cancel";
            this.btnCancelSetup.UseVisualStyleBackColor = true;
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 571);
            this.Controls.Add(this.btnCancelSetup);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDeleteTrack);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SetupForm";
            this.Text = "Setup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ListBox listImport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnDeleteTrack;
        private System.Windows.Forms.Button btnNextGenre;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPreviousGenre;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelSetup;
    }
}
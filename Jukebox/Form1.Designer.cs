﻿namespace Jukebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.txtPlayingNow = new System.Windows.Forms.TextBox();
            this.txtGenreTitle = new System.Windows.Forms.TextBox();
            this.lstboxTracks = new System.Windows.Forms.ListBox();
            this.lstboxPlaylist = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(13, 618);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 31);
            this.btnSetup.TabIndex = 1;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(94, 618);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 31);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCopyright.Location = new System.Drawing.Point(234, 9);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(222, 17);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "Copyright 2018 Radit Zanardi";
            // 
            // txtPlayingNow
            // 
            this.txtPlayingNow.BackColor = System.Drawing.Color.Lime;
            this.txtPlayingNow.Location = new System.Drawing.Point(101, 290);
            this.txtPlayingNow.Name = "txtPlayingNow";
            this.txtPlayingNow.ReadOnly = true;
            this.txtPlayingNow.Size = new System.Drawing.Size(246, 22);
            this.txtPlayingNow.TabIndex = 4;
            // 
            // txtGenreTitle
            // 
            this.txtGenreTitle.BackColor = System.Drawing.Color.Salmon;
            this.txtGenreTitle.Location = new System.Drawing.Point(101, 143);
            this.txtGenreTitle.Name = "txtGenreTitle";
            this.txtGenreTitle.ReadOnly = true;
            this.txtGenreTitle.Size = new System.Drawing.Size(246, 22);
            this.txtGenreTitle.TabIndex = 5;
            // 
            // lstboxTracks
            // 
            this.lstboxTracks.FormattingEnabled = true;
            this.lstboxTracks.HorizontalScrollbar = true;
            this.lstboxTracks.ItemHeight = 16;
            this.lstboxTracks.Location = new System.Drawing.Point(101, 160);
            this.lstboxTracks.Name = "lstboxTracks";
            this.lstboxTracks.Size = new System.Drawing.Size(246, 100);
            this.lstboxTracks.TabIndex = 6;
            this.lstboxTracks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstboxTracks_MouseDoubleClick);
            // 
            // lstboxPlaylist
            // 
            this.lstboxPlaylist.BackColor = System.Drawing.Color.Khaki;
            this.lstboxPlaylist.FormattingEnabled = true;
            this.lstboxPlaylist.ItemHeight = 16;
            this.lstboxPlaylist.Location = new System.Drawing.Point(132, 318);
            this.lstboxPlaylist.Name = "lstboxPlaylist";
            this.lstboxPlaylist.Size = new System.Drawing.Size(194, 148);
            this.lstboxPlaylist.TabIndex = 7;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(13, 50);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(289, 45);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(101, 263);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(246, 21);
            this.hScrollBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jukebox.Properties.Resources._6a0120a7b5f86a970b0153936c0efb970b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 683);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lstboxPlaylist);
            this.Controls.Add(this.lstboxTracks);
            this.Controls.Add(this.txtGenreTitle);
            this.Controls.Add(this.txtPlayingNow);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "My Jukebox v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox txtPlayingNow;
        private System.Windows.Forms.TextBox txtGenreTitle;
        private System.Windows.Forms.ListBox lstboxTracks;
        private System.Windows.Forms.ListBox lstboxPlaylist;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}


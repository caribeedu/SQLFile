﻿namespace SQLPhotos
{
  partial class FormView
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
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.BtnDownload = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox
      // 
      this.pictureBox.Location = new System.Drawing.Point(12, 12);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(260, 237);
      this.pictureBox.TabIndex = 0;
      this.pictureBox.TabStop = false;
      // 
      // BtnDownload
      // 
      this.BtnDownload.Location = new System.Drawing.Point(12, 255);
      this.BtnDownload.Name = "BtnDownload";
      this.BtnDownload.Size = new System.Drawing.Size(260, 23);
      this.BtnDownload.TabIndex = 1;
      this.BtnDownload.Text = "Download";
      this.BtnDownload.UseVisualStyleBackColor = true;
      this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
      // 
      // FormView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 282);
      this.Controls.Add(this.BtnDownload);
      this.Controls.Add(this.pictureBox);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormView";
      this.Text = "SQL Photos";
      this.Load += new System.EventHandler(this.FormView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.Button BtnDownload;
  }
}
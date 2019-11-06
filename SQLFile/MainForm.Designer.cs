namespace SQLFile
{
  partial class MainForm
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
      this.BtnView = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxQuery = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.comboBox = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // BtnView
      // 
      this.BtnView.Location = new System.Drawing.Point(15, 326);
      this.BtnView.Name = "BtnView";
      this.BtnView.Size = new System.Drawing.Size(230, 23);
      this.BtnView.TabIndex = 0;
      this.BtnView.Text = "Download File";
      this.BtnView.UseVisualStyleBackColor = true;
      this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Server:";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(15, 30);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(230, 20);
      this.textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(15, 83);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(230, 20);
      this.textBox2.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Database:";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(15, 136);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(230, 20);
      this.textBox3.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 115);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "User:";
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(15, 189);
      this.textBox4.Name = "textBox4";
      this.textBox4.PasswordChar = '•';
      this.textBox4.Size = new System.Drawing.Size(230, 20);
      this.textBox4.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 168);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Password:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 274);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "File Type:";
      // 
      // textBoxQuery
      // 
      this.textBoxQuery.Location = new System.Drawing.Point(15, 242);
      this.textBoxQuery.Name = "textBoxQuery";
      this.textBoxQuery.Size = new System.Drawing.Size(230, 20);
      this.textBoxQuery.TabIndex = 12;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 221);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(38, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Query:";
      // 
      // comboBox
      // 
      this.comboBox.FormattingEnabled = true;
      this.comboBox.Items.AddRange(new object[] {
            "Excel 2003 (.xls)",
            "Excel 2010 (.xlsx)",
            "Word 2003 (.doc)",
            "Word 2010 (.docx)",
            "PDF (.pdf)",
            "PNG (.png)",
            "JPG (.jpg)",
            "JPEG (.jpeg)",
            "SVG (.svg)",
            "MP4 (.mp4)",
            "MP3 (.mp3)",
            "AVI (.avi)",
            "WAV (.wav)"});
      this.comboBox.Location = new System.Drawing.Point(15, 294);
      this.comboBox.Name = "comboBox";
      this.comboBox.Size = new System.Drawing.Size(230, 21);
      this.comboBox.TabIndex = 13;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(259, 361);
      this.Controls.Add(this.comboBox);
      this.Controls.Add(this.textBoxQuery);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BtnView);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(275, 400);
      this.MinimumSize = new System.Drawing.Size(275, 400);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SQL File";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnView;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxQuery;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox comboBox;
  }
}


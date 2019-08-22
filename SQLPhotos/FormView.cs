using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SQLPhotos
{
  public partial class FormView : Form
  {
    private byte[] File;

    public FormView(byte[] ReceivedFile)
    {
      InitializeComponent();
      File = ReceivedFile;
    }

    private void FormView_Load(object sender, EventArgs e)
    {
      MemoryStream MS = new MemoryStream();
      MS.Write(File, 0, Convert.ToInt32(File.Length));
      pictureBox.Image = new Bitmap(MS, false);
      MS.Dispose();
    }

    private void BtnDownload_Click(object sender, EventArgs e)
    {
      Stream Stream = new MemoryStream(File);
      Bitmap BM = new Bitmap(Stream);

      using (SaveFileDialog SaveFile = new SaveFileDialog())
      {
        SaveFile.Filter = "PNG Files|*.png";
        if (SaveFile.ShowDialog(this) == DialogResult.OK)
        {
          BM.Save(SaveFile.FileName, ImageFormat.Png);
          MessageBox.Show("Imagem salva com sucesso.");
        }
      }
    }
  }
}

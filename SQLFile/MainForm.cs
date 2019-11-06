using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SQLFile
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void BtnView_Click(object sender, EventArgs e)
    {
      if(textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBoxQuery.Text.Equals("") || comboBox.Text.Equals(""))
      {
        MessageBox.Show("Properly complete all fields.");
        return;
      }

      string ConnectionString = string.Format("Server={0};Database={1};User Id={2}; Password={3};", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

      try
      {
        SqlDataAdapter DataAdapter = new SqlDataAdapter(textBoxQuery.Text, ConnectionString);
        DataTable DT = new DataTable();
        DataAdapter.Fill(DT);

        if (DT.Rows.Count <= 0)
        {
          MessageBox.Show("No rows were found.");
          textBoxQuery.Text = string.Empty;
          return;
        }
        else if(DT.Rows.Count > 1)
        {
          MessageBox.Show("More than one row was found.");
          textBoxQuery.Text = string.Empty;
          return;
        }
        else
        {
          try
          {
            byte[] FileBuffer = (byte[])DT.Rows[0].ItemArray[0];

            SaveFileDialog FileDialog = new SaveFileDialog();
            FileDialog.Filter = comboBox.Text.Replace("(", "|*").Replace(")", string.Empty);
            FileDialog.Title = "Save file";
            FileDialog.AddExtension = true;
            FileDialog.RestoreDirectory = true;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {              
              File.WriteAllBytes(FileDialog.FileName, FileBuffer);
            }
          }
          catch
          {
            MessageBox.Show("The selected cell is not a valid file.");
            return;
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("[{0}] Erro {1}: {2}", DateTime.Now.ToString("dd/MM/yyyy HH:mm"), ex.HResult.ToString().Replace("-", ""), ex.Message));
      }
    }
  }
}

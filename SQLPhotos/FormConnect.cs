using SQLPhotos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLFotos
{
  public partial class FormConnect : Form
  {
    public FormConnect()
    {
      InitializeComponent();
    }

    private void BtnView_Click(object sender, EventArgs e)
    {
      string ConnectionString = string.Format("Server={0};Database={1};User Id={2}; Password={3};", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

      try
      {
        SqlDataAdapter DataAdapter = new SqlDataAdapter(textBox5.Text, ConnectionString);
        DataTable DT = new DataTable();
        DataAdapter.Fill(DT);

        if (DT.Rows.Count != 1)
        {
          MessageBox.Show("Mais de uma ou nenhuma linha(s) foram encontrada(s).");
          textBox5.Text = "";
          return;
        }
        else
        {
          byte[] File = (byte[])DT.Rows[0].ItemArray[0];
          FormView Form = new FormView(File);
          Form.ShowDialog();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Erro ({0}): {1}", ex.HResult, ex.Message));
      }
    }
  }
}

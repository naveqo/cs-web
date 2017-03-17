using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class index : System.Web.UI.Page
{

  public DataTable dt;

  public DataTable GetData()
  {
    var table = new DataTable();

    var connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    using (var conn = new SqlConnection(connectionString))
    using (var command = conn.CreateCommand())
    {
      try
      {
        // データベースの接続開始
        conn.Open();

        // SQLの設定
        command.CommandText = @"SELECT * FROM Staff";

        // SQLの実行
        var adapter = new SqlDataAdapter(command);
        adapter.Fill(table);
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
        throw;
      }
      finally
      {
        // データベースの接続終了
        conn.Close();
      }
    }
    return table;
  }


  protected void Page_Load(object sender, EventArgs e)
  {
    dt = GetData();


  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test : System.Web.UI.Page
{

  public Complex z = new Complex();

  protected void Page_Load(object sender, EventArgs e)
  {
    z.re = 3;
    z.im = 4;
    double abs = z.Abs();
    string aaa = z.ToString();

    Response.Write(abs + "<br>");
    Response.Write(aaa);
  }
}

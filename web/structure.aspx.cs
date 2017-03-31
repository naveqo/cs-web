using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class structure : System.Web.UI.Page
{

  struct Sample
  {
    public int _x;
    public int _y;

    public Sample(int x, int y)
    {
      _x = x;
      _y = y;
      M();
    }

    void M() { }
  }


  protected void Page_Load(object sender, EventArgs e)
  {
    Sample s = new Sample();
    Response.Write(s._x);
  }
}
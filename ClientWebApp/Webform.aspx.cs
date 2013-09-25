using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Webform : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        int result = web.add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        TextBox3.Text = Convert.ToString(result);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        int result = web.subtract(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        TextBox3.Text = Convert.ToString(result);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        int result = web.multiply(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        TextBox3.Text = Convert.ToString(result);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        int result = web.divide(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        TextBox3.Text = Convert.ToString(result);
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}
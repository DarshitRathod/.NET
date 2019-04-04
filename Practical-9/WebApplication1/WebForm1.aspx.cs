using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        service.WebService1 calc = new service.WebService1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblans.Text = calc.Add(Convert.ToInt16(txtinput1.Text), Convert.ToInt16(txtinput2.Text)).ToString();
           
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            lblans.Text = calc.Sub(Convert.ToInt16(txtinput1.Text), Convert.ToInt16(txtinput2.Text)).ToString();
        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            lblans.Text = calc.Mul(Convert.ToInt16(txtinput1.Text), Convert.ToInt16(txtinput2.Text)).ToString();
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            lblans.Text = calc.Div(Convert.ToInt16(txtinput1.Text), Convert.ToInt16(txtinput2.Text)).ToString();
        }
    }
}
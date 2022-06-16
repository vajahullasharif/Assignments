using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_2
{
    public partial class Bikes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "Hayabusa bike", "Bmw bike", "Harley Davidson bike", "KTM bike", "R15 bike" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/Images/" + str + ".jfif";

        }
        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Hayabusa bike")
            {
                TextBox1.Text = "Rs 1600000";
            }
            else if (DropDownList1.Text == "Bmw bike")
            {
                TextBox1.Text = "Rs 1400000";
            }
            else if (DropDownList1.Text == "Harley Davidson bike")
            {
                TextBox1.Text = "Rs 1500000";
            }
            else if (DropDownList1.Text == "KTM bike")
            {
                TextBox1.Text = "Rs 1600000";
            }
            else if (DropDownList1.Text == "R15 bike")
            {
                TextBox1.Text = "Rs 1200000";
            }
            else
            {
                TextBox1.Text = "Rs 4000000";
            }
        }
    }
}
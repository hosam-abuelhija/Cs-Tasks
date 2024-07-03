using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = $"Name: {TextBox1.Text}";
            Label3.Text = $"Email: {TextBox2.Text}";
            Label4.Text = $"ID: {TextBox3.Text}";

            if (CheckBox1.Checked)
            {
                Label5.Text = CheckBox1.Text;
            }
            else
            {
                Label5.Text = "";
            }
            if (CheckBox2.Checked)
            {
                Label8.Text = CheckBox2.Text;
            }
            else
            {
                Label8.Text = "";
            }
            if (CheckBox3.Checked)
            {
                Label9.Text = CheckBox3.Text;
            }
            else
            {
                Label9.Text = "";
            }
            if (RadioButtonList1.SelectedItem.Selected)
            {
                Label6.Text = RadioButtonList1.SelectedItem.Text;
            }
            Label7.Text = $"Description: {TextBox4.Text}";
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
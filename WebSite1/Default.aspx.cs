using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Label1.Text = "Hello FIme";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       

        if (DropDownList1.SelectedValue == "Suma")
        {
            int num1 = Convert.ToInt32(this.TextBox1.Text);
            int num2 = Convert.ToInt32(this.TextBox2.Text);
            int sum = num1 + num2;
            this.Label2.Text = sum.ToString();
        }
        if (DropDownList1.SelectedValue == "Resta")
        {
            int num1 = Convert.ToInt32(this.TextBox1.Text);
            int num2 = Convert.ToInt32(this.TextBox2.Text);
            
            int sum = num1 - num2;

            this.Label2.Text = sum.ToString();
        }

        if (DropDownList1.SelectedValue == "Multiplicacion")
        {
            int num1 = Convert.ToInt32(this.TextBox1.Text);
            int num2 = Convert.ToInt32(this.TextBox2.Text);
            int sum = num1 * num2;
            this.Label2.Text = sum.ToString();
        }

        if (DropDownList1.SelectedValue == "Divisiones")
        {
            int num1 = Convert.ToInt32(this.TextBox1.Text);
            int num2 = Convert.ToInt32(this.TextBox2.Text);
            int sum = num1 * num2;
            this.Label2.Text = sum.ToString();
        }

        // this.Label2.Text = (Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
             

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string texto = "";
        string operador = this.DropDownList2.SelectedItem.Text;

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                texto += operador;
            }
            texto += "<br />";
            this.Label4.Text = texto;
        }

    }

}
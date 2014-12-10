using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ad_Category : System.Web.UI.Page
{
    ConnectMySQL connectMySql;

    protected void Page_Load(object sender, EventArgs e)
    {
        connectMySql = new ConnectMySQL();
        addItemComboBox();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //  Literal1.Text = "<div class='alert alert-success alert-dismissable'><button type='button' class='close' data-dismiss='alert' aria-hidden='true'>×</button>Lorem ipsum dolor sit amet, consectetur adipisicing elit. <a href='#' class='alert-link'>Alert Link</a>. </div>";
        if (connectMySql.checkMatchCategory(txt_cateName.Text) == true)
        {
            int parent = Int32.Parse(dropListParent.SelectedValue);
            connectMySql.insertCategory(txt_cateName.Text, Int32.Parse(txt_index.Text), parent, txt_url.Text);
            addItemComboBox();
        }
        else
        {

        }
    }

    private void addItemComboBox()
    {
        Dictionary<string, int> test = connectMySql.selectParentCategory();

        dropListParent.DataSource = test;
        dropListParent.DataTextField = "Key";
        dropListParent.DataValueField = "Value";

        dropListParent.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void txt_cateName_TextChanged(object sender, EventArgs e)
    {

    }
}
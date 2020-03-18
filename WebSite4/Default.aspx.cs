using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            refreshdata();
        }
    }

    public void refreshdata()
    {


        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\BHARGAVA K\Desktop\WebSite4\WebSite4\Website41.mdb");
        OleDbCommand cmd = new OleDbCommand("select * from tbl_data",con);
        OleDbDataAdapter olda = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        olda.Fill(dt);
        
 
    
        GridView1.DataSource = dt;
        GridView1.DataBind();
 
    
    
    }


}
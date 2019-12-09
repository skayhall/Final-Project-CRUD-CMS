using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace FinalProject_PagesCMS
{
    public partial class ListPageCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pagecms_result.InnerHtml = "";

            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = pagecms_search.Text;
            }
            // query for MySQL to search for page title from database
            string query = "select * from pagecmsinfo";

            if (searchkey != "")
            {   //annying little space between the " and WHERE was making it not work. 
                //ahhhh so annoying. I have to remember that c# is very case sensitive and
                //a strongly typed language. Have to really be careful. 
                query += " where pagecmstitle like '%"+searchkey+"%' ";
            }
            //displays query result
            sql_searcher.InnerHtml = query;

            //lists pages populated from database
            var db = new PagesCMSDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                pagecms_result.InnerHtml += "<div class=\"listitem\">";

                string pagecmsid = row["pagecmsid"];

                string pagecmstitle = row["pagecmstitle"];
                pagecms_result.InnerHtml += "<div class=\"col2\"><a href=\"ShowPageCMS.aspx?pagecmsid=" + pagecmsid + "\">" + pagecmstitle + "</a></div>";

                string pagecmsbody = row["pagecmsbody"];
                pagecms_result.InnerHtml += "<div class=\"col2last\">" + pagecmsbody + "</div>";

                pagecms_result.InnerHtml += "</div>";
            }
        }
    }
}
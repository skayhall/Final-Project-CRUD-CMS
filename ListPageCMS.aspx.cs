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

            string query = "select * from pagecmsinfo";
            if (searchkey != "")
            {
                query += "where pagecmstitle like '%" + searchkey + "%'";
                query += "where pagecmsbody like '%" + searchkey + "%'";
            }

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
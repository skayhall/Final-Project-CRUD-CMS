using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_PagesCMS
{
    public partial class FeaturedPageCMS : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PagesCMSDB db = new PagesCMSDB();
            ListFeaturedPageCMS(db);
        }

        protected void ListFeaturedPageCMS(PagesCMSDB db)
        {
            //query to select all of pages from table
            string query = " SELECT * from pagecmsinfo ";
            List<Dictionary<String, String>> rs = db.List_Query(query);

            foreach (Dictionary<String, String> row in rs)
            {   //displays the page titles using user control 
                //string stores pagecmsid to be used later 
                string pagecmsid = row["pagecmsid"];
                //show all pages on page
                //grab page using pagecmsid url, then grab the pagecmsid from the string we did above then show the page title - seperated by |
                featured_pagecms.InnerHtml += "<a href=\"ShowPageCMS.aspx?pagecmsid=" + pagecmsid + "\">" + row["pagecmstitle"] + " | " + "</a>";
                
             
            }
        }
    }
}
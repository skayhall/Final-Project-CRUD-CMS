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
            //tried quering for the pages id to display as a user control on the 
            //list page and it's not working.
            string query = " SELECT pagecmsid from pagecmsinfo ";
            List<Dictionary<String, String>> rs = db.List_Query(query);

            foreach (Dictionary<String, String> row in rs)
            {
                featured_pagecms.InnerHtml += row["Page "] + " " +  "<br>";


            }
        }
    }
}
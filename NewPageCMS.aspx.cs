using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_PagesCMS
{
    public partial class NewPageCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_PageCMS(object sender, EventArgs e)
        {
            //creates a  connection
            PagesCMSDB db = new PagesCMSDB();

            //creates a new page
            PageCMS new_pagecms = new PageCMS();

            //sets the page data
            new_pagecms.SetCMStitle(page_title.Text);
            new_pagecms.SetCMSbody(page_body.Text);


            //adds the page to the database
            db.AddPageCMS(new_pagecms);


            Response.Redirect("ListPageCMS.aspx");
        }


    }
}
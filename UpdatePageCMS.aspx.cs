using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_PagesCMS
{
    public partial class UpdatePageCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Only show the data when the user visits the page for the first time
            //HAVE TO MAKE SURE WE PUT
            if (!Page.IsPostBack)
            {
                //this connection instance is for showing data
                PagesCMSDB db = new PagesCMSDB();
                ShowPageInfo(db);
            }
        }

        protected void Update_PageCMS(object sender, EventArgs e)
        {

            //this connection instance is for editing data
            PagesCMSDB db = new PagesCMSDB();

            bool valid = true;
            string pagecmsid = Request.QueryString["pagecmsid"];
            if (String.IsNullOrEmpty(pagecmsid)) valid = false;
            if (valid)
            {
                PageCMS new_pagecms = new PageCMS();
                //sets page data
                new_pagecms.SetCMStitle(pagecms_title.Text);
                new_pagecms.SetCMSbody(pagecms_body.Text);

                //adds page to the database
                try
                {
                    db.UpdatePageCMS(Int32.Parse(pagecmsid), new_pagecms);
                    Response.Redirect("ShowPageCMS.aspx?pagecmsid=" + pagecmsid);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {   //if not valid
                PageUpdateCMS.InnerHtml = "There was an error updating that page.";
            }

        }

        protected void ShowPageInfo(PagesCMSDB db)
        {

            bool valid = true;
            string pagecmsid = Request.QueryString["pagecmsid"];
            if (String.IsNullOrEmpty(pagecmsid)) valid = false;

           
            if (valid)
            {

                PageCMS pagecms_record = db.FindPageCMS(Int32.Parse(pagecmsid));
              
                pagecms_title.Text = pagecms_record.GetCMStitle();
                pagecms_body.Text = pagecms_record.GetCMSbody();

            }
   
            //if not valid
            if (!valid)
            {

                PageUpdateCMS.InnerHtml = "There was an error finding that page.";
            }
        }
    }
}
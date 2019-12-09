using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace FinalProject_PagesCMS
{
    public partial class ShowPageCMS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PagesCMSDB db = new PagesCMSDB();
            ShowPageInfo(db);

        }

        protected void ShowPageInfo(PagesCMSDB db)
        {   //Debug.WriteLine allows to check for errors in the Debug Output window easier
            Debug.WriteLine("I am trying to show a page");
            bool valid = true;
            string pagecmsid = Request.QueryString["pagecmsid"];
            if (String.IsNullOrEmpty(pagecmsid)) valid = false;


            if (valid)
            {
                //finds page title and body info and displays it
                PageCMS page_record = db.FindPageCMS(Int32.Parse(pagecmsid));

                Debug.WriteLine("the page is "+ page_record.GetCMStitle());
                page_title.InnerHtml = page_record.GetCMStitle();
                page_body.InnerHtml = page_record.GetCMSbody();

            }
            else
            {
                valid = false;
            }


            if (!valid)
            {   //displays if the user goes to the page directly and not from
                //the list page
                pagecms.InnerHtml = "There was an error finding that page.";
            }
        }



        protected void Delete_PageCMS(object sender, EventArgs e)
        {
            bool valid = true;
            string pagecmsid = Request.QueryString["pagecmsid"];
            if (String.IsNullOrEmpty(pagecmsid)) valid = false;

            PagesCMSDB db = new PagesCMSDB();

            //deleting the page from the system
            if (valid)
            {
                db.DeletePageCMS(Int32.Parse(pagecmsid));
                Response.Redirect("ListPageCMS.aspx");
            }
        }



    }
}
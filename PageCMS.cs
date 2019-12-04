using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace FinalProject_PagesCMS
{
    public class PageCMS
    {

        private string CMStitle;
        private string CMSbody;

        /*
         methods which get and set values for the page - encapsulation  
        */

        public string GetCMStitle()
        {
            return CMStitle;
        }
        public string GetCMSbody()
        {
            return CMSbody;
        }

        public void SetCMStitle(string value)
        {
            CMStitle = value;
        }
        public void SetCMSbody(string value)
        {
            CMSbody = value;
        }


    }
}
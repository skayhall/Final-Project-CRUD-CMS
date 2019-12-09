using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace FinalProject_PagesCMS
{
    public class PagesCMSDB
    {
     
        //make sure this information is exactly the same from the XAMPP and
        //the correct permissions are given to assess it!
        private static string User { get { return "test_user"; } }
        private static string Password { get { return "test"; } }
        private static string Database { get { return "pagescms"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //ConnectionString connects to the database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }


        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

      
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                //opens db connection
                Connect.Open();
                //gives the connection a query
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grabs the result set
                MySqlDataReader resultset = cmd.ExecuteReader();


                //for every row in the result set
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    //for every column in the row
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }//end row
                resultset.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }



            public PageCMS FindPageCMS(int pagecmsid)
            {
                MySqlConnection Connect = new MySqlConnection(ConnectionString);

                PageCMS result_pagecms = new PageCMS();


                try
            {

                string query = "select * from pagecmsinfo where pagecmsid = " + pagecmsid;
                Debug.WriteLine("Connection Initialized...");

                Connect.Open();

                MySqlCommand cmd = new MySqlCommand(query, Connect);
  
                MySqlDataReader resultset = cmd.ExecuteReader();

                List<PageCMS> pagecms = new List<PageCMS>();

    
                while (resultset.Read())
                {
  
                    PageCMS currentpagecms = new PageCMS();

                    
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);
                      
                        switch (key)
                        {
                            case "pagecmstitle":
                                currentpagecms.SetCMStitle(value);
                                break;
                            case "pagecmsbody":
                                currentpagecms.SetCMSbody(value);
                                break;
                        }

                    }
                  
                    pagecms.Add(currentpagecms);
                }

                result_pagecms = pagecms[0]; 

            }
            catch (Exception ex)
            {
               
                Debug.WriteLine("Something went wrong in the find Page method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return result_pagecms;
        }

        
        public void AddPageCMS(PageCMS new_pagecms)
        {
            

            string query = "insert into pagecmsinfo (pagecmstitle, pagecmsbody) values ('{0}','{1}')";
            query = String.Format(query, new_pagecms.GetCMStitle(), new_pagecms.GetCMSbody());

            
        

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddPageCMS Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }


        public void UpdatePageCMS(int pagecmsid, PageCMS new_pagecms)
        {
            
            string query = "update pagecmsinfo set pagecmstitle='{0}', pagecmsbody='{1}' where pagecmsid={2}";
            query = String.Format(query, new_pagecms.GetCMStitle(), new_pagecms.GetCMSbody(), pagecmsid);
            query = String.Format(query, new_pagecms.GetCMStitle(), new_pagecms.GetCMSbody());

            

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
               
                Debug.WriteLine("Something went wrong in the UpdatePageCMS Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void DeletePageCMS(int pagecmsid)
        {
           

            //deletes the primary key of pages 

            string removepagecms = "delete from pagecmsinfo where pagecmsid = {0}";
            removepagecms = String.Format(removepagecms, pagecmsid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //This command removes the particular page from the table
            MySqlCommand cmd_removepagecms = new MySqlCommand(removepagecms, Connect);
            try
            {
                
                Connect.Open();

             
                cmd_removepagecms.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removepagecms);
            }
            catch (Exception ex)
            {
               
                Debug.WriteLine("Something went wrong in the delete PageCMS Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

    }

}       

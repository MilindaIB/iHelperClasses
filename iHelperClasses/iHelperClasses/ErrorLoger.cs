using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iHelperClasses
{
    public class ErrorLogger
    {

        /// <summary>
        /// Please use below setting on app.config or web.config for logfile path(Create Log folder manualy if not exist
        /// 
        /// <appsetting>
        ///  <add key="LogFilePath" value="\Log\Log.txt"/>
        /// </apsetting>
        /// 
        /// </summary>
        /// <param name="Err"></param>



        public static void ErrorWriter(string Err)
        {
            
                try
                {

                    if (!String.IsNullOrEmpty(Err)) 
                    {
                        string path = ConfigurationManager.AppSettings["LogFilePath"];
                        Err = Err + "---Start---/n<<Occurred on" + DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString() + ">>/n---End---";
                        string relativePath = ConfigurationManager.AppSettings["LogFilePath"];
                       string vPath = AppDomain.CurrentDomain.BaseDirectory+""+relativePath;



                        if (File.Exists(vPath))
                        {
                            TextWriter tw = new StreamWriter(vPath, true);
                            tw.WriteLine(Err);
                            tw.Close();
                        }
                        else {
                            var file = File.CreateText(vPath);
                            file.Close();
                                using (StreamWriter writer = new StreamWriter(vPath))
	                            {
	                         
	                                writer.WriteLine(Err);
                                  
                                    writer.Flush(); 

	                            }
                    
                            
                        }

                    }
                }
                catch (Exception)
                {
                    
                   // throw;
                }
              
            
        }

    }
}

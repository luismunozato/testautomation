using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAutomation
{
   public  class LoginPage
    {
       public void Go()
       {

           var driver = new FirefoxDriver();
           driver.Navigate().GoToUrl("https://wordpress.com/wp-login.php");

       }
    }
}

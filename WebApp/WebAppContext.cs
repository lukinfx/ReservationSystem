using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class WebAppContext
    {
        public string Username;
        public string Password;
        public bool ValidUser;

        private static WebAppContext instance;

        public static WebAppContext Instance()
        {
            if (instance == null)
            {
                instance = new WebAppContext();
            }

            return instance;
        }
    }
}
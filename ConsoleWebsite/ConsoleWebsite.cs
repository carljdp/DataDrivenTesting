using System;

namespace ConsoleWebsite
{

    public static class Website
    {
        

        
        
        public static bool IsValidUserAuthObject(object objToTest)
        {
            var result = false;
            
            try
            {
                var userAuth = (UserAuth) objToTest;

                if ((userAuth != null) && (userAuth.Username != "") && (userAuth.Password != ""))
                {
                    result = true;
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }
        
    }


    public class UserAuth
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
    
    
}
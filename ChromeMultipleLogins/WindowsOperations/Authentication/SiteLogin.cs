/**
 * Author: Frank H.
 */
using AutoIt;

namespace WindowsOperations.Authentication {
    public class SiteLogin {
        public class AuthWindow {          
            /**
             *  Log in as specific User, specified by name.
             */
            public static void LoginUser(string username, string password) {
                AutoItX.WinActivate("Authentication Required");
                AutoItX.Send(username);
                AutoItX.Send("{TAB}");
                AutoItX.Send(password);
                AutoItX.Send("{TAB}");
                AutoItX.Send("{ENTER}");
            } 
        }
    }
}
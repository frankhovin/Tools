using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfluencePageBackup.Validators {
    public class UrlValidator {
        /**
         * Returns true if the string is a valid URL.
         */
        public static bool IsValid (string uriName) {
            string url = "";
            bool result = false;

            try {
                if (!uriName.Substring(0, 7).Equals("http://")) {        
                    url = "http://" + uriName.Substring(0, 7);
                }
                else {
                    url = uriName;
                }
            } catch (System.ArgumentOutOfRangeException aoore) {
                Console.WriteLine(aoore);
            }

            try {
                Uri uriResult;
                result = Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            } catch (System.InvalidOperationException ioe) {
                Console.WriteLine(ioe);
            }

            return result;
        }


    }
}

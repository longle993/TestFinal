using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;

namespace TestManagement.DTO
{
    public class UPDATE_CHECK
    {
        public string Type_Update { get; set; }
        public string DateTimeUpdate { get; set; }
        public static FirebaseConfig Firebaseconfig = new FirebaseConfig()
        {
            AuthSecret = "Ed8O78DPwVh2UidzWlfxNvZF7fVIJgfjY0OeWFig",
            BasePath = "https://test-management-ec0bd-default-rtdb.firebaseio.com/"
        };
        public static FireSharp.FirebaseClient Client = new FireSharp.FirebaseClient(Firebaseconfig);
        public static void SetTable(string table)
        {
            var res = Client.Get(@"Update/" + table);
            UPDATE_CHECK check = res.ResultAs<UPDATE_CHECK>();

            if (check == null)
            {
                check = new UPDATE_CHECK() { DateTimeUpdate = DateTime.Now.ToString(), Type_Update = table };
                var set = Client.Set(@"Update/" + table, check);
            }
        }
        public static void NotifyChange(string table)
        {
            var res = Client.Get(@"Update/" + table);
            UPDATE_CHECK check = res.ResultAs<UPDATE_CHECK>();
            check.DateTimeUpdate = DateTime.Now.ToString();
            var set = Client.Update(@"Update/" + table, check);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    class UserNameDisplay
    {
        static string UserName;

        public static string username
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class UserHelper
    {
        public static string GetFIO(this User user)
        {
            return user.FIO;
        }

        public static void SetParam(ref long a)
        {
            a = 10;
        }

        public static void GetParam(out long a)
        {           
            a = 10;
        }
    }
}

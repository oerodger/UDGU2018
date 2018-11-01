using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class User: IEntity
    {
        public string FIO { get; set; }

        public string Id { get; set; }
    }

    public struct UserStruct
    {
        public string FIO;
    }
}

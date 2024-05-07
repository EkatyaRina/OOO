using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООО_Ткани.Model
{
    public class UserSingleton
    {
        public static bool isAuth = false;
        public static User Person { get; set; }
    }
}

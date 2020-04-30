using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public static class CurrentUser
    {
        private static User user;

        public static User Get() { return user; }

        public static void  Set(User user) { CurrentUser.user = user; }
    }
}

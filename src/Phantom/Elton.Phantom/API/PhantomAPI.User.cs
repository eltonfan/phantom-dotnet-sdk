// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.API
{
    partial class PhantomAPI
    {
        public User GetUser()
        {
            return GET<User>("user.json");
        }

    }
}

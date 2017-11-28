// Coded by chuangen http://chuangen.name.

using Elton.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom.Version1
{
    partial class PhantomAPI
    {
        public User GetUser()
        {
            return GetJson<User>("user.json");
        }

    }
}

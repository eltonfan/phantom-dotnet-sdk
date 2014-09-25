using Mavplus.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.API
{
    partial class PhantomAPI
    {
        public User GetUser()
        {
            return GET<User>("user.json");
        }

    }
}

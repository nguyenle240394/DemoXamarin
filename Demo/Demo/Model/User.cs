using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.model
{
    public class User
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string EnterpriseCode { get; set; }
    }
}

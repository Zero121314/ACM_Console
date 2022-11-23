using System;
using System.Collections.Generic;
using System.Text;

namespace Module
{
    public partial class TenantUser
    {
        public int Id { get; set; }

        public User User { get; set; }

        public Tenant Tenant { get; set; }

        public int MyProperty { get; set; }
    }
}

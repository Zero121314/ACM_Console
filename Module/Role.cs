using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Module
{
    public partial class Role
    {
        [Key]
        public Guid RoleId { get; set; }

        public string RoleName { get; set; }

        [ForeignKey(nameof(Tenant))]
        public Guid TenantId { get; set; }

        public string Permissions { get; set; }

        public Tenant Tenant { get; set; }
    }
}

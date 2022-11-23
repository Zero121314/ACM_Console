using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Module
{
    [Table("Tenant")]
    public partial class Tenant
    {
        public Tenant()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public Guid TenantId { get; set; }

        public string TenantName { get; set; }

        public string Address { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

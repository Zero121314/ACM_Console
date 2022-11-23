using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace Module
{
    [Table("User")]
    public partial class User
    {

        public User()
        {
            Tenants = new HashSet<Tenant>();
        }

        [Key]
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get; set; }

        [ForeignKey("Tenants")]
        public Guid TenantId { get; set; }

        public virtual ICollection<Tenant> Tenants { get; set; }    
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevExtremeMvcApp1.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Gender { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
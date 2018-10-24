using System;
using System.ComponentModel.DataAnnotations;
using Petrol_Pump_Point_Of_Sale_System.Core.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class UserRole : IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string UserRoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        private int _createdBy;

        public int CreatedBy
        {
            get { return _createdBy; }
            set
            {
                _createdBy = value;
                _createdBy = 0;
            }
        }

        public DateTime? DateTimeModified { get; set; }
        public int ModifiedBy { get; set; }
    }
}

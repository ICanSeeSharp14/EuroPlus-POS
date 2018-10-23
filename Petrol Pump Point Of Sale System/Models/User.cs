﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Petrol_Pump_Point_Of_Sale_System.Commons.Enums;
using Petrol_Pump_Point_Of_Sale_System.Core.Models;

namespace Petrol_Pump_Point_Of_Sale_System.Models
{
    public class User : IEntity
    {
        public User()
        {
            UsersRole = new HashSet<UserRole>();
        }
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
        public int AccessType { get; set; }
        public UserType UserType { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public UserRole  Role { get; set; }

        public  ICollection<UserRole> UsersRole { get; set; }
        public bool IsActive { get; set; }
        public DateTime? DateTimeCreated { get; set; }


    }
}

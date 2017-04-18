﻿using EnterpriseManagement.Models.OrderManagement.Enum;
using EnterpriseManagement.Models.TimeManagement;
using System.Collections.Generic;

namespace EnterpriseManagement.Models.OrderManagement
{
    public class Order: BaseEntity
    {
        public int? OrderId { get; set; }
        public string Identifier { get; set; }
        public OrderType Type { get; set; }
        public OrderStatus Status { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<OrderDetail> Details { get; set; }
        public virtual ICollection<Order> Orders { get; set; } // Recursive relationship
        public ICollection<Task> Tasks { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseManagement.API.ServiceModels
{
    public class BaseModel
    {
        public int? Id { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
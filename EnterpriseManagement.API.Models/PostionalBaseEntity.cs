using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseManagement.API.Models
{
    /// <summary>
    /// This class provides the base elements of all classes in the Model    
    /// </summary>
    public class PostionalBaseEntity<VectorBaseEntity>: BaseEntity
    {
        public PostionalBaseEntity()
        {
            Vectors = new HashSet<VectorBaseEntity>();
        }
        public virtual ICollection<VectorBaseEntity> Vectors { get; set; }
    }
}

using EnterpriseManagement.API.Shared.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseManagement.API.Models
{
    /// <summary>
    /// This class provides the base elements of all classes in the Model    
    /// </summary>W
    public class BaseEntity
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        ///         
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Entity created DateTime2
        /// </summary>              
        [DateTimeKind(DateTimeKind.Utc)]
        public DateTime? CreatedDateTime { get; set; }
        /// <summary>
        /// Entity updated DateTime2
        /// </summary>   
        [DateTimeKind(DateTimeKind.Utc)]
        public DateTime? UpdatedDateTime { get; set; }
    }
}

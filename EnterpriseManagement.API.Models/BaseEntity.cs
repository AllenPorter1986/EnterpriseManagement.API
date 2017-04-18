using System;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseManagement.Models
{
    /// <summary>
    /// This class provides the base elements of all classes in the Model    
    /// </summary>
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
        public DateTime? CreatedDateTime { get; set; }
        /// <summary>
        /// Entity updated DateTime2
        /// </summary>   
        public DateTime? UpdatedDateTime { get; set; }

    }
}

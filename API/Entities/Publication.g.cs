using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace demoClient.Entities
{
    /// <summary> 
    /// Represents a publication entity with essential details
    /// </summary>
    public class Publication
    {
        /// <summary>
        /// Primary key for the Publication 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Books of the Publication 
        /// </summary>
        public string? Books { get; set; }
    }
}
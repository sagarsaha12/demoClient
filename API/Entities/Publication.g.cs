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
        /// Required field Id of the Publication 
        /// </summary>
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Books of the Publication 
        /// </summary>
        public string? Books { get; set; }
    }
}
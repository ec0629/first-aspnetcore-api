using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        // By convention a complex type like City is recognized by
        // the framework as a Navigation Property, and the framework
        // will define the relationship automatically and will
        // automatically target the primary key of the parent class
        [ForeignKey("CityId")]
        public City City { get; set; }
        // here we have defined the foreign key property explicitly even
        // though not required
        public int CityId { get; set; }
    }
}

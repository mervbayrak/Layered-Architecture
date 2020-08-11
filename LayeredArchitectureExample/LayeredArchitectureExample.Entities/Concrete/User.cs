using LayeredArchitectureExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitectureExample.Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        [Required]
        public string Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FullName { get; set; }
    }
}

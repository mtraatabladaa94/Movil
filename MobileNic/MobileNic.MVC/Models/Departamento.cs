using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MobileNic.MVC.Models
{
    [Table("tbDepartamento")]
    public class Departamento
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public short IdDepartamento { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Departamento")]
        [Column(TypeName = "varchar")]
        public string NombreDepartamento { get; set; }
    }
}
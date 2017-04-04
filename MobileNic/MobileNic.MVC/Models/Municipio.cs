using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MobileNic.MVC.Models
{
    [Table("tbMunicipio")]
    public partial class Municipio
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public short IdMunicipio { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name= "Municipio")]
        [Column(TypeName = "varchar")]
        public string NombreMunicipio { get; set; }

        [Required]
        [Display(Name = "Departamento")]
        public short IdDepartamento { get; set; }

    }

    public partial class Municipio
    {
        public Municipio()
        {
            this.Usuarios = new HashSet<Usuario>();
        }

        public Departamento Departamento { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }

}
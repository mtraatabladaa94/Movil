using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MobileNic.MVC.Models
{
    [Table("tbDepartamento")]
    public partial class Departamento
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

    public partial class Departamento
    {
        public Departamento()
        {
            this.Municipios = new HashSet<Municipio>();
        }

        public virtual ICollection<Municipio> Municipios { get; set; }
    }

    public class DepartamentoMapping : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoMapping()
        {
            HasRequired(c => c.Municipios).WithRequiredDependent();
        }
    }
}
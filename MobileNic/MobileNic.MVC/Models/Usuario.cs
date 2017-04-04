using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MobileNic.MVC.Models
{
    [Table("tbUsuario")]
    public partial class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Required]
        [StringLength(16)]
        [Display(Name = "Cédula")]
        [Column(TypeName = "varchar")]
        public string CedulaUsuario { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombres")]
        [Column(TypeName = "varchar")]
        public string NombresUsuario { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Apellidos")]
        [Column(TypeName = "varchar")]
        public string ApellidosUsuario { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "E-Mail")]
        [Column(TypeName = "varchar")]
        public string EmailUsuario { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Contraseña")]
        [Column(TypeName = "varchar")]
        public string ContrasenaUsuario { get; set; }

        [Required]
        public Boolean ActivoUsuario { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Dirección")]
        [Column(TypeName = "varchar")]
        public string DireccionUsuario { get; set; }

        [Required]
        [StringLength(8)]
        [Display(Name = "Celular 1")]
        [Column(TypeName = "varchar")]
        public string Celular1Usuario { get; set; }

        [StringLength(8)]
        [Display(Name = "Celular 2")]
        [Column(TypeName = "varchar")]
        public string Celular2Usuario { get; set; }

        [Required]
        [Display(Name = "Municipio")]
        public int IdMunicipio { get; set; }
    }

    public partial class Usuario
    {

        public Usuario()
        {
            this.Dispositivos = new HashSet<Dispositivo>();
        }

        public Municipio Municipio { get; set; }

        public virtual ICollection<Dispositivo> Dispositivos { get; set; }

    }
}
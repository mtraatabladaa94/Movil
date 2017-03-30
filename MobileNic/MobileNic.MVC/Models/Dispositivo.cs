using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MobileNic.MVC.Models
{
    [Table("tbDispositivo")]
    public class Dispositivo
    {
        [Key]
        [Column(TypeName = "uniqueidentifier")]
        public Guid IdDispositivo { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Marca")]
        [Column(TypeName = "varchar")]
        public string MarcaDispositivo { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Modelo")]
        [Column(TypeName = "varchar")]
        public string ModeloDispositivo { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Nº Factura")]
        [Column(TypeName = "varchar")]
        public string FacturaDispositivo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "IMEI 1")]
        [Column(TypeName = "varchar")]
        public string Imei1Dispositivo { get; set; }

        [StringLength(50)]
        [Display(Name = "IMEI 2")]
        [Column(TypeName = "varchar")]
        public string Imei2Dispositivo { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Compañia del IMEI 1")]
        [Column(TypeName = "varchar")]
        public string CompaniaImei1Dispositivo { get; set; }

        [StringLength(15)]
        [Display(Name = "Compañia del IMEI 1")]
        [Column(TypeName = "varchar")]
        public string CompaniaImei2Dispositivo { get; set; }

        [Required]
        [Display(Name = "Dispositivo Propio")]
        public Boolean PropiedadDispositivo { get; set; }

        [StringLength(60)]
        [Display(Name = "Nombre del Propietario")]
        public string NombrePropiedadDispositivo { get; set; }

        [Required]
        public Guid IdUsuario { get; set; }

    }
}
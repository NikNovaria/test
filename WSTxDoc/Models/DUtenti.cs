using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSTxDoc.Models
{
    [Table("D_Utenti")]
    public partial class DUtenti
    {
        [Key]
        public int CodErogante { get; set; }
        [Key]
        [StringLength(255)]
        public string Login { get; set; } = null!;
        [StringLength(16)]
        public string? PiCf { get; set; }
        [StringLength(16)]
        public string Cofi { get; set; } = null!;
        [StringLength(25)]
        public string Password { get; set; } = null!;
        [StringLength(100)]
        public string? CoNo { get; set; }
        [StringLength(50)]
        public string? Rags { get; set; }
        [Column("CambioPWD")]
        public bool CambioPwd { get; set; }
        public bool DaVerificare { get; set; }
        public int? Stato { get; set; }
    }
}

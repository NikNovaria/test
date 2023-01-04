using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSTxDoc.Models
{
    [Keyless]
    [Table("A_Versione")]
    public partial class AVersione
    {
        [StringLength(50)]
        public string? Versione { get; set; }
        [Column("VersioneSP")]
        public double? VersioneSp { get; set; }
        [Column("VersioneVW")]
        public double? VersioneVw { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSTxDoc.Models
{
    [Keyless]
    public partial class VwTbconf
    {
        [StringLength(50)]
        public string Chiave { get; set; } = null!;
        [StringLength(255)]
        public string? Valore { get; set; }
        [Column("IDUtente")]
        public int Idutente { get; set; }
    }
}

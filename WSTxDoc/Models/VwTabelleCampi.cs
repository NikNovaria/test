using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSTxDoc.Models
{
    [Keyless]
    public partial class VwTabelleCampi
    {
        [Column("object_id")]
        public int ObjectId { get; set; }
        [Column("name")]
        [StringLength(128)]
        public string Name { get; set; } = null!;
        [StringLength(128)]
        public string? Campo { get; set; }
    }
}

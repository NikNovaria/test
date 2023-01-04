using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSTxDoc.Models
{
    [Keyless]
    public partial class VwArchiviazione
    {
        [Column("IDStudio")]
        [StringLength(255)]
        public string Idstudio { get; set; } = null!;
        public int CodErogante { get; set; }
        public int CodDipendente { get; set; }
        [StringLength(4)]
        public string? Anno { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? Periodo { get; set; }
        [StringLength(2)]
        public string? Mese { get; set; }
        [StringLength(22)]
        [Unicode(false)]
        public string? TipoDocumento { get; set; }
        [StringLength(5)]
        public string TipoDoc { get; set; } = null!;
        [StringLength(16)]
        public string? PiCf { get; set; }
        [StringLength(50)]
        public string? Rags { get; set; }
        [StringLength(40)]
        public string? Cogd { get; set; }
        [StringLength(40)]
        public string? Nomd { get; set; }
        [StringLength(16)]
        public string? Cofi { get; set; }
        [StringLength(30)]
        public string? Utente { get; set; }
        public bool Ufficiale { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string? NomeFile { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DataArchiviazione { get; set; }
        public bool? InviataMail { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Visualizzato { get; set; } = null!;
        [Column(TypeName = "smalldatetime")]
        public DateTime? DataInvioMail { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DataVisualizzazione { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSTxDoc.Models
{
    [Keyless]
    public partial class VwDArchiviazione
    {
        [Column("IDStudio")]
        [StringLength(255)]
        public string Idstudio { get; set; } = null!;
        public int CodErogante { get; set; }
        public int CodDipendente { get; set; }
        [StringLength(6)]
        public string AnnoMese { get; set; } = null!;
        [StringLength(5)]
        public string TipoDoc { get; set; } = null!;
        public bool Ufficiale { get; set; }
        [Column("ID")]
        public int Id { get; set; }
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
        [StringLength(255)]
        public string? NomeFile { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DataArchiviazione { get; set; }
        public bool? InviataMail { get; set; }
        public int? Visualizzato { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DataInvioMail { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DataVisualizzazione { get; set; }
        public bool? ConfermaLettura { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DataConfermaLettura { get; set; }
        public bool? Eliminato { get; set; }
        public bool? VisibilitaPortale { get; set; }
        public byte[]? FileArch { get; set; }
        public bool? Esterno { get; set; }
        public int? Stato { get; set; }
    }
}

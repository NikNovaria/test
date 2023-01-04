﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSTxDoc.Models
{
    [Table("D_Archiviazione")]
    public partial class DArchiviazione
    {
        [Key]
        [Column("IDStudio")]
        [StringLength(255)]
        public string Idstudio { get; set; } = null!;
        [Key]
        public int CodErogante { get; set; }
        [Key]
        public int CodDipendente { get; set; }
        [Key]
        [StringLength(6)]
        public string AnnoMese { get; set; } = null!;
        [Key]
        [StringLength(5)]
        public string TipoDoc { get; set; } = null!;
        [Key]
        public bool Ufficiale { get; set; }
        [Key]
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


    //Classe per la lettura intermedia dei dati con stato = 1
    public class DArc_readIntermedia{

        [Key]
        [Column("ID")]
        public int Id { get; set; }

        public int? Visualizzato { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DataVisualizzazione { get; set; }

    }
}

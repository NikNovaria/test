using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WSTxDoc.Models
{
    [Keyless]
    public partial class VwGlobSetup
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("t1")]
        [StringLength(50)]
        public string? T1 { get; set; }
        [Column("t2")]
        [StringLength(50)]
        public string? T2 { get; set; }
        [Column("t3")]
        [StringLength(50)]
        public string? T3 { get; set; }
        [Column("t4")]
        [StringLength(50)]
        public string? T4 { get; set; }
        [Column("t5")]
        [StringLength(50)]
        public string? T5 { get; set; }
        [Column("t6")]
        [StringLength(25)]
        public string? T6 { get; set; }
        [Column("t7")]
        [StringLength(25)]
        public string? T7 { get; set; }
        [Column("t8")]
        [StringLength(25)]
        public string? T8 { get; set; }
        [Column("t9")]
        [StringLength(25)]
        public string? T9 { get; set; }
        [Column("t10")]
        [StringLength(25)]
        public string? T10 { get; set; }
        [Column("t11")]
        [StringLength(10)]
        public string? T11 { get; set; }
        [Column("t12")]
        [StringLength(10)]
        public string? T12 { get; set; }
        [Column("t13")]
        [StringLength(10)]
        public string? T13 { get; set; }
        [Column("t14")]
        [StringLength(10)]
        public string? T14 { get; set; }
        [Column("t15")]
        [StringLength(10)]
        public string? T15 { get; set; }
        [Column("o1")]
        public bool? O1 { get; set; }
        [Column("o2")]
        public bool? O2 { get; set; }
        [Column("o3")]
        public bool? O3 { get; set; }
        [Column("o4")]
        public bool? O4 { get; set; }
        [Column("o5")]
        public bool? O5 { get; set; }
        [Column("o6")]
        public bool? O6 { get; set; }
        [Column("o7")]
        public bool? O7 { get; set; }
        [Column("o8")]
        public bool? O8 { get; set; }
        [Column("o9")]
        public bool? O9 { get; set; }
        [Column("o10")]
        public bool? O10 { get; set; }
        [Column("n1")]
        public int? N1 { get; set; }
        [Column("n2")]
        public int? N2 { get; set; }
        [Column("n3")]
        public int? N3 { get; set; }
        [Column("n4")]
        public int? N4 { get; set; }
        [Column("n5")]
        public int? N5 { get; set; }
        [Column("n6")]
        public int? N6 { get; set; }
        [Column("n7")]
        public int? N7 { get; set; }
        [Column("n8")]
        public int? N8 { get; set; }
        [Column("n9")]
        public int? N9 { get; set; }
        [Column("n10")]
        public int? N10 { get; set; }
        [Column("d1", TypeName = "smalldatetime")]
        public DateTime? D1 { get; set; }
        [Column("d2", TypeName = "smalldatetime")]
        public DateTime? D2 { get; set; }
        [Column("d3", TypeName = "smalldatetime")]
        public DateTime? D3 { get; set; }
        [Column("d4", TypeName = "smalldatetime")]
        public DateTime? D4 { get; set; }
        [Column("d5", TypeName = "smalldatetime")]
        public DateTime? D5 { get; set; }
        [Column("m1", TypeName = "ntext")]
        public string? M1 { get; set; }
        [Column("m2", TypeName = "ntext")]
        public string? M2 { get; set; }
        [Column("m3", TypeName = "ntext")]
        public string? M3 { get; set; }
        [Column(TypeName = "image")]
        public byte[]? L1 { get; set; }
        [Column(TypeName = "image")]
        public byte[]? L2 { get; set; }
        [Column("sn1")]
        public float? Sn1 { get; set; }
        [Column("sn2")]
        public float? Sn2 { get; set; }
        [Column("sn3")]
        public float? Sn3 { get; set; }
        [Column("sn4")]
        public float? Sn4 { get; set; }
        [Column("sn5")]
        public float? Sn5 { get; set; }
        [Column("st1")]
        [StringLength(5)]
        public string? St1 { get; set; }
        [Column("st2")]
        [StringLength(60)]
        public string? St2 { get; set; }
        [Column("st3")]
        [StringLength(16)]
        public string? St3 { get; set; }
        [Column("st4")]
        [StringLength(40)]
        public string? St4 { get; set; }
        [Column("st5")]
        [StringLength(40)]
        public string? St5 { get; set; }
        [Column("st6")]
        [StringLength(1)]
        public string? St6 { get; set; }
        [Column("st7")]
        [StringLength(40)]
        public string? St7 { get; set; }
        [Column("st8")]
        [StringLength(10)]
        public string? St8 { get; set; }
        [Column("st9")]
        [StringLength(2)]
        public string? St9 { get; set; }
        [Column("st10")]
        [StringLength(40)]
        public string? St10 { get; set; }
        [Column("st11")]
        [StringLength(40)]
        public string? St11 { get; set; }
        [Column("st12")]
        [StringLength(2)]
        public string? St12 { get; set; }
        [Column("st13")]
        [StringLength(5)]
        public string? St13 { get; set; }
        [Column("st14")]
        [StringLength(40)]
        public string? St14 { get; set; }
        [Column("st15")]
        [StringLength(40)]
        public string? St15 { get; set; }
        [Column("st16")]
        [StringLength(2)]
        public string? St16 { get; set; }
        [Column("st17")]
        [StringLength(5)]
        public string? St17 { get; set; }
        [Column("st18")]
        public bool? St18 { get; set; }
        [Column("st19")]
        public bool? St19 { get; set; }
        [Column("st20")]
        [StringLength(10)]
        public string? St20 { get; set; }
        [Column("st21")]
        [StringLength(50)]
        public string? St21 { get; set; }
        [Column("st22")]
        [StringLength(50)]
        public string? St22 { get; set; }
        [Column("st23")]
        [StringLength(50)]
        public string? St23 { get; set; }
        [Column("st24")]
        [StringLength(50)]
        public string? St24 { get; set; }
        [Column("st25")]
        [StringLength(50)]
        public string? St25 { get; set; }
        [Column("st26")]
        [StringLength(50)]
        public string? St26 { get; set; }
        [Column("st27")]
        [StringLength(50)]
        public string? St27 { get; set; }
        [Column("st28")]
        [StringLength(50)]
        public string? St28 { get; set; }
        [Column("st29")]
        [StringLength(50)]
        public string? St29 { get; set; }
        [Column("EM01")]
        [StringLength(255)]
        public string? Em01 { get; set; }
        [Column("EM02")]
        [StringLength(255)]
        public string? Em02 { get; set; }
        [Column("EM03")]
        [StringLength(255)]
        public string? Em03 { get; set; }
        [Column("EM04")]
        [StringLength(255)]
        public string? Em04 { get; set; }
        [Column("EM05")]
        [StringLength(255)]
        public string? Em05 { get; set; }
        [Column("EM06")]
        [StringLength(255)]
        public string? Em06 { get; set; }
        [Column("EM07")]
        [StringLength(255)]
        public string? Em07 { get; set; }
        [Column("EM08")]
        [StringLength(255)]
        public string? Em08 { get; set; }
        [Column("EM09")]
        [StringLength(255)]
        public string? Em09 { get; set; }
        [Column("EM10")]
        [StringLength(255)]
        public string? Em10 { get; set; }
        [Column("EM11")]
        [StringLength(255)]
        public string? Em11 { get; set; }
        [Column("EM12")]
        [StringLength(255)]
        public string? Em12 { get; set; }
        [Column("e1")]
        public float? E1 { get; set; }
        [Column("e2")]
        public float? E2 { get; set; }
        [Column("e3")]
        public float? E3 { get; set; }
        [Column("e4")]
        public float? E4 { get; set; }
        [Column("e5")]
        public float? E5 { get; set; }
        [Column("e6")]
        public float? E6 { get; set; }
        [Column("e7")]
        public float? E7 { get; set; }
        [Column("e8")]
        public float? E8 { get; set; }
        [Column("e9")]
        public float? E9 { get; set; }
        [Column("e10")]
        public float? E10 { get; set; }
        [Column("st30")]
        [StringLength(50)]
        public string? St30 { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Logo { get; set; }
        [Column("emailMittente")]
        [StringLength(255)]
        public string? EmailMittente { get; set; }
        [Column("o11")]
        public bool? O11 { get; set; }
        [Column("GDPRTitolare")]
        [StringLength(255)]
        public string? Gdprtitolare { get; set; }
        [Column("GDPRTitolareSede")]
        [StringLength(255)]
        public string? GdprtitolareSede { get; set; }
        [Column("GDPRTitolareCF")]
        [StringLength(16)]
        public string? GdprtitolareCf { get; set; }
        [Column("GDPRTitolareNum")]
        [StringLength(20)]
        public string? GdprtitolareNum { get; set; }
        [Column("GDPRTitolareAlbo")]
        [StringLength(255)]
        public string? GdprtitolareAlbo { get; set; }
        [Column("GDPRDPO")]
        [StringLength(255)]
        public string? Gdprdpo { get; set; }
        [Column("GDPRDPOSede")]
        [StringLength(255)]
        public string? Gdprdposede { get; set; }
        [Column("GDPRDPOMail")]
        [StringLength(255)]
        public string? Gdprdpomail { get; set; }
        [Column("GDPRPEC")]
        [StringLength(255)]
        public string? Gdprpec { get; set; }
        [Column("GDPRIndirizzo")]
        [StringLength(255)]
        public string? Gdprindirizzo { get; set; }
        [Column("GDPRAnni")]
        [StringLength(3)]
        public string? Gdpranni { get; set; }
        [Column(TypeName = "ntext")]
        public string? MsgEmailPers1 { get; set; }
        [Column(TypeName = "ntext")]
        public string? MsgEmailPers2 { get; set; }
        public int? MsgEmailPersValidazione { get; set; }
        public int? MsgEmailPersEmissione { get; set; }
    }
}

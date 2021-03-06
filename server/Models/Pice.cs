using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace server.Models
{
    [Table("Pice")]
    public class Pice
    {
        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Naziv")]
        public string Naziv {get; set;}

        [Column("Cena")]
        public int Cena {get; set;}

        [Column("NaStolu")]
        public virtual List<PiceSto> Veza { get; set; }

        [Column("MeniID")]
        public int MeniID { get; set; }
    }
}
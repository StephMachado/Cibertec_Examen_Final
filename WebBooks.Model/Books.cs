using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBooks.Model
{
    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int title_id { get; set; }

        [Display(Name ="Título")]
        public string title { get; set; }

        [Display(Name = "Tipo")]
        public string type { get; set; }

        [Display(Name = "Pub.ID")]
        public int pub_id { get; set; }

        [Display(Name = "Precio")]
        public double price { get; set; }

        [Display(Name = "Avance")]
        public int advance { get; set; }

        [Display(Name = "Royalty")]
        public string royalty { get; set; }

        [Display(Name = "Venta")]
        public string ytd_sales { get; set; }

        [Display(Name = "Notas")]
        public string notes { get; set; }

        [Display(Name = "Fecha Publicación")]
        public DateTime pubdate { get; set; }
    }
}

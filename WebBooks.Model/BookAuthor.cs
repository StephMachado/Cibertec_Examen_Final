﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBooks.Model
{
    public class BookAuthor
    {
        [Key]
        [Column(Order = 0)]
        [Display(Name = "Autor.ID")]
        public int au_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [Display(Name = "Título.ID")]
        public int title_id { get; set; }

        [Display(Name = "Autor.Orden")]
        public string au_ord { get; set; }

        [Display(Name = "Tipeado Real")]
        public string royaltyper { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBooks.Model
{
    public class Autores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Autor.ID")]
        public int au_id { get; set; }

        [Display(Name = "Nombre")]
        public string au_lname { get; set; }

        [Display(Name = "Teléfono")]
        public string au_phone { get; set; }

        [Display(Name = "País")]
        public string au_city { get; set; }

        [Display(Name = "Estado")]
        public string au_state { get; set; }

        [Display(Name = "Cod.Postal")]
        public string au_zip { get; set; }

        [Display(Name = "Sexo")]
        public string au_sex { get; set; }

        [Display(Name = "Salario")]
        public double au_salary { get; set; }

        [Display(Name = "Tema")]
        public string au_subject { get; set; }

    }
}

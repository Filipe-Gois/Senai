﻿using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi_.Domains
{
    public class EstudioDomain
    {
        public int IdEstudio { get; set; }
        [Required(ErrorMessage = "O nome do estúdio é obrigatório!")]
        public string NomeEstudio { get; set; }

        public List<JogoDomain> Jogoes { get; set;}
    }
}

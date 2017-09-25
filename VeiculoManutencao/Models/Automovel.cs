﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeiculoManutencao.Models
{
    public class Automovel
    {
        public int AutomovelId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public Boolean Disponivel { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
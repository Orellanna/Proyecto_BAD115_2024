﻿using System;
using System.Collections.Generic;

namespace ProyectoBAD.Models
{
    public partial class Encuestum
    {
        public Encuestum()
        {
            Pregunta = new HashSet<Preguntum>();
            Respuesta = new HashSet<Respuestum>();
        }

        public int IdEncuesta { get; set; }
        public int? IdUsuario { get; set; }
        public string TituloEncuesta { get; set; } = null!;
        public string ObjetivoEncuesta { get; set; } = null!;
        public string GrupometaEncuesta { get; set; } = null!;
        public string IndicacionesEncuesta { get; set; } = null!;
        public bool? EstadoEncuesta { get; set; }
        public DateTime? FechaEncuesta { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
        public virtual ICollection<Preguntum> Pregunta { get; set; }
        public virtual ICollection<Respuestum> Respuesta { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mysterio.Models
{
    public class Photos
    {


        public int ID { get; set; }
        public string Legenda { get; set; }
        public string Image { get; set; }
        


        [ForeignKey(nameof(Evento))]
        public int EventoFK { get; set; }
        public virtual Events Evento { get; set; }
    }
}
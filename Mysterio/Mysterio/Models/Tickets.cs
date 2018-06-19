using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mysterio.Models
{
    public class Tickets
    {
      
        [Key]
        [ForeignKey(nameof(Evento))]
        public int ID { get; set; }
        public virtual Events Evento { get; set; }


        public string Cartaz { get; set; }

        public string LinkBOL { get; set; }

      
    }
}
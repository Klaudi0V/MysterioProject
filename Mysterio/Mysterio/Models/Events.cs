using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Mysterio.Models
{
    public class Events
    {

        public Events()
        {
            FotografiasDoEvento = new HashSet<Photos>();
        }



        [Key]
        [ForeignKey(nameof(Ticket))]
        public int ID { get; set; }

        // Dados do Evento

        public string Nome { get; set; }

        public DateTime DataDoEvento { get; set; }

        public string Video { get; set; }



        // *******************************************
        // especificação das chaves forasteiras
        // *******************************************


        //// FK para o Agente
        //[ForeignKey("Promotions")]
        //public int PromotionFK { get; set; }
        //public virtual Promotions Promotion { get; set; }

            
        // FK para Ticket
        public virtual Tickets Ticket { get; set; }

                // fotografias associadas ao evento
        public virtual ICollection<Photos> FotografiasDoEvento { get; set; }





    }
}
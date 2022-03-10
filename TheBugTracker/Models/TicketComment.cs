using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TheBugTracker.Models
{
    public class TicketComment
    {
        //Primary Key
        public int Id { get; set; }

        [DisplayName("Member Comment")]
        public string Comment { get; set; }

        [DisplayName("Date")]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Ticket")]
        public int TicketID { get; set; }

        [DisplayName("Team Member")]
        public string UserId { get; set; }

        //Navigation properties
        //Ticket
        public virtual Ticket Ticket { get; set; }
        //User
        public virtual BTUser User { get; set; }
    }
}

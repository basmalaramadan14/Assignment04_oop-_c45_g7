using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_oop
{
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Seat: {SeatNumber}");
        }
    }
}

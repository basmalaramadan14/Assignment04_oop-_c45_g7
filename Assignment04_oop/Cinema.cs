using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_oop
{
    public class Cinema
    {
        public Ticket[] Tickets = new Ticket[10];
        private int index = 0;

        public void AddTicket(Ticket ticket)
        {
            if (index < Tickets.Length)
                Tickets[index++] = ticket;
        }

        public void PrintAllTickets()
        {
            for (int i = 0; i < index; i++)
            {
                Tickets[i]?.PrintTicket();
                Console.WriteLine();
            }
        }

        public void Open()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            Console.WriteLine("Projector started.");
        }

        public void Close()
        {
            Console.WriteLine("========== Cinema Closed ==========");
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_oop
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public decimal Price { get; private set; }
        public decimal PriceAfterTax => Price + (Price * 0.14m);

        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP");
        }
    }
}

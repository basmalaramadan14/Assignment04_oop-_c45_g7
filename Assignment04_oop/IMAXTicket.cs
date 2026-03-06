using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_oop
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}

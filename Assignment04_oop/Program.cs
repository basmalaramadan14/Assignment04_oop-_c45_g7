
namespace Assignment04_oop

{
    #region Q01 Part 01 

    //--Static Binding when the method call is resolved before the program runs
    //usually occurs with non-virtual methods and method overloadin
    //--happens at compile time

    //--Dynamic Binding:when the method call is resolved while the program is running,
    //usually with virtual methods and method overriding
    //--happens at runtime


    #endregion

    #region Q02
    //Overloading: same method name, different parameters, within the same class.

    //Overriding: same method name and parameters, in base and derived classes.
    #endregion

    #region Q03
    //virtual-override

    //--virtual:keyword allows the method to be overridden
    //--override:keyword changes the implementation of the method in
    //the derived class while keeping the same signature.
    #endregion
    class Program
    {
        static void ProcessTicket(Ticket t)
        {
            t?.PrintTicket();
        }

        static void Main(string[] args)
        {
            Cinema cinema = new Cinema();
            cinema.Open();

            Console.WriteLine("\n========== SetPrice Test ========== ");

            Ticket test = new Ticket();
            test.SetPrice(150);
            Console.WriteLine($"Setting price directly: {test.Price}");

            test.SetPrice(100, 1.5m);
            Console.WriteLine($"Setting price with multiplier: 100 x 1.5 {test.Price}");

            Console.WriteLine("\n========== All Tickets ==========");

            StandardTicket std = new StandardTicket
            {
                TicketId = 1,
                MovieName = "Inception",
                SeatNumber = "A-5"
            };
            std.SetPrice(150);

            VIPTicket vip = new VIPTicket
            {
                TicketId = 2,
                MovieName = "Avengers",
                LoungeAccess = true,
                ServiceFee = 50
            };
            vip.SetPrice(200);

            IMAXTicket imax = new IMAXTicket
            {
                TicketId = 3,
                MovieName = "Dune",
                Is3D = false
            };
            imax.SetPrice(180);

            cinema.AddTicket(std);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);

            cinema.PrintAllTickets();

            Console.WriteLine("\n========= Process Single Ticket ==========");
            ProcessTicket(vip);

            cinema.Close();
        }
    }
}


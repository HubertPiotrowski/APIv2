using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mapsv1._01
{
    class Program
    {
        public static void Main()
        {
            Broker Capxm = new Broker()
            {
                server = "api.pro.we.01.currentdesk.com:444",
                id = 29,
                user = "api@capxm.com",
                password = "123trade"
            };

            Dictionary<int, Broker> dictionaryBrokers = new Dictionary<int, Broker>();
            dictionaryBrokers.Add(Capxm.id, Capxm);

            Broker broker101 = dictionaryBrokers[29];

            Console.WriteLine("ID = {0}, email = {1}", broker101.id, broker101.user);
        }
    }

    public class Broker
    {
        public string server { get; set; }
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
    };

}

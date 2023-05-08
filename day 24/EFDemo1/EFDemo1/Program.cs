using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Adding 1 row

           /* using (var context = new EMPDEntities())
            {
                var std = new Salesman_Master()
                {
                   SalesManno="S00006",
                   SalesManname="Christy",
                   Address1="ED/98",
                   Address2="Dream",
                   City="Idukki",
                   Pincode=678954,
                   State="Kerala",
                   Salamt=78909,
                   Tgttoget=987,
                   Ytdsales=42,
                   Remarks="Good"
                };
                context.Salesman_Master.Add(std);
            
                context.SaveChanges();
            }*/

            // updating a row

            /*using (var context = new EMPDEntities())
            {
                var std = context.Salesman_Master.First<Salesman_Master>();
                std.SalesManname = "Steve";
                context.SaveChanges();
            }*/

           //deleting a row

            using (var context = new EMPDEntities())
            {
                var std = context.Salesman_Master.Where(y=>y.SalesManno="S0002);
                context.Salesman_Master.Remove(std);

                context.SaveChanges();
            }
        }
    }
}

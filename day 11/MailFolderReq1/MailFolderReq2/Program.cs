using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolderReq2
{
        class Program
        {
           static void Main(string[] args)
            {
                List<Mail>list = new List<Mail>();
                Console.WriteLine("Enter the name of the folder: ");
                string folderName = Console.ReadLine();
                MailFolder folder = new MailFolder();
            Mail m=new Mail();
                int ch;
                do
                {
                    Console.WriteLine("\n1. Add Mail");
                    Console.WriteLine("\n2. Delete Mail");
                    Console.WriteLine("\n3. Display Mails");
                    Console.WriteLine("\n4. Exit");
                    Console.WriteLine("\nEnter choice: ");
                    ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("\nEnter the details of mail in CSV format: ");
                            string[] s = Console.ReadLine().Split(',');
                        Mail m1 = new Mail(long.Parse(s[0]),
                            s[1], s[2], s[3], s[4],
                            DateTime.ParseExact(s[5], "dd=MM-yyyy", null),
                            double.Parse(s[6]));
                        
                            folder.AddMailToFolder(m1);
                            break;
                        case 2:
                            Console.WriteLine("\nEnter the id of the mail to be deleted");
                            long mailId = long.Parse(Console.ReadLine());
                            folder.RemoveMailFromFolder(mailId);
                            break;
                        case 3:
                            folder.DisplayMails();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("\nInvalid choice");
                            break;
                    }
                }
                while (ch != 0);
                Console.WriteLine();
            }
        }
    }






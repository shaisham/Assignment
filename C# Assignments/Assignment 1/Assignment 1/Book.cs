using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
 
     internal class Book
        {


            struct book
            {
                public int bookId;
                public string title;
                public int price;
                public string bookType;

            }
            enum bookType
            {
                Magazine,
                Novel,
                ReferenceBook,
                Miscellaneous
            }

            public static void Main()
            {
                book b = new book();
                Console.Write("\n\nEnter the information of books  :\n");
                Console.Write("-----------------------------------\n");
                Console.Write("Enter  BookId  :");
                b.bookId = Int32.Parse(Console.ReadLine());
                Console.Write("Enter  Title :");
                b.title = Console.ReadLine();
                Console.Write("Enter price  :");
                b.price = Int32.Parse(Console.ReadLine());
                Console.Write("Book Type  :");
                b.bookType = Console.ReadLine();


                if (b.bookType == "magazine")
                {
                    bookType type1 = bookType.Magazine;
                    Console.WriteLine(type1);
                }
                else if (b.bookType == "novel")
                {
                    bookType type2 = bookType.Novel;
                    Console.WriteLine(type2);
                }
                else if (b.bookType == "referencebook")
                {
                    bookType type3 = bookType.ReferenceBook;
                    Console.WriteLine(type3);
                }
                else if (b.bookType == "miscellaneous")
                {
                    bookType type4 = bookType.Miscellaneous;
                    Console.WriteLine(type4);
                }
                else
                {
                    Console.WriteLine("selected book not present in  booktype");
                }

                Console.ReadLine();
            }

        }
    }


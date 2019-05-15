using System;


namespace BookProgress
{
    public class Book
    {
        uint pages;
        public uint myPages { get { return pages; } set { pages = (uint)(value > 0 ? value : -value); } }
        public uint chapters;
        public uint current_page { get;  set; }
        public uint current_chapter { get; set; }
        public Book(uint pages,uint chapters)
        {
            this.pages = pages;
            this.chapters = chapters;
        }
        public static void PagesLeft(Book book)
        {
            bool check = false;
            Console.WriteLine("Enter current page: ");
            do
            {
                try
                {
                    book.current_page = Convert.ToUInt16(Console.ReadLine());
                    if (book.current_page > book.pages) throw new Exception();
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect input!\n Try again: ");
                    check = true;
                }
            }while(check);
            
            Console.Write("Pages left: " + (book.pages - book.current_page));
            double percentage = (double)  book.current_page / book.pages;
            Console.Write(" In percent passed: {0:P1}\n", percentage);
        }
        public static void ChaptersLeft(Book book)
        {
            bool check = false;
            Console.WriteLine("Enter current chapter: ");
            do
            {
                try
                {
                    book.current_chapter = Convert.ToUInt16(Console.ReadLine());
                    if (book.current_chapter > book.chapters) throw new Exception();
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect input!\n Try again: ");
                    check = true;
                }
            } while (check);
            Console.Write("\nChapters left: " + (book.chapters - book.current_chapter));
            double percentage = (double)  book.current_chapter / book.chapters;
            Console.Write(" In percent passed: {0:P1}\n", percentage);
        }
        public static bool IsHalfPassed(Book book)
        {
            if (book.current_page != 0 && book.current_page < book.pages)
            {
                if (book.current_page > (book.pages / 2)) return true;
                else return false;
            }
            else return false;
        }
        // reference example
        public static void LetRef(ref int a)
        {
            a *= 10; 
        }
        static void Main(string[] args)
        {
            Book Shieldt = new Book(1465, 20);
            PagesLeft(Shieldt);
            //ChaptersLeft(Shieldt);
            //Console.WriteLine("Is half passed? Answer : " + IsHalfPassed(Shieldt)); 


            Console.ReadKey();
        }
    }
       
    
}

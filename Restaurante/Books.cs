using System.CodeDom;

namespace EjerciciosPOO_P3
{
    internal class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        public Books(string title, string author, int pages, int rating)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Rating = rating;
        }

        public Books()
        {

        }

        public override string ToString()
        {
            return string.Format("Titulo: {0}\nAutor: {1}\nPaginas: {2}\nCalificacion: {3}\n", Title, Author, Pages, Rating);
        }
    }
}
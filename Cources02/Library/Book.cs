using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources02.Library
{
    class Book
    {
       public Author BookAuthor{get;set;}
       public Content BookContent { get; set; }
       public Title BookTitle { get; set; }
        
        public Book(Author inputauthor,Content inputcontent,Title inputtitle)
        {
            BookAuthor = inputauthor;
            BookContent = inputcontent;
            BookTitle = inputtitle;
        }
        public void Show()
        {
            BookAuthor.Show(ConsoleColor.Blue);
            BookContent.Show(ConsoleColor.DarkGreen);
            BookTitle.Show(ConsoleColor.DarkRed);
        }
    }
}

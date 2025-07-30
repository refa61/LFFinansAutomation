using System;

namespace TestAutomation.PageObjects
{
    public class Book
    {
        private string title;
        private string author;
        private int pages;

        // ´Constructor *******************************************

        public Book(string title, int pages, string author)
        {

            this.title = title;
            this.pages = pages;
            this.author = author;
        }

        // Title **************************************************

        public string getTitle()
        {

            return title;

        }

        public void setTitle(string title)
        {

            if (title == null)
            {
                return;
            }

            if (title.Length == 0)
            {
                throw new ArgumentException("Title must include charachters");
            }

            this.title = title;
        }

        // Pages *****************************************************

        public void setPages(int pages)
        {

            if (pages == 0)
            {
                throw new ArgumentException("Pages must include number");
            }

            this.pages = pages;
        }

        public int getPages()
        {

            return pages;
        }

        // Author *****************************************************

        public void setAuthor(string author)
        {

            if (author == null)
            {
                return;
            }

            if (author.Length == 0)
            {
                throw new ArgumentNullException("Author must include charachters!");
            }

            this.author = author;
        }

        public string getAuthor()
        {
            return author;
        }
    }
}
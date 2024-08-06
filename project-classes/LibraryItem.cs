using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace project_classes
{
    public class LibraryItem
    {
        internal protected string Title = "sefer";


        public string getTitle()
        {
            return Title;
        }
    }

    public class Book : LibraryItem
    {

        public Book(string title)
        {
            Title = title;
        }

    }
}

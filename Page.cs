using System;

namespace NotepadDemo
{
    public class Page
    {
        public string Text { get; private set; }

        public string Title { get; private set; }

        public void AddText(string text)
        {
            this.Text += " " + text;
        }

        public void SetTitle(string title)
        {
            this.Title += title;
        }

        public void RemoveText()
        {
            this.Text = "";
        }

        public void PrintContent()
        {
            Console.WriteLine("----------------------------------------------------------------");
            if (Title != null)
            {
                Console.WriteLine(Title);
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("///////////////////");
            Console.WriteLine();
            if (Text != null)
            {
                Console.WriteLine(Text);
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}

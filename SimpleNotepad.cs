using System;

namespace NotepadDemo
{
    public class SimpleNotepad : INotepad
    {
        //Properties
        public string NotepadName { get; private set; }

        public Page[] Pages { get; set; }


        //Constructor
        public SimpleNotepad(int pageNumber, string notepadName)
        {
            this.NotepadName = notepadName;

            Pages = new Page[pageNumber];

            for (int i = 0; i < pageNumber; i++)
            {
                Pages[i] = new Page();
            }
        }


        //Functions
        public void AddText(int pageNumber, string text)
        {
            if (IsPageNumberCorrect(pageNumber))
            {
                Pages[pageNumber].AddText(text);
            }
        }

        public void AddTitle(int pageNumber, string title)
        {
            if (IsPageNumberCorrect(pageNumber))
            {
                Pages[pageNumber].SetTitle(title);
            }
        }

        private bool IsPageNumberCorrect(int pageNumber)
        {
            if(pageNumber < 0 || pageNumber > Pages.Length - 1)
            {
                return false;
            }
            return true;
        }

        public void RemoveText(int pageNumber)
        {
            if (IsPageNumberCorrect(pageNumber))
            {
                Pages[pageNumber].RemoveText();
            }
        }

        public void ReplaceText(int pageNumber, string text)
        {
            if (IsPageNumberCorrect(pageNumber))
            {
                RemoveText(pageNumber);
                AddText(pageNumber, text);
            }
        }

        public void PrintContent()
        {
            for (int i = 0; i < Pages.Length; i++)
            {
                int index = i + 1;

                if(i == 0)
                {
                    Console.WriteLine("Notepad name: " + NotepadName);
                    Console.WriteLine("{");
                }

                Console.WriteLine("--------------------");
                Console.WriteLine("|Page " + index + "|");

                Pages[i].PrintContent();

                if(i == Pages.Length - 1)
                {
                    Console.WriteLine("}");
                    Console.WriteLine();
                }
            }
        }
    }
}

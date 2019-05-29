using System;

namespace NotepadDemo
{
    public class SecuredNotepad : INotepad
    {
        private string _password;

        public string NotepadName { get; private set; }

        public Page[] Pages { get; set; }

        public SecuredNotepad(int pageNumber, string notepadName, string password)
        {

            this._password = password;

            this.NotepadName = notepadName;

            Pages = new Page[pageNumber];

            for (int i = 0; i < pageNumber; i++)
            {
                Pages[i] = new Page();
            }
        }

        public void ChangePassword()
        {
            Console.Write("Enter this password to change it: ");
            if (CheckIfPasswordCorrect(Console.ReadLine()))
            {
                Console.Write("Enter new password: ");
                _password = Console.ReadLine();
            }
        }

        private bool CheckIfPasswordCorrect(string pass)
        {
            if(this._password == pass)
            {
                Console.WriteLine("Success");
                return true;
            }
            Console.WriteLine("Failed");
            return false;
        }

        public void AddText(int pageNumber, string text)
        {
            Console.Write("Enter password to add text: ");
            if (CheckIfPasswordCorrect(Console.ReadLine()))
            {
                if (IsPageNumberCorrect(pageNumber))
                {
                    Pages[pageNumber].AddText(text);
                }
            }
        }

        public void AddTitle(int pageNumber, string title)
        {
            Console.Write("Enter password to add title: ");
            if (CheckIfPasswordCorrect(Console.ReadLine()) && IsPageNumberCorrect(pageNumber))
            {
                if (IsPageNumberCorrect(pageNumber))
                {
                    Pages[pageNumber].SetTitle(title);
                }
            }
        }

        private bool IsPageNumberCorrect(int pageNumber)
        {
            if (pageNumber < 0 || pageNumber > Pages.Length - 1)
            {
                return false;
            }
            return true;
        }

        public void RemoveText(int pageNumber)
        {
            Console.Write("Enter password to remove text: ");
            if (CheckIfPasswordCorrect(Console.ReadLine()) && IsPageNumberCorrect(pageNumber))
            {
                Pages[pageNumber].RemoveText();
            }
        }

        public void ReplaceText(int pageNumber, string text)
        {
            Console.Write("Enter password to add replace: ");
            if (CheckIfPasswordCorrect(Console.ReadLine()) && IsPageNumberCorrect(pageNumber))
            {
                RemoveText(pageNumber);
                AddText(pageNumber, text);
            }
        }

        public void PrintContent()
        {
            Console.Write("Enter password to print content: ");
            if (CheckIfPasswordCorrect(Console.ReadLine()))
            {
                for (int i = 0; i < Pages.Length; i++)
                {
                    int index = i + 1;

                    if (i == 0)
                    {
                        Console.WriteLine("Notepad name: " + NotepadName);
                        Console.WriteLine("{");
                    }

                    Console.WriteLine("--------------------");
                    Console.WriteLine("|Page " + index + "|");

                    Pages[i].PrintContent();

                    if (i == Pages.Length - 1)
                    {
                        Console.WriteLine("}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

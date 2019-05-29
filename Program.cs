using System;

namespace NotepadDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //SimpleNotepad 1

            INotepad simpleNotepad = new SimpleNotepad(4, "SimpleNotebook");

            SimpleNotepad simpleNotepad2 = new SimpleNotepad(1, "SimpleNotebook2");

            INotepad securedNotepad = new SecuredNotepad(2, "SecuredNotebook", "123");

            INotepad securedNotepad2 = new SecuredNotepad(2, "SecuredNotebook", "asd");


            simpleNotepad.AddTitle(0, "Welcome, i have only title");
            simpleNotepad.AddTitle(0, null);

            simpleNotepad.AddTitle(1, null);
            simpleNotepad.RemoveText(1);
            simpleNotepad.AddText(1, "Hello World!!! \n Im using new lines! \n And its working!!! \n I dont have title");

            simpleNotepad.AddTitle(2, "Hmmmmm");
            simpleNotepad.AddText(2, "I have everything");

            simpleNotepad.PrintContent();

            //SimpleNotepad 2

            simpleNotepad2.AddTitle(0, "First");

            simpleNotepad2.PrintContent();

            //SecuredNotepad 1
            //password is 123
            securedNotepad.AddTitle(0, "SECURED");
            securedNotepad.AddText(0, "This is too secured!!!");
            //Changing password
            ((SecuredNotepad)securedNotepad).ChangePassword();

            securedNotepad.AddTitle(1, null);
            securedNotepad.AddText(1, "This is too secured without title!!!");

            securedNotepad.AddTitle(1, "SECURED without text");
            securedNotepad.AddText(1, null);

            securedNotepad.PrintContent();

            //SecuredNotepad2

            securedNotepad2.AddTitle(0,"Welcome to Secured Notepad");
            securedNotepad2.AddText(0, "You know the pass \n Awesome !");

            securedNotepad2.AddTitle(1, "Hello Secured Notepad");
            securedNotepad2.AddText(1, "I dont know what to write");
            securedNotepad2.RemoveText(1);
            securedNotepad2.AddText(1, "Hello everybody!!!");

            securedNotepad2.AddTitle(2, "Trying to break program");
            securedNotepad2.AddText(2, "I can't...");

            securedNotepad2.PrintContent();
        }
    }
}

namespace NotepadDemo
{
    public interface INotepad
    {
        Page[] Pages { get; set; }

        void AddText(int pageNumber, string text);

        void AddTitle(int pageNumber, string title);

        void ReplaceText(int pageNumber, string text);

        void PrintContent();

        void RemoveText(int pageNumber);
    }
}

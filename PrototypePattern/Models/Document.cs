using PrototypePattern.Interfaces;

namespace PrototypePattern.Models
{
    public abstract class Document: IPrototype<Document>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreatedAt { get; set; }

        protected Document() { }

        protected Document(Document source)
        {
            if (source != null)
            {
                Title = source.Title;
                Author = source.Author;
                CreatedAt = source.CreatedAt;
            }
        }


        public virtual void Display()
        {
            Console.WriteLine($"Document: {Title}, Author: {Author}, Created: {CreatedAt}");
        }

        public abstract Document Clone();
    }
}

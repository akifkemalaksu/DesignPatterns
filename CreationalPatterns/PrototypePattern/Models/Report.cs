namespace PrototypePattern.Models
{
    public class Report : Document
    {
        public int PageCount { get; set; }

        public Report() { }

        public Report(Report source) : base(source)
        {
            if (source != null)
                PageCount = source.PageCount;
        }

        public override Report Clone()
        {
            return new Report(this);
        }

        public override void Display()
        {
            Console.WriteLine($"Report - Title: {Title}, Pages: {PageCount}, Author: {Author}");
        }
    }
}

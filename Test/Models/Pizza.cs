namespace Test.Models
{
    public class Pizza
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }

        public Pizza()
        {
            _id++;
            Id = _id;
        }
    }
}

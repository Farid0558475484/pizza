using Test.Models;

namespace Test
{
    public class Admin : User
    {
        private static int _id;
        public int Id { get; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }

        public Admin()
        {
            _id++;
            Id = _id;
        }

        
    }
}

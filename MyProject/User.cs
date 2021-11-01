namespace MyProject
{
    public class User
    {
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public User()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        private int MaiorIdade = 18;
        public bool MaiorDeIdade()
        {
            return Age >= 18;
        }
    }
}
namespace Google
{
    using System.Collections.Generic;

    public class Person
    {
        public string Name { get; set; }
        public List<string> Company { get; set; }
        public List<string> Car { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Children> Children { get; set; }

        public Person(string name)
        {
            this.Name = name;
            this.Company = new List<string>();
            this.Car = new List<string>();
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Children>();            
        }  
    }
}

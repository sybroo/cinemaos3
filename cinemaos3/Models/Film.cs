namespace cinemaos3.Models
{
    public class Film
    {
        public string name;
        public string description;
        public string poster;
        public string cast;
        public string age;

        public Film(string name, string description, string poster, string cast, string age)
        {
            this.name = name;
            this.description = description;
            this.poster = poster;
            this.cast = cast;
            this.age = age;
        }
    }
}

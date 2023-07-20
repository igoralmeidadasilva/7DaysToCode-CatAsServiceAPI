using System;

namespace model
{
    public class Cat
    {
        public string? name { get; set; }
        public string? temperament { get; set; }
        public string? origin { get; set; }
        public string? description { get; set; }
        public string? reference_image_id { get; set; }
        public string? id { get; set; }
        public override string? ToString()
        {
            //return $"Raça: {name}, Temperamento: {temperament}, Origem: {origin}\nDescrição: {description}";
            return name;
        }
    }
}

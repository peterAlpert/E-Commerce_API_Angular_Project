﻿using System.Text.Json.Serialization;

namespace E_Commerce_API_Angular_Project.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Relations 
       public List<Category>? categories { get; set; } //samsung (mob +lab..etc)

        [JsonIgnore]
        public List<Product>? products { get; set; }

        public Boolean IsDeleted { get; set; }

    }
}

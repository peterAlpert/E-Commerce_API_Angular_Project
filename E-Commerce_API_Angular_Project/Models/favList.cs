﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace E_Commerce_API_Angular_Project.Models
{
    public class favList
    {
        public int Id { get; set; }



        //Relations

        [ForeignKey("user")]
        public int userId { get; set; }
        public appUser user { get; set; }
        [JsonIgnore]
        public List<favListItems> favListItems { get; set; }
    }
}

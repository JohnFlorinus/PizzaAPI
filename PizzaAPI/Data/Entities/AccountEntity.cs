using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PizzaAPI.Data.Entities
{
    public class AccountEntity
    {
        [Key]
        [JsonIgnore]
        public int AccountID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string Phone { get; set; } = string.Empty;
    }
}

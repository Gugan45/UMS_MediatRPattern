using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Users
{
    public class User
    {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
        public string? Id {get; set;}
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }

    
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password{ get; set; }

        [Required]
        public bool IsActive {get; set; } = true;

    }

}
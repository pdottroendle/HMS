using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Security.Cryptography;
using System.Text;

public class UserData
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string UserID { get; set; }

    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; } // "Doctor", "Nurse", "Admin", "Patient"
    public string Email { get; set; }
    public string Phone { get; set; }
}


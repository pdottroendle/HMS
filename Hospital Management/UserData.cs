using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Security.Cryptography;
using System.Text;

public class UserData
{
    [BsonId]
    [BsonRepresentation(BsonType.String)] // MongoDB will store this as string like "001"
    public string UserID { get; set; }

    [BsonElement("Username")]
    public string Username { get; set; }

    [BsonElement("PasswordHash")]
    public string PasswordHash { get; set; }

    [BsonElement("Role")]
    public string Role { get; set; } // Doctor, Nurse, Admin, Patient

    [BsonElement("Email")]
    public string Email { get; set; }

    [BsonElement("Phone")]
    public string Phone { get; set; }
}


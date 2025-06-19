using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Security.Cryptography;
using System.Text;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string username { get; set; }
    public string passwordHash { get; set; }
    public string role { get; set; }
}

public static class PasswordHelper
{
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }

    public static bool VerifyPassword(string enteredPassword, string storedHash)
    {
        var enteredHash = HashPassword(enteredPassword);
        return enteredHash == storedHash;
    }
}

public class UserService
{
    private readonly IMongoCollection<User> _users;

    public UserService(string connectionString, string dbName)
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(dbName);
        _users = database.GetCollection<User>("Users");
    }

    public bool RegisterUser(string username, string password, string role)
    {
        var existingUser = _users.Find(u => u.username == username).FirstOrDefault();
        if (existingUser != null)
            return false;

        var user = new User
        {
            username = username,
            passwordHash = PasswordHelper.HashPassword(password),
            role = role
        };

        _users.InsertOne(user);
        return true;
    }

    public User AuthenticateUser(string username, string password)
    {
        var user = _users.Find(u => u.username == username).FirstOrDefault();
        if (user != null && PasswordHelper.VerifyPassword(password, user.passwordHash))
            return user;

        return null;
    }
}

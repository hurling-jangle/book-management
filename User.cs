public class User {
    public string Username { get; set; }
    private string Password { get; set; }

    public User(string username, string password) {
        Username = username;
        Password = password; // In a real-world scenario, use secure password hashing
    }

    public bool Authenticate(string enteredPassword) {
        return Password == enteredPassword;
    }
}

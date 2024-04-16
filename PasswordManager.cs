class PasswordManager : IDisplayable, IResetable
{
    //Properties
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    //Constructors
    public PasswordManager(string password, bool hidden) {
        Password = password;
        Hidden = hidden;
    }

    //Methods
    public void Display() {
        if (Hidden) {
            Console.WriteLine("*****");
        }
        else {
            Console.WriteLine(Password);
        }
    }

    public void Reset() {
        Password = "";
        Hidden = false;
    }
}
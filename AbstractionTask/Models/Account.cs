namespace AbstractionTask.Models;



    public abstract class Account
    {
        protected bool PasswordChecker(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit);
        }
    }




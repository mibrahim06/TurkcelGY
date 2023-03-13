namespace PasswordStrength;

/**
* This program is a simple password strength checker.
*/
internal static class Program
{
    /**
     * Check if the password has at least six characters
     * @param password The password to check
     * @return true if the password has at least six characters, false otherwise
     */
    private static bool HasAtLeastSixCharacters(string? password)
    {
        return password != null && password.Length >= 6;
    }
    /**
     * Check if the password if only letters
     * @param password The password to check
     * @return true if the password is only letters, false otherwise
     */
    private static bool IsOnlyLetters(string? password)
    {
        if (password != null)
            foreach (char c in password)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

        return true;
    }
    /**
     * Check if the password if only digits
     * @param password The password to check
     * @return true if the password is only digits, false otherwise
     */
    private static bool IsOnlyDigits(string? password)
    {
        if (password != null)
            foreach (char c in password)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

        return true;
    }
    /**
     * Check if the password if only letters and digits
     * @param password The password to check
     * @return true if the password is only letters and digits, false otherwise
     */
    private static bool IsOnlyLettersAndDigits(string? password)
    {
        if (password != null)
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }

        return true;
    }
    /**
     * Check if the password if only letters and digits
     * @param password The password to check
     * @return true if the password is only letters and digits, false otherwise
     */
    private static bool HasLettersDigitsAndSpecialCharacters(string? password)
    {
        bool hasLetter = false;
        bool hasDigit = false;
        bool hasSpecialCharacter = false;
        if (password != null)
            foreach (char c in password)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else
                {
                    hasSpecialCharacter = true;
                }
            }

        return hasLetter && hasDigit && hasSpecialCharacter;
    }
    /**
     * The main entry point for the application.
     */
    private static void Main()
    {
        // Get the password from the user
        Console.Write("Enter a password: ");
        string? password = Console.ReadLine();
        // Check if the password is valid (at least 6 characters) 
        bool isValid = password != null && HasAtLeastSixCharacters(password);
        // Check the password strength
        switch (isValid)
        {
            case false:
                // The password is not valid
                Console.WriteLine("The password must be at least 6 characters.");
                break;
            case true when IsOnlyLetters(password):
                // The password is valid and only letters
                Console.WriteLine("The password  weak.");
                break;
            case true when IsOnlyDigits(password):
                // The password is valid and only digits
                Console.WriteLine("The password  weak.");
                break;
            case true when IsOnlyLettersAndDigits(password):
                // The password is valid and only letters and digits
                Console.WriteLine("The password is medium.");
                break;
            case true when HasLettersDigitsAndSpecialCharacters(password):
                // The password is valid and has letters, digits and special characters
                Console.WriteLine("The password is strong.");
                break;
            default:
                // The password is valid but has no letters, digits only special characters
                Console.WriteLine("The password is too weak.");
                break;
        }
    }
}

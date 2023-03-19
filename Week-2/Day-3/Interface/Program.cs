namespace Interface;
/**
 * @brief This program demonstrates the use of interfaces in C#.
 */

// Create a interface for sending messages (IMessageSender)
public interface IMessageSender
{
    void SendMessage(string message);
}

// Create two classes that implement the IMessageSender interface'

// This is first class that implements the IMessageSender interface
public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Sending email: " + message);
    }
}

// This is second class that implements the IMessageSender interface
public class SmsSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

// Main program
internal static class Program
{
    private static void Main()
    {
        IMessageSender emailSender = new EmailSender();
        emailSender.SendMessage("This is an email message.");
        
        IMessageSender smsSender = new SmsSender();
        smsSender.SendMessage("This is an SMS message.");
        
    }
}

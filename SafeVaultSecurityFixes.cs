using System;

public class SafeVaultSecurityFixes
{
    public static void FixSQLInjection(string userInput)
    {
        // Original vulnerable code (SQL injection issue)
        // string query = "SELECT * FROM Users WHERE UserName = '" + userInput + "'";
        
        // Fixed code using parameterized queries to prevent SQL injection
        string sanitizedInput = InputValidation.SanitizeInput(userInput);
        string query = "SELECT * FROM Users WHERE UserName = @UserName";
        // Execute SQL query with parameterized input
    }

    public static void FixXSS(string userInput)
    {
        // Original vulnerable code (XSS issue)
        // string content = "<div>" + userInput + "</div>";

        // Fixed code using encoding to prevent XSS
        string sanitizedContent = System.Net.WebUtility.HtmlEncode(userInput);
        string content = "<div>" + sanitizedContent + "</div>";
        // Return safe content
    }
}

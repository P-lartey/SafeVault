using System;
using System.Data.SqlClient;

public class InputValidation
{
    public static string SanitizeInput(string input)
    {
        if (string.IsNullOrEmpty(input))
            throw new ArgumentException("Input cannot be empty");

        // Perform input validation to prevent SQL Injection
        input = input.Replace("'", "''"); // Escape single quotes
        input = input.Replace(";", "");   // Remove semicolons
        return input;
    }

    public static void PreventSQLInjection(string userInput)
    {
        string sanitizedInput = SanitizeInput(userInput);
        string query = "SELECT * FROM Users WHERE UserName = @UserName";
        using (SqlConnection conn = new SqlConnection("your_connection_string"))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", sanitizedInput);
            conn.Open();
            var result = cmd.ExecuteScalar();
            // Handle the result
        }
    }
}

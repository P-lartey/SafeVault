using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class SecurityTests
{
    [TestMethod]
    public void TestInputSanitization()
    {
        string maliciousInput = "O'Riley; DROP TABLE Users;";
        string sanitizedInput = InputValidation.SanitizeInput(maliciousInput);
        Assert.AreEqual("O''Riley DROP TABLE Users", sanitizedInput);
    }

    [TestMethod]
    public void TestSQLInjectionPrevention()
    {
        string maliciousInput = "O'Riley";
        // Simulate SQL query execution and check if the input is sanitized
        Assert.DoesNotThrow(() => InputValidation.PreventSQLInjection(maliciousInput));
    }

    [TestMethod]
    public void TestXSSProtection()
    {
        string maliciousInput = "<script>alert('XSS');</script>";
        string sanitizedContent = SafeVaultSecurityFixes.FixXSS(maliciousInput);
        Assert.AreEqual("&lt;script&gt;alert('XSS');&lt;/script&gt;", sanitizedContent);
    }
}

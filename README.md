# SafeVault
# Secure Vault Application - Summary

## Identified Vulnerabilities:
- **SQL Injection**: Unsafe input handling allowed attackers to inject malicious SQL queries.
- **XSS (Cross-Site Scripting)**: User inputs were not properly sanitized, leading to potential script injection vulnerabilities.

## Fixes Applied:
- **SQL Injection**: Implemented parameterized queries and input sanitization using `InputValidation` class to prevent SQL injection.
- **XSS**: Used `System.Net.WebUtility.HtmlEncode()` to sanitize user inputs and prevent script injections.

## How Copilot Assisted:
- Copilot helped generate the secure code for input validation and SQL injection prevention, providing quick suggestions for implementing proper security measures in the application.

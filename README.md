# Password Generator

A secure, user-friendly password generator application built with C# and Windows Forms. This tool generates cryptographically strong passwords using .NET's `System.Security.Cryptography` namespace, providing a balance between security and usability.

## Security Features

- **Cryptographic Security**: Uses `System.Security.Cryptography.RandomNumberGenerator` for true random number generation
- **Memory Protection**: Sensitive data is handled securely and cleared from memory when no longer needed
- **No Password Storage**: Passwords are generated on-demand and never stored
- **Secure Design**: Implements security best practices and secure coding guidelines

## Key Features

- **Character Set Control**:
  - Uppercase letters (A-Z)
  - Lowercase letters (a-z)
  - Numbers (0-9)
  - Special characters (!@#$%^&*)
  - Additional symbols (~`[];?,()+)

- **Advanced Options**:
  - Adjustable password length (5-128 characters)
  - Minimum number requirements
  - Minimum special character requirements
  - Exclude ambiguous characters (l, I, O, 0)
  - Prevent character duplication
  - Fisher-Yates shuffle implementation for uniform distribution

## Getting Started

### System Requirements

- Windows 10 or later
- .NET 8.0 Runtime
- 64-bit Windows operating system

## Usage Guide

1. **Launch** the application
2. **Configure** your password requirements:
   - Select desired character types
   - Adjust password length using the slider (5-128 characters)
   - Set minimum requirements for numbers and special characters
   - Enable/disable additional options as needed
3. **Generate** your password by clicking the "Generate" button
4. **Copy** the password using the "Copy" button

## Technical Details

### Architecture
- Written in C# using .NET 8.0
- Windows Forms for the user interface
- Implements secure random number generation
- Modular design for easy maintenance and extension

### Security Implementation
- Uses cryptographically secure random number generation
- Implements secure character selection algorithms
- Employs Fisher-Yates shuffle for unbiased distribution
- Follows secure coding practices and guidelines

# Password Generator

A simple, secure, and cryptographically safe password generator built with C# and Windows Forms. This application offers a user-friendly interface to customize and generate robust passwords based on various criteria such as character types and password length, leveraging the .NET's `System.Security.Cryptography` namespace for cryptographic security.

## Features

- **Cryptographically Secure Randomness**: Utilizes `System.Security.Cryptography.RandomNumberGenerator` for generating passwords, ensuring high-quality randomness suitable for security-sensitive applications.
- **Customizable Character Sets**: Include lowercase, uppercase, numbers, and special characters in your passwords.
- **Adjustable Length**: Control the desired length of your passwords with a slider or numeric input.
- **Minimum Character Requirements**: Enforce minimum counts for numeric and special characters to ensure password complexity.
- **Avoid Ambiguous Characters**: Option to remove characters that can be easily confused, like `l`, `I`, `O`, and `0`.
- **Exclude Duplicate Characters**: Guarantee each character in the password is unique, enhancing security.
- **Shuffle Algorithm**: Implements the Fisher-Yates shuffle algorithm to randomize the order of characters in the generated password, providing additional unpredictability.

## Getting Started

### Prerequisites

- .NET Framework (compatible version with Windows Forms)
- Visual Studio or a compatible IDE to compile and run the Windows Forms application.

### Installation

1. Clone the repository or download the source code.
2. Open the solution in Visual Studio.
3. Restore NuGet packages if necessary.
4. Build the solution to compile the application.
5. Run the application from Visual Studio or by executing the compiled executable directly.

### Usage

1. Launch the Password Generator application.
2. Set your password preferences using the checkboxes and numeric inputs:
    - Choose character types (lowercase, uppercase, numbers, special characters, and other symbols).
    - Adjust the password length with the slider or numeric input.
    - Define minimum counts for numbers and special characters as needed.
    - Opt to exclude ambiguous characters or duplicate characters for clarity and security.
3. Click "Generate Password" to create a new password.
4. Use the "Copy" button to copy the generated password to your clipboard.

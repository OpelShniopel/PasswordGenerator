using System.Security.Cryptography;
using System.Text;

namespace PasswordGenerator;

public partial class Form1 : Form
{
    private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
    private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string NumberChars = "0123456789";
    private const string SpecialChars = "!@#$%^&*";
    private const string OtherSpecialChars = "~`[];?,()+";

    private readonly RandomNumberGenerator _randomGenerator = RandomNumberGenerator.Create();

    public Form1()
    {
        InitializeComponent();
        GeneratePassword();
    }

    private void GeneratePassword()
    {
        StringBuilder passwordBuilder = new();
        string characterPool = BuildCharacterPool();

        AddRequiredCharacters(passwordBuilder);
        FillPassword(passwordBuilder, characterPool);

        if (checkBoxExcludeDuplicateCharacters.Checked)
            ExcludeDuplicateCharacters(passwordBuilder);

        ShufflePassword(passwordBuilder);

        textBoxGeneratedPassword.Text = passwordBuilder.ToString();
    }

    private char GetRandomCharacter(string characters)
    {
        if (string.IsNullOrEmpty(characters))
            throw new ArgumentException(@"Characters should not be empty", nameof(characters));

        // Calculate the maximum value that is evenly divisible by the character pool length
        int maxVal = (int.MaxValue / characters.Length) * characters.Length;
        byte[] randomNumber = new byte[4];
        int randomValue;

        do
        {
            _randomGenerator.GetBytes(randomNumber);
            randomValue = BitConverter.ToInt32(randomNumber, 0) & int.MaxValue; // Ensure non-negative
        } while (randomValue >= maxVal); // Reject values that would introduce bias

        return characters[randomValue % characters.Length];
    }

    private int GetRandomNumber(int maxExclusive)
    {
        if (maxExclusive <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxExclusive), @"maxExclusive must be positive.");

        int maxVal = (int.MaxValue / maxExclusive) * maxExclusive;
        byte[] randomNumber = new byte[4];
        int value;

        do
        {
            _randomGenerator.GetBytes(randomNumber);
            value = BitConverter.ToInt32(randomNumber, 0) & int.MaxValue; // Ensure non-negative
        } while (value >= maxVal); // Reject values that would introduce bias

        return value % maxExclusive;
    }

    private static string RemoveAmbiguousCharacters(string characterPool)
    {
        const string ambiguousCharacters = "lIO01";
        StringBuilder newCharacterPool = new(characterPool.Length);

        foreach (char c in characterPool)
        {
            if (!ambiguousCharacters.Contains(c))
                newCharacterPool.Append(c);
        }

        return newCharacterPool.ToString();
    }
    
    private void AppendCharacters(CheckBox checkBox, string characters, StringBuilder builder, int numCharacters = 1)
    {
        if (!checkBox.Checked)
            return;

        string characterSet = checkBoxAvoidAmbiguousCharacters.Checked
            ? RemoveAmbiguousCharacters(characters)
            : characters;

        for (int i = 0; i < numCharacters; i++)
            builder.Append(GetRandomCharacter(characterSet));
    }
    
    private void AddRequiredCharacters(StringBuilder passwordBuilder)
    {
        AppendCharacters(checkBoxLowerCase, LowercaseChars, passwordBuilder);
        AppendCharacters(checkBoxUpperCase, UppercaseChars, passwordBuilder);
        AppendCharacters(checkBoxNumbers, NumberChars, passwordBuilder, (int)numericUpDownMinNumbers.Value);
        AppendCharacters(checkBoxSpecialChar, SpecialChars, passwordBuilder, (int)numericUpDownMinSpecial.Value);
        AppendCharacters(checkBoxAllowOtherSymbols, OtherSpecialChars, passwordBuilder);
    }
    
    private string BuildCharacterPool()
    {
        StringBuilder characterPoolBuilder = new();

        // Append characters based on checkbox selections
        if (checkBoxUpperCase.Checked)
            characterPoolBuilder.Append(UppercaseChars);
        if (checkBoxLowerCase.Checked)
            characterPoolBuilder.Append(LowercaseChars);
        if (checkBoxNumbers.Checked)
            characterPoolBuilder.Append(NumberChars);
        if (checkBoxSpecialChar.Checked)
            characterPoolBuilder.Append(SpecialChars);
        if (checkBoxAllowOtherSymbols.Checked)
            characterPoolBuilder.Append(OtherSpecialChars);

        // Default to lowercase if no option is selected
        if (characterPoolBuilder.Length == 0)
        {
            checkBoxLowerCase.Checked = true;
            characterPoolBuilder.Append(LowercaseChars);
        }

        string characterPool = characterPoolBuilder.ToString();

        // Remove ambiguous characters if the option is selected
        if (checkBoxAvoidAmbiguousCharacters.Checked)
            characterPool = RemoveAmbiguousCharacters(characterPool);

        return characterPool;
    }
    
    private void FillPassword(StringBuilder passwordBuilder, string characterPool)
    {
        for (int i = passwordBuilder.Length; i < trackBarPasswordLength.Value; i++)
        {
            char nextChar = GetRandomCharacter(characterPool);
            passwordBuilder.Append(nextChar);
        }
    }

    // Fisher Yates shuffle
    private void ShufflePassword(StringBuilder passwordBuilder)
    {
        char[] passwordArray = passwordBuilder.ToString().ToCharArray();
        int n = passwordArray.Length;

        while (n > 1)
        {
            n--;
            int k = GetRandomNumber(n + 1);
            (passwordArray[k], passwordArray[n]) = (passwordArray[n], passwordArray[k]);
        }

        passwordBuilder.Clear();
        passwordBuilder.Append(passwordArray);
    }
    
    private void ExcludeDuplicateCharacters(StringBuilder passwordBuilder)
    {
        HashSet<char> uniqueCharacters = new();
        HashSet<char> characterPool = new(BuildCharacterPool().ToHashSet());
        StringBuilder newPassword = new(passwordBuilder.Length);

        // First pass: Add unique characters to newPassword and update characterPool
        foreach (char c in passwordBuilder.ToString())
        {
            if (!uniqueCharacters.Add(c)) continue;
            newPassword.Append(c);
            characterPool.Remove(c);
        }

        // Second pass: Fill the password back to the required length with random characters
        List<char> remainingCharacterPool = characterPool.ToList();

        while (newPassword.Length < trackBarPasswordLength.Value && remainingCharacterPool.Count > 0)
        {
            int index = GetRandomNumber(remainingCharacterPool.Count);
            newPassword.Append(remainingCharacterPool[index]);
            remainingCharacterPool.RemoveAt(index);
        }

        // Replace the original passwordBuilder content
        passwordBuilder.Clear();
        passwordBuilder.Append(newPassword);
    }

    private void ValidateAndUpdatePasswordLength()
    {
        int totalMinimumRequiredChars = (int)(numericUpDownMinNumbers.Value + numericUpDownMinSpecial.Value);

        if (trackBarPasswordLength.Value >= totalMinimumRequiredChars)
            return;

        trackBarPasswordLength.Value = totalMinimumRequiredChars;
        numericUpDownPasswordLength.Value = totalMinimumRequiredChars;
    }

    private void buttonGeneratePassword_Click(object sender, EventArgs e)
    {
        GeneratePassword();
    }

    private void buttonCopy_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(textBoxGeneratedPassword.Text);
    }

    private void trackBarPasswordLength_Scroll(object sender, EventArgs e)
    {
        numericUpDownPasswordLength.Value = trackBarPasswordLength.Value;
        GeneratePassword();
    }

    private void numericUpDownMinNumbers_ValueChanged(object sender, EventArgs e)
    {
        ValidateAndUpdatePasswordLength();
        GeneratePassword();
    }

    private void numericUpDownMinSpecial_ValueChanged(object sender, EventArgs e)
    {
        ValidateAndUpdatePasswordLength();
        GeneratePassword();
    }

    private void numericUpDownPasswordLength_ValueChanged(object sender, EventArgs e)
    {
        trackBarPasswordLength.Value = (int)numericUpDownPasswordLength.Value;
        GeneratePassword();
    }
}
// a method that checks for lowercase character.
using System;

class Character
{
    public static bool IsLower(char c)
    {
        // ASCII values for lowercase letters: 'a' to 'z' are from 97 to 122
        return c >= 'a' && c <= 'z';
    }
}

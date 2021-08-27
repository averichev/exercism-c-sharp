using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var dict = new Dictionary<char, char> { { 'G', 'C' }, { 'C', 'G' }, { 'T', 'A' }, { 'A', 'U' } };
        var result = "";
        foreach (var character in nucleotide)
        {
            result += dict[character];
        }

        return result;
    }
}
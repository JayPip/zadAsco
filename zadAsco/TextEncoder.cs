using System.Collections.Generic;
using System.Text;

public class TextEncoder
{
    private char escapeChar;
    private Dictionary<char, char> encodingMap;

    public TextEncoder(Dictionary<char, char> encodingSets, char escapeChar = ',')
    {
        this.escapeChar = escapeChar;
        this.encodingMap = encodingSets;
    }

    public string Encode(string text)
    {
        StringBuilder encodedText = new StringBuilder();
        foreach (char c in text)
        {
            if (encodingMap.ContainsKey(c))
            {
                encodedText.Append(escapeChar);
                encodedText.Append(encodingMap[c]);
            }
            else
            {
                encodedText.Append(c);
            }
        }
        return encodedText.ToString();
    }

    public string Decode(string encodedText)
    {
        StringBuilder decodedText = new StringBuilder();
        bool isEscaped = false;

        foreach (char c in encodedText)
        {
            if (isEscaped)
            {
                var myKey = encodingMap.FirstOrDefault(x => x.Value == c).Key;
                decodedText.Append(myKey);
                
                isEscaped = false;
            }
            else if (c == escapeChar)
            {
                isEscaped = true;
            }
            else
            {
                decodedText.Append(c);
            }
        }

        return decodedText.ToString();
    }
}
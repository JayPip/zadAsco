namespace zadAsco;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, char> encodingMap = new Dictionary<char, char>();
        encodingMap[' '] = '1';
        encodingMap['a'] = '2';
        encodingMap['b'] = '3';
        encodingMap['v'] = '9';

        TextEncoder encoder = new TextEncoder(encodingMap);
        string originalText = " ";
        Console.WriteLine("Original Text: " + originalText);

        string encodedText = encoder.Encode(originalText);
        Console.WriteLine("Encoded Text: " + encodedText);

        string decodedText = encoder.Decode(encodedText);
        Console.WriteLine("Decoded Text: " + decodedText);
    }
}

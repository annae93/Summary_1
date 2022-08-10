string[] GetShorterStrings(string[] inputStrings)
{
    int inputSize = inputStrings.Length;
    
    int[] indexes = new int[inputSize];
    
    int outputSize = 0;

    for (int i = 0; i < inputSize; i++)
    {
        if (inputStrings[i].Length <= 3)
        {
            indexes[outputSize] = i;
            outputSize++;
        }
    }

    string[] result = new string[outputSize];

    for (int i = 0; i < outputSize; i++)
    {
        result[i] = inputStrings[indexes[i]];
    }

    return result;
}

string[] strings = {"hello", "world", "-2", ":-)"};

string[] results = GetShorterStrings(strings);

for (int i = 0; i < results.Length; i++)
{
    Console.WriteLine(results[i]);
}
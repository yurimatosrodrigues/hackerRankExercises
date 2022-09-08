int alternatingCharacters(string s)
{
    int deletionsSum = 0;
    for(int i = 0; i < s.Length -1; i++){
        if(s[i] == s[i+1])
            deletionsSum = deletionsSum + 1;
    }
    return deletionsSum;
}

Console.WriteLine(alternatingCharacters("AAABBB"));
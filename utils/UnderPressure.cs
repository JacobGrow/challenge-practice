namespace underpressure.utils
{
    public static class UnderPressure
    {
        public static int doubleInteger(int num) {
    // num will be an integer. Double it and return it.
    return num*2;
}
public static bool isNumberEven(int num) {
    // num will be an integer. Return true if it's even, and false if it isn't.
    return num % 2 == 0;
}
public static string getFileExtension(string str) {
    // str will be a string, but it may not have a file extension.
    // return the file extension (with no period) if it has one, otherwise null (ex: file.txt => txt)
    if(str.Contains(".")){
        var words = str.Split(".");
        return words[words.Length - 1];
    }
    return null;
}
public static string longestWord(string str) {
    // str will be a string
    // return the longest word in the string
    string longest = "";
    string[] words = str.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];
        if(word.Length > longest.Length)
        {
            longest = word;
        }
    }
            return longest;
}
public static int arraySum(int[]  nums) {
 // nums will be an array, containing integers return the Sum of all the integers
    int total = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        var num = nums[i];
        total += num;
    }
    return total;
}
    }
}
using System;
class ShortStrings {
    static void Main() {
        Console.Write("Введите строку: ");
        
        string[] UserArray  = Console.ReadLine().Split();
        
        int LenShortStrings = 3;
        
        PrintResult(FindShortStrings(UserArray, LenShortStrings));
    }
    
    static string[] FindShortStrings(string[] UserArray, int LenShortStrings){
        string[] ArrayOfShortStrings = new string[0];
        int INDEX = 0;
        string word;
        
        for (int index = 0; index < UserArray.Length; index++){
            word = UserArray[index];
            
            if ((word.Length <= LenShortStrings) && (word != "")){
                Array.Resize(ref ArrayOfShortStrings, ArrayOfShortStrings.Length+1);
                ArrayOfShortStrings[INDEX] = word;
                INDEX += 1;
            }
        }
        
        return ArrayOfShortStrings;
    }
    
    static void PrintResult(string[] ArrayOfShortStrings){
        Console.Write($"[");
        
        int LenArr = ArrayOfShortStrings.Length;
        
        if (LenArr != 0){
            for (int index = 0; index < LenArr-1; index++){
                Console.Write($"'{ArrayOfShortStrings[index]}', ");
            }
            Console.Write($"'{ArrayOfShortStrings[LenArr-1]}']");
        }
        
        else{
            Console.Write("]");
        }
    }
}


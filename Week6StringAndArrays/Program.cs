using System.Runtime.Serialization.Formatters;

string hello = " hello, world! Here I am! ";

int stringLength = hello.Length;

//string trimmedString = hello.Trim();

hello= hello.Trim();
//int wordCounter = 1;

char firstLetter = hello[0];

Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter= hello[0];

Console.WriteLine(firstLetter);
Console.WriteLine(hello);

//Console.WriteLine(trimmedString.Length);

//for (int i=0; i < hello.Length; i++)

    
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }


//    //Console.WriteLine($"{i} symbol is string: {hello[i]}");
//    //if (hello[i] == ' ')
//   // { 
//        //wordCounter++;
//          //  }

//}

//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words ");
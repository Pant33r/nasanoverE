using System;

//ANDRA UPPGIFTEN PROG 1
//class ifsatseroarrayer
//{
//    static void Main(string[]args)
//    {
//        int a =6;
//        int b =3;
//        if(a>=b)
//        {
//            System.Console.WriteLine("Hello World!");
//        }
//    }
//}
//TREDJE UPPGIFTEN PROG 1

// class andradelen
// {
// static void Main(string[]args)
// {
// System.Console.WriteLine("tjeanre ta och skriv in ditt namn och lösenord");
// 
// string namn = Console.ReadLine();
// string losenord = Console.ReadLine();
// if(namn == "noname" && losenord =="nopass")
// {
// System.Console.WriteLine("Welcome");
// }
// else
// {
// System.Console.WriteLine("Wrong username or password");
// }
// Console.ReadLine();
// }
// }

//FJÄRDE PROG 1
// class whileloop
// {
// static void Main(string[]args)
// {
// int i = 0;
// 
// while(i<32)
// {
// System.Console.WriteLine("Hello, World!");
// i++;
// }
// Console.ReadLine();
// }
// }
//FÄMTE UPPGIFEN PROG 1

// class whileloopkod
// {
//     static void Main(string[] args)
//     {
//         string losenord = "losenord";
//         System.Console.WriteLine("skriv lösen");

//         while (Console.ReadLine() != losenord)
//         {
//             System.Console.WriteLine("fel");
//         }
//         Console.ReadLine();
//     }
// }

//SJÄTTE UPPGIFTEN PROG 1

    // class whileloopkod
    // {
    //     static void Main(string[]args)
    //     {
    //          for (int i = 0; i < 5; i++)
    //     {
    //         Console.Write("Skriv in ett tal: ");
    //         string numStorlek = Console.ReadLine();
    //         int nummer = int.Parse(numStorlek);
    //         if (nummer > 5)
    //         {
    //             Console.WriteLine("Högre än 5!");
    //         }
    //         Console.ReadLine();
    //     }
    //     }
    // }
    
//SJUNDE UPPGIFTEN

class SJUNDE
{
    static void Main(string[] args)
    {
        bool funkardet = false;
        
        while (!funkardet)
        {
            Console.Write("Skriv in ett heltal: ");
            string skrivare = Console.ReadLine();

            if (int.TryParse(skrivare, out int nummer))
            {
                Console.WriteLine($"Du skrev in talet {nummer}");
                funkardet = true;
            }
            else
            {
                Console.WriteLine("Försök igens");
            }
        }
    }
}
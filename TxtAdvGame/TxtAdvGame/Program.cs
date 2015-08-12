using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtAdvGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 1;  //where are we in the maze
            bool keepGoing = true; //will be false when we die or find the way out
            bool hasKey = false; //did we pickup the key
            string input = null; //what did the user type
            while (keepGoing == true) //will be false when we die or find the exit door
            {
                if (pos == 1)
                {
                    Console.WriteLine("You are trapped in a Maze.");
                    Console.WriteLine("You must find your way out without getting eaten by the monster.");
                    Console.WriteLine("You can go East. (e)");
                    input = Console.ReadLine();
                    if (input == "e")  //can only go east at the start position, ignore everything else
                    {
                        pos++;
                    }
                }
                else if (pos == 2)
                {
                    Console.WriteLine("You are at an intersection. There are hallways to the North, East, and West.");
                    Console.WriteLine("There is a painting on the south wall.");
                    Console.WriteLine("You can go North, East, or West. (n/e/w)");
                    input = Console.ReadLine();
                    if (input == "n")
                    {
                        pos = 3;
                    }
                    else if (input == "e")
                    {
                        pos = 6;
                    }
                    else if (input == "w")
                    {
                        pos = 1;
                    }
                }
                else if (pos == 3)
                {
                    Console.WriteLine("You have reached an intersection. There is a grimy window on the wall that you can't see out of.");
                    Console.WriteLine("You can go West, East, or South. (w/e/s)");
                    input = Console.ReadLine();
                    if (input == "e")
                    {
                        pos = 5;
                    } 
                    else if (input == "w")
                    {
                        pos = 4;
                    }
                    else if (input == "s")
                    {
                        pos = 2;
                    }
                }
                else if (pos == 4)
                {
                    Console.WriteLine("There is a door to the West.");
                    Console.WriteLine("You can open the door by typing 'open door' or you can go East. (open door/e)");
                    input = Console.ReadLine();
                    if (input == "open door")
                    {
                        Console.WriteLine("You stumble into a room and hear a growl. Something grabs you.");
                        Console.WriteLine("You were eaten by a monster.");
                        Console.WriteLine("        /-/--\\          "); 
                        Console.WriteLine("      (@~@)   )/\\       ");
                        Console.WriteLine("  ___/--      \\  |      ");
                        Console.WriteLine(" (oo)__ _      )_/       ");
                        Console.WriteLine("  ^^___/       \\        ");
                        Console.WriteLine("        \\       |/-\\   ");
                        Console.WriteLine("         (      )   |    ");
                        Console.WriteLine("         |       \\_/    ");
                        Console.ReadLine();
                        keepGoing = false;
                    }
                    else if (input == "e")
                    {
                        pos = 3;
                    }
                }
                else if (pos == 5)
                {
                    Console.WriteLine("There is a door to the East.");
                    Console.WriteLine("You can open the door by typing 'open door' or you can go West. (open door/w)");
                    input = Console.ReadLine();
                    if (input == "open door")
                    {
                        hasKey = true;
                        Console.WriteLine("You have picked up a key.");
                    }
                    else if (input == "w")
                    {
                        pos = 3;
                    }
                }
                else if (pos == 6)
                {
                    Console.WriteLine("There is a door to the East.");
                    Console.WriteLine("You can open the door by typing 'open door' or you can go West. (open door/w)");
                    input = Console.ReadLine();
                    if (input == "open door")
                    {
                        Console.WriteLine("This door is locked");
                        if (hasKey == true)
                        {
                            Console.WriteLine("Would you like to use your key? (y/n)");
                            input = Console.ReadLine();
                            if (input == "y")
                            {
                                Console.WriteLine("You made it out of the maze alive.");
                                Console.ReadLine();
                                keepGoing = false;
                            }
                        }
                    }
                    else if (input == "w")
                    {
                        pos = 2;
                    }
                }
            }
        }
    }
}

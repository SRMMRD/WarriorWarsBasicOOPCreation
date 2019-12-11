using System;
using System.Collections.Generic;
using System.Text;

namespace WarriorWars
{
    //All this does is saves a bunch of typing when the win/loss message displays by inserting color to the message
    static class Tools
    {
        public static void ColorfulWriteline(string text, ConsoleColor color)
        {

            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();

        }
    
            
    }

}

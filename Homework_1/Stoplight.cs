using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Stoplight
    {
        string name;
        string color;


        //
        // Method Name: Stoplight
        // Description: Constructor 
        public Stoplight(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        //
        // Method Name: GetName
        // Description: Returns name as a string 
        public string GetName()
        {
            return name;
        }

        //
        // Method Name: GetColor
        // Description: Returns color as a string 
        public string GetColor()
        {
            return color;
        }

        //
        // Method Name: SetColor
        // Description: Sets the color of the stoplight 
        public void SetColor(string color)
        {
            this.color = color;
        }

    }
}

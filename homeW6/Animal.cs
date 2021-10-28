using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeW6
{
    public class Animal
    { 
        public Animal(string eyecolor, string age, string height)

    {
            this.EyeColor = eyeColor;
            this.Age = age;
            this.Height = height;
    }
        private string eyeColor;
        private string skinColor;
        private string weight;
        private string hight;
        private string age;
    
    public string Eyecolor
        {
            get { return eyeColor; }
            set { eyeColor = value; }
        }
    public string Age
        {
            get { return age; }
            set { age = value; }
        }
    public string Height
        {
            get { return height; }
            set { height = value; }
        }

        public void ChangeSkinColor(SkinColor);
    {
        
    }
    public void SetAge()
    {


    }
}

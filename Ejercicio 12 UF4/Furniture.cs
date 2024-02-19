using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12_UF4
{
    public class Furniture
    {
        private float weight;
        private double price;
        private Boolean set;
        private string name, material, color;

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Boolean Set
        {
            get { return set; }
            set { set = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Furniture(float weight, double price, Boolean set, string name, string material, string color)
        {
            Weight = weight;
            Price = price;
            Set = set;
            Name = name;
            Material = material;
            Color = color;
        }

        public void ShowFurniture()
        {
            Console.WriteLine("Nombre: " + Name);
            Console.WriteLine("Peso: " + Weight);
            Console.WriteLine("Precio: " + Price);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("¿Está montado? " + Set);
        }
    }
}

using Ejercicio_12_UF4;
using System;

namespace Program
{
    class MyClass
    {
        public static void Main()
        {
            Furniture furniture = new Furniture(10, 100, true, "Table", "Wood", "Brown");
            furniture.ShowFurniture();
        }
    }
}
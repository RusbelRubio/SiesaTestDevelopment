using System;
using BinaryTreeSample;
using ChangeBaseDefinition;

namespace ChangeBaseSample
{
    class Program
    {        
    
        static void Main(string[] args)
        {
            var Value = 256;
            var Base = 16;
            Console.WriteLine("Base Change Test Sample RRP");
            Console.WriteLine($"Sample with Values: Number={Value} and Base ={Base}");
            Console.WriteLine(new ChangeBaseNumber().ChangedBase(Value, Base));
            
            
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);
            Console.WriteLine($"Peso Arbol:{binaryTree.GetTreeWeight()}");
            Console.WriteLine($"Promedio Arbol:{binaryTree.GetTreeAverage()}");
            Console.ReadLine();
        }
    }
}

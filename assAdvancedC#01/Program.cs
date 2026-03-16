using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace assAdvancedC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region Qustion1
            //What is a generic class? Why use generics?
            //uses type parameters that are replaced with actual types when you create an instance
            //to avoid duplication and object class
            #endregion
            #region Qustion2
            // Write a generic class Container<T> with Add and Get methods.
            #endregion
            #region Question3
            //What are multiple type parameters? Write Pair<TKey, TValue>.
            //generic class have multiple type parameters
            #endregion
            #region Question4
            //What is a generic method? Write Swap<T> method.
            //declares its own type parameter
            #endregion
            #region Question5
            //Write a generic method FindMax<T> that finds maximum value
            #endregion
            #region  Question6
            //What is a generic interface? Write IRepository<T>.
            //define contracts with type parameters
            #endregion
            #region Question7
            //What is the 'struct' constraint? Write an example.
            //T to value types only
            // var A = new EXStruct<int>(50);//valid 
            //var A = new EXStruct<String>("Hazem");//Not valid becouse the generic class has a constraint struct on it
            #endregion
        }
    }
}

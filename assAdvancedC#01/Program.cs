using Microsoft.VisualBasic;
using System;
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
            #region Question8
            //What is the 'class' constraint? Write an example.
            //T is referance type only 
            // var A = new EXClass<int>(50);//not valid becouse the generic class has a class constraint on it 
            //var A = new EXClass<String>("Hazem");//valid
            #endregion
            #region Question9
            //What is the 'new()' constraint? Write an example
            //must T to have a public parameterless constructor
            //var S = new EXNew<A>();
            //S.create();//valid becouse A has a parameterless constructor
            #endregion
            #region Question10
            // What is the interface constraint? Write an example.
            //Must T to implement a specific interface
            #endregion
            #region Question11
            //What is the base class constraint? Write an example
            // T  must inherit from a specific base class. 
            //var T = new EXBaseclass<A>();//not valid becouse A don't inhert from Person
            //var T = new EXBaseclass<male>();// male is inhert from person
            #endregion
            #region Question12
            //How do you apply multiple constraints? Write an example
            //we apply class\struct first then iterface and the last is new()
            #endregion
            #region Question13
            //What does the 'default' keyword do in generics?
            //deturns the default value for type T
            #endregion
            #region Question14
            //Write a SafeList<T> that returns default when the index is invalid.
            #endregion
            #region Question15
            // What is covariance? Explain the 'out' keyword
            //use a more derived type than originally specified
            //T can only appear in output positions
            #endregion

        }
    }
}

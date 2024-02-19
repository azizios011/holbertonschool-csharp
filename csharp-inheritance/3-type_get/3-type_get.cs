using System;
using System.Reflection;

/// <summary>
/// A representation of class "Obj".
/// </summary>
class Obj
{
    /// <summary>
    /// A method that prints the names of the available properties and methods of an object. 
    /// </summary>
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();

        Console.WriteLine($"{typeInfo.Name} Properties:");
        foreach (PropertyInfo property in typeInfo.GetProperties())
        {
            Console.WriteLine($"{property.Name}");
        }

        Console.WriteLine($"{typeInfo.Name} Methods:");
        foreach (MethodInfo method in typeInfo.GetMethods())
        {
            Console.WriteLine($"{method.Name}");
        }
    }
}

using System;
using System.Reflection;

///<summary> Obj class</summary>
class Obj
{
    ///<summary> List all</summary>
    ///<param name="myObj">Object to list their props and methods</param>
    public static void Print(object myObj)
    {
        PropertyInfo[] props = myObj.GetType().GetProperties();
        MethodInfo[] methods = myObj.GetType().GetMethods();

        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach(var prop in props)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
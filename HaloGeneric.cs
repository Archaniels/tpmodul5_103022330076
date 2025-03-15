using System;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class HaloGeneric
{
    public HaloGeneric()
    {
    }

    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }
    
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data); 
    }
}
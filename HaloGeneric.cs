using System;
using System.Runtime.CompilerServices;

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
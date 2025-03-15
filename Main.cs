internal class program
{
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Dani");

        DataGeneric<long> data = new DataGeneric<long>(103022330076);
        data.PrintData();
    }
}
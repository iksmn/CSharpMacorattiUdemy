Console.WriteLine("## Struct parte 2 ##");


MinhaClasse minhaClasse1 = new(), minhaClasse2 = null;
MinhaStruct minhaStruct1 = new(), minhaStruct2 = new();

minhaClasse1.x = minhaStruct1.x = 5;
minhaClasse1.y = minhaStruct1.y = 10;

minhaClasse2 = minhaClasse1; //ref
minhaStruct2 = minhaStruct1; //valor

Console.ReadKey();

public class MinhaClasse
{
    public int x;
    public int y;
}

public struct MinhaStruct
{
    public int x;
    public int y;
}
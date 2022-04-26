using ListaIndirizzi;
string path = "C:\\Users\\Alec\\source\\repos\\ListaIndirizzi\\ListaIndirizzi\\bin\\Debug\\net6.0\\addresses.csv";

List<Persona> persone = new List<Persona>();

bool debug = false;

Console.WriteLine("Premi Y per il debug");
if(Console.ReadLine() == "y")
    debug = true;
List<string> lista = new List<string>();


try
{
    StreamReader file = File.OpenText(path);
    file.ReadLine();
    while (!file.EndOfStream)
    {
        string line = file.ReadLine();
        lista.Add(line);
        string[] parts = line.Split(',');
        if (parts.Length == 6)
        {
            Persona persona = new Persona(parts[0], parts[1], parts[2], parts[3], parts[4], int.Parse(parts[5]));
            persone.Add(persona);
        }
    }
    file.Close();

}
catch (Exception error)
{
    Console.WriteLine(error.Message);
    Console.WriteLine(error.StackTrace);
    Console.WriteLine("Errore nella lettura del file");
}
foreach (Persona persona in persone)
{
    Console.WriteLine(persona.ToString());
}
if (debug)
{
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
}
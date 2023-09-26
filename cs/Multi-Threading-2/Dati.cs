class Dati
{
    int condivisa = 0;

    public void f() {
        Random generatore = new();
        Console.WriteLine($"Invoca dal thread {Thread.CurrentThread.Name}");
        condivisa = generatore.Next(100);
        Console.WriteLine($"Ora la variabile condivisa vale: {condivisa}");
    }
}
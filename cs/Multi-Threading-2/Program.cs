class Program {
    static void Main(string[] args){
        Dati d = new();

        Thread t1 = new(d.f){
            Name = "thread: " + nameof(t1)
        };

        Thread t2 = new(d.f){
            Name = "thread: " + nameof(t2)
        };

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
    }
}
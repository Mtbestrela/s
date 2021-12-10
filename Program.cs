﻿
class StopWtach{
    static void Main(string[] args){
        Menu();
    }

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo => 1s = 1 segundo");
    Console.WriteLine("M = Minuto => 1m = 60 segundos");
    Console.WriteLine("0 = Sair da Aplicação");
    Console.WriteLine("Quanto tempo deseja contar? ");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length -1 ,1));
    int time = int.Parse(data.Substring(0, data.Length -1)) ;
    
    int multiplier = 1;

    if (type == 'm')
    multiplier = 60;

    if (time == 0)
        System.Environment.Exit(0);

    PreStart(time * multiplier);
    
}

static void PreStart(int time){
    Console.Clear();
    Console.WriteLine("Preparar...");
    Thread.Sleep(1000);
    Console.WriteLine("Apontar...");
    Thread.Sleep(1000);
    Console.WriteLine("Valendo...");
    Thread.Sleep(1500);

    Start(time);
}
static void Start(int time)
{
    int currentTime = 0;

    while(currentTime != time)
    {
        Console.Clear();
        currentTime ++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

        Console.Clear();
        Console.WriteLine("StopWatch finalizado...");
        Thread.Sleep(2500);

        Menu();
    
}
}

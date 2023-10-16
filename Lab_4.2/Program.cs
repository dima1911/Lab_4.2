using System;
using System.Collections.Generic;

// Базовий клас "Комп'ютер"
public class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OS { get; set; }

    public Computer(string ipAddress, int power, string os)
    {
        IPAddress = ipAddress;
        Power = power;
        OS = os;
    }
}

// Клас "Сервер"
public class Server : Computer, IConnectable
{
    public Server(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
    }

    public void Connect(Computer target)
    {
        Console.WriteLine($"Server {IPAddress} is connecting to {target.IPAddress}.");
    }

    public void Disconnect(Computer target)
    {
        Console.WriteLine($"Server {IPAddress} is disconnecting from {target.IPAddress}.");
    }

    public void SendData(Computer target, string data)
    {
        Console.WriteLine($"Server {IPAddress} is sending data to {target.IPAddress}: {data}");
    }

    public void ReceiveData(Computer source, string data)
    {
        Console.WriteLine($"Server {IPAddress} received data from {source.IPAddress}: {data}");
    }
}

// Клас "Робоча станція"
public class Workstation : Computer, IConnectable
{
    public Workstation(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
    }

    public void Connect(Computer target)
    {
        Console.WriteLine($"Workstation {IPAddress} is connecting to {target.IPAddress}.");
    }

    public void Disconnect(Computer target)
    {
        Console.WriteLine($"Workstation {IPAddress} is disconnecting from {target.IPAddress}.");
    }

    public void SendData(Computer target, string data)
    {
        Console.WriteLine($"Workstation {IPAddress} is sending data to {target.IPAddress}: {data}");
    }

    public void ReceiveData(Computer source, string data)
    {
        Console.WriteLine($"Workstation {IPAddress} received data from {source.IPAddress}: {data}");
    }
}

// Клас "Маршрутизатор"
public class Router : Computer, IConnectable
{
    public Router(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
    }

    public void Connect(Computer target)
    {
        Console.WriteLine($"Router {IPAddress} is connecting to {target.IPAddress}.");
    }

    public void Disconnect(Computer target)
    {
        Console.WriteLine($"Router {IPAddress} is disconnecting from {target.IPAddress}.");
    }

    public void SendData(Computer target, string data)
    {
        Console.WriteLine($"Router {IPAddress} is sending data to {target.IPAddress}: {data}");
    }

    public void ReceiveData(Computer source, string data)
    {
        Console.WriteLine($"Router {IPAddress} received data from {source.IPAddress}: {data}");
    }
}

// Інтерфейс для з'єднання та передачі даних
public interface IConnectable
{
    void Connect(Computer target);
    void Disconnect(Computer target);
    void SendData(Computer target, string data);
    void ReceiveData(Computer source, string data);
}

// Клас "Мережа"
public class Network
{
    private List<Computer> computers = new List<Computer>();

    public void AddComputer(Computer computer)
    {
        computers.Add(computer);
    }

    public void SimulateNetwork()
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Network network = new Network();

        Server server1 = new Server("192.168.0.1", 1000, "Windows Server");
        Workstation workstation1 = new Workstation("192.168.0.2", 500, "Windows 10");
        Router router1 = new Router("192.168.0.3", 200, "RouterOS");

        network.AddComputer(server1);
        network.AddComputer(workstation1);
        network.AddComputer(router1);

        network.SimulateNetwork();

        Console.WriteLine("Network simulation completed.");
    }
}

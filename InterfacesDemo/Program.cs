﻿// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        IWorker[] workers = new IWorker[]
        {
            new Worker(),
            new Manager(),
            new Robot()
        };

        foreach (var worker in workers)
        {
            worker.Work();
        }


        IEat[] eats = new IEat[]
        {
            new Worker(),
            new Manager()
            
        };
    }

    interface IWorker
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();

    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }


    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}

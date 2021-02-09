using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class ConsoleUIMain
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());//Ben inmemory çalışacağım dedik.
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            
        }
    }
}

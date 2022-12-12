// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
namespace RockyHorror
{
    class Program
    {
        static void Main(string[] args)
        {
            var showing = new Showing();
            showing.Location = "Brattle";
            showing.NumberOfSeats = 250;
            showing.ShowTimes = new List<DateTime>
            {

            }
        }
    }
}
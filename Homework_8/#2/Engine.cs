﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Engine
{
    public class Engine 
    {
        private bool isStarted;
        public void StartEngine()
        {
            if (isStarted == false)
            {
                isStarted = true;
                Console.WriteLine("Двигатель запущен!");
            }
            else
            {
                isStarted = false;
                Console.WriteLine("Двигатель остановлен!");
            }
        }

    }
}

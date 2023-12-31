﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _Stack
{
    public class Stack
    {       
        private object[] stack = new object[5] {"String", 27015, 15.32D, 'A', "IT Academy"};      
        public void Show() //Отображение текущего содержимого стека
        {
            Console.WriteLine("Текущее содержимое стека:");
            for (int i = 0; i < stack.Length; i++) 
            {
                Console.Write(stack[i] + " | ");
            }
            Console.WriteLine("\n");
        }

        public void IsEmpty() //Проверка стека на наличие элементов
        {
            if (stack.Length == 0 | stack == null) Console.WriteLine("Стек пуст!");
            else Console.WriteLine("Стек не пуст!");
            Console.WriteLine();
        }

        public void Push(object newMember) //Запись нового элемента в стек
        {
            Array.Resize(ref stack, stack.Length + 1);
            stack[stack.Length - 1] = newMember;
        }

        public object Pop() //Возврат верхнего элемента из стека
        {
            object lastRemovedMember; //Переменная для записи удаленного элемента
            
            if (stack == null | stack.Length == 0)
            {
                Console.WriteLine("Стек пуст!");
                return lastRemovedMember = null;
            }
            else
            {
                lastRemovedMember = stack[stack.Length - 1];
                Array.Resize(ref stack, stack.Length - 1);
                return lastRemovedMember;
            }
        }
    }
}

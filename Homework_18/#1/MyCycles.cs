﻿// <copyright file="MyCycles.cs" company="Alexei Morozov">
// Copyright (C) Alexei Morozov. All rights reserved.
// </copyright>

using System;
using System.Threading;
using IMMyCycles;

namespace MMyCycles
{
	/// <summary>
	/// Класс с кастомными циклами.
	/// </summary>
	public class MyCycles : IMyCycles
	{
		/// <inheritdoc/>
		public void WriteNumbers()
		{
			for (int i = 0; i <= 33; i++)
			{
				Thread.Sleep(1500);
				Console.Write(new string(' ', 20));
				Console.Write(Thread.CurrentThread.Name);
				Console.WriteLine($"{i} ");
			}

			Console.WriteLine();
		}

		/// <inheritdoc/>
		public void WriteLetters()
		{
			char chr = 'А';
			for (int i = 0; i <= 33; i++)
			{
				Thread.Sleep(1000);
				Console.Write(Thread.CurrentThread.Name);
				Console.WriteLine($"'{(char)(chr + i)}' ");
			}
		}
	}
}

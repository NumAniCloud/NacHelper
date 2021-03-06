﻿using System;
using System.Threading.Tasks;

namespace NacHelpers.Utility
{
	public class AtomicConsole : Atomics
	{
		public async Task WriteAsync(string msg) => await Run(() => Console.Write(msg));

		public async Task WriteLineAsync(string msg) => await Run(() => Console.WriteLine(msg));

		public async Task<string> ReadLineAsync() => await Run(() => Console.ReadLine());
	}
}

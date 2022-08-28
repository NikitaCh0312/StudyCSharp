// See https://aka.ms/new-console-template for more information

using System.Data;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
Console.ReadLine();




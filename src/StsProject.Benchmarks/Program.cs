﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Running;

namespace StsProject.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<ListVsGrowthArray_Append>();
            //BenchmarkRunner.Run<ListVsGrowthArray_GetItem>();
            //BenchmarkRunner.Run<ListVsGrowthArray_Iteration>();
            BenchmarkRunner.Run<ListVsGrowthArray_Copying>();
        }
    }
}

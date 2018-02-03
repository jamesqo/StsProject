using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;

namespace StsProject.Benchmarks
{
    [CoreJob]
    //[RPlotExporter]
    [CsvMeasurementsExporter]
    public class ListVsGrowthArray_Copying
    {
        [Params(
            4,
            8,
            16,
            32,
            64,
            128,
            256,
            512,
            1024,
            2048,
            4096,
            8192,
            16384,
            32768,
            65536
        )]
        public int N;

        public List<object> _List;
        public GrowthArray<object> _GrowthArray;
        public object[] _Target;

        [GlobalSetup]
        public void Setup()
        {
            var obj = new object();

            _List = new List<object>();
            for (int i = 0; i < N; i++)
            {
                _List.Add(obj);
            }

            _GrowthArray = new GrowthArray<object>();
            for (int i = 0; i < N; i++)
            {
                _GrowthArray.Append(obj);
            }
        }

        [IterationSetup]
        public void IterSetup()
        {
            _Target = new object[N];
        }

        [Benchmark]
        public void List()
        {
            _List.CopyTo(_Target);
        }

        [Benchmark]
        public void GrowthArray()
        {
            _GrowthArray.CopyTo(_Target, 0);
        }
    }
}

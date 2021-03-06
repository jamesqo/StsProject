``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.125)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical cores and 2 physical cores
Frequency=2648438 Hz, Resolution=377.5810 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host] : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  Core   : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|            Method |     N |           Mean |         Error |        StdDev |
|------------------ |------ |---------------:|--------------:|--------------:|
|              **List** |     **4** |       **2.393 ns** |     **0.0381 ns** |     **0.0356 ns** |
|    GrowthArray_O1 |     4 |      24.981 ns |     0.2045 ns |     0.1913 ns |
| GrowthArray_OLogN |     4 |      14.948 ns |     0.0829 ns |     0.0775 ns |
|              **List** |     **8** |       **5.841 ns** |     **0.0570 ns** |     **0.0533 ns** |
|    GrowthArray_O1 |     8 |      49.576 ns |     0.3124 ns |     0.2922 ns |
| GrowthArray_OLogN |     8 |      24.525 ns |     0.2888 ns |     0.2560 ns |
|              **List** |    **16** |      **11.198 ns** |     **0.0660 ns** |     **0.0618 ns** |
|    GrowthArray_O1 |    16 |      97.664 ns |     0.7582 ns |     0.6721 ns |
| GrowthArray_OLogN |    16 |      55.627 ns |     0.3466 ns |     0.2895 ns |
|              **List** |    **32** |      **20.955 ns** |     **0.1887 ns** |     **0.1765 ns** |
|    GrowthArray_O1 |    32 |     184.140 ns |     1.0622 ns |     0.9416 ns |
| GrowthArray_OLogN |    32 |     130.776 ns |     1.4187 ns |     1.3270 ns |
|              **List** |    **64** |      **43.192 ns** |     **0.3543 ns** |     **0.2959 ns** |
|    GrowthArray_O1 |    64 |     370.766 ns |     3.0572 ns |     2.7101 ns |
| GrowthArray_OLogN |    64 |     309.051 ns |     2.0236 ns |     1.7939 ns |
|              **List** |   **128** |      **94.821 ns** |     **0.3903 ns** |     **0.3460 ns** |
|    GrowthArray_O1 |   128 |     737.732 ns |     5.0882 ns |     4.7595 ns |
| GrowthArray_OLogN |   128 |     710.232 ns |     5.8664 ns |     4.8987 ns |
|              **List** |   **256** |     **185.571 ns** |     **3.7390 ns** |     **4.9914 ns** |
|    GrowthArray_O1 |   256 |   1,445.778 ns |    14.7568 ns |    13.8035 ns |
| GrowthArray_OLogN |   256 |   1,534.022 ns |    14.6142 ns |    12.2035 ns |
|              **List** |   **512** |     **354.651 ns** |     **2.4638 ns** |     **2.1841 ns** |
|    GrowthArray_O1 |   512 |   2,832.287 ns |    15.0967 ns |    14.1214 ns |
| GrowthArray_OLogN |   512 |   3,538.120 ns |    27.8047 ns |    26.0086 ns |
|              **List** |  **1024** |     **702.306 ns** |     **7.2093 ns** |     **6.3909 ns** |
|    GrowthArray_O1 |  1024 |   5,647.700 ns |    50.3729 ns |    47.1188 ns |
| GrowthArray_OLogN |  1024 |   7,752.552 ns |   152.5025 ns |   175.6220 ns |
|              **List** |  **2048** |   **1,391.046 ns** |    **11.0952 ns** |     **9.8356 ns** |
|    GrowthArray_O1 |  2048 |  11,307.378 ns |    99.8211 ns |    93.3727 ns |
| GrowthArray_OLogN |  2048 |  16,900.097 ns |   328.2259 ns |   322.3617 ns |
|              **List** |  **4096** |   **2,801.883 ns** |    **36.4902 ns** |    **34.1330 ns** |
|    GrowthArray_O1 |  4096 |  22,539.415 ns |   246.6843 ns |   218.6792 ns |
| GrowthArray_OLogN |  4096 |  35,304.481 ns |   330.2233 ns |   308.8910 ns |
|              **List** |  **8192** |   **5,592.379 ns** |    **48.9303 ns** |    **45.7694 ns** |
|    GrowthArray_O1 |  8192 |  44,999.301 ns |   312.6049 ns |   277.1161 ns |
| GrowthArray_OLogN |  8192 |  77,186.318 ns |   711.0646 ns |   665.1302 ns |
|              **List** | **16384** |  **11,158.899 ns** |    **95.9412 ns** |    **85.0494 ns** |
|    GrowthArray_O1 | 16384 |  90,941.250 ns | 2,143.6333 ns | 2,005.1557 ns |
| GrowthArray_OLogN | 16384 | 160,931.881 ns | 1,119.2127 ns |   934.5932 ns |
|              **List** | **32768** |  **22,294.323 ns** |   **274.5016 ns** |   **256.7690 ns** |
|    GrowthArray_O1 | 32768 | 178,844.834 ns | 1,548.8497 ns | 1,448.7948 ns |
| GrowthArray_OLogN | 32768 | 348,503.661 ns | 3,365.3458 ns | 2,983.2911 ns |
|              **List** | **65536** |  **44,973.163 ns** |   **519.5590 ns** |   **485.9958 ns** |
|    GrowthArray_O1 | 65536 | 358,245.360 ns | 2,564.8224 ns | 2,141.7427 ns |
| GrowthArray_OLogN | 65536 | 735,125.939 ns | 6,657.5400 ns | 5,559.3469 ns |

# ExcessiveMemoryUsageWhenLargeDI

This issue refers to https://github.com/dotnet/runtime/issues/36374

The default MS.DI container uses excessive amounts of memory when a large dependency graph is defined.
A background thread is launched that traverses the DI graph. Which generates large amounts of IL that chews through a lot of memory that sits on the LOH for the duration of the asp.net core web api.

A remark by brandondahler which explains why this happens 

```
Doing a quick analysis on the size of the generated IL of different maximally dense trees, I found they follow these approximate sizes:

Transient - 5 * 2^n
Scoped - 90 + 22n
Singleton - 16n
While the IL generated being is O(2^n) in size, this presumably isn't that big of an issue because the total number of constructed objects in this case would also be O(2^x), meaning that the size of the IL generated is linearly related to the total number of objects to be constructed.

If I'm expanding this logic right, 1024 bytes should be enough IL space for us to construct ~200 transient object instances, ~50 scoped object instances, or ~64 singleton object instances.
``` 
https://github.com/dotnet/runtime/issues/36374#issuecomment-533933856

How to reproduce
1. Run the example project in release
2. Hit http://localhost:5000/WeatherForecast multiple times
3. Use something to observe the LOH (dotnet-counters/dotmemory)

[logo]: ./images/dotnet-counters.PNG "dotnet-counters example"
[logo]: ./images/dotmemory-visual.PNG "dotmemory visual example"

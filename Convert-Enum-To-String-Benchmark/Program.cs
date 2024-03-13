﻿using BenchmarkDotNetVisualizer;
using Convert_Enum_To_String_Benchmark;
using EnumStringValues;

// add caching ability for EnumStringValues nuget
EnumExtensions.Behaviour.UseCaching = true;

var summary = BenchmarkAutoRunner.Run<Benchmark>();

await summary.SaveAsImageAsync(
    path: DirectoryHelper.GetPathRelativeToProjectDirectory("Benchmark.png"),
    options: new ReportHtmlOptions
    {
        Title = "Converting Enum To A String Benchmarks",
        SpectrumColumns = ["Mean", "Allocated"],
        SortByColumns = ["Mean", "Allocated"],
        HighlightGroups = false,
    });
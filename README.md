# Maestria Reflection Extensions

[![Build status](https://ci.appveyor.com/api/projects/status/81ctraq8ry13ma18/branch/master?svg=true)](https://ci.appveyor.com/project/fabionaspolini/reflectionextensions/branch/master)
[![NuGet](https://buildstats.info/nuget/Maestria.Reflection.Extensions)](https://www.nuget.org/packages/Maestria.Reflection.Extensions)
[![MyGet](https://buildstats.info/myget/maestrianet/Maestria.Reflection.Extensions)](https://www.myget.org/feed/maestrianet/package/nuget/Maestria.Reflection.Extensions)

[![Build History](https://buildstats.info/appveyor/chart/fabionaspolini/reflectionextensions?branch=master)](https://ci.appveyor.com/project/fabionaspolini/reflectionextensions/history?branch=master)

## What is Reflection Extensions?

This package provider a fluent syntax to simple data conversions.
Extension functions package for simple data convert.

## What is Maestria Project?

This library is part of Maestria Project.

Maestria is a project to provide maximum productivity and elegance to your code.

## How do I get started?

First, import "Maestria.Reflection.Extensions" reference:

```csharp
using Maestria.Reflection.Extensions;
```

Then in your application code, use fluent syntax: 

```csharp
// all to fixed point
"150".ToInt16();        // string to int16 conversion
"150".ToInt32();        // string to int32 conversion
"150".ToInt64();        // string to int64 conversion
"150.345".ToInt32();    // string to int32 conversion, output is a int32 = 150
150.345.ToInt32();      // double to int32 covnersion, output is a int32 = 150

// all to floating point
"150.45".ToFloat();                                         // use default number culture configured at the application startup
"150.45".ToDouble(CultureInfo.GetCultureInfo("en"));        // use USA decimal separator ","
"150,45".ToDecimal(CultureInfo.GetCultureInfo("pt-BR"));    // use Brazil decimal separator "."

// all to date time
"2019-06-29 13:31:59".ToDateTime();                                     // use default datetime culture configured at the application startup
"6/29/19 1:31:59 PM".ToDateTime(CultureInfo.GetCultureInfo("en"));      // use USA datetime format "M/d/yyyy h:mm tt"
"29/06/2019 13:31:59".ToDateTime(CultureInfo.GetCultureInfo("pt-BR"));  // use Brazil datetime format "dd/MM/yyyy HH:mm"

// string to guid
"a7fb69ba-7922-4d88-9569-d8d0d6641b86".ToGuid(); // output is a Guid 

// all to string
((object) null).ToStringSafe(); // output is a null string

// safe conversion support
"broken input".ToInt32Safe();                   // output is nullable int
"broken input".ToInt32Safe(-1);                 // output is -1
"broken input".ToDateTimeSafe();                // output is nullable DateTime
"broken input".ToDateTimeSafe(DateTime.Today);  // output is today DateTime

// exception throws - Broken inputs values throw exeption on unsafe mode
"broken input".ToInt32();
"broken input".ToDecimal();
"broken input".ToDateTime();
"broken input".ToGuid();
```

It's possible set default culture format for library, when not configured, default culture is CultureInfo.InvariantCulture:

```csharp
ReflectionExtensions.GlobalSettings.Configure(cfg => cfg
    .NumberCulture(CultureInfo.InvariantCulture)
    .DateTimeCulture(CultureInfo.GetCultureInfo("en")));
```

Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [Maestria.Reflection.Extensions](https://www.nuget.org/packages/Maestria.Reflection.Extensions/) from the package manager console:

```bash
PM> Install-Package Maestria.Reflection.Extensions
```

or install from the dotnet cli command line:

```bash
> dotnet add package Maestria.Reflection.Extensions
```

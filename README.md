# Maestria Reflection Extensions

[![Build status](https://ci.appveyor.com/api/projects/status/81ctraq8ry13ma18/branch/master?svg=true)](https://ci.appveyor.com/project/fabionaspolini/reflectionextensions/branch/master)
[![NuGet](https://buildstats.info/nuget/Maestria.Reflection.Extensions)](https://www.nuget.org/packages/Maestria.Reflection.Extensions)
[![MyGet](https://img.shields.io/myget/maestrianet/v/Maestria.Reflection.Extensions?label=MyGet)](https://www.myget.org/feed/maestrianet/package/nuget/Maestria.Reflection.Extensions)

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
// ReflectionExtensions
<type>.IsInheritedOrImplements(<parent-type>)
ReflectionExtensions.GetAssemblyByName(<name>)
ReflectionExtensions.Create<T>(<arguments[]>)
ReflectionExtensions.HasConstructor<T>(<arguments-types[]>)
ReflectionExtensions.PropertyExist(<object-instance>, <property-name>)
ReflectionExtensions.SetPropertyValue(<object-instance>, <property-name>, <value>)
<object> ReflectionExtensions.GetPropertyValue(<object-instance>, <property-name>)
<T> ReflectionExtensions.GetPropertyValue<T>(<object-instance>, <property-name>)
<object> ReflectionExtensions.GetTaskResult(<task-instance>)
<object> ReflectionExtensions.InvokeMethod(<object-instance>, <method-name>, <parameters>)
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

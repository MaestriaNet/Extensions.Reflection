# Maestria Reflection Extensions

[![Build status](https://ci.appveyor.com/api/projects/status/81ctraq8ry13ma18/branch/master?svg=true)](https://ci.appveyor.com/project/fabionaspolini/reflectionextensions/branch/master)
[![NuGet](https://buildstats.info/nuget/Maestria.Reflection.Extensions)](https://www.nuget.org/packages/Maestria.Reflection.Extensions)
[![MyGet](https://img.shields.io/myget/maestrianet/v/Maestria.Reflection.Extensions?label=MyGet)](https://www.myget.org/feed/maestrianet/package/nuget/Maestria.Reflection.Extensions)

[![Build History](https://buildstats.info/appveyor/chart/fabionaspolini/reflectionextensions?branch=master)](https://ci.appveyor.com/project/fabionaspolini/reflectionextensions/history?branch=master)

[![donate](https://www.paypalobjects.com/en_US/i/btn/btn_donate_LG.gif)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

## What is Reflection Extensions?

This package provider a fluent syntax to simple data conversions.
Extension functions package for simple data convert.

## What is Maestria Project?

This library is part of Maestria Project.

Maestria is a project to provide maximum productivity and elegance to your code.

## Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [Maestria.Reflection.Extensions](https://www.nuget.org/packages/Maestria.Reflection.Extensions/) from the package manager console:

```bash
PM> Install-Package Maestria.Reflection.Extensions
```

or install from the dotnet cli command line:

```bash
> dotnet add package Maestria.Reflection.Extensions
```

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

[![buy-me-a-coffee](resources/buy-me-a-coffee.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)
[![smile.png](resources/smile.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

If my contributions helped you, please help me buy a coffee :D

[![donate](https://www.paypalobjects.com/en_US/i/btn/btn_donate_LG.gif)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

# Maestria.Extensions.Reflection

[![NuGet Version](https://img.shields.io/nuget/v/Maestria.Extensions.Reflection)](https://www.nuget.org/packages/Maestria.Extensions.Reflection/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Maestria.Extensions.Reflection)](https://www.nuget.org/packages/Maestria.Extensions.Reflection/)
[![Apimundo](https://img.shields.io/badge/Maestria.Extensions.Reflection%20API-Apimundo-728199.svg)](https://apimundo.com/organizations/nuget-org/nuget-feeds/public/packages/Maestria.Extensions.Reflection/versions/latest?tab=types)

---

[![buy-me-a-coffee](https://raw.githubusercontent.com/MaestriaNet/Extensions/master/resources/buy-me-a-coffee.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)
[![smile.png](https://raw.githubusercontent.com/MaestriaNet/Extensions/master/resources/smile.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

If my contributions helped you, please help me buy a coffee :D

[![donate](https://raw.githubusercontent.com/MaestriaNet/Extensions/master/resources/btn_donate.gif)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

---

## What is Maestria.Extensions.Reflection?

This package provider a fluent syntax to simple data conversions.
Extension functions package for simple data convert.

## What is Maestria Project?

This library is part of Maestria Project.

Maestria is a project to provide maximum productivity and elegance to your code.

## Where can I get it?

First, [install NuGet](http://docs.nuget.org/docs/start-here/installing-nuget). Then, install [Maestria.Extensions.Reflection](https://www.nuget.org/packages/Maestria.Extensions.Reflection/) from the package manager console:

```bash
PM> Install-Package Maestria.Extensions.Reflection
```

or install from the dotnet cli command line:

```bash
> dotnet add package Maestria.Extensions.Reflection
```

## How do I get started?

First, import "Maestria.Extensions.Reflection" reference:

```csharp
using Maestria.Extensions.Reflection;
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

--

[![buy-me-a-coffee](https://raw.githubusercontent.com/MaestriaNet/Extensions.Reflection/master/resources/buy-me-a-coffee.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)
[![smile.png](https://raw.githubusercontent.com/MaestriaNet/Extensions.Reflection/master/resources/smile.png)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

If my contributions helped you, please help me buy a coffee :D

[![donate](https://raw.githubusercontent.com/MaestriaNet/Extensions.Reflection/master/resources/btn_donate.gif)](https://www.paypal.com/donate?hosted_button_id=8RSES6GAYH9BL)

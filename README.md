# Prime number extension

## Test
To test this extension it needs to execute the following code on terminal:

```bash
dotnet test
```

## How to use
First, you should add this nuget package registry in your nuget package source reference:

```bash
dotnet nuget add source https://nuget.pkg.github.com/welton-andrade/index.json --name github -u nome_do_usuario -p ${{ secrets.GITHUB_TOKEN }} --store-password-in-clear-text
```

Then, use the dotnet to add the package on your project:

```bash
 dotnet add package PrimeNumber 
```

## Example
```csharp
using System;
using PrimeNumber;

int value = 4;
bool result = value.isPrime();

if(result)
    Console.WriteLine("Is a prime number");
else
    Console.WriteLine("Isn't a prime number");
```
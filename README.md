# C# Utils
### This repository is a collection of C# code that I find helpful when working with C#.

[![Build status](https://ci.appveyor.com/api/projects/status/g66hrxktvovucdfu/branch/master?svg=true)](https://ci.appveyor.com/project/taysumi/csharputils/branch/master)

As for now, it only contains extension methods for a few types. For example:

```csharp
// value received from API or something
string myString = "My String";

// default approach:
bool myBool = string.IsNullOrWhiteSpace(myString);

// extension approach:
bool myBool = myString.IsNullOrWhiteSpace();
```

This makes it more readable and looks definitely fancier in cases like these:
```csharp
if(string.IsNullOrWhiteSpace(myString))
{
	// do stuff
}

if(myString.IsNullOrWhiteSpace())
{
	// do stuff
}
```

I am trying to add more as I find something and the time for it
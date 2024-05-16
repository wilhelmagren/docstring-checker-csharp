# docstring-checker-csharp
Check that all docstrings in a project have been updated to match latest changes, written in Microsoft Java (C#). 

# Setup

You need .NET 8. Install it with this stuff (ON UBUNTU 23.10):
```
sudo apt update && sudo apt install -y dotnet-sdk-8.0 aspnetcore-runtime-8.0
```

SInce this is Microsoft trash ecosystem and software it doesn't match well on Linux
system. You need another compiler to actually compile and rune stuff, install
```
sudo apt install mono-complete
```

this will give you the mono-c# compiler (mcs) and also being able to run shitty windows
.exe files. If you have a C# file called `BadProgram.cs`, do this to run it on Linux:
```
mcs -out:BadProgram.exe BadProgram.cs
mono BadProgram.exe
...
```

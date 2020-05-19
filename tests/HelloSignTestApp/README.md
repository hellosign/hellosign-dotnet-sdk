# HelloSign Test App

This directory contains a simple C# program that demonstrates/tests using the HelloSign C#.NET SDK.

The program's source is entirely contained within `Program.cs`, which runs performs a series of API calls and prints response information to the console.

## Build

Use Visual Studio (Express), or use `dotnet build` (see the README.md at the root of this repository for instructions).

## Usage

Usage from the command line is as follows:

```bash
bin/Debug/HelloSignTestApp.exe
```

Or, for .NET Core (required for non-Windows hosts):

```bash
dotnet tests/HelloSignTestApp/bin/Debug/netcoreapp2.0/HelloSignTestApp.dll
```

The **environment** argument specifies which HelloSign environment to connect to, and can be one of: `prod` `staging` `qa` `dev` (defaults to staging)

You **must** set the API host/domain via the `APIHOST` environment variable and your account's API key via the `APIKEY` environment variable. You could inline your invokation like so:

```bash
APIHOST=api.hellosign.com \
APIKEY=abcdef1234567890 \
dotnet tests/HelloSignTestApp/bin/Debug/netcoreapp2.0/HelloSignTestApp.dll
```


# HelloSign Test App

This directory contains a simple C# program that demonstrates/tests using the HelloSign C#.NET SDK.

The program's source is entirely contained within `Program.cs`, which runs performs a series of API calls and prints response information to the console.

## Build

Use Visual Studio (Express), or run 'xbuild' (the binary will be generated at `bin/Debug/HelloSignTestApp.exe`).

## Usage

Usage from the command line is as follows:

```bash
bin/Debug/HelloSignTestApp.exe [environment]
```

The **environment** argument specifies which HelloSign environment to connect to, and can be one of: `prod` `staging` `qa` `dev` (defaults to staging)

You **must** set your account's API key via the `APIKEY` environment variable. You could inline your invokation like so:

```bash
APIKEY=abcdef1234567890 bin/Debug/HelloSignTestApp.exe prod
```


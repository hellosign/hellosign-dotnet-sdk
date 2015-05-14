# HelloSign .NET SDK

**Not ready for release**

An official library for using the HelloSign API written in C#.NET and powered by RestSharp.

## Usage

First, use our namespace:

```C#
using HelloSign;
```

Create a client object:

```C#
// Create a client object
var client = new Client("your account API key here");
```

### Account Methods

```C#
// Get your Account details
var account = client.GetAccount();
Console.WriteLine("My Account ID is: " + account.AccountId);

// Update your Account Callback URL
account = client.UpdateAccount("https://example.com/hellosign.asp");
Console.WriteLine("Now my Callback URL is: " + account.CallbackUrl);

// Create a new Account (throws exception if account already exists)
var newAccount = client.CreateAccount("new.account@example.com");
Console.WriteLine("The new Account's ID is: " + newAccount.AccountId);
```

### Signature Request Methods

```C#
// Send signature request
var request = new SignatureRequest();
request.Title = "NDA with Acme Co.";
request.Subject = "The NDA we talked about";
request.Message = "Please sign this NDA and then we can discuss more. Let me know if you have any questions.";
request.AddSigner("jack@example.com", "Jack");
request.AddSigner("jill@example.com", "Jill");
request.AddCc("lawyer@example.com");
request.AddFile("c:\users\me\My Documents\nda.txt");
request.AddFile("c:\users\me\My Documents\AppendixA.txt");
request.Metadata.Add("custom_id", "1234");
request.Metadata.Add("custom_text", "NDA #9");
request.TestMode = true;
var response = client.SendSignatureRequest(request);
Console.WriteLine("New Signature Request ID: " + response.SignatureRequestId);

// Cancel that signature request
client.CancelSignatureRequest(response.SignatureRequestId);

// Send signature request using a template
var tRequest = new TemplateSignatureRequest();
tRequest.TemplateId = "TEMPLATE ID GOES HERE";
tRequest.Subject = "Purchase Order";
tRequest.Message = "Glad we could come to an agreement.";
tRequest.AddSigner("Client", "george@example.com", "George");
tRequest.AddCc("Accounting", "accounting@hellosign.com");
tRequest.CustomFields.Add("Cost", "$20,000");
tRequest.TestMode = true;
var tResponse = client.SendSignatureRequest(request);
Console.WriteLine("New Template Signature Request ID: " + tResponse.SignatureRequestId);
```

## Build from Source

### Windows

Use Visual Studio (Express).

### Linux (and OSX?) using Mono

1. Install Mono
2. Install NuGet
3. `cd HelloSign`
4. `nuget install`
5. `mkdir ../packages`
6. `mv RestSharp* ../packages`
7. `cd ..`
8. `xbuild`

## License

```
The MIT License (MIT)

Copyright (C) 2014 hellosign.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

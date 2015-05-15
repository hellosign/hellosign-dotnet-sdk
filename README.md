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

#### Send Signature Request using files (non-Embedded)

```C#
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
```

#### Send Signature Request using a template (non-Embedded)

```C#
var request = new TemplateSignatureRequest();
request.TemplateId = "TEMPLATE ID HERE";
request.Subject = "Purchase Order";
request.Message = "Glad we could come to an agreement.";
request.AddSigner("Client", "george@example.com", "George");
request.AddCc("Accounting", "accounting@hellosign.com");
request.CustomFields.Add("Cost", "$20,000");
request.TestMode = true;
var response = client.SendSignatureRequest(request);
Console.WriteLine("New Template Signature Request ID: " + response.SignatureRequestId);
```

#### Create Embedded Signature Request using files

```C#
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
var response = client.CreateEmbeddedSignatureRequest(request, "CLIENT ID HERE");
Console.WriteLine("New Embedded Signature Request ID: " + response.SignatureRequestId);
```

#### Create Embedded Signature Request using a template

```C#
var request = new TemplateSignatureRequest();
request.TemplateId = "TEMPLATE ID HERE";
request.Subject = "Purchase Order";
request.Message = "Glad we could come to an agreement.";
request.AddSigner("Client", "george@example.com", "George");
request.AddCc("Accounting", "accounting@hellosign.com");
request.CustomFields.Add("Cost", "$20,000");
request.TestMode = true;
var response = client.CreateEmbeddedSignatureRequest(request, "CLIENT ID HERE");
Console.WriteLine("New Template-based Embedded Signature Request ID: " + response.SignatureRequestId);
```

#### Cancel a Signature Request

```C#
client.CancelSignatureRequest("SIGNATURE REQUEST ID HERE");
```

#### Remind a Signer to Sign

```C#
client.RemindSignatureRequest("SIGNATURE REQUEST ID HERE", "EMAIL ADDRESS HERE");
```

#### Download a Signature Request (in its current state) and save to disk

```C#
// Download a merged PDF
client.DownloadSignatureRequestFiles("SIGNATURE REQUEST ID HERE", "/path/to/output.pdf");
// Or download a ZIP containing individual unmerged PDFs
client.DownloadSignatureRequestFiles("SIGNATURE REQUEST ID HERE", "/path/to/output.pdf", SignatureRequest.FileType.ZIP);
```

#### Download a Signature Request (in its current state) as bytes

```C#
// Download a merged PDF
client.DownloadSignatureRequestFiles("SIGNATURE REQUEST ID HERE");
// Or download a ZIP containing individual unmerged PDFs
client.DownloadSignatureRequestFiles("SIGNATURE REQUEST ID HERE", SignatureRequest.FileType.ZIP);
```

### Embedded Methods

#### Retrieve Embedded Signing URL for a particular signer

```C#
response = client.GetSignUrl("SIGNATURE ID HERE");
Console.WriteLine("Signature URL for HelloSign.open(): " + response.SignUrl);
```

#### Retrieve Embedded Templates Editing URL

```C#
response = client.GetEditUrl("EMBEDDED TEMPLATE ID HERE");
Console.WriteLine("Editing URL for HelloSign.open(): " + response.EditUrl);
```

### Unclaimed Draft Methods (for Embedded Requesting)

Not implemented

### Template Methods

Not implemented

### Team Methods

Not Implemented

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

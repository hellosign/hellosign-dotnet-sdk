# HelloSign .NET SDK 

[![Build status](https://ci.appveyor.com/api/projects/status/90m1ygpgg50qt30v/branch/v3?svg=true)](https://ci.appveyor.com/project/HelloSign/hellosign-dotnet-sdk/branch/v3)

An official library for using the HelloSign API written in C#.NET and powered by RestSharp.

**This SDK is currently in beta. If you need help:**

* **Use the [Issue Tracker](https://github.com/hellosign/hellosign-dotnet-sdk/issues) to report bugs or missing functionality in this library.**
* **Send an email to apisupport@hellosign.com to request help with our API or your account.**

## Installation

The HelloSign .NET SDK can be installed using the NuGet package manager, under the package name **HelloSign** ([package details](https://www.nuget.org/packages/HelloSign/)).

If you prefer not to use NuGet, you can download a ZIP archive containing the built .dll files from the [Releases](https://github.com/hellosign/hellosign-dotnet-sdk/releases) page, or clone this repository and build the project yourself (see "Build from Source" below).

## Usage

First, use our namespace:

```C#
using HelloSign;
```

Create a client object:

```C#
var client = new Client("ACCOUNT API KEY HERE"); // Preferred
// Or...
var client = new Client("EMAIL ADDRESS HERE", "PASSWORD HERE"); // Not preferred
```

### Error Handling

Most methods will throw a relevant exception if something goes wrong.
This includes when our server returns an error message documented [here](https://www.hellosign.com/api/reference#ErrorNames).

You should always be prepared to catch these exceptions and handle them appropriately.
Refer to HelloSign/Exceptions.cs in this repository for information about the custom exception classes this library defines.

#### Warnings

Some API responses include one or more warnings if there was a non-fatal problem with your request.
At any time, you may inspect the contents of `client.Warnings` (a List of HelloSign.Warning objects) and output them as you see fit.

### Callback Event Parsing

If you're implementing a server that will receive callbacks from HelloSign, this library can parse the received JSON
into a native object and perform the hash-based integrity check for you.

```C#
String eventJson = ...; // Get this string from the 'json' POST parameter in the HTTP request
Event myEvent = client.ParseEvent(eventJson);

// The Event object contains accessors for all related data.
Console.WriteLine("Received event with type: " + event.EventType);
SignatureRequest request = myEvent.SignatureRequest;
```

### Account Methods

#### Get your Account details

```C#
var account = client.GetAccount();
Console.WriteLine("My Account ID is: " + account.AccountId);
```

#### Update your Account Callback URL

```C#
var account = client.UpdateAccount("https://example.com/hellosign.asp");
Console.WriteLine("Now my Callback URL is: " + account.CallbackUrl);
```

#### Create a new Account

```C#
// Throws exception if account already exists
var account = client.CreateAccount("new.account@example.com");
Console.WriteLine("The new Account's ID is: " + account.AccountId);
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

**Note:** You can optionally pass an API App client ID as a second parameter to SendSignatureRequest.

#### Send Signature Request using files and form fields (non-Embedded)

```C#
var request = new SignatureRequest();
request.Title = "NDA with Acme Co.";
request.Subject = "The NDA we talked about";
request.Message = "Please sign this NDA and then we can discuss more. Let me know if you have any questions.";
request.AddSigner("jack@example.com", "Jack");
request.AddFile("c:\users\me\My Documents\nda.pdf").WithFields(
    //            id      type                     page    x    y    w   h   req signer
    new FormField("chk1", FormField.TypeCheckbox,     1, 140,  72,  36, 36, true,     0),
    new FormField("txt1", FormField.TypeText,         1, 140, 144, 225, 20, true,     0),
    new FormField("dat1", FormField.TypeDateSigned,   1, 140, 216, 225, 52, true,     0),
    new FormField("sig1", FormField.TypeSignature,    1, 140, 288, 225, 52, true,     0),
);
request.TestMode = true;
var response = client.SendSignatureRequest(request);
Console.WriteLine("New Signature Request ID: " + response.SignatureRequestId);
```

#### Send Signature Request using a template (non-Embedded)

```C#
var request = new TemplateSignatureRequest();
request.AddTemplate("TEMPLATE ID HERE");
request.Subject = "Purchase Order";
request.Message = "Glad we could come to an agreement.";
request.AddSigner("Client", "george@example.com", "George");
request.AddCc("Accounting", "accounting@hellosign.com");
request.CustomFields.Add("Cost", "$20,000");
request.TestMode = true;
var response = client.SendSignatureRequest(request);
Console.WriteLine("New Template Signature Request ID: " + response.SignatureRequestId);
```

**Note:** You can optionally pass an API App client ID as a second parameter to SendSignatureRequest.

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
request.AddTemplate("TEMPLATE ID HERE");
request.Subject = "Purchase Order";
request.Message = "Glad we could come to an agreement.";
request.AddSigner("Client", "george@example.com", "George");
request.AddCc("Accounting", "accounting@hellosign.com");
request.AddCustomField("Cost", "$20,000");
request.TestMode = true;
var response = client.CreateEmbeddedSignatureRequest(request, "CLIENT ID HERE");
Console.WriteLine("New Template-based Embedded Signature Request ID: " + response.SignatureRequestId);
```

#### Get info about an existing Signature Request

```C#
var request = client.GetSignatureRequest("SIGNATURE REQUEST ID HERE");
Console.WriteLine("Signature Request title: " + request.Title);
```

#### Cancel a Signature Request

```C#
client.CancelSignatureRequest("SIGNATURE REQUEST ID HERE");
```

#### Remind a Signer to Sign

```C#
client.RemindSignatureRequest("SIGNATURE REQUEST ID HERE", "EMAIL ADDRESS HERE");
```

#### Update a Signature Request

```C#
client.UpdateSignatureRequest("SIGNATURE REQUEST ID HERE", "SIGNATURE ID HERE", "NEW EMAIL ADDRESS HERE");
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
var bytes = client.DownloadSignatureRequestFiles("SIGNATURE REQUEST ID HERE");
// Or download a ZIP containing individual unmerged PDFs
var bytes = client.DownloadSignatureRequestFiles("SIGNATURE REQUEST ID HERE", SignatureRequest.FileType.ZIP);
```

#### Get a temporary URL to download a Signature Request

```C#
var url = client.GetSignatureRequestDownloadUrl("SIGNATURE REQUEST ID HERE");
Console.WriteLine("The download URL is: " + url.FileUrl);
Console.WriteLine("The URL expires at: " + url.ExpiresAt);
```

### Embedded Methods

#### Retrieve Embedded Signing URL for a particular signer

```C#
var response = client.GetSignUrl("SIGNATURE ID HERE");
Console.WriteLine("Signature URL for HelloSign.open(): " + response.SignUrl);
```

#### Retrieve Embedded Templates Editing URL

```C#
var response = client.GetEditUrl("EMBEDDED TEMPLATE ID HERE");
Console.WriteLine("Editing URL for HelloSign.open(): " + response.EditUrl);
```

### Unclaimed Draft Methods (for Embedded Requesting)

Not implemented

### Template Methods

#### Get Template details

```C#
var template = client.GetTemplate("TEMPLATE ID HERE");
```

#### Add an Account to a Template

```C#
var template = client.AddAccountToTemplate("TEMPLATE ID HERE", "ACCOUNT ID HERE");
// Or...
var template = client.AddAccountToTemplate("TEMPLATE ID HERE", null, "EMAIL ADDRESS HERE");
```

#### Remove an Account from a Template

```C#
var template = client.RemoveAccountFromTemplate("TEMPLATE ID HERE", "ACCOUNT ID HERE");
// Or...
var template = client.RemoveAccountFromTemplate("TEMPLATE ID HERE", null, "EMAIL ADDRESS HERE");
```

#### Download a Template as a PDF and save to disk

```C#
client.DownloadTemplateFiles("TEMPLATE ID HERE", "/path/to/output.pdf");
```

#### Download a Template as a PDF, as bytes

```C#
var bytes = client.DownloadTemplateFiles("TEMPLATE ID HERE");
```

#### Get a temporary URL to download a Template's files

```C#
var url = client.GetTemplateFilesDownloadUrl("TEMPLATE ID HERE");
Console.WriteLine("The download URL is: " + url.FileUrl);
Console.WriteLine("The URL expires at: " + url.ExpiresAt);
```

#### Delete a Template

```C#
client.DeleteTemplate("TEMPLATE ID HERE");
```

## Create a new Embedded Template Draft

```C#
var draft = new EmbeddedTemplateDraft();
draft.TestMode = true;
draft.AddFile(file1, "NDA.txt");
draft.Title = "Test Template";
draft.Subject = "Please sign this document";
draft.Message = "For your approval.";
draft.AddSignerRole("Client", 0);
draft.AddSignerRole("Witness", 1);
draft.AddCcRole("Manager");
draft.AddMergeField("Full Name", MergeField.FieldType.Text);
draft.AddMergeField("Is Registered?", MergeField.FieldType.Checkbox);
var response = client.CreateEmbeddedTemplateDraft(draft, "CLIENT ID HERE");
```

### Team Methods

#### Get your Team details

```C#
var team = client.GetTeam();
```

#### Create a new Team

```C#
var team = client.CreateTeam("NAME HERE");
```

#### Update your Team name

```C#
var team = client.UpdateTeamName("NAME HERE");
```

#### Delete your Team

```C#
var team = client.DeleteTeam();
```

#### Add a member to your Team

```C#
var team = AddMemberToTeam("ACCOUNT ID HERE");
// Or...
var team = AddMemberToTeam(null, "EMAIL ADDRESS HERE");
```

#### Remove a member from your Team

```C#
var team = RemoveMemberFromTeam("ACCOUNT ID HERE");
// Or...
var team = RemoveMemberFromTeam(null, "EMAIL ADDRESS HERE");
```

## Build from Source

### Windows

Use Visual Studio (Express).

### Linux (and OSX?) using Mono

1. Install Mono
2. Install NuGet
3. `mkdir packages`
4. `cd HelloSign`
5. `nuget install -o ../packages`
6. `cd ..`
7. `xbuild` (or `xbuild /p:Configuration=Release` for a non-Debug build)

### Packaging for NuGet

1. `cd HelloSign`
2. `nuget pack HelloSign.csproj -Prop Configuration=Release`

## License

```
The MIT License (MIT)

Copyright (C) 2015 hellosign.com

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

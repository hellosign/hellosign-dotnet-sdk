using System;
using System.Collections.Generic;
using RestSharp;

namespace HelloSign
{
    /// <summary>
    /// A file-based (not template-based) HelloSign Signature Request.
    /// </summary>
    public class SignatureRequest : BaseSignatureRequest
    {
        public enum FileType
        {
            ZIP,
            PDF
        }

        public List<string> Ccs { get; private set; }
        public List<FileContainer> Files { get; private set; }
        public List<string> FileUrls { get; private set; }
        public bool UseTextTags { get; set; }
        public bool UsePreexistingFields { get; set; }
        public bool HideTextTags { get; set; }
        // TODO: public List<FormField> FormFieldsPerDocument { get; private set; }
        
        public SignatureRequest() : base()
        {
            Ccs = new List<string>();
            Files = new List<FileContainer>();
            FileUrls = new List<string>();
        }

        /// <summary>
        /// Add a CC email address to the request.
        /// </summary>
        /// <param name="emailAddress"></param>
        public void AddCc(string emailAddress)
        {
            Ccs.Add(emailAddress);
        }

        /// <summary>
        /// Add a file to the signature request by giving its local path.
        /// </summary>
        /// <param name="path">Full path to file to upload.</param>
        /// <param name="contentType">The MIME type of the file to upload.</param>
        public void AddFile(string path, string contentType = null)
        {
            if (FileUrls.Count > 0)
            {
                throw new NotSupportedException("Cannot add local and remote files in the same request");
            }

            var file = new FileContainer();
            file.Path = path;
            file.ContentType = contentType;
            Files.Add(file);
        }

        /// <summary>
        /// Add a file to the signature request by providing a byte array.
        /// </summary>
        /// <param name="bytes">The file data as an array of bytes.</param>
        /// <param name="filename">Filename this file should appear to the server as.</param>
        /// <param name="contentType">The MIME type of the file to upload.</param>
        public void AddFile(byte[] bytes, string filename, string contentType = null)
        {
            if (FileUrls.Count > 0)
            {
                throw new NotSupportedException("Cannot add local and remote files in the same request");
            }

            var file = new FileContainer();
            file.Bytes = bytes;
            file.Filename = filename;
            file.ContentType = contentType;
            Files.Add(file);
        }

        /// <summary>
        /// Add a file to the signature request by providing a Stream.
        /// </summary>
        /// <param name="writer">Input stream delegate that will provide the file data.</param>
        /// <param name="filename">Filename this file should appear to the server as.</param>
        /// <param name="contentType">The MIME type of the file to upload.</param>
        public void AddFile(Action<System.IO.Stream> writer, string filename, string contentType = null)
        {
            if (FileUrls.Count > 0)
            {
                throw new NotSupportedException("Cannot add local and remote files in the same request");
            }

            var file = new FileContainer();
            file.Writer = writer;
            file.Filename = filename;
            file.ContentType = contentType;
            Files.Add(file);
        }
        
        /// <summary>
        /// Add a file to the signature request by giving its remote address.
        /// </summary>
        public void AddFile(Uri uri)
        {
            if (Files.Count > 0)
            {
                throw new NotSupportedException("Cannot add local and remote files in the same request");
            }
            if ((uri.Scheme != "http") && (uri.Scheme != "https"))
            {
                throw new ArgumentException("Only HTTP or HTTPS URIs are allowed");
            }
            
            FileUrls.Add(uri.AbsoluteUri);
        }
    }

    /// <summary>
    /// Wrapper class for storing information about files to be sent.
    /// </summary>
    public class FileContainer
    {
        public string ContentType { get; set; }
        public string Filename { get; set; }
        public string Path { get; set; }
        public Action<System.IO.Stream> Writer { get; set; }
        public byte[] Bytes { get; set; }

        /// <summary>
        /// Add this file to the specified RestRequest under the specified name.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public RestRequest AddToRequest(RestRequest request, string name)
        {
            if (Path != null)
            {
                request.AddFile(name, Path, ContentType);
            }
            else if (Writer != null)
            {
                request.AddFile(name, Writer, Filename, ContentType);
            }
            else if (Bytes != null)
            {
                request.AddFile(name, Bytes, Filename, ContentType);
            }
            else
            {
                throw new NotSupportedException("One of Path, Writer, or Bytes must not be null");
            }

            return request;
        }
    }
    
    public class FormField
    {
        public enum FormFieldType
        {
            Text,
            Checkbox,
            DateSigned,
            Initials,
            Signature
        }
        
        public string ApiId { get; set; }
        public string Name { get; set; }
        public FormFieldType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Required { get; set; }
        public int Signer { get; set; }
        public int File { get; set; }
        public int Page { get; set; }
    }
}

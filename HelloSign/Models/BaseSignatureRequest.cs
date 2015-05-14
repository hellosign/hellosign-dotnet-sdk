using System;
using System.Collections.Generic;
using RestSharp;

namespace HelloSign
{
    /// <summary>
    /// Base class for Template-based and File-based Signature Request classes.
    /// </summary>
    public class BaseSignatureRequest
    {
        public string SignatureRequestId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool TestMode { get; set; }
        public Dictionary<String, String> Metadata { get; set; }
        public bool IsComplete { get; set; }
        public bool HasError { get; set; }
        //public List<???> CustomFields { get; set; }
        //public List<SignatureResponseData> ResponseData { get; set; }
        public string SigningUrl { get; set; }
        public string SigningRedirectUrl { get; set; }
        public string DetailsUrl { get; set; }
        public string RequesterEmailAddress { get; set; }
        //public List<Signature> Signatures { get; set; }
        public List<string> CcEmailAddresses { get; set; }

        public List<Signer> Signers = new List<Signer>();
        public List<string> Ccs = new List<string>();
        public List<FileContainer> Files = new List<FileContainer>();
        public List<string> FileUrls = new List<string>();

        public BaseSignatureRequest()
        {
            Metadata = new Dictionary<String, String>();
            CcEmailAddresses = new List<string>();
        }

        /// <summary>
        /// Convenience method for creating and adding a Signer.
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="name"></param>
        /// <param name="order"></param>
        /// <param name="pin"></param>
        public void AddSigner(string emailAddress, string name, int? order = null, string pin = null)
        {
            Signers.Add(new Signer(emailAddress, name, order, pin));
        }

        /// <summary>
        /// Convenience method for adding a CC email address.
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
            if (FileUrls.Count > 0) {
                throw new NotSupportedException("Cannot use AddFile and AddFileUrl in the same request");
            }

            var file = new FileContainer();
            file.Path = path;
            file.ContentType = contentType;
            Files.Add(file);
        }
    }

    public class FileContainer
    {
        public string ContentType { get; set; }
        public string Filename { get; set; }
        public string Path { get; set; }
        public Action<System.IO.Stream> Writer { get; set; }
        public byte[] Bytes { get; set; }

        public RestRequest AddToRequest(RestRequest request, string name)
        {
            if (Path != null) {
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
}

using System;
using System.Collections.Generic;
using RestSharp;

namespace HelloSign
{
    public class SignatureRequest : BaseSignatureRequest
    {
        public List<string> Ccs = new List<string>();
        public List<FileContainer> Files = new List<FileContainer>();
        public List<string> FileUrls = new List<string>();

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
            if (FileUrls.Count > 0)
            {
                throw new NotSupportedException("Cannot use AddFile and AddFileUrl in the same request");
            }

            var file = new FileContainer();
            file.Path = path;
            file.ContentType = contentType;
            Files.Add(file);
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
}

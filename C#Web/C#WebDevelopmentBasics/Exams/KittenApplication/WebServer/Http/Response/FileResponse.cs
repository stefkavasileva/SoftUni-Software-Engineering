namespace WebServer.Http.Response
{
    using Enums;
    using Exceptions;

    public class FileResponse : HttpResponse
    {
        public FileResponse(HttpStatusCode statusCode, byte[] fileData, string mimeType)
        {
            this.FileData = fileData;
            this.StatusCode = statusCode;

            this.Headers.Add(HttpHeader.ContentLength, this.FileData.Length.ToString());
            this.Headers.Add(HttpHeader.ContentDisposition, "attachment");
            this.Headers.Add(HttpHeader.ContentType, mimeType);
        }

        public byte[] FileData { get; private set; }

        private static void EnsureValidStatusCode(HttpStatusCode statusCode)
        {
            int statusCodeNumber = (int)statusCode;
            bool isValidResponseCode = statusCodeNumber >= 200 && statusCodeNumber < 300;
            if (!isValidResponseCode)
            {
                throw new InvalidResponseException("File responses need a OK-type status code.");
            }
        }
    }
}

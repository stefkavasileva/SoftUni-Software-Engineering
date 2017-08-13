namespace _01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable file;
    
        public StreamProgressInfo(IStreamable file)
        {
            this.file = file;
        }

        public int CalculateCurrentPercent()
        {
            return file.BytesSent * 100 / file.Length;
        }
    }
}
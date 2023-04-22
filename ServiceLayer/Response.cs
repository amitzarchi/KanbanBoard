    internal class Response: IResponse
    {
        public string Value { get; set; }
        public string Error { get; set; }
        public Response(string value, string error)
        {
            this.Error = error;
            this.Value = value;
        }
    }


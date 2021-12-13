using System;
namespace BookCatalogs.Dtos
{
    public class GeneralResult
    {
        public bool isSucces { get; set; }

        public Object payload { get; set; }

        public Error error { get; set; }
    }

    public class Error
    {
        public int code { get; set; }
        public string message { get; set; }
    }
}

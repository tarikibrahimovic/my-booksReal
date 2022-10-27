﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace my_booksReal.Data.ViewModel
{
    public class ErrorVM
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

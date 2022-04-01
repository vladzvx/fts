using System;
using System.Collections.Generic;
using System.Text;

namespace FTS.CoreLib.Models
{
    public class SearchRequest
    {
        public string Word { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int Limit { get; set; } = 100;
    }
}

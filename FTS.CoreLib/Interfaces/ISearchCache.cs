using FTS.CoreLib.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTS.CoreLib.Interfaces
{
    public interface ISearchCache
    {
        public void Add(string text, Guid textId, DateTime? timestamp = null);
        //public IEnumerable<SearchResult> Search(SearchRequest searchRequest);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FTS.CoreLib.Models
{
    public class PreparatedWord
    {
        public readonly string Word;
        public readonly TextToken.Stored Token;

        public PreparatedWord(string word, TextToken.Stored token)
        {
            this.Word = word;
            this.Token = token;
        }
    }
}

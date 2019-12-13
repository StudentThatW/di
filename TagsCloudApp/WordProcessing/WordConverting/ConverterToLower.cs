﻿using System.Collections.Generic;
using System.Linq;

namespace TagsCloudApp.WordConverting
{
    public class ToLowerWordConverter : IWordConverter
    {
        public IEnumerable<string> ConvertWords(IEnumerable<string> words)
        {
            return words.Select(w => w.ToLower());
        }
    }
}
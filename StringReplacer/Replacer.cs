using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace StringReplacer
{
    public class Replacer
    {
        Option option;

        public Replacer(IOptions<Option> option)
        {
            this.option = option.Value;
        }

        public void Start()
        {
            var files = Directory.GetFiles(option.Directory, "*.html", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Replace(file);
            }
        }

        void Replace(string path)
        {
            Console.WriteLine($"[変換] {path}");

            string text = File.ReadAllText(path);

            foreach (var str in option.Str)
            {
                text = text.Replace(str.Before, str.After);
            }

            File.WriteAllText(path, text);

        }
    }
}

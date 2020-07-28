using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownApp
{
    public interface IDictionary
    {
        List<string> Load(string filePath);
        string MatchWord(List<string> letters);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Interfaces
{
    public interface IDataManager
    {
        void getFile(string[] args);
        int wordCount(string filePath);
    }
}

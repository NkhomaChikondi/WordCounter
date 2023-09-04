using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Interfaces;
using WordCounter.Services;

namespace WordCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            // register dependencies
            var serviceProvider = new ServiceCollection().AddSingleton<IDataManager, DataManagerService>().BuildServiceProvider();

            // Resolve dependencies
            var wordCountService = serviceProvider.GetRequiredService<IDataManager>();
            // get file and count their words
            wordCountService.getFile(args);
        }
    }
}

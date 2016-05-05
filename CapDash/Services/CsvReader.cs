using CapDash.Models;
using System.IO;
using System.Linq;

namespace CapDash.Services
{
    public class CsvReader : IGetTheResults
    {
        public ResultsModel GetResults(string path)
        {
            var csv = new CsvHelper.CsvReader(File.OpenText(path));
            csv.Configuration.IgnoreHeaderWhiteSpace = true;
            csv.Configuration.IsHeaderCaseSensitive = false;
            return csv.GetRecords<ResultsModel>().First();
        }
    }
}
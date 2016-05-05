using CapDash.Models;

namespace CapDash.Services
{
    public interface IGetTheResults
    {
        ResultsModel GetResults(string path);
    }
}

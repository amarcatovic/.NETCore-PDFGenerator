using System.Threading.Tasks;

namespace PDFGenerator.Services
{
    public interface IPDFService
    {
        Task<byte[]> CreatePDFAsync(string name);
    }
}
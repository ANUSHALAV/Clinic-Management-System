using Clinic_Management_System.Models.Masters;

namespace Clinic_Management_System.Services.Interfaces
{
    public interface IMasterService
    {
        public Task<List<CountryMaster>> GetCountryAsync();
    }
}

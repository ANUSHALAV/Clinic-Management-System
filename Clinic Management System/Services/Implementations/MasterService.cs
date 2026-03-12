using Clinic_Management_System.Configurations;
using Clinic_Management_System.Models.Masters;
using Clinic_Management_System.Services.Interfaces;

namespace Clinic_Management_System.Services.Implementations
{
    public class MasterService : IMasterService
    {
        private readonly DBSettings _dbSetting;

        public MasterService(DBSettings dBSettings) {
            this._dbSetting = dBSettings;
        }

        public async Task<List<CountryMaster>> GetCountryAsync()
        {
            var countryList = new List<CountryMaster>
            {

            };
            return countryList;
        }
    }
}

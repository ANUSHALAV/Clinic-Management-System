using Clinic_Management_System.Configurations;
using Clinic_Management_System.Models.Masters;
using Clinic_Management_System.Services.Interfaces;
using MongoDB.Driver;

namespace Clinic_Management_System.Services.Implementations
{
    public class MasterService : IMasterService
    {
        private readonly DBSettings _dbSetting;
        private readonly MongoClient _mongoClient;
        private readonly IMongoDatabase _database;  

        public MasterService(DBSettings dbSettings) {
            this._dbSetting = dbSettings;
            this._mongoClient = new MongoClient(_dbSetting.ConnectionString);
            this._database = _mongoClient.GetDatabase(_dbSetting.DatabaseName);

        }

        public async Task<List<CountryMaster>> GetCountryAsync()
        {
            var countryCollection = _database.GetCollection<CountryMaster>("CountryMaster");

            var countryList = await countryCollection.Find(c => c.Status == 1).ToListAsync();

            return countryList;
        }

        public async Task<List<StateMaster>> GetStateByCountryIdAsync(string countryId)
        {
            var stateCollection = _database.GetCollection<StateMaster>("StateMaster");

            var stateList = await stateCollection.Find(s => s.CountryId == countryId && s.Status == 1).ToListAsync();

            return stateList;
        }
    }
}

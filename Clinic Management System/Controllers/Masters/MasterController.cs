using Clinic_Management_System.Models.Responses;
using Clinic_Management_System.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Clinic_Management_System.Controllers.Masters
{
    [Route("api/[controller]")]
    public class MasterController : ControllerBase
    {
        private readonly IMasterService _masterService;
        public MasterController(IMasterService masterService)
        {
            this._masterService = masterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCountryAsync()
        {
            var res = new APIResponse();
            try
            {
                var country = await this._masterService.GetCountryAsync();
                if (country != null)
                {
                    res.Success = true;
                    res.Data = country;
                    res.Message = "Country data retrieved successfully.";
                }
                else
                {
                    res.Success = false;
                    res.Message = "No country data found.";
                }
            }
            catch (Exception ex)
            {
                res.Success = false;
                res.Message = $"An error occurred while retrieving country data: {ex.Message}";
            }
            return Ok(res);
        }
    }
}

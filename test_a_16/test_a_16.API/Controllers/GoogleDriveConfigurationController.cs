namespace test_a_16.API
{
    using System;
    using System.Linq;
    using test_a_16.DataAccess;
    using test_a_16.DTO;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class GoogleDriveConfigurationController : ControllerBase
    {
        private readonly GoogleDriveConfigurationService _googleDriveConfigurationService;

        public GoogleDriveConfigurationController(GoogleDriveConfigurationService googleDriveConfigurationService)
        {
            _googleDriveConfigurationService = googleDriveConfigurationService;
        }

        [HttpPost]
        public IActionResult CreateGoogleDriveConfiguration(GoogleDriveConfiguration googleDriveConfiguration)
        {
            _googleDriveConfigurationService.CreateGoogleDriveConfiguration(googleDriveConfiguration);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetGoogleDriveConfiguration(int id)
        {
            return Ok(_googleDriveConfigurationService.GetGoogleDriveConfiguration(id));
        }

        [HttpGet]
        public IActionResult GetAllGoogleDriveConfigurations()
        {
            return Ok(_googleDriveConfigurationService.GetAllGoogleDriveConfigurations());
        }

        [HttpPut]
        public IActionResult UpdateGoogleDriveConfiguration(GoogleDriveConfiguration googleDriveConfiguration)
        {
            _googleDriveConfigurationService.UpdateGoogleDriveConfiguration(googleDriveConfiguration);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGoogleDriveConfiguration(int id)
        {
            _googleDriveConfigurationService.DeleteGoogleDriveConfiguration(id);

            return Ok();
        }
    }
}
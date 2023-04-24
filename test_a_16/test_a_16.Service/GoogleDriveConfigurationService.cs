namespace test_a_16
{
    using System;
    using System.Linq;
    using test_a_16.DataAccess;
    using test_a_16.DTO;

    public class GoogleDriveConfigurationService
    {
        private readonly GoogleDriveConfigurationRepository _repository;

        public GoogleDriveConfigurationService(GoogleDriveConfigurationRepository repository)
        {
            _repository = repository;
        }

        public void CreateGoogleDriveConfiguration(GoogleDriveConfiguration googleDriveConfiguration)
        {
            _repository.CreateGoogleDriveConfiguration(googleDriveConfiguration);
        }

        public GoogleDriveConfiguration GetGoogleDriveConfiguration(int id)
        {
            return _repository.GetGoogleDriveConfiguration(id);
        }

        public IQueryable<GoogleDriveConfiguration> GetAllGoogleDriveConfigurations()
        {
            return _repository.GetAllGoogleDriveConfigurations();
        }

        public void UpdateGoogleDriveConfiguration(GoogleDriveConfiguration googleDriveConfiguration)
        {
            _repository.UpdateGoogleDriveConfiguration(googleDriveConfiguration);
        }

        public void DeleteGoogleDriveConfiguration(int id)
        {
            _repository.DeleteGoogleDriveConfiguration(id);
        }
    }
}
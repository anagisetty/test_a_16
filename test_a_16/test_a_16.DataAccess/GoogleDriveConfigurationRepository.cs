using System;
using System.Linq;

namespace test_a_16
{
    public class GoogleDriveConfigurationRepository
    {
        private readonly GoogleDriveConfigurationContext _context;
        public GoogleDriveConfigurationRepository(GoogleDriveConfigurationContext context)
        {
            _context = context;
        }

        //Create
        public void CreateGoogleDriveConfiguration(GoogleDriveConfiguration googleDriveConfiguration)
        {
            _context.GoogleDriveConfigurations.Add(googleDriveConfiguration);
            _context.SaveChanges();
        }

        //Read
        public GoogleDriveConfiguration GetGoogleDriveConfiguration(int id)
        {
            return _context.GoogleDriveConfigurations.Find(id);
        }

        public IQueryable<GoogleDriveConfiguration> GetAllGoogleDriveConfigurations()
        {
            return _context.GoogleDriveConfigurations;
        }

        //Update
        public void UpdateGoogleDriveConfiguration(GoogleDriveConfiguration googleDriveConfiguration)
        {
            _context.Entry(googleDriveConfiguration).State = EntityState.Modified;
            _context.SaveChanges();
        }

        //Delete
        public void DeleteGoogleDriveConfiguration(int id)
        {
            var googleDriveConfiguration = _context.GoogleDriveConfigurations.Find(id);
            _context.GoogleDriveConfigurations.Remove(googleDriveConfiguration);
            _context.SaveChanges();
        }
    }
}
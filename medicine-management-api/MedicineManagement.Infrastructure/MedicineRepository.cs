using MedicineManagement.Application.MedicineRepositries;
using MedicineManagement.Domain;
using System.Text.Json;
using Microsoft.Extensions.Options;

namespace MedicineManagement.Infrastructure
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly ApplicationConfigurations _config;

        public MedicineRepository( IOptions<ApplicationConfigurations> config)
        { 
            _config = config.Value;
        }

        public async Task<List<Medicine>> GetAllMedicines()
        {
          try
          {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), _config.JsonFilePath);

                if (!File.Exists(filePath))
                    return new List<Medicine>();

                var jsonData = await File.ReadAllTextAsync(filePath);

                var medicines = JsonSerializer.Deserialize<List<Medicine>>(jsonData,
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                return medicines ?? new List<Medicine>();

            }
          catch(Exception ex)
          {
                throw;
          }
        }
    }
}

using MedicineManagement.Application.MedicineRepositries;
using MedicineManagement.Domain;
using System.Text.Json;

namespace MedicineManagement.Infrastructure
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly MedicineContext _context;

        public MedicineRepository(MedicineContext context)
        {
            _context = context;
        }

        private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "medicines.json");

        private async Task<List<Medicine>> ReadFileAsync()
        {
            if (!File.Exists(_filePath))
            {
                await File.WriteAllTextAsync(_filePath, "[]");
            }

            var json = await File.ReadAllTextAsync(_filePath);
            return JsonSerializer.Deserialize<List<Medicine>>(json) ?? new List<Medicine>();
        }

        private async Task WriteFileAsync(List<Medicine> medicines)
        {
            var json = JsonSerializer.Serialize(medicines, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_filePath, json);
        }

        public async Task<List<Medicine>> GetAllAsync(string search)
        {
            var medicines = await ReadFileAsync();

            if (!string.IsNullOrEmpty(search))
            {
                medicines = medicines
                    .Where(m => m.FullName.Contains(search, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return medicines;
        }

        public async Task<Medicine> GetByIdAsync(int id)
        {
            var medicines = await ReadFileAsync();
            return medicines.FirstOrDefault(x => x.Id == id);
        }

        public async Task AddAsync(Medicine medicine)
        {
            var medicines = await ReadFileAsync();

            medicine.Id = medicines.Any() ? medicines.Max(x => x.Id) + 1 : 1;

            medicines.Add(medicine);

            await WriteFileAsync(medicines);
        }

        public async Task UpdateAsync(Medicine medicine)
        {
            var medicines = await ReadFileAsync();

            var existing = medicines.FirstOrDefault(x => x.Id == medicine.Id);
            if (existing == null) return;

            existing.FullName = medicine.FullName;
            existing.Notes = medicine.Notes;
            existing.Price = medicine.Price;
            existing.Quantity = medicine.Quantity;
            existing.ExpiryDate = medicine.ExpiryDate;
            existing.Brand = medicine.Brand;

            await WriteFileAsync(medicines);
        }

        public async Task DeleteAsync(int id)
        {
            var medicines = await ReadFileAsync();

            var item = medicines.FirstOrDefault(x => x.Id == id);
            if (item == null) return;

            medicines.Remove(item);

            await WriteFileAsync(medicines);
        }
    }
}

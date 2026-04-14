using MedicineManagement.Domain;

namespace MedicineManagement.Application.MedicineRepositries
{
    public interface IMedicineRepository
    {
        Task<List<Medicine>> GetAllMedicines();

        Task<List<Medicine>> GetAllMedicines(int Id);

        Task AddMedicine(Medicine medicine);

        Task UpdateMedicine(Medicine medicine);

        Task DeleteMedicine(int id);
    }
}

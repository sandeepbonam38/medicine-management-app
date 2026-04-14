using MedicineManagement.Application.Interfaces;
using MedicineManagement.Application.MedicineRepositries;
using MedicineManagement.Domain;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MedicineManagement.Application
{
    public class MedicineService : IMedicineService
    {
        private readonly IMedicineRepository _repository;
        public MedicineService(IMedicineRepository repository) {
            _repository = repository;
        }

        public async Task<List<Medicine>> GetAllMedicinesservice()
        {
            var medicines = await _repository.GetAllMedicines();
            return medicines;
        }

    }
}

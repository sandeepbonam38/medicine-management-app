using MedicineManagement.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace medicineAPI.Controllers
{
    [ApiController]
    [Route("api/MedicineController")]
    public class MedicineController : Controller
    {
        private readonly IMedicineService _medicineService;
        public MedicineController(IMedicineService medicineService)
        {
            _medicineService = medicineService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMedicines()
        {
            var response = await _medicineService.GetAllMedicinesservice();
            return Ok(response);
        }
    }
}

using Application.DTOs;
using Application.Interfaces;
using Application.Validators;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EmployeeManager(IGenericRepository<Employee>repository,IMapper mapper ):IEmployeeService
    {
        
        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
        {
            var employees = await repository.GetAllAsync();
            return mapper.Map<IEnumerable<EmployeeDto>>(employees);
        }
        public async Task<EmployeeDto?> GetEmployeeByIdAsync(int id)
        {
            var employee = await repository.GetByIdAsync(id);
            return mapper.Map<EmployeeDto>(employee);
        }
        public async Task<int> CreateEmployeeAsync(CreateEmployeeRequest request)
        {
            var entity = mapper.Map<Employee>(request);
            await repository.AddAsync(entity);
            await repository.SaveAsync();
            return entity.Id;
        }
    }
}

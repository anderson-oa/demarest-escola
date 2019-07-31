using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
    }
}
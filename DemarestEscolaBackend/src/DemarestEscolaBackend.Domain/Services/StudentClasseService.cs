using DemarestEscolaBackend.Domain.Entities;
using DemarestEscolaBackend.Domain.Interfaces.Repositories;
using DemarestEscolaBackend.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace DemarestEscolaBackend.Domain.Services
{
    public class StudentClasseService : IStudentClasseService
    {
        private readonly IStudentClasseRepository _studentClasseRepository;

        public StudentClasseService(IStudentClasseRepository studentClasseRepository)
        {
            _studentClasseRepository = studentClasseRepository;
        }

        public IEnumerable<StudentClasse> GetByStudent(int studentId)
        {
            return _studentClasseRepository.GetByStudent(studentId);
        }
    }
}
using AutoMapper;
using Flink.Domain.Inferfaces;
using Flink.Infraestructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flink.Application.Services
{
    public class CursoService : ICursoService
    {
        private readonly ICursoRepository _repository;
        private readonly IMapper _mapper;

        public  CursoService(ICursoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Delete
        public IEnumerable<Curso> GetCursos()
        {
            throw new NotImplementedException();
        }

        public Curso GetCursosId(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertCurso(Curso curso)
        {
            throw new NotImplementedException();
        }

        public void UpdateCursos(Curso curso)
        {
            throw new NotImplementedException();
        }

        public void DeleteCursos(int id)
        {
            throw new NotImplementedException();
        }
    }
}

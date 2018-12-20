using System.Collections.Generic;
using System.Linq;
using GerenciadorEscolar.Models;

namespace GerenciadorEscolar.Services
{
    public class InMemoryAlunoData:IAlunoData
    {
        private List<Aluno> _alunos; //TODO: ver questão das threading issues

        public InMemoryAlunoData()
        {

            _alunos = new List<Aluno>
            {
                new Aluno{Id=1,Nome="Felipe Vaz"},
                new Aluno{Id=2,Nome="Heitor"},
                new Aluno{Id=3,Nome="Louise"}

            };


        }

        public IEnumerable<Aluno> GetAll()
        {
            return _alunos.OrderBy(r=> r.Nome);
        }
    }
}

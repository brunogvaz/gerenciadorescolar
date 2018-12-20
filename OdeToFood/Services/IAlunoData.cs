using System;
using System.Collections;
using System.Collections.Generic;
using GerenciadorEscolar.Models;

namespace GerenciadorEscolar.Services
{
    public interface IAlunoData
    {
        IEnumerable<Aluno> GetAll();
    }
}

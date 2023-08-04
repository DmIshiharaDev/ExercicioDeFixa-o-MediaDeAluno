using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixação_MediaDeAluno
{
    internal class Aluno
    {
        public string Nome;
        public float N1;
        public float N2;
        public float N3;

        public float NotaFinal() { 
            return N1 + N2 + N3;
        }

    }
}

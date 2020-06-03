using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Professor
    {
        public string Login { get; set; }
        public string Foto { get; set; } = $"https://robohash.org/{Guid.NewGuid()}.png?size=60x60&bgset-bg1";
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Profissao { get; set; }
        public string Email { get; set; }
        public string InstituicaoEnsino { get; set; }
        public string Biografia { get; set; }
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();

    }
}

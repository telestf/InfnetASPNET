using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Interacao (string nome, string ultimoNome)
        {
            if (!string.IsNullOrWhiteSpace(nome) || !string.IsNullOrWhiteSpace(ultimoNome))
            {
                ViewBag.NomeCompleto = $"{nome} {ultimoNome}";
                return View("Xpto");
            }
            return View();
        }

        public IActionResult SobreMim()
        {
            Professor professor = new Professor()
            {
                Nome = "Thyago Teles",
                DataNascimento = new DateTime(1989, 05, 11),
                Biografia = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                Email = "thyago.ferreira@al.infnet.edu.br",
                InstituicaoEnsino = "Infnet",
                Profissao = "Professor",
                Login = "thyago.teles"
            };

            professor.Disciplinas.Add(new Disciplina()
            {
                Nome = "Projeto de Bloco",
                Horario = "17:00 - 19:30",
                Codigo = "PBCODIGOPB1"
            });
            
            professor.Disciplinas.Add(new Disciplina()
            {
                Nome = "Fundamentos da Web - ASP.NET",
                Horario = "17:00 - 19:30",
                Codigo = "DR1CODIGODR11"
            });

            professor.Disciplinas.Add(new Disciplina()
            {
                Nome = "Fundamentos da Web - C#",
                Horario = "17:00 - 19:30",
                Codigo = "DR2CODIGODR21"
            });

            var estudante = new Estudante();

            return View(professor);
        }

        [Route("{loginProfessor}/{codigoMateria}/Alunos")]
        public IActionResult Alunos(string loginProfessor, string codigoMateria)
        {
            List<Estudante> estudantes = new List<Estudante>()
            {
                new Estudante()
                {
                    Nome = $"Pipinho_{codigoMateria}",
                    Email = $"pipinho_{codigoMateria}@gmail.com",
                    CodigoTurma = codigoMateria,
                    LoginProfessor = loginProfessor
                },
                new Estudante()
                {
                    Nome = $"Paulinho_{codigoMateria}",
                    Email = $"paulinho_{codigoMateria}@gmail.com",
                    CodigoTurma = codigoMateria,
                    LoginProfessor = loginProfessor
                }               
            };

            for (int i = 3; i <= 10; i++)
            {
                estudantes.Add(new Estudante()
                {
                    Nome = $"Aluno {i}_{codigoMateria}",
                    Email = $"aluno{i}_{codigoMateria}@teste.com",
                    CodigoTurma = codigoMateria,
                    LoginProfessor = loginProfessor
                });
            }
            return View(estudantes);
        }
    }
}

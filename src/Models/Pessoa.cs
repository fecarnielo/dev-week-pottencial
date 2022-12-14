using System.Collections.Generic;

namespace src.Models;

public class Pessoa
{
    public Pessoa(){
        this.Nome = "template";
        this.Idade = 0;
        this.Ativado = true;
        this.contratos = new List<Contrato>();
    }

    public Pessoa (string Nome, int idade, string Cpf){
        this.Nome = Nome;
        this.Idade = idade;
        this.Cpf = Cpf;
        this.Ativado = true;
        this.contratos = new List<Contrato>();
    }
    public int Id { get; set; }
    public string Nome {get; set;}
    public int Idade { get; set; }
    public string? Cpf { get; set; }
    public bool Ativado { get; set; }
    public List<Contrato> contratos {get; set;}
}
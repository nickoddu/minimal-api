using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Test.MocksVeiculo;

public class VeiculoServicoMock : IVeiculoServico
{
    private static List<Veiculo> veiculos = new List<Veiculo>()
    {
        new Veiculo {
            Id = 1,
            Nome = "Etios",
            Marca = "Toyota",
            Ano = 2020
        },

        new Veiculo {
            Id = 2,
            Nome = "Civic",
            Marca = "Honda",
            Ano = 2019
            },

        new Veiculo {
            Id = 3,
            Nome = "Ka",
            Marca = "Ford",
            Ano = 2018
        }
    };

    public Veiculo? BuscaPorId(int id)
    {
        return veiculos.Find(v => v.Id == id);
    }

    public Veiculo Incluir(Veiculo veiculo)
    {
        veiculo.Id = veiculos.Count + 1;
        veiculos.Add(veiculo);
        return veiculo;
    }

    public List<Veiculo> Todos(int? pagina)
    {
        return veiculos;
    }

    public void Atualizar(Veiculo veiculo)
    {
        var veiculoExistente = veiculos.Find(v => v.Id == veiculo.Id);
        if (veiculoExistente != null)
        {
            veiculoExistente.Nome = veiculo.Nome;
            veiculoExistente.Marca = veiculo.Marca;
            veiculoExistente.Ano = veiculo.Ano;
        }
    }

    public void Remover(int id)
    {
        var veiculo = veiculos.Find(v => v.Id == id);
        if (veiculo != null)
        {
            veiculos.Remove(veiculo);
        }
    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        throw new NotImplementedException();
    }

    void IVeiculoServico.Incluir(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public void Apagar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }
}

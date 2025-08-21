using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var veiculo = new Veiculo();

        veiculo.Id = 1;
        veiculo.Nome = "Fiesta";
        veiculo.Marca = "Ford";
        veiculo.Ano = 2008;

        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Fiesta", veiculo.Nome);
        Assert.AreEqual("Ford", veiculo.Marca);
        Assert.AreEqual(2008, veiculo.Ano);
    }
}

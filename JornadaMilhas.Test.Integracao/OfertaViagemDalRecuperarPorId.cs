using JornadaMilhas.Dados;
using Xunit.Abstractions;

namespace JornadaMilhas.Test.Integracao;

[Collection(nameof(ContextoCollection))]
public class OfertaViagemDalRecuperarPorId : IClassFixture<ContextoFixture>
{
    public JornadaMilhasContext context { get; set; }
    
    private OfertaViagemDalRecuperarPorId(ITestOutputHelper output, ContextoFixture fixture)
    {
        context = fixture.Context;
        output.WriteLine(context.GetHashCode().ToString());
    }

    


    [Fact]
    public void RetornaNuloQuandoIdInexistente()
    {
        //arrage
        var dal = new OfertaViagemDAL(context);
        //act
        var ofertaRecuperada = dal.RecuperarPorId(-2);
        //assert
        Assert.Null(ofertaRecuperada);
    }
}
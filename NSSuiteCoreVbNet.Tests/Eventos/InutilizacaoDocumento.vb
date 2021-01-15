Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos
Imports Xunit

Namespace NSSuiteCoreVbNet.Tests.Eventos
    Public Class InutilizacaoDocumento
        <Fact()>
        Public Sub RealizaUmaInutilizacaoSincronaDadoUmNFe()
            Dim inutilizacao As InutilizarReq = New InutilizarReqNFe With {
                .cUF = TCodUfIBGE.RS,
                .tpAmb = TAmb.Homologacao,
                .ano = "20",
                .CNPJ = "07364617000135",
                .serie = "16",
                .nNFIni = "10004",
                .nNFFin = "10004",
                .xJust = "Inutilizacao realizada para teste de integracao"
            }
            inutilizacao.EnvioSincrono("C:\Testes\Inutilizacao\NFe\")
        End Sub
    End Class
End Namespace



Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes.NFe
Imports Xunit

Namespace NSSuiteCoreVbNet.Tests.Eventos
    Public Class CancelarDocumentoSincrono
        <Theory>
        <MemberData(NameOf(GetDFes))>
        Public Sub RealizaUmaEmissaoSincronaDadoUmDFe(ByVal dfe As IEventoSincronoReqNFe, ByVal tpDown As TipoEvenDownload, ByVal caminho As String, ByVal exibirPDFNaTela As Boolean)
            dfe.EnvioSincrono(tpDown, caminho, exibirPDFNaTela)
        End Sub

        Public Shared ReadOnly Property GetDFes As IEnumerable(Of Object())
            Get
                Return {New Object() {New CancelarReqNFe With {
                    .chave = "43210107364617000135550160000001011004621866",
                    .nProt = "143210000031375",
                    .tpAmb = TAmb.Homologacao,
                    .xJust = "TESTE INTEGRACAO",
                    .dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")
                }, TipoEvenDownload.XML_E_PDF, "C:\Testes\Cancelamentos\NFe\", True}}
            End Get
        End Property
    End Class
End Namespace

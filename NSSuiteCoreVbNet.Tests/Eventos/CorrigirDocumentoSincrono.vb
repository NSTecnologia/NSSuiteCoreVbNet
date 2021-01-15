Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos
Imports Xunit

Namespace NSSuiteCoreVbNet.Tests.Eventos
    Public Class CorrigirDocumentoSincrono
        <Theory>
        <MemberData(NameOf(GetDFes))>
        Public Sub RealizaUmaEmissaoSincronaDadoUmDFe(ByVal dfe As IEventoSincronoReqNFe)
            Try
                dfe.EnvioSincrono(TipoEvenDownload.XML_E_PDF, "C:\NotasTeste\", True)
            Catch e As Exception
                Console.WriteLine(e.Message)
            End Try
        End Sub

        Public Shared ReadOnly Property GetDFes As IEnumerable(Of Object())
            Get
                Return {New Object() {New CorrigirReqNFe With {
                    .chave = "",
                    .tpAmb = TAmb.Homologacao,
                    .dhEvento = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                    .nSeqEvento = 1,
                    .xCorrecao = "CC-e realizada para teste de integração"
                }}}
            End Get
        End Property
    End Class
End Namespace
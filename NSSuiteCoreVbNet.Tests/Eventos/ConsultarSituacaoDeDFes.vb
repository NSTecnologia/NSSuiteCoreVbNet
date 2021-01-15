Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Eventos
Imports Xunit

Namespace NSSuiteCoreVbNet.Tests.Eventos
    Public Class ConsultarSituacaoDeDFes
        <Theory()>
        <MemberData(NameOf(GetReqs))>
        Public Sub RealizaUmaEmissaoSincronaDadoUmDFe(ByVal dfe As IConsultarSituacaoReq)
            Try
                Dim respostaConsultaSituacao = dfe.Envia()
                respostaConsultaSituacao.Valida()
            Catch e As Exception
                Console.WriteLine(e.Message)
            End Try
        End Sub

        Public Shared ReadOnly Property GetReqs As IEnumerable(Of Object())
            Get
                Return {New Object() {New ConsultarSituacaoReqNFe With {
                    .chave = "",
                    .tpAmb = TAmb.Homologacao,
                    .licencaCnpj = "",
                    .versao = "4.00"
                }}}
            End Get
        End Property
    End Class
End Namespace

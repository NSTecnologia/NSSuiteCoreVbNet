Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes.NFe
Imports Xunit

Namespace NSSuiteCoreVbNet.Tests.Eventos
    Public Class DownloadEventoDeDocumento
        <Theory()>
        <MemberData(NameOf(GetCancelamentos))>
        Public Sub RealizaUmDownloadDeCancelmanetosESalvaNaMaquina(ByVal downloadEventoReq As IDownloadEventoReq)
            Dim downloadEventoResposta = TryCast(downloadEventoReq.Envia(), IDownloadEventoResp)
            downloadEventoResposta.ValidarESalvar("C:\Testes\Eventos\DownloadEventoDFe\", True)
        End Sub

        Public Shared ReadOnly Property GetCancelamentos As IEnumerable(Of Object())
            Get
                Return {New Object() {New DownloadEventoReqNFe With {
                    .chave = "43201207364617000135550000000124861966529827",
                    .tpAmb = TAmb.Homologacao,
                    .tpDown = TipoEvenDownload.XML_E_PDF,
                    .tpEvento = TipoDeEventoNFe.CANCELAMENTO,
                    .nSeqEvento = 1
                }}}
            End Get
        End Property
    End Class
End Namespace

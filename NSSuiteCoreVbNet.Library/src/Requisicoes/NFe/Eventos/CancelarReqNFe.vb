Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Respostas.NFe.Eventos

Namespace NSSuiteCoreVbNet.Requisicoes.NFe
    Public Class CancelarReqNFe
        Inherits SolicitavelNaAPI
        Implements ICancelamentoReq, IEventoSincronoReqNFe

        <JsonProperty("chNFe", Required:=Required.Always)>
        Public Property chave As String Implements ICancelamentoReq.chave
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb
        <JsonProperty("dhEvento", Required:=Required.Always)>
        Public Property dhEvento As String Implements ICancelamentoReq.dhEvento
        <JsonProperty("nProt", Required:=Required.Always)>
        Public Property nProt As String Implements ICancelamentoReq.nProt
        <JsonProperty("xJust", Required:=Required.Always)>
        Public Property xJust As String Implements ICancelamentoReq.xJust

        Public Function Envia() As IResposta Implements ICancelamentoReq.Envia
            Const requestURL As String = "https://nfe.ns.eti.br/nfe/cancel"
            Util.GravarLinhaLog("[CANCELAMENTO_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[CANCELAMENTO_NFE_FIM]")
            Return JsonConvert.DeserializeObject(Of CancelarRespNFe)(resposta)
        End Function

        Public Sub EnvioSincrono(ByVal tpDown As TipoEvenDownload, ByVal caminhoSalvar As String, ByVal exibirPDF As Boolean) Implements IEventoSincronoReqNFe.EnvioSincrono
            Util.GravarLinhaLog("[CANCELAMENTO_SINCRONO_NFE_INICIO]")
            Dim cancelamentoResposta = Me.Envia()
            cancelamentoResposta.Valida()
            Dim downloadRequisicao = New DownloadEventoReqNFe With {
                .tpAmb = Me.tpAmb,
                .chave = Me.chave,
                .tpDown = tpDown,
                .tpEvento = TipoDeEventoNFe.CANCELAMENTO,
                .nSeqEvento = 1
            }
            Dim downloadResposta = TryCast(downloadRequisicao.Envia(), IDownloadEventoResp)
            downloadResposta.ValidarESalvar(caminhoSalvar, exibirPDF)
            Util.GravarLinhaLog("[CANCELAMENTO_SINCRONO_NFE_FIM]")
        End Sub
    End Class
End Namespace
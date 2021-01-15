Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes.NFe

Namespace NSSuiteCoreVbNet.Requisicoes._Genericos
    Public Class CorrigirReqNFe
        Inherits SolicitavelNaAPI
        Implements ICorrigirReq, IEventoSincronoReqNFe

        <JsonProperty("chNFe", Required:=Required.Always)>
        Public Property chave As String Implements ICorrigirReq.chave
        <JsonProperty("xCorrecao", Required:=Required.Always)>
        Public Property xCorrecao As String
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb
        <JsonProperty("dhEvento", Required:=Required.Always)>
        Public Property dhEvento As String Implements ICorrigirReq.dhEvento

        <JsonProperty("nSeqEvento", Required:=Required.Always)>
        Public Property nSeqEvento As Integer Implements ICorrigirReq.nSeqEvento

        Public Function Envia() As IResposta Implements ICorrigirReq.Envia
            Const requestURL As String = "https://nfe.ns.eti.br/nfe/cce"
            Util.GravarLinhaLog("[DOWNLOAD_EVENTO_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[DOWNLOAD_EVENTO_NFE_INICIO]")
            Return JsonConvert.DeserializeObject(Of CorrigirRespNFe)(resposta)
        End Function

        Public Sub EnvioSincrono(ByVal tpDown As TipoEvenDownload, ByVal caminhoSalvar As String, ByVal exibirPDF As Boolean) Implements IEventoSincronoReqNFe.EnvioSincrono
            Dim ccResposta = TryCast(Me.Envia(), CorrigirRespNFe)
            ccResposta.Valida()
            Dim downloadRequisicao = New DownloadEventoReqNFe With {
                .tpAmb = Me.tpAmb,
                .chave = Me.chave,
                .tpDown = tpDown,
                .tpEvento = TipoDeEventoNFe.CARTA_DE_CORRECAO,
                .nSeqEvento = Me.nSeqEvento
            }
            Dim downloadResposta = TryCast(downloadRequisicao.Envia(), IDownloadEventoResp)
            downloadResposta.ValidarESalvar(caminhoSalvar, exibirPDF)
        End Sub
    End Class
End Namespace
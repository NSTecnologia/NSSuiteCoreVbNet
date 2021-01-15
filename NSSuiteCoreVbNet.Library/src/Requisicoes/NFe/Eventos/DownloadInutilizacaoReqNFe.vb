Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Eventos
    Public Class DownloadInutilizacaoReqNFe
        Inherits SolicitavelNaAPI
        Implements IDownloadInutilizacaoReq

        <JsonProperty("chave", Required:=Required.Always)>
        Public Property chave As String
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb
        <JsonProperty("tpDown", Required:=Required.Always)>
        Public Property tpDown As String = "X"

        Public Function Envia() As IResposta Implements IDownloadInutilizacaoReq.Envia
            Const requestURL As String = "https://nfe.ns.eti.br/nfe/get/inut"
            Util.GravarLinhaLog("[DOWNLOAD_INUTILIZACAO_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[DOWNLOAD_INUTILIZACAO_NFE_FIM]")
            Return JsonConvert.DeserializeObject(Of DownloadInutilizacaoRespNFe)(resposta)
        End Function
    End Class
End Namespace

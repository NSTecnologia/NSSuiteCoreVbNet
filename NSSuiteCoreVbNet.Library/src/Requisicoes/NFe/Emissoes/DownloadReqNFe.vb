
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Respostas.NFe

Namespace NSSuiteCoreVbNet.Requisicoes.NFe.Emissoes
    Public Class DownloadReqNFe
        Inherits SolicitavelNaAPI
        Implements IDownloadReq

        <JsonProperty("chNFe", Required:=Required.Always)>
        Public Property chNFe As String
        <JsonProperty("printCEAN", Required:=Required.[Default], NullValueHandling:=NullValueHandling.Ignore)>
        Public Property printCEAN As Boolean?
        <JsonProperty("obsCanhoto", Required:=Required.[Default], NullValueHandling:=NullValueHandling.Ignore)>
        Public Property obsCanhoto As Boolean?
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpDown", Required:=Required.Always)>
        Public Property tpDown As TipoDownloadDFes Implements IDownloadReq.tpDown
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb

        Public Function Envia() As IResposta Implements IDownloadReq.Envia
            Const requestURL As String = "https://nfe.ns.eti.br/nfe/get"
            Util.GravarLinhaLog("[DOWNLOAD_NFE_INICIO]")
            Dim resposta As String = EnviaConteudoParaAPI(Me, requestURL)
            Return JsonConvert.DeserializeObject(Of DownloadRespNFe)(resposta)
        End Function
        Public Overrides Sub WriteLogs(ByVal requisicao As String, ByVal resposta As String)

            Util.GravarLinhaLog("[DADOS_REQUISITADOS_NA_API]")
            Util.GravarLinhaLog(requisicao)

            Dim unused = JsonConvert.DeserializeObject(Of DownloadRespNFe)(resposta)
            If (Not unused.status.Equals("200")) Then
                Util.GravarLinhaLog("[DADOS_RETORNADOS_API]")
                Util.GravarLinhaLog(resposta)
            Else
                Util.GravarLinhaLog("[DADOS_RETORNADOS_API]")
                Util.GravarLinhaLog(unused.status)
            End If

        End Sub

    End Class

End Namespace

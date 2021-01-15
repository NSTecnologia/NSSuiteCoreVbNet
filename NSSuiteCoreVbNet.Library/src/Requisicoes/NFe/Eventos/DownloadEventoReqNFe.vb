Imports System.Runtime.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos

Namespace NSSuiteCoreVbNet.Requisicoes.NFe
    Public Class DownloadEventoReqNFe
        Inherits SolicitavelNaAPI
        Implements IDownloadEventoReq

        <JsonProperty("chNFe", Required:=Required.Always)>
        Public Property chave As String
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpDown", Required:=Required.Always)>
        Public Property tpDown As TipoEvenDownload
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpEvento", Required:=Required.Always)>
        Public Property tpEvento As TipoDeEventoNFe
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb
        <JsonProperty("nSeqEvento", Required:=Required.Always)>
        Public Property nSeqEvento As Integer Implements IDownloadEventoReq.nSeqEvento

        Public Function Envia() As IResposta Implements IDownloadEventoReq.Envia
            Const requestURL As String = "https://nfe.ns.eti.br/nfe/get/event"
            Util.GravarLinhaLog("[DOWNLOAD_EVENTO_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[DOWNLOAD_EVENTO_NFE_INICIO]")
            Return JsonConvert.DeserializeObject(Of DownloadEventoRespNFe)(resposta)
        End Function
    End Class

    Public Enum TipoDeEventoNFe
        <EnumMember(Value:="CANC")>
        CANCELAMENTO
        <EnumMember(Value:="CCE")>
        CARTA_DE_CORRECAO
    End Enum
End Namespace
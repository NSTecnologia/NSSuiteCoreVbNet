Imports System.Text.Json.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Eventos
    Public Class InutilizarReqNFe
        Inherits InutilizarReq

        <Text.Json.Serialization.JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("cUF", Required:=Required.Always)>
        Public Property cUF As TCodUfIBGE
        <Text.Json.Serialization.JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb
        <JsonProperty("nNFIni", Required:=Required.Always)>
        Public Property nNFIni As String
        <JsonProperty("nNFFin", Required:=Required.Always)>
        Public Property nNFFin As String

        Public Overrides Function Envia() As IResposta
            Const requestURL As String = "https://nfe.ns.eti.br/nfe/inut"
            Util.GravarLinhaLog("[INUTILIZAR_NUMERACAO_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[INUTILIZAR_NUMERACAO_NFE_INICIO]")
            Return JsonConvert.DeserializeObject(Of InutilizarRespNFe)(resposta)
        End Function
    End Class
End Namespace

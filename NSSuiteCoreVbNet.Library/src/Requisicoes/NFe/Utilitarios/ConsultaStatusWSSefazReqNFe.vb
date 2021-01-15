Imports System.Text.Json.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Utilitarios
    Public Class ConsultaStatusWSSefazReqNFe
        Inherits SolicitavelNaAPI
        Implements IConsultaStatusWSSefazReq

        <Newtonsoft.Json.JsonIgnore()>
        Private Const _requestURL As String = "https://nfe.ns.eti.br/util/wssefazstatus"
        <JsonProperty("CNPJCont", Required:=Required.Always)>
        Public Property CNPJCont As String
        <Newtonsoft.Json.JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("UF", Required:=Required.Always)>
        Public Property UF As TUf
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb
        <JsonProperty("versao", Required:=Required.Always)>
        Public Property versao As String

        Public Function Envia() As IResposta Implements IConsultaStatusWSSefazReq.Envia
            Util.GravarLinhaLog("[CONSULTA_STATUS_SEFAZ_WS_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, _requestURL)
            Util.GravarLinhaLog("[CONSULTA_STATUS_SEFAZ_WS_NFE_INICIO]")
            Return JsonConvert.DeserializeObject(Of ConsultaStatusWSSefazRespNFe)(resposta)
        End Function
    End Class
End Namespace

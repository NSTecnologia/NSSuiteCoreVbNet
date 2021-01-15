Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Eventos
    Public Class ConsultarSituacaoReqNFe
        Inherits SolicitavelNaAPI
        Implements IConsultarSituacaoReq

        <JsonProperty("licencaCnpj", Required:=Required.Always)>
        Public Property licencaCnpj As String Implements IConsultarSituacaoReq.licencaCnpj
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb
        <JsonProperty("chNFe", Required:=Required.Always)>
        Public Property chave As String Implements IConsultarSituacaoReq.chave
        <JsonProperty("versao", Required:=Required.Always)>
        Public Property versao As String

        Public Function Envia() As IResposta Implements IConsultarSituacaoReq.Envia
            Const requestURL As String = "https://nfe.ns.eti.br/nfe/stats"
            Util.GravarLinhaLog("[CONSULTA_SITUACAO_NFE_INICIO]")
            Dim resposta As String = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[CONSULTA_SITUACAO_NFE_FIM]")
            Return JsonConvert.DeserializeObject(Of ConsultarSituacaoRespNFe)(resposta)
        End Function
    End Class
End Namespace

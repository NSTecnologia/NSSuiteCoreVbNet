
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Utilitarios
    Public Class ConsultaCadastroContribuinteReqNFe
        Inherits SolicitavelNaAPI
        Implements IConsultaCadastroContribuinteReq

        <JsonIgnore()>
        Private Const _requestURL As String = "https://nfe.ns.eti.br/util/conscad"
        <JsonProperty("CNPJCont", Required:=Required.Always)>
        Public Property CNPJCont As String
        <Text.Json.Serialization.JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("UF", Required:=Required.Always)>
        Public Property UF As TUf
        <JsonProperty("IE", Required:=Required.AllowNull)>
        Public Property IE As String
        <JsonProperty("CNPJ", Required:=Required.AllowNull)>
        Public Property CNPJ As String
        <JsonProperty("CPF", Required:=Required.AllowNull)>
        Public Property CPF As String

        Public Function Envia() As IResposta Implements IConsultaCadastroContribuinteReq.Envia
            Util.GravarLinhaLog("[CONSULTA_CADASTRO_CONTRIBUINTE_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, _requestURL)
            Util.GravarLinhaLog("[CONSULTA_CADASTRO_CONTRIBUINTE_NFE_INICIO]")
            Return JsonConvert.DeserializeObject(Of ConsultaCadastroContribuinteRespNFe)(resposta)
        End Function
    End Class
End Namespace

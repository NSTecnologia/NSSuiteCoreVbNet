Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Respostas.NFe.Emissoes

Namespace NSSuiteCoreVbNet.Requisicoes.NFe.Emissoes
    Public Class ConsStatusProcessamentoReqNFe
        Inherits SolicitavelNaAPI
        Implements IConsStatusProcessamentoReq

        <JsonProperty("CNPJ", Required:=Required.Always)>
        Public Property CNPJ As String Implements IConsStatusProcessamentoReq.CNPJ

        <JsonProperty("nsNRec", Required:=Required.Always)>
        Public Property nsNRec As String Implements IConsStatusProcessamentoReq.nsNRec

        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty("tpAmb", Required:=Required.Always)>
        Public Property tpAmb As TAmb

        Public Function Envia() As IResposta Implements IRequisicao.Envia

            Const requestURL As String = "https://nfe.ns.eti.br/nfe/issue/status"
            Util.GravarLinhaLog("[CONSULTA_PROCESSAMENTO_NFE_INICIO]")
            Dim resposta As String = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[CONSULTA_PROCESSAMENTO_NFE_FIM]")
            Return JsonConvert.DeserializeObject(Of ConsStatusProcessamentoRespNFe)(resposta)
        End Function

    End Class
End Namespace

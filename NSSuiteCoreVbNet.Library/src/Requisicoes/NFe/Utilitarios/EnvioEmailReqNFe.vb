
Imports Newtonsoft.Json
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Utilitarios
    Public Class EnvioEmailReqNFe
        Inherits SolicitavelNaAPI
        Implements IEnvioEmailReq

        <Newtonsoft.Json.JsonIgnore()>
        Private Const _requestURL As String = "https://nfe.ns.eti.br/util/resendemail"
        <JsonProperty("email", Required:=Required.AllowNull)>
        Public Property emails As String()
        <JsonProperty("enviaEmailDoc", Required:=Required.AllowNull)>
        Public Property enviaEmailDoc As Boolean?
        <JsonProperty("chNFe", Required:=Required.Always)>
        Public Property chave As String Implements IEnvioEmailReq.chave
        <JsonProperty("anexarPDF", Required:=Required.AllowNull)>
        Public Property anexarPDF As Boolean? Implements IEnvioEmailReq.anexarPDF
        <JsonProperty("anexarEvento", Required:=Required.AllowNull)>
        Public Property anexarEvento As Boolean? Implements IEnvioEmailReq.anexarEvento

        Public Function Envia() As IResposta Implements IEnvioEmailReq.Envia
            Util.GravarLinhaLog("[ENVIO_EMAIL_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, _requestURL)
            Util.GravarLinhaLog("[ENVIO_EMAIL_NFE_INICIO]")
            Return JsonConvert.DeserializeObject(Of EnvioEmailRespNFe)(resposta)
        End Function
    End Class
End Namespace

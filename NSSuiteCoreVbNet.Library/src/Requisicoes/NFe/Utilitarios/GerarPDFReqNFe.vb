Imports Newtonsoft.Json
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Utilitarios
    Public Class GerarPDFReqNFe
        Inherits SolicitavelNaAPI
        Implements IGerarPDFReq

        <JsonIgnore()>
        Private Const _requestURL As String = "https://nfe.ns.eti.br/util/generatepdf"
        <JsonProperty("xml", Required:=Required.Always)>
        Public Property NFeXmlProc As String
        <JsonProperty("printCEAN", Required:=Required.AllowNull)>
        Public Property printCEAN As Boolean?
        <JsonProperty("obsCanhoto", Required:=Required.AllowNull)>
        Public Property obsCanhoto As Boolean?

        Public Function Envia() As IResposta Implements IGerarPDFReq.Envia
            Util.GravarLinhaLog("[GERAR_PDF_NFE_INICIO]")
            Dim resposta As String = EnviaConteudoParaAPI(Me, _requestURL)
            Util.GravarLinhaLog("[GERAR_PDF_NFE_FIM]")
            Return JsonConvert.DeserializeObject(Of GerarPDFRespNFe)(resposta)
        End Function

        Public Sub EnviarSincrono(ByVal caminho As String, ByVal exibirNaTela As Boolean) Implements IGerarPDFReq.EnviarSincrono
            Dim gerarPDFResp = TryCast(Me.Envia(), GerarPDFRespNFe)
            Dim chNFe As String = Util.LerElementoDeXMLString(NFeXmlProc, "chNFe")
            gerarPDFResp.ValidarESalvar(caminho, chNFe, exibirNaTela)
        End Sub
    End Class
End Namespace

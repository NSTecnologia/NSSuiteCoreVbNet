Imports Newtonsoft.Json
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genéricas.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Utilitarios
    Public Class ListarNSNRecsReqNFe
        Inherits SolicitavelNaAPI
        Implements IListarNSNRecsReq

        <JsonIgnore()>
        Private Const _requestURL As String = "https://nfe.ns.eti.br/util/list/nsnrecs"
        <JsonProperty("chNFe", Required:=Required.Always)>
        Public Property chave As String Implements IListarNSNRecsReq.chave

        Public Function Envia() As IResposta Implements IListarNSNRecsReq.Envia
            Util.GravarLinhaLog("[LISTAR_NSNRECS_NFE_INICIO]")
            Dim resposta = EnviaConteudoParaAPI(Me, _requestURL)
            Util.GravarLinhaLog("[LISTAR_NSNRECS_NFE_INICIO]")
            Return JsonConvert.DeserializeObject(Of ListarNSNRecsRespNFe)(resposta)
        End Function
    End Class
End Namespace
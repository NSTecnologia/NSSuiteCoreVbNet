Namespace NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios
    Public Interface IGerarPDFResp
        Inherits IResposta

        Property pdf As String
        Property erros As List(Of String)
        Property erro As Erro
        Sub ValidarESalvar(ByVal caminho As String, ByVal chaveDeAcesso As String, ByVal exibirPDFNaTela As Boolean)
    End Interface
End Namespace

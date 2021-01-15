
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas

Namespace NSSuiteCoreVbNetLib.Respostas._Genéricas.Emissoes
    Public Interface IDownloadResp
        Inherits IResposta

        Property erro As Erro
        Property xml As String
        Property pdf As String
        Sub ValidarESalvar(ByVal caminho As String, ByVal exibirPDF As Boolean)
    End Interface
End Namespace
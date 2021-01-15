

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas

Namespace NSSuiteCoreVbNetLib.Respostas._Genéricas.Emissoes
    Public Interface IEnvioResp
        Inherits IResposta

        Property erros As List(Of String)
        Property erro As Erro
    End Interface
End Namespace

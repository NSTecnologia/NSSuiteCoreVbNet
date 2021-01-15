
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas

Namespace NSSuiteCoreVbNetLib.Respostas._Genéricas
    Public Interface IConsNaoEncerradosResp
        Property status As String
        Property motivo As String
        Property erros As List(Of String)
        Property erro As Erro
    End Interface
End Namespace

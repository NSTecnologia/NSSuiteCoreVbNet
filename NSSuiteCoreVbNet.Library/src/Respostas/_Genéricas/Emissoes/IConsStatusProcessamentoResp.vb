
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas

Namespace NSSuiteCoreVbNetLib.Respostas._Genéricas
    Public Interface IConsStatusProcessamentoResp
        Inherits IResposta

        Property xMotivo As String
        Property dhRecbto As String
        Property erro As Erro
        Property cStat As String
        Property nProt As String
        Property xml As String
    End Interface
End Namespace
Namespace NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios
    Public Interface IListarNSNRecsResp
        Inherits IResposta

        Property nsNRecs As List(Of NSNRecs)
    End Interface

    Public Class NSNRecs
        Public Property nsNRec As String
        Public Property cStat As String
        Public Property xMotivo As String
    End Class
End Namespace

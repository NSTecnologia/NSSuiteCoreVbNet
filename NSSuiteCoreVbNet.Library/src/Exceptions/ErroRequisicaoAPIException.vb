

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons

Namespace NSSuiteCoreVbNet.Library.src.Exceptions
    Public Class ErroRequisicaoAPIException
        Inherits Exception

        Public Sub New(ByVal message As String)
            MyBase.New(message)
            Util.GravarLinhaLog("[ERRO_REQUISICAO]")
            Util.GravarLinhaLog(message)
        End Sub
    End Class
End Namespace

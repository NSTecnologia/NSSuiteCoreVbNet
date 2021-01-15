Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons

Namespace NSSuiteCoreVbNet.Library.src.Exceptions
    Public Class SalvarDocumentosException
        Inherits Exception

        Public Sub New(ByVal message As String)
            MyBase.New(message)
            Util.GravarLinhaLog("[ERRO AO SALVAR DOCUMENTO(S)]")
            Util.GravarLinhaLog(message)
        End Sub
    End Class
End Namespace

﻿
Namespace NSSuiteCoreVbNet.Library.src.Exceptions
    Public Class RequisicaoDownloadException
        Inherits ErroRequisicaoAPIException

        Public Sub New(ByVal msg As String)
            MyBase.New(msg)
        End Sub
    End Class
End Namespace

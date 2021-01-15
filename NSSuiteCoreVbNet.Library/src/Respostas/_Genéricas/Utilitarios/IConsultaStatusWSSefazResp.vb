Namespace NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios
    Public Interface IConsultaStatusWSSefazResp
        Inherits IResposta

        Property retStatusServico As RetStatusServico
    End Interface

    Public Class RetStatusServico
        Public Property cStat As String
        Public Property xMotivo As String
    End Class
End Namespace

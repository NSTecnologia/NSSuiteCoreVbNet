

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Utilitarios
    Public Interface IGerarPDFReq
        Inherits IRequisicao

        Sub EnviarSincrono(ByVal caminho As String, ByVal exibirNaTela As Boolean)
    End Interface
End Namespace

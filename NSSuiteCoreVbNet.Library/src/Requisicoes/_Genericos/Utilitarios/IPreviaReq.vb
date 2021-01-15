

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Utilitarios
    Public Interface IPreviaReq
        Inherits IRequisicao

        Function MostrarDFePreviaPDF() As IPreviaResp
    End Interface
End Namespace

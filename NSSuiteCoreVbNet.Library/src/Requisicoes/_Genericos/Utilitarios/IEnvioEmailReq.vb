

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Utilitarios
    Public Interface IEnvioEmailReq
        Inherits IRequisicao

        Property chave As String
        Property anexarPDF As Boolean?
        Property anexarEvento As Boolean?
    End Interface
End Namespace

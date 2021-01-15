
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios
    Public Class ListarNSNRecsRespNFe
        Implements IListarNSNRecsResp

        Public Property nsNRecs As List(Of NSNRecs) Implements IListarNSNRecsResp.nsNRecs
        Public Property status As String Implements IResposta.status
        Public Property motivo As String Implements IResposta.motivo


        Public Sub Valida() Implements IResposta.Valida
            If Not "200".Equals(Me.status) Then Throw New RequisicaoListarNSNRecException($"Erro ao listar nsnrecs de NFe: {Me.status} - {Me.motivo}")
        End Sub
    End Class
End Namespace
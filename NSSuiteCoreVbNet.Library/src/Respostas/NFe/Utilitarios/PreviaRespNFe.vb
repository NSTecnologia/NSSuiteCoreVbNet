Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios
    Public Class PreviaRespNFe
        Implements IPreviaResp

        Public Property pdf As String Implements IPreviaResp.pdf
        Public Property status As String Implements IResposta.status
        Public Property motivo As String Implements IResposta.motivo
        Public Property erros As List(Of String)


        Public Sub ValidarEMostrar() Implements IPreviaResp.ValidarEMostrar
            Me.Valida()
            Util.GerarPDFTemporario(Me.pdf)
            Util.GravarLinhaLog($"[PREVIA_GERADA_COM_SUCESSO]")
        End Sub

        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) Then
                Return
            ElseIf erros IsNot Nothing Then
                Throw New RequisicaoPreviaException($"NFe invalida de acordo com a validacao contra schema: {Me.erros}")
            Else
                Throw New RequisicaoPreviaException($"Erro ao inutilizar NFe: {Me.status} - {Me.motivo}")
            End If
        End Sub
    End Class
End Namespace
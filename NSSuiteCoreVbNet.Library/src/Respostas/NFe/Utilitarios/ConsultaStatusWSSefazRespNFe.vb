

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios
    Public Class ConsultaStatusWSSefazRespNFe
        Implements IConsultaStatusWSSefazResp

        Public Property retStatusServico As RetStatusServico Implements IConsultaStatusWSSefazResp.retStatusServico

        Public Property status As String Implements IResposta.status

        Public Property motivo As String Implements IResposta.motivo


        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) Then
                Util.GravarLinhaLog("[CONSULTA_STATUS_SEFAZ_WS_NFE_FEITO_COM_SUCESSO]")
                Return
            End If
            Throw New Exception($"Erro ao enviar email da NFe: {Me.status} - {Me.motivo}")
        End Sub
    End Class
End Namespace

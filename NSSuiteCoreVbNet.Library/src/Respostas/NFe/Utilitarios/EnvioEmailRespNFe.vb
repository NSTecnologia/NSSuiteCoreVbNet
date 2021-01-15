
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios
    Public Class EnvioEmailRespNFe
        Implements IEnvioEmailResp

        Public Property erro As Erro Implements IEnvioEmailResp.erro

        Public Property status As String Implements IResposta.status

        Public Property motivo As String Implements IResposta.motivo

        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) Then
                Util.GravarLinhaLog("[ENVIO_EMAIL_NFE_FEITO_COM_SUCESSO]")
                Return
            ElseIf erro IsNot Nothing Then
                Throw New RequisicaoEnvioEmailException($"{Me.erro.cStat} - {Me.erro.xMotivo}")
            Else
                Throw New RequisicaoEnvioEmailException($"Erro ao enviar email da NFe: {Me.status} - {Me.motivo}")
            End If
        End Sub
    End Class
End Namespace

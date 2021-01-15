Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNetLib.Respostas._Genéricas.Emissoes

Namespace NSSuiteCoreVbNet.Respostas.NFe.Emissoes
    Public Class EnvioRespNFe
        Implements IEnvioResp

        Public Property erros As List(Of String) Implements IEnvioResp.erros

        Public Property erro As Erro Implements IEnvioResp.erro

        Public Property status As String Implements IResposta.status

        Public Property motivo As String Implements IResposta.motivo

        Public Property nsNRec As String

        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) OrElse "-6".Equals(Me.status) Then
                Util.GravarLinhaLog($"[ENVIO_FEITO_COM_SUCESSO]")
                Return
            ElseIf "-7".Equals(Me.status) Then
                Throw New RequisicaoEmissaoException($"{Me.motivo}. nsNRec: {Me.nsNRec}")
            ElseIf erros IsNot Nothing Then
                Throw New RequisicaoEmissaoException($"NFe invalida de acordo com a validacao contra schema: {Me.erros}")
            ElseIf erro IsNot Nothing Then
                Throw New RequisicaoEmissaoException($"{Me.erro.cStat} - {Me.erro.xMotivo}")
            Else
                Throw New RequisicaoEmissaoException($"Erro ao Enviar a NFe: {Me.status} - {Me.motivo}")
            End If
        End Sub
    End Class
End Namespace



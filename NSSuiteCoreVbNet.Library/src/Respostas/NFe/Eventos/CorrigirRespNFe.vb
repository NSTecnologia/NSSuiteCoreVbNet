

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNetLib.Respostas._Genéricas

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
    Public Class CorrigirRespNFe
        Implements ICorrigirResp

        Public Property erros As List(Of String) Implements ICorrigirResp.erros

        Public Property erro As Erro Implements ICorrigirResp.erro

        Public Property status As String Implements IResposta.status

        Public Property motivo As String Implements IResposta.motivo

        Public Property retEvento As RetEventoNFe

        Public Sub Valida() Implements IResposta.Valida
            Select Case Me.status
                Case "200"
                    If Not retEvento.cStat.Equals("135") Then Throw New RequisicaoCorrecaoException("")
                    Util.GravarLinhaLog("CORRECAO_NFE_FEITA_COM_SUCESSO")
                    Exit Select
                Case Else
                    Throw New RequisicaoCorrecaoException("")
            End Select
        End Sub
    End Class
End Namespace
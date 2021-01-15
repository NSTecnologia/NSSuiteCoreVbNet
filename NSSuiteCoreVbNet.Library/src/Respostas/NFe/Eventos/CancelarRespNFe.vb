

Imports Newtonsoft.Json
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNetLib.Respostas._Genéricas.Eventos

Namespace NSSuiteCoreVbNet.Respostas.NFe.Eventos
    Public Class CancelarRespNFe
        Implements ICancelamentoResp

        Public Property erros As List(Of String) Implements ICancelamentoResp.erros

        Public Property erro As Erro Implements ICancelamentoResp.erro

        Public Property status As String Implements IResposta.status

        Public Property motivo As String Implements IResposta.motivo

        Public Property retEvento As RetEventoNFe


        Public Sub Valida() Implements IResposta.Valida
            Select Case Me.status
                Case "200"
                    If Not Me.retEvento.cStat.Equals("135") Then Throw New RequisicaoCancelarException($"Codigo erro: {Me.erro.cStat}. Motivo do erro: {Me.erro.xMotivo}")
                    Util.GravarLinhaLog("[CANCELAMENTO_NFE_REALIZADO_COM_SUCESSO]")
                    Exit Select
                Case "-3"
                    Throw New RequisicaoCancelarException($"Codigo erro: {Me.erro.cStat}. Motivo do erro: {Me.erro.xMotivo}")
                Case "-2"
                    Throw New RequisicaoCancelarException($"{Me.motivo}")
                Case Else
                    Throw New RequisicaoCancelarException($"Erro não catalogado, verifique o JSON de retono: {JsonConvert.SerializeObject(Me)}")
            End Select
        End Sub
    End Class
End Namespace

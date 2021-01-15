Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNetLib.Respostas._Genéricas

Namespace NSSuiteCoreVbNet.Respostas.NFe.Emissoes
    Public Class ConsStatusProcessamentoRespNFe
        Implements IConsStatusProcessamentoResp

        Public Property xMotivo As String Implements IConsStatusProcessamentoResp.xMotivo

        Public Property dhRecbto As String Implements IConsStatusProcessamentoResp.dhRecbto

        Public Property erro As Erro Implements IConsStatusProcessamentoResp.erro

        Public Property cStat As String Implements IConsStatusProcessamentoResp.cStat

        Public Property nProt As String Implements IConsStatusProcessamentoResp.nProt

        Public Property xml As String Implements IConsStatusProcessamentoResp.xml

        Public Property status As String Implements IResposta.status

        Public Property motivo As String Implements IResposta.motivo
        Public Property chNFe As String


        Public Sub Valida() Implements IResposta.Valida
            Select Case Me.status
                Case "200"
                    If Not Me.cStat.Equals("100") Then Throw New RequisicaoConsultaEmissaoException($"{Me.xMotivo}. cStat: {Me.cStat}")
                    Util.GravarLinhaLog($"[CONSULTA_STATUS_PROCESSAMENTO_SUCESSO]")
                    Exit Select
                Case "-2"
                    If Me.cStat.Equals("996") Then
                        Util.GravarLinhaLog("[REALIZANDO_CONSULTA_NFE_NOVAMENTE...]")
                        Throw New InvalidOperationException()
                    Else
                        Throw New RequisicaoConsultaEmissaoException($"{Me.erro.xMotivo}. cStat: {Me.erro.cStat}")
                    End If
                Case Else
                    Throw New RequisicaoConsultaEmissaoException($"{Me.motivo}.")
            End Select
        End Sub
    End Class
End Namespace

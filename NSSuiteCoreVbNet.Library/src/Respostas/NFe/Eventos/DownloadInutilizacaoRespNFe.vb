
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Eventos

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
    Public Class DownloadInutilizacaoRespNFe
        Implements IDownloadInutilizacaoResp

        Public Property status As String Implements IResposta.status
        Public Property motivo As String Implements IResposta.motivo
        Public Property retInut As RetInutNFe
        Public Property erro As Erro

        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) Then

                If "102".Equals(Me.retInut.cStat) Then
                    Util.GravarLinhaLog("[DOWNLOAD_INUTILIZACAO_NFE_FEITA_COM_SUCESSO]")
                    Return
                End If

                Throw New RequisicaoDownloadInutilizacaoException("Erro nao catalogado ao fazer o Download de Inutilizacao de NFe, verifique os logs para mais informacoes")
            ElseIf erro IsNot Nothing Then
                Throw New RequisicaoDownloadInutilizacaoException($"{Me.erro.cStat} - {Me.erro.xMotivo}")
            Else
                Throw New RequisicaoDownloadInutilizacaoException($"Erro ao fazer Download de Inutilizacao de NFe: {Me.status} - {Me.motivo}")
            End If
        End Sub

        Public Sub ValidarESalvar(caminho As String) Implements IDownloadInutilizacaoResp.ValidarESalvar
            Me.Valida()
            Dim filename As String = retInut.chave & "-inu"
            Util.SalvarXML(Me.retInut.xmlInut, caminho, filename)
        End Sub
    End Class
End Namespace

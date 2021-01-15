
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios
    Public Class GerarPDFRespNFe
        Implements IGerarPDFResp

        Public Property pdf As String Implements IGerarPDFResp.pdf
        Public Property erros As List(Of String) Implements IGerarPDFResp.erros
        Public Property erro As Erro Implements IGerarPDFResp.erro
        Public Property status As String Implements IResposta.status
        Public Property motivo As String Implements IResposta.motivo

        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) Then
                Util.GravarLinhaLog("[GERAR_PDF_NFE_FEITA_COM_SUCESSO]")
                Return
            ElseIf erros IsNot Nothing Then
                Throw New RequisicaoGerarPDFException($"Inutilizacao invalida de acordo com a validacao contra schema: {Me.erros}")
            ElseIf erro IsNot Nothing Then
                Throw New RequisicaoGerarPDFException($"{Me.erro.cStat} - {Me.erro.xMotivo}")
            Else
                Throw New RequisicaoGerarPDFException($"Erro ao gerar pdf de NFe: {Me.status} - {Me.motivo}")
            End If
        End Sub

        Public Sub ValidarESalvar(caminho As String, chaveDeAcesso As String, exibirPDFNaTela As Boolean) Implements IGerarPDFResp.ValidarESalvar
            Me.Valida()
            Dim filename As String = $"{chaveDeAcesso}-procNFe"
            Dim tarefaSalvarPDF = Util.SalvarPDF(Me.pdf, caminho, filename, exibirPDFNaTela)
            Task.WaitAll(tarefaSalvarPDF)
        End Sub
    End Class
End Namespace

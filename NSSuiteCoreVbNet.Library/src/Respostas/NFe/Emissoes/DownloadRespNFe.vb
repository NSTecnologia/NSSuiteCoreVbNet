Imports NSSuiteCoreVbNet.Library.NSSuiteCoreCSharp.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNetLib.Respostas._Genéricas.Emissoes

Namespace NSSuiteCoreVbNet.Respostas.NFe
    Public Class DownloadRespNFe
        Implements IDownloadResp

        Public Property chNFe As String
        Public Property nfeProc As String

        Public Property erro As Erro Implements IDownloadResp.erro

        Public Property xml As String Implements IDownloadResp.xml

        Public Property pdf As String Implements IDownloadResp.pdf

        Public Property status As String Implements IResposta.status

        Public Property motivo As String Implements IResposta.motivo

        Public Sub ValidarESalvar(caminho As String, exibirPDF As Boolean) Implements IDownloadResp.ValidarESalvar
            Me.Valida()
            Util.CriarDiretorio(caminho)
            Dim filename As String = $"{Me.chNFe}-procNFe"
            Util.GravarLinhaLog("[BAIXANDO_DOCUMENTOS_NA_MAQUINA]")
            Util.GravarLinhaLog($"[CAMINHO_DOCUMENTOS] - {caminho}")
            Dim tarefas As List(Of Task) = New List(Of Task)()
            tarefas.Add(Util.SalvarXML(Me.xml, caminho, filename))
            tarefas.Add(Util.SalvarPDF(Me.pdf, caminho, filename, exibirPDF))
            Task.WaitAll(tarefas.ToArray())
        End Sub

        Public Sub Valida() Implements IResposta.Valida
            If Not "200".Equals(Me.status) Then
                Throw New RequisicaoDownloadException($"{Me.motivo}.")
            End If

            Util.GravarLinhaLog($"[DOWNLOAD_NFE_FEITO_COM_SUCESSO]")
        End Sub
    End Class
End Namespace

Imports Newtonsoft.Json
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Eventos

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
    Public Class DownloadEventoRespNFe
        Implements IDownloadEventoResp

        Public Property status As String Implements IResposta.status
        Public Property motivo As String Implements IResposta.motivo
        Public Property retEvento As RetEventoNFe
        Public Property pdf As String
        Public Property xml As String

        Public Sub ValidarESalvar(caminho As String, exibirPDF As Boolean) Implements IDownloadEventoResp.ValidarESalvar
            Me.Valida()
            Util.CriarDiretorio(caminho)
            Dim filename As String = retEvento.chNFe & "-procNFeEven"
            Dim tarefas As List(Of Task) = New List(Of Task)()
            tarefas.Add(Util.SalvarXML(Me.xml, caminho, filename))
            tarefas.Add(Util.SalvarPDF(Me.pdf, caminho, filename, exibirPDF))
            Task.WaitAll(tarefas.ToArray())
        End Sub

        Public Sub Valida() Implements IResposta.Valida
            If Not Me.status.Equals("200") Then Throw New RequisicaoDownloadEventoException($"Erro não catalogado, verifique o JSON de resposta: {JsonConvert.SerializeObject(Me)}")
        End Sub
    End Class
End Namespace

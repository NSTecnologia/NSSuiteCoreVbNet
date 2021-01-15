
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Eventos
    Public Interface IEventoSincronoReqNFe
        Sub EnvioSincrono(ByVal tpDown As TipoEvenDownload, ByVal caminhoSalvar As String, ByVal exibirPDF As Boolean)
    End Interface
End Namespace
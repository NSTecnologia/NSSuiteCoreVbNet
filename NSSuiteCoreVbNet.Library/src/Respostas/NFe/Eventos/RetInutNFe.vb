

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Eventos

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
    Public Class RetInutNFe
        Implements IRetInut

        Public Property cStat As String
        Public Property xMotivo As String Implements IRetInut.xMotivo
        Public Property chave As String Implements IRetInut.chave
        Public Property tpAmb As String Implements IRetInut.tpAmb
        Public Property nProt As String Implements IRetInut.nProt
        Public Property dhRecbto As String Implements IRetInut.dhRecbto
        Public Property xmlInut As String Implements IRetInut.xmlInut
    End Class
End Namespace
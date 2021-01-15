Imports System.Runtime.Serialization


Namespace NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos
    Public Interface IDownloadEventoReq
        Inherits IRequisicao

        Property nSeqEvento As Integer
    End Interface

    Public Enum TipoEvenDownload
        <EnumMember(Value:="XP")>
        XML_E_PDF
        <EnumMember(Value:="X")>
        XML
        <EnumMember(Value:="P")>
        PDF
    End Enum
End Namespace

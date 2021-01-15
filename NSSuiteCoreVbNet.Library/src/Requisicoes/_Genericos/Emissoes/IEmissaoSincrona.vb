Imports System.Runtime.Serialization


Namespace NSSuiteCoreVbNet.Requisicoes._Genericos.Emissoes
    Public Interface IEmissaoDFeSincrona
        Inherits IRequisicao

        Sub EnvioSincrono(ByVal tpDown As TipoDownloadDFes, ByVal caminho As String, ByVal exibirNaTela As Boolean, ByVal Optional a3 As Boolean = False)
    End Interface

    Public Enum TipoDownloadDFes
        <EnumMember(Value:="X")>
        XML
        <EnumMember(Value:="J")>
        JSON
        <EnumMember(Value:="P")>
        PDF
        <EnumMember(Value:="XP")>
        XML_PDF
        <EnumMember(Value:="JP")>
        JSON_PDF
    End Enum
End Namespace

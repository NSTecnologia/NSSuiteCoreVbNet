Imports Newtonsoft.Json
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Eventos

Namespace NSSuiteCoreVbNet.Requisicoes._Genericos.Eventos
    Public MustInherit Class InutilizarReq
        Inherits SolicitavelNaAPI
        Implements IRequisicao

        <JsonProperty("ano", Required:=Required.Always)>
        Public Property ano As String
        <JsonProperty("CNPJ", Required:=Required.Always)>
        Public Property CNPJ As String
        <JsonProperty("serie", Required:=Required.Always)>
        Public Property serie As String
        <JsonProperty("xJust", Required:=Required.Always)>
        Public Property xJust As String

        Public MustOverride Function Envia() As IResposta Implements IRequisicao.Envia

        Public Sub EnvioSincrono(ByVal caminhoSalvar As String)
            Dim inutilizacaoResp = TryCast(Me.Envia(), IInutilizarResp)
            inutilizacaoResp.ValidarESalvar(caminhoSalvar)
        End Sub

    End Class
End Namespace

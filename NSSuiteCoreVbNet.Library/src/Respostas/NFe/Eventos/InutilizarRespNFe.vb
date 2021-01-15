
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Eventos


Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
    Public Class InutilizarRespNFe
        Implements IInutilizarResp

        Public Property status As String Implements IResposta.status
        Public Property motivo As String Implements IResposta.motivo
        Public Property retornoInutNFe As RetInutNFe
        Public Property erros As List(Of String)
        Public Property erro As Erro

        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) Then
                Util.GravarLinhaLog("[INUTILIZACAO_NUMERACAO_NFE_FEITA_COM_SUCESSO]")
                Return
            ElseIf erros IsNot Nothing Then
                Throw New RequisicaoInutilizarNumeracaoException($"Inutilizacao invalida de acordo com a validacao contra schema: {Me.erros}")
            ElseIf erro IsNot Nothing Then
                Throw New RequisicaoInutilizarNumeracaoException($"{Me.erro.cStat} - {Me.erro.xMotivo}")
            Else
                Throw New RequisicaoInutilizarNumeracaoException($"Erro ao inutilizar NFe: {Me.status} - {Me.motivo}")
            End If
        End Sub


        Public Sub ValidarESalvar(caminhoSalvar As String) Implements IInutilizarResp.ValidarESalvar
            Me.Valida()
            Util.CriarDiretorio(caminhoSalvar)
            Dim filename As String = retornoInutNFe.chave & "-inu"
            Util.SalvarXML(Me.retornoInutNFe.xmlInut, caminhoSalvar, filename)
        End Sub
    End Class
End Namespace


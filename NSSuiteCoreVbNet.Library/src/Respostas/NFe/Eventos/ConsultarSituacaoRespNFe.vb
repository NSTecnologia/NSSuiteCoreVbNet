
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNetLib.Respostas._Genéricas.Eventos

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Eventos
    Public Class ConsultarSituacaoRespNFe
        Implements IConsultarSituacaoResp

        Public Property status As String Implements IResposta.status
        Public Property motivo As String Implements IResposta.motivo
        Public Property retConsSitNFe As RetConsSitNFe
        Public Property erro As Erro

        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) Then

                If "100".Equals(RetConsSitNFe.cStat) OrElse "101".Equals(RetConsSitNFe.cStat) OrElse "110".Equals(RetConsSitNFe.cStat) Then
                    Util.GravarLinhaLog("[CONSULTA_SITUACAO_NFE_FEITA_COM_SUCESSO]")
                    Return
                End If
            ElseIf Erro IsNot Nothing Then
                Throw New RequisicaoConsultaSituacaoException($"{Me.erro.cStat} - {Me.erro.xMotivo}")
            Else
                Throw New RequisicaoConsultaSituacaoException($"Erro ao Consultar Situacao da NFe: {Me.status} - {Me.motivo}")
            End If
        End Sub
    End Class

    Public Class RetConsSitNFe
        Public Property tpAmb As String
        Public Property verAplic As String
        Public Property nRec As String
        Public Property cStat As String
        Public Property xMotivo As String
        Public Property cUF As String
        Public Property dhRecbto As String
        Public Property protNFe As List(Of TProtNFe)
        Public Property procEventoNFe As List(Of TProcEvento)
        Public Property versao As String
    End Class

    Public Class TProtNFe
        Public Property infProt As InfProt
        Public Property versao As String
    End Class

    Public Class InfProt
        Public Property tpAmb As String
        Public Property verAplic As String
        Public Property chNFe As String
        Public Property dhRecbto As String
        Public Property nProt As String
        Public Property digVal As Byte()
        Public Property cStat As String
        Public Property xMotivo As String
        Public Property Id As String
    End Class

    Public Class TProcEvento
        Public Property evento As TEvento
        Public Property retEvento As TRetEvento
        Public Property versao As String
    End Class

    Public Class TEvento
        Public Property infEvento As TEventoInfEvento
        Public Property versao As String
    End Class

    Public Class TEventoInfEvento
        Public Property cOrgao As String
        Public Property tpAmb As String
        Public Property CNPJ As String
        Public Property CPF As String
        Public Property chNFe As String
        Public Property dhEvento As String
        Public Property tpEvento As String
        Public Property nSeqEvento As String
        Public Property verEvento As String
        Public Property detEvento As DetEvento
        Public Property Id As String
    End Class

    Public Class DetEvento
        Public Property descEvento As String
        Public Property nProt As String
        Public Property xJust As String
        Public Property versao As String
    End Class

    Public Class TRetEvento
        Public Property infEvento As TRetEventoInfEvento
        Public Property versao As String
    End Class

    Public Class TRetEventoInfEvento
        Public Property tpAmb As String
        Public Property verAplic As String
        Public Property cOrgao As String
        Public Property cStat As String
        Public Property xMotivo As String
        Public Property chNFe As String
        Public Property tpEvento As String
        Public Property xEvento As String
        Public Property nSeqEvento As String
        Public Property CNPJDest As String
        Public Property CPFDest As String
        Public Property emailDest As String
        Public Property dhRegEvento As String
        Public Property nProt As String
        Public Property Id As String
    End Class
End Namespace

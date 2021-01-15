

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios

Namespace NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios
    Public Class ConsultaCadastroContribuinteRespNFe
        Implements IConsultaCadastroContribuinteResp

        Public Property status As String Implements IResposta.status
        Public Property motivo As String Implements IResposta.motivo
        Public Property retConsCad As RetConsCad


        Public Sub Valida() Implements IResposta.Valida
            If "200".Equals(Me.status) Then

                If "111".Equals(retConsCad.infCons.cStat) OrElse "112".Equals(retConsCad.infCons.cStat) Then
                    Util.GravarLinhaLog("[CONSULTA_CADASTRO_CONTRIBUINTE_NFE_FEITO_COM_SUCESSO]")
                    Return
                End If
            End If
            Throw New RequisicaoConsultaCadastroContribuinteException($"Erro na consulta cadastro contribuinte da NFe: {Me.status} - {Me.motivo}")
        End Sub
    End Class

    Public Class RetConsCad
        Public Property infCons As InfCons
        Public Property versao As String
    End Class

    Public Class InfCons
        Public Property verAplic As String
        Public Property cStat As Integer
        Public Property xMotivo As String
        Public Property UF As String
        Public Property CNPJ As String
        Public Property dhCons As String
        Public Property cUF As Integer
        Public Property infCad As List(Of InfCad)
    End Class

    Public Class InfCad
        Public Property IE As String
        Public Property CNPJ As String
        Public Property CPF As String
        Public Property UF As String
        Public Property cSit As Integer
        Public Property indCredNFe As Integer
        Public Property indCredCTe As Integer
        Public Property xNome As String
        Public Property xFant As String
        Public Property xRegApur As String
        Public Property CNAE As Integer
        Public Property dIniAtiv As String
        Public Property dUltSit As String
        Public Property dBaixa As String
        Public Property IEUnica As String
        Public Property IEAtual As String
        Public Property ender As Ender
    End Class

    Public Class Ender
        Public Property xLgr As String
        Public Property nro As String
        Public Property xCpl As String
        Public Property xBairro As String
        Public Property cMun As String
        Public Property xMun As String
        Public Property CEP As String
    End Class
End Namespace

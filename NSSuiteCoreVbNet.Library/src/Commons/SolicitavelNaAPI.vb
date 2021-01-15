Imports Newtonsoft.Json
Imports System
Imports System.IO
Imports System.Net
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Exceptions

Namespace NSSuiteCoreVbNet.Library.src.Commons
    Public MustInherit Class SolicitavelNaAPI
        Implements ISerializableJSON

        Private Const Token As String = "4EB15D6DEDAEBAE3FD0B7B5E5B0AD6D4"

        Public Overridable Function ToJSONString() As String Implements ISerializableJSON.ToJSONString
            Return JsonConvert.SerializeObject(Me, New JsonSerializerSettings With {
                .NullValueHandling = NullValueHandling.Ignore
            })
        End Function
        Public Overridable Sub WriteLogs(ByVal requisicao As String, ByVal resposta As String)
            Util.GravarLinhaLog("[DADOS_REQUISITADOS_NA_API]")

            Util.GravarLinhaLog(requisicao)

            Util.GravarLinhaLog("[DADOS_RETORNADOS_API]")
            Util.GravarLinhaLog(resposta)

        End Sub

        Protected Function EnviaConteudoParaAPI(ByVal conteudo As SolicitavelNaAPI, ByVal url As String, ByVal Optional tpConteudo As Conteudo = Conteudo.JSON) As String
            Dim requisicao As String = String.Empty
            Dim retorno As String = String.Empty
            Dim httpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            httpWebRequest.Method = "POST"
            Util.GravarLinhaLog($"[TOKEN_REQUISICAO: {Token}]")
            httpWebRequest.Headers("X-AUTH-TOKEN") = Token

            Select Case tpConteudo
                Case Commons.Conteudo.JSON
                    httpWebRequest.ContentType = "application/json;charset=utf-8"
                    requisicao = conteudo.ToJSONString()
                    Exit Select
                Case Commons.Conteudo.XML
                    httpWebRequest.ContentType = "application/xml;charset=utf-8"
                    requisicao = Util.SerializeXMLObject(conteudo)
                    Exit Select
            End Select

            Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())
                streamWriter.Write(requisicao)
                streamWriter.Flush()
                streamWriter.Close()
            End Using

            Try
                Dim httpResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)

                Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                    retorno = streamReader.ReadToEnd()
                End Using

            Catch ex As WebException

                If ex.Status = WebExceptionStatus.ProtocolError Then
                    Dim response As HttpWebResponse = CType(ex.Response, HttpWebResponse)

                    Using streamReader = New StreamReader(response.GetResponseStream())
                        retorno = streamReader.ReadToEnd()
                    End Using

                    Select Case Convert.ToInt32(response.StatusCode)
                        Case 401
                            Throw New ErroRequisicaoAPIException("Token não enviado ou inválido")
                        Case 403
                            Throw New ErroRequisicaoAPIException("Token sem permissão")
                        Case 404
                            Throw New ErroRequisicaoAPIException("Não encontrado, verifique o retorno para mais informações")
                        Case Else
                    End Select
                End If
            End Try
            Me.WriteLogs(requisicao, retorno)
            Return retorno
        End Function
    End Class

    Public Enum Conteudo
        JSON
        XML
    End Enum
End Namespace
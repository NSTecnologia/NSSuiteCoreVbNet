Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Namespace NSSuiteCoreVbNet.Library.src.Commons
    Module Util
        Function GerarPDFTemporario(ByVal pdf As String) As String
            Dim bytes As Byte() = Convert.FromBase64String(pdf)
            Dim file As String = Path.GetTempFileName() & ".pdf"
            IO.File.WriteAllBytes(file, bytes)
            Process.Start("cmd.exe ", "/c " & file)
            Return file
        End Function

        Function LerElementoDeXMLString(ByVal xml As String, ByVal elemento As String) As String
            Dim doc As XmlDocument = New XmlDocument()
            doc.LoadXml(xml)
            Dim root As XmlElement = doc.DocumentElement
            Dim xmlNodeList As XmlNodeList = root.GetElementsByTagName(elemento)
            If xmlNodeList.Count > 1 Then Throw New ArgumentOutOfRangeException()
            Return root.GetElementsByTagName(elemento).Item(0).InnerText
        End Function

        Function SerializeXMLObject(Of T)(ByVal ObjectXML As T) As String
            Dim xmlDoc As XmlDocument = New XmlDocument()
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(ObjectXML.[GetType]())

            Using xmlStream As MemoryStream = New MemoryStream()
                xmlSerializer.Serialize(xmlStream, ObjectXML)
                xmlStream.Position = 0
                xmlDoc.Load(xmlStream)
                Dim sw As StringWriter = New StringWriter()
                Dim xw As XmlTextWriter = New XmlTextWriter(sw)
                xmlDoc.WriteTo(xw)
                Return sw.ToString()
            End Using
        End Function

        Function DeserializeXMLObject(Of T As Class)(ByVal strXML As String) As Object
            Dim ser As XmlSerializer = New XmlSerializer(GetType(T))

            Using sr As StringReader = New StringReader(strXML)
                Return CType(ser.Deserialize(sr), T)
            End Using
        End Function

        Function CriarDiretorio(ByVal caminho As String) As String
            Try
                If Not Directory.Exists(caminho) Then Directory.CreateDirectory(caminho)
                If Not caminho.EndsWith("\") Then caminho += "\"
                Return caminho
            Catch ex As IOException
                GravarLinhaLog("[CRIAR_DIRETORIO]" & caminho)
                GravarLinhaLog(ex.Message)
                Throw New Exception("Erro: " & ex.Message)
            End Try
        End Function

        Async Function SalvarXML(ByVal xml As String, ByVal caminho As String, ByVal nome As String) As Task
            Await Task.Run(Function()

                               If Not String.IsNullOrEmpty(xml) Then
                                   Dim localParaSalvar As String = $"{caminho & nome}.xml"
                                   Dim ConteudoSalvar As String = xml.Replace("\""", "")
                                   File.WriteAllText(localParaSalvar, ConteudoSalvar)
                               Else
                                   Util.GravarLinhaLog("[ERRO AO SALVAR XML] : XML sem conteudo")
                               End If
                           End Function)
        End Function

        Async Function SalvarPDF(ByVal pdf As String, ByVal caminho As String, ByVal nome As String, ByVal exibirPDFNaTela As Boolean) As Task
            Await Task.Run(Function()

                               If Not String.IsNullOrEmpty(pdf) Then
                                   Dim localParaSalvar As String = $"{caminho & nome}.pdf"
                                   Dim bytes As Byte() = Convert.FromBase64String(pdf)
                                   If File.Exists(localParaSalvar) Then File.Delete(localParaSalvar)

                                   Using writer As BinaryWriter = New BinaryWriter(New FileStream(localParaSalvar, FileMode.CreateNew))
                                       writer.Write(bytes, 0, bytes.Length)
                                   End Using

                                   If exibirPDFNaTela Then System.Diagnostics.Process.Start("cmd.exe ", "/c " & localParaSalvar)
                               Else
                                   Util.GravarLinhaLog("[ERRO AO SALVAR PDF] : PDF sem conteudo")
                               End If
                           End Function)
        End Function

        Sub GravarLinhaLog(ByVal conteudo As String)
            Dim caminho As String = ".\log\"
            If Not Directory.Exists(caminho) Then Directory.CreateDirectory(caminho)
            Dim data As String = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff")
            Dim nomeArq As String = DateTime.Now.ToString("MM-dd-yyyy")

            Using outputFile As StreamWriter = New StreamWriter($"{caminho & nomeArq}.log", True)
                outputFile.WriteLine(data & " - " & conteudo)
            End Using
        End Sub
    End Module
End Namespace

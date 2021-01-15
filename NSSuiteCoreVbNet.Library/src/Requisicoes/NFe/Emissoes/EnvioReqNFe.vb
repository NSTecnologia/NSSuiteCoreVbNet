
Imports System.Runtime.Serialization
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports Newtonsoft.Json.Linq
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Commons
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes._Genericos.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas._Genéricas.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Respostas.NFe.Utilitarios
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Respostas.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNetLib.Respostas._Genéricas.Emissoes

Namespace NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    <XmlRoot("Signature", [Namespace]:="http://www.w3.org/2000/09/xmldsig#", IsNullable:=False)>
    Partial Public Class SignatureType
        Public Property SignedInfo As SignedInfoType
        Public Property SignatureValue As SignatureValueType
        Public Property KeyInfo As KeyInfoType
        <XmlAttribute(DataType:="ID")>
        Public Property Id As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class SignedInfoType
        Public Property CanonicalizationMethod As SignedInfoTypeCanonicalizationMethod
        Public Property SignatureMethod As SignedInfoTypeSignatureMethod
        Public Property Reference As ReferenceType
        <XmlAttribute(DataType:="ID")>
        Public Property Id As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class SignedInfoTypeCanonicalizationMethod
        Private algorithmField As String

        Public Sub New()
            algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315"
        End Sub

        <XmlAttribute(DataType:="anyURI")>
        Public Property Algorithm As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class X509DataType
        <XmlElement(DataType:="base64Binary")>
        Public Property X509Certificate As Byte()
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class KeyInfoType
        Public Property X509Data As X509DataType
        <XmlAttribute(DataType:="ID")>
        Public Property Id As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class SignatureValueType
        <XmlAttribute(DataType:="ID")>
        Public Property Id As String
        <XmlText(DataType:="base64Binary")>
        Public Property Value As Byte()
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class TransformType
        <XmlElement("XPath")>
        Public Property XPath As String()
        <XmlAttribute()>
        <JsonIgnore()>
        Public Property Algorithm As TTransformURI
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Public Enum TTransformURI
        <XmlEnum("http://www.w3.org/2000/09/xmldsig#enveloped-signature")>
        httpwwww3org200009xmldsigenvelopedsignature
        <XmlEnum("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")>
        httpwwww3orgTR2001RECxmlc14n20010315
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class ReferenceType
        <XmlArrayItem("Transform", IsNullable:=False)>
        Public Property Transforms As TransformType()
        Public Property DigestMethod As ReferenceTypeDigestMethod
        <XmlElement(DataType:="base64Binary")>
        Public Property DigestValue As Byte()
        <XmlAttribute(DataType:="ID")>
        Public Property Id As String
        <XmlAttribute(DataType:="anyURI")>
        Public Property URI As String
        <XmlAttribute(DataType:="anyURI")>
        Public Property Type As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class ReferenceTypeDigestMethod
        Private algorithmField As String

        Public Sub New()
            algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1"
        End Sub

        <XmlAttribute(DataType:="anyURI")>
        Public Property Algorithm As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
    Partial Public Class SignedInfoTypeSignatureMethod
        Private algorithmField As String

        Public Sub New()
            algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1"
        End Sub

        <XmlAttribute(DataType:="anyURI")>
        Public Property Algorithm As String
            Get
                Return algorithmField
            End Get
            Set(ByVal value As String)
                algorithmField = value
            End Set
        End Property
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    <XmlRoot("NFe", [Namespace]:="http://www.portalfiscal.inf.br/nfe", IsNullable:=False)>
    <JsonObject("NFe")>
    Partial Public Class EnvioReqNFe
        Inherits SolicitavelNaAPI
        Implements IEmissaoDFeSincrona, IPreviaReq

        Public Property infNFe As TNFeInfNFe
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property infNFeSupl As TNFeInfNFeSupl
        <XmlElement([Namespace]:="http://www.w3.org/2000/09/xmldsig#")>
        <JsonIgnore()>
        Public Property Signature As SignatureType

        Public Function Envia() As IResposta Implements IRequisicao.Envia
            Const requestURL As String = "https://nfe.ns.eti.br/nfe/issue"
            Util.GravarLinhaLog("[ENVIO_NFE_INICIO]")
            Dim resposta As String = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[ENVIO_NFE_FIM]")
            Return JsonConvert.DeserializeObject(Of EnvioRespNFe)(resposta)
        End Function

        Public Sub EnvioSincrono(tpDown As TipoDownloadDFes, caminho As String, exibirNaTela As Boolean, Optional a3 As Boolean = False) Implements IEmissaoDFeSincrona.EnvioSincrono
            Util.GravarLinhaLog("[INICIO_EMISSAO_SINCRONA_NFE]")
            Dim envioResposta As IResposta = Me.Envia()
            envioResposta.Valida()
            Dim consultaRequisicao = New ConsStatusProcessamentoReqNFe With {
                .CNPJ = infNFe.emit.CNPJ,
                .tpAmb = infNFe.ide.tpAmb,
                .nsNRec = (TryCast(envioResposta, EnvioRespNFe)).nsNRec
            }
            Dim consultaResposta As IResposta

            While True
                consultaResposta = consultaRequisicao.Envia()

                Try
                    consultaResposta.Valida()
                    Exit While
                Catch __unusedInvalidOperationException1__ As InvalidOperationException
                    Continue While
                End Try
            End While

            Dim downloadRequisicao = New DownloadReqNFe With {
                .tpDown = tpDown,
                .tpAmb = infNFe.ide.tpAmb,
                .chNFe = (TryCast(consultaResposta, ConsStatusProcessamentoRespNFe)).chNFe
            }
            Dim downloadResposta = TryCast(downloadRequisicao.Envia(), IDownloadResp)
            downloadResposta.ValidarESalvar(caminho, exibirNaTela)
            Util.GravarLinhaLog("[FIM_EMISSAO_SINCRONA_NFE]")
        End Sub

        Public Function MostrarDFePreviaPDF() As IPreviaResp Implements IPreviaReq.MostrarDFePreviaPDF
            Const requestURL As String = "https://nfe.ns.eti.br/util/preview/nfe"
            Util.GravarLinhaLog("[PREVIA_NFE_INICIO]")
            Dim resposta As String = EnviaConteudoParaAPI(Me, requestURL)
            Util.GravarLinhaLog("[PREVIA_NFE_FIM]")
            Dim previaResp = JsonConvert.DeserializeObject(Of PreviaRespNFe)(resposta)
            previaResp.ValidarEMostrar()
            Return previaResp
        End Function
        Public Overrides Function ToJSONString() As String
            Dim root As JObject = JObject.FromObject(New With {
                .NFe = Me
            })
            Return JsonConvert.SerializeObject(root, Formatting.Indented, New JsonSerializerSettings With {
                .NullValueHandling = NullValueHandling.Ignore
            })
        End Function

    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFe
        Public Property ide As TNFeInfNFeIde
        Public Property emit As TNFeInfNFeEmit
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property avulsa As TNFeInfNFeAvulsa
        Public Property dest As TNFeInfNFeDest
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property retirada As TLocal
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property entrega As TLocal
        <XmlElement("autXML")>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property autXML As List(Of TNFeInfNFeAutXML)
        <XmlElement("det")>
        Public Property det As List(Of TNFeInfNFeDet)
        Public Property total As TNFeInfNFeTotal
        Public Property transp As TNFeInfNFeTransp
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property cobr As TNFeInfNFeCobr
        Public Property pag As TNFeInfNFePag
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property infAdic As TNFeInfNFeInfAdic
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property exporta As TNFeInfNFeExporta
        Public Property compra As TNFeInfNFeCompra
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property cana As TNFeInfNFeCana
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property infRespTec As TInfRespTec
        <XmlAttribute()>
        Public Property versao As String
        <XmlAttribute(DataType:="ID")>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property Id As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIde
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property cUF As TCodUfIBGE
        Public Property cNF As String
        Public Property natOp As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property [mod] As TMod
        Public Property serie As String
        Public Property nNF As String
        Public Property dhEmi As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property dhSaiEnt As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpNF As TNFeInfNFeIdeTpNF
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property idDest As TNFeInfNFeIdeIdDest
        Public Property cMunFG As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpImp As TNFeInfNFeIdeTpImp
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpEmis As TNFeInfNFeIdeTpEmis
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property cDV As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpAmb As TAmb
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property finNFe As TFinNFe
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property indFinal As TNFeInfNFeIdeIndFinal
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property indPres As TNFeInfNFeIdeIndPres
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property procEmi As TProcEmi
        Public Property verProc As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property dhCont As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xJust As String
        <XmlElement("NFref")>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property NFref As List(Of TNFeInfNFeIdeNFref)
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TCodUfIBGE
        <EnumMember(Value:="11")>
        <XmlEnum("11")>
        RO
        <EnumMember(Value:="12")>
        <XmlEnum("12")>
        AC
        <EnumMember(Value:="13")>
        <XmlEnum("13")>
        AM
        <EnumMember(Value:="14")>
        <XmlEnum("14")>
        RR
        <EnumMember(Value:="15")>
        <XmlEnum("15")>
        PA
        <EnumMember(Value:="16")>
        <XmlEnum("16")>
        AP
        <EnumMember(Value:="17")>
        <XmlEnum("17")>
        [TO]
        <EnumMember(Value:="21")>
        <XmlEnum("21")>
        MA
        <EnumMember(Value:="22")>
        <XmlEnum("22")>
        PI
        <EnumMember(Value:="23")>
        <XmlEnum("23")>
        CE
        <EnumMember(Value:="24")>
        <XmlEnum("24")>
        RN
        <EnumMember(Value:="25")>
        <XmlEnum("25")>
        PB
        <EnumMember(Value:="26")>
        <XmlEnum("26")>
        PE
        <EnumMember(Value:="27")>
        <XmlEnum("27")>
        AL
        <EnumMember(Value:="28")>
        <XmlEnum("28")>
        SE
        <EnumMember(Value:="29")>
        <XmlEnum("29")>
        BA
        <EnumMember(Value:="31")>
        <XmlEnum("31")>
        MG
        <EnumMember(Value:="32")>
        <XmlEnum("32")>
        ES
        <EnumMember(Value:="33")>
        <XmlEnum("33")>
        RJ
        <EnumMember(Value:="35")>
        <XmlEnum("35")>
        SP
        <EnumMember(Value:="41")>
        <XmlEnum("41")>
        PR
        <EnumMember(Value:="42")>
        <XmlEnum("42")>
        SC
        <EnumMember(Value:="43")>
        <XmlEnum("43")>
        RS
        <EnumMember(Value:="50")>
        <XmlEnum("50")>
        MS
        <EnumMember(Value:="51")>
        <XmlEnum("51")>
        MT
        <EnumMember(Value:="52")>
        <XmlEnum("52")>
        GO
        <EnumMember(Value:="53")>
        <XmlEnum("53")>
        DF
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TMod
        <EnumMember(Value:="55")>
        <XmlEnum("55")>
        NFe
        <EnumMember(Value:="65")>
        <XmlEnum("65")>
        NFCe
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeTpNF
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        Entrata
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Saida
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeIdDest
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        OpInterna
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        OpInterestadual
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        OpExterior
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeTpImp
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        SemDANFE
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        DANFERetrato
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        DANFEPaisagem
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        DANFESimplificado
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        DANFENFCe
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        DANFENFCeMsgEletronica
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeTpEmis
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Normal
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ContigenciaFSIA
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ContigenciaSCAN
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        ContigenciaDPEC
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        ContigenciaFSDA
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ContigenciaSVCAN
        <EnumMember(Value:="7")>
        <XmlEnum("7")>
        ContigenciaSVNRS
        <EnumMember(Value:="8")>
        <XmlEnum("9")>
        ContigenciaOffline
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TAmb
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Producao
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        Homologacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TFinNFe
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Normal
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        Complementar
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        Ajuste
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        Devolucao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeIndFinal
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        Nao
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ConsumidorFinal
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeIndPres
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        NaoAplica
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Presencial
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        Internet
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        Teleatendimento
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        NFCEntregaDomicilio
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        PresencialForaEstabelecimento
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        Outros
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TProcEmi
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        AplicativoContribuinte
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        AvulsaPeloFisco
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        SiteFisco
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        AplicativoFisco
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIdeNFref
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property refCTe As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property refECF As TNFeInfNFeIdeNFrefRefECF
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property refNF As TNFeInfNFeIdeNFrefRefNF
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property refNFP As TNFeInfNFeIdeNFrefRefNFP
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property refNFe As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIdeNFrefRefECF
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property [mod] As TNFeInfNFeIdeNFrefRefECFMod
        Public Property nECF As String
        Public Property nCOO As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeNFrefRefECFMod
        <EnumMember(Value:="2B")>
        <XmlEnum("2B")>
        Item2B
        <EnumMember(Value:="2C")>
        <XmlEnum("2C")>
        Item2C
        <EnumMember(Value:="2D")>
        <XmlEnum("2D")>
        Item2D
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIdeNFrefRefNF
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property cUF As TCodUfIBGE
        Public Property AAMM As String
        Public Property CNPJ As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property [mod] As TNFeInfNFeIdeNFrefRefNFMod
        Public Property serie As String
        Public Property nNF As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeNFrefRefNFMod
        <EnumMember(Value:="01")>
        <XmlEnum("01")>
        Modelo01
        <EnumMember(Value:="02")>
        <XmlEnum("02")>
        Modelo02
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeIdeNFrefRefNFP
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property cUF As TCodUfIBGE
        Public Property AAMM As String
        Public Property CNPJ As String
        Public Property CPF As String
        Public Property IE As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property [mod] As TNFeInfNFeIdeNFrefRefNFPMod
        Public Property serie As String
        Public Property nNF As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeIdeNFrefRefNFPMod
        <EnumMember(Value:="01")>
        <XmlEnum("01")>
        NF
        <EnumMember(Value:="04")>
        <XmlEnum("04")>
        NFProdutor
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeEmit
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CPF As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CNPJ As String
        Public Property xNome As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xFant As String
        Public Property enderEmit As TEnderEmi
        Public Property IE As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property IEST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property IM As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CNAE As String
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CRT As TNFeInfNFeEmitCRT
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TEnderEmi
        Public Property xLgr As String
        Public Property nro As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xCpl As String
        Public Property xBairro As String
        Public Property cMun As String
        Public Property xMun As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property UF As TUfEmi
        Public Property CEP As String
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property cPais As TEnderEmiCPais
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property cPaisSpecified As Boolean
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xPais As TEnderEmiXPais
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property xPaisSpecified As Boolean
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property fone As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TUfEmi
        <EnumMember(Value:="AC")>
        AC
        <EnumMember(Value:="AL")>
        AL
        <EnumMember(Value:="AM")>
        AM
        <EnumMember(Value:="AP")>
        AP
        <EnumMember(Value:="BA")>
        BA
        <EnumMember(Value:="CE")>
        CE
        <EnumMember(Value:="DF")>
        DF
        <EnumMember(Value:="ES")>
        ES
        <EnumMember(Value:="Go")>
        GO
        <EnumMember(Value:="MA")>
        MA
        <EnumMember(Value:="MG")>
        MG
        <EnumMember(Value:="MS")>
        MS
        <EnumMember(Value:="MT")>
        MT
        <EnumMember(Value:="PA")>
        PA
        <EnumMember(Value:="PB")>
        PB
        <EnumMember(Value:="PE")>
        PE
        <EnumMember(Value:="PI")>
        PI
        <EnumMember(Value:="PR")>
        PR
        <EnumMember(Value:="RJ")>
        RJ
        <EnumMember(Value:="RN")>
        RN
        <EnumMember(Value:="RO")>
        RO
        <EnumMember(Value:="RR")>
        RR
        <EnumMember(Value:="RS")>
        RS
        <EnumMember(Value:="SC")>
        SC
        <EnumMember(Value:="SE")>
        SE
        <EnumMember(Value:="SP")>
        SP
        <EnumMember(Value:="TO")>
        [TO]
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TEnderEmiCPais
        <EnumMember(Value:="1058")>
        <XmlEnum("1058")>
        BRASIL
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TEnderEmiXPais
        <EnumMember(Value:="Brasil")>
        Brasil
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeEmitCRT
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        SimplesNacional
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        SNExcessoRC
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        RegimeNormal
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeAvulsa
        Public Property CNPJ As String
        Public Property xOrgao As String
        Public Property matr As String
        Public Property xAgente As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property fone As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property UF As TUfEmi
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property nDAR As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property dEmi As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vDAR As String
        Public Property repEmi As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property dPag As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDest
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CNPJ As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CPF As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property idEstrangeiro As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xNome As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property enderDest As TEndereco
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property indIEDest As TNFeInfNFeDestIndIEDest
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property IE As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ISUF As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property IM As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property email As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TEndereco
        Public Property xLgr As String
        Public Property nro As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xCpl As String
        Public Property xBairro As String
        Public Property cMun As String
        Public Property xMun As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property UF As TUf
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CEP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property cPais As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xPais As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property fone As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TUf
        <EnumMember(Value:="AC")>
        AC
        <EnumMember(Value:="AL")>
        AL
        <EnumMember(Value:="AM")>
        AM
        <EnumMember(Value:="AP")>
        AP
        <EnumMember(Value:="BA")>
        BA
        <EnumMember(Value:="CE")>
        CE
        <EnumMember(Value:="DF")>
        DF
        <EnumMember(Value:="ES")>
        ES
        <EnumMember(Value:="Go")>
        GO
        <EnumMember(Value:="MA")>
        MA
        <EnumMember(Value:="MG")>
        MG
        <EnumMember(Value:="MS")>
        MS
        <EnumMember(Value:="MT")>
        MT
        <EnumMember(Value:="PA")>
        PA
        <EnumMember(Value:="PB")>
        PB
        <EnumMember(Value:="PE")>
        PE
        <EnumMember(Value:="PI")>
        PI
        <EnumMember(Value:="PR")>
        PR
        <EnumMember(Value:="RJ")>
        RJ
        <EnumMember(Value:="RN")>
        RN
        <EnumMember(Value:="RO")>
        RO
        <EnumMember(Value:="RR")>
        RR
        <EnumMember(Value:="RS")>
        RS
        <EnumMember(Value:="SC")>
        SC
        <EnumMember(Value:="SE")>
        SE
        <EnumMember(Value:="SP")>
        SP
        <EnumMember(Value:="TO")>
        [TO]
        <EnumMember(Value:="EX")>
        EX
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDestIndIEDest
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ContribuinteICMS
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ContribuinteIsento
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        NaoContribuinte
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TLocal
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CNPJ As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CPF As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xNome As String
        Public Property xLgr As String
        Public Property nro As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xCpl As String
        Public Property xBairro As String
        Public Property cMun As String
        Public Property xMun As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property UF As TUf
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CEP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property cPais As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xPais As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property fone As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property email As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property IE As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeAutXML
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CNPJ As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CPF As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDet
        Public Property prod As TNFeInfNFeDetProd
        Public Property imposto As TNFeInfNFeDetImposto
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property impostoDevol As TNFeInfNFeDetImpostoDevol
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property infAdProd As String
        <XmlAttribute()>
        Public Property nItem As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProd
        Public Property cProd As String
        Public Property cEAN As String
        Public Property xProd As String
        Public Property NCM As String
        <XmlElement("NVE")>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property NVE As List(Of String)
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CEST As String
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property indEscala As TNFeInfNFeDetProdIndEscala
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property indEscalaSpecified As Boolean
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CNPJFab As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property cBenef As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property EXTIPI As String
        Public Property CFOP As String
        Public Property uCom As String
        Public Property qCom As String
        Public Property vUnCom As String
        Public Property vProd As String
        Public Property cEANTrib As String
        Public Property uTrib As String
        Public Property qTrib As String
        Public Property vUnTrib As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFrete As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vSeg As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vDesc As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vOutro As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property indTot As TNFeInfNFeDetProdIndTot
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xPed As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property nItemPed As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property nFCI As String
        <XmlElement("rastro")>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property rastro As List(Of TNFeInfNFeDetProdRastro)
        <XmlElement("DI")>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property DI As List(Of TNFeInfNFeDetProdDI)
        <XmlElement("detExport")>
        Public Property detExport As List(Of TNFeInfNFeDetProdDetExport)
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property veicProd As TNFeInfNFeDetProdVeicProd
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property med As TNFeInfNFeDetProdMed
        <XmlElement("arma")>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property arma As List(Of TNFeInfNFeDetProdArma)
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property comb As TNFeInfNFeDetProdComb
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property nRECOPI As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdIndEscala
        <EnumMember(Value:="S")>
        S
        <EnumMember(Value:="N")>
        N
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdIndTot
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        NaoCompoeTotal
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        CompoeTotal
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdDI
        Public Property nDI As String
        Public Property dDI As String
        Public Property xLocDesemb As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property UFDesemb As TUfEmi
        Public Property dDesemb As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpViaTransp As TNFeInfNFeDetProdDITpViaTransp
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vAFRMM As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpIntermedio As TNFeInfNFeDetProdDITpIntermedio
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CNPJ As String
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property UFTerceiro As TUfEmi
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property UFTerceiroSpecified As Boolean
        Public Property cExportador As String
        <XmlElement("adi")>
        Public Property adi As List(Of TNFeInfNFeDetProdDIAdi)
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdDITpViaTransp
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Maritima
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        Fluvial
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        Lacustre
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        Aerea
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Postal
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        Ferroviaria
        <EnumMember(Value:="7")>
        <XmlEnum("7")>
        Rodoviaria
        <EnumMember(Value:="8")>
        <XmlEnum("8")>
        Conduto_RedeTrasmissao
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        MeiosProprios
        <EnumMember(Value:="10")>
        <XmlEnum("10")>
        Entrada_SaidaFicta
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdDITpIntermedio
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ContaPropria
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ContaEOrdem
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        Encomenda
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdDIAdi
        Public Property nAdicao As String
        Public Property nSeqAdic As String
        Public Property cFabricante As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vDescDI As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property nDraw As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdDetExport
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property nDraw As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property exportInd As TNFeInfNFeDetProdDetExportExportInd
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdDetExportExportInd
        Public Property nRE As String
        Public Property chNFe As String
        Public Property qExport As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdRastro
        Public Property nLote As String
        Public Property qLote As String
        Public Property dFab As String
        Public Property dVal As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property cAgreg As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdArma
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpArma As TNFeInfNFeDetProdArmaTpArma
        Public Property nSerie As String
        Public Property nCano As String
        Public Property descr As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdArmaTpArma
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        UsoPermitido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        UsoRestrito
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdComb
        Public Property cProdANP As String
        Public Property descANP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pGLP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pGNn As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pGNi As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vPart As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CODIF As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property qTemp As String
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property UFCons As TUf
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property CIDE As TNFeInfNFeDetProdCombCIDE
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property encerrante As TNFeInfNFeDetProdCombEncerrante
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdCombCIDE
        Public Property qBCProd As String
        Public Property vAliqProd As String
        Public Property vCIDE As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdCombEncerrante
        Public Property nBico As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property nBomba As String
        Public Property nTanque As String
        Public Property vEncIni As String
        Public Property vEncFin As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdMed
        Public Property cProdANVISA As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property xMotivoIsencao As String
        Public Property vPMC As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetProdVeicProd
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpOp As TNFeInfNFeDetProdVeicProdTpOp
        Public Property chassi As String
        Public Property cCor As String
        Public Property xCor As String
        Public Property pot As String
        Public Property cilin As String
        Public Property pesoL As String
        Public Property pesoB As String
        Public Property nSerie As String
        Public Property tpComb As String
        Public Property nMotor As String
        Public Property CMT As String
        Public Property dist As String
        Public Property anoMod As String
        Public Property anoFab As String
        Public Property tpPint As String
        Public Property tpVeic As String
        Public Property espVeic As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property VIN As TNFeInfNFeDetProdVeicProdVIN
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property condVeic As TNFeInfNFeDetProdVeicProdCondVeic
        Public Property cMod As String
        Public Property cCorDENATRAN As String
        Public Property lota As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpRest As TNFeInfNFeDetProdVeicProdTpRest
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdVeicProdTpOp
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        Outros
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        VendaConcessionaria
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        FaturamentoConsumidorFinal
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        VendaGrandesConsumidores
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdVeicProdVIN
        <EnumMember(Value:="R")>
        R
        <EnumMember(Value:="N")>
        N
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdVeicProdCondVeic
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Acabado
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        Inacabado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        Semiacabado
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetProdVeicProdTpRest
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        NaoHa
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        AlienacaoFiduciaria
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ArrendamentoMercantil
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ReservaDominio
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        PenhorVeiculos
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        Outras
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImposto
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vTotTrib As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS As TNFeInfNFeDetImpostoICMS
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property II As TNFeInfNFeDetImpostoII
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property IPI As TIpi
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ISSQN As TNFeInfNFeDetImpostoISSQN
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property PIS As TNFeInfNFeDetImpostoPIS
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property PISST As TNFeInfNFeDetImpostoPISST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property COFINS As TNFeInfNFeDetImpostoCOFINS
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property COFINSST As TNFeInfNFeDetImpostoCOFINSST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSUFDest As TNFeInfNFeDetImpostoICMSUFDest
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMS
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS00 As TNFeInfNFeDetImpostoICMSICMS00
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS10 As TNFeInfNFeDetImpostoICMSICMS10
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS20 As TNFeInfNFeDetImpostoICMSICMS20
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS30 As TNFeInfNFeDetImpostoICMSICMS30
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS40 As TNFeInfNFeDetImpostoICMSICMS40
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS51 As TNFeInfNFeDetImpostoICMSICMS51
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS60 As TNFeInfNFeDetImpostoICMSICMS60
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS70 As TNFeInfNFeDetImpostoICMSICMS70
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMS90 As TNFeInfNFeDetImpostoICMSICMS90
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSPart As TNFeInfNFeDetImpostoICMSICMSPart
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSSN101 As TNFeInfNFeDetImpostoICMSICMSSN101
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSSN102 As TNFeInfNFeDetImpostoICMSICMSSN102
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSSN201 As TNFeInfNFeDetImpostoICMSICMSSN201
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSSN202 As TNFeInfNFeDetImpostoICMSICMSSN202
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSSN500 As TNFeInfNFeDetImpostoICMSICMSSN500
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSSN900 As TNFeInfNFeDetImpostoICMSICMSSN900
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ICMSST As TNFeInfNFeDetImpostoICMSICMSST
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS00
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS00CST
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS00ModBC
        Public Property vBC As String
        Public Property pICMS As String
        Public Property vICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCP As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum Torig
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        Nacional
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        EstrangeiraImportacaoDireta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        EstrangeiraMercadoInterno
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        NacionalImportacaoSup40ouIgual70
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        NacionalAjustes
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        NacionalImportacaoIgualouInf40
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        EstrangeiraImportacaoDiretaCAMEXEGasNatural
        <EnumMember(Value:="7")>
        <XmlEnum("7")>
        EstrangeiraMercadoInternoCAMEXEGasNatural
        <EnumMember(Value:="8")>
        <XmlEnum("8")>
        NacionalImportacaoSup70
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS00CST
        <EnumMember(Value:="00")>
        <XmlEnum("00")>
        CST00
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS00ModBC
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        MargemValAgregado
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Pauta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        PrecoMaxTabelado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ValorDaOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS10
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS10CST
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS10ModBC
        Public Property vBC As String
        Public Property pICMS As String
        Public Property vICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCP As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMS10ModBCST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pMVAST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPST As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS10CST
        <EnumMember(Value:="10")>
        <XmlEnum("10")>
        CST10
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS10ModBC
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        MargemValAgregado
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Pauta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        PrecoMaxTabelado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ValorDaOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS10ModBCST
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PrecoTabeladoOuMaxSugerido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ListaNegativa
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ListaPositiva
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ListaNeutra
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        MargemValorAgregado
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Pauta
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ValorOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS20
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS20CST
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS20ModBC
        Public Property pRedBC As String
        Public Property vBC As String
        Public Property pICMS As String
        Public Property vICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSDeson As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS20CST
        <EnumMember(Value:="20")>
        <XmlEnum("20")>
        CST20
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS20ModBC
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        MargemValAgregado
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Pauta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        PrecoMaxTabelado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ValorDaOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        UsoAgropecuaria
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        Outros
        <EnumMember(Value:="12")>
        <XmlEnum("12")>
        OrgaoFomentoDevAgropecuario
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS30
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS30CST
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMS30ModBCST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pMVAST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCST As String
        Public Property vBCST As String
        Public Property pICMSST As String
        Public Property vICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSDeson As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS30CST
        <EnumMember(Value:="30")>
        <XmlEnum("30")>
        CST30
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PrecoTabeladoOuMaxSugerido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ListaNegativa
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ListaPositiva
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ListaNeutra
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        MargemValorAgregado
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Pauta
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ValorOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        UtilitariosMotosAmazoniaEAreasLivreComercio
        <EnumMember(Value:="7")>
        <XmlEnum("7")>
        SUFRAMA
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        Outros
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS40
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS40CST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSDeson As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS40CST
        <EnumMember(Value:="40")>
        <XmlEnum("40")>
        CST40
        <EnumMember(Value:="41")>
        <XmlEnum("41")>
        CST41
        <EnumMember(Value:="50")>
        <XmlEnum("50")>
        CST50
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Taxi
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ProdutorAgropecurio
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        Frotista_Locadora
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Diplomatico_Consular
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        UtilitariosMotosAmazoniaEAreasLivreComercio
        <EnumMember(Value:="7")>
        <XmlEnum("7")>
        SUFRAMA
        <EnumMember(Value:="8")>
        <XmlEnum("8")>
        VendaOrgaoPublico
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        Outros
        <EnumMember(Value:="10")>
        <XmlEnum("10")>
        DeficienteCondutor
        <EnumMember(Value:="11")>
        <XmlEnum("11")>
        DeficienteNaoCondutor
        <EnumMember(Value:="16")>
        <XmlEnum("16")>
        OliempiedasRio2016
        <EnumMember(Value:="90")>
        <XmlEnum("90")>
        SolicitadaFiscoRevogadaVersao301
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS51
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS51CST
        <JsonConverter(GetType(StringEnumConverter))>
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS51ModBC
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property modBCSpecified As Boolean
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBC As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBC As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSOp As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pDif As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSDif As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCP As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS51CST
        <EnumMember(Value:="51")>
        <XmlEnum("51")>
        CST51
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS51ModBC
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        MargemValAgregado
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Pauta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        PrecoMaxTabelado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ValorDaOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS60
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS60CST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSSubstituto As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMSEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSEfet As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS60CST
        <EnumMember(Value:="60")>
        <XmlEnum("60")>
        CST60
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS70
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS70CST
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS70ModBC
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBC As String
        Public Property vBC As String
        Public Property pICMS As String
        Public Property vICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCP As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMS70ModBCST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pMVAST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSDeson As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70CST
        <EnumMember(Value:="70")>
        <XmlEnum("70")>
        CST70
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70ModBC
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        MargemValAgregado
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Pauta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        PrecoMaxTabelado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ValorDaOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PrecoTabeladoOuMaxSugerido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ListaNegativa
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ListaPositiva
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ListaNeutra
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        MargemValorAgregado
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Pauta
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ValorOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        UsoAgropecuaria
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        Outros
        <EnumMember(Value:="12")>
        <XmlEnum("12")>
        OrgaoFomentoDevAgropecuario
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMS90
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMS90CST
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMS90ModBC
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBC As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBC As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCP As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMS90ModBCST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pMVAST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSDeson As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property motDesICMS As TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90CST
        <EnumMember(Value:="90")>
        <XmlEnum("90")>
        CST90
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90ModBC
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        MargemValAgregado
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Pauta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        PrecoMaxTabelado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ValorDaOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PrecoTabeladoOuMaxSugerido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ListaNegativa
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ListaPositiva
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ListaNeutra
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        MargemValorAgregado
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Pauta
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ValorOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        UsoAgropecuaria
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        Outros
        <EnumMember(Value:="12")>
        <XmlEnum("12")>
        OrgaoFomentoDevAgropecuario
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSPart
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMSPartCST
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMSPartModBC
        Public Property vBC As String
        Public Property pRedBC As String
        Public Property pICMS As String
        Public Property vICMS As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMSPartModBCST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pMVAST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCST As String
        Public Property vBCST As String
        Public Property pICMSST As String
        Public Property vICMSST As String
        Public Property pBCOp As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property UFST As TUf
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSPartCST
        <EnumMember(Value:="10")>
        <XmlEnum("10")>
        CST10
        <EnumMember(Value:="90")>
        <XmlEnum("90")>
        CST90
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSPartModBC
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        MargemValAgregado
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Pauta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        PrecoMaxTabelado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ValorDaOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PrecoTabeladoOuMaxSugerido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ListaNegativa
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ListaPositiva
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ListaNeutra
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        MargemValorAgregado
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Pauta
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ValorOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN101
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
        Public Property pCredSN As String
        Public Property vCredICMSSN As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
        <EnumMember(Value:="101")>
        <XmlEnum("101")>
        CSOSN101
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN102
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
        <EnumMember(Value:="102")>
        <XmlEnum("102")>
        CSOSN102
        <EnumMember(Value:="103")>
        <XmlEnum("103")>
        CSOSN103
        <EnumMember(Value:="300")>
        <XmlEnum("300")>
        CSOSN300
        <EnumMember(Value:="400")>
        <XmlEnum("400")>
        CSOSN400
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN201
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pMVAST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCST As String
        Public Property vBCST As String
        Public Property pICMSST As String
        Public Property vICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pCredSN As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vCredICMSSN As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
        <EnumMember(Value:="201")>
        <XmlEnum("201")>
        CSOSN201
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PrecoTabeladoOuMaxSugerido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ListaNegativa
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ListaPositiva
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ListaNeutra
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        MargemValorAgregado
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Pauta
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ValorOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN202
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pMVAST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCST As String
        Public Property vBCST As String
        Public Property pICMSST As String
        Public Property vICMSST As String
        Public Property vBCFCPST As String
        Public Property pFCPST As String
        Public Property vFCPST As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
        <EnumMember(Value:="202")>
        <XmlEnum("202")>
        CSOSN202
        <EnumMember(Value:="203")>
        <XmlEnum("203")>
        CSOSN203
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PrecoTabeladoOuMaxSugerido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ListaNegativa
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ListaPositiva
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ListaNeutra
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        MargemValorAgregado
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Pauta
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ValorOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN500
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSSubstituto As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMSEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSEfet As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
        <EnumMember(Value:="500")>
        <XmlEnum("500")>
        CSOSN500
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSSN900
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CSOSN As TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBC As TNFeInfNFeDetImpostoICMSICMSSN900ModBC
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBC As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBC As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMS As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modBCST As TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pMVAST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pCredSN As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vCredICMSSN As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
        <EnumMember(Value:="900")>
        <XmlEnum("900")>
        CST900
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        MargemValAgregado
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Pauta
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        PrecoMaxTabelado
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ValorDaOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PrecoTabeladoOuMaxSugerido
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ListaNegativa
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ListaPositiva
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        ListaNeutra
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        MargemValorAgregado
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Pauta
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ValorOperacao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSICMSST
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property orig As Torig
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoICMSICMSSTCST
        Public Property vBCSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pST As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSSubstituto As String
        Public Property vICMSSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vFCPSTRet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCSTDest As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSSTDest As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pRedBCEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vBCEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property pICMSEfet As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore)>
        Public Property vICMSEfet As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSICMSSTCST
        <EnumMember(Value:="41")>
        <XmlEnum("41")>
        CST41
        <EnumMember(Value:="60")>
        <XmlEnum("60")>
        CST60
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoII
        Public Property vBC As String
        Public Property vDespAdu As String
        Public Property vII As String
        Public Property vIOF As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TIpi
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore, Required:=Required.AllowNull)>
        Public Property CNPJProd As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore, Required:=Required.AllowNull)>
        Public Property cSelo As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore, Required:=Required.AllowNull)>
        Public Property qSelo As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore, Required:=Required.Always)>
        Public Property cEnq As String
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore, Required:=Required.Always)>
        Public Property IPINT As TIpiIPINT
        <JsonProperty(NullValueHandling:=NullValueHandling.Ignore, Required:=Required.Always)>
        Public Property IPITrib As TIpiIPITrib
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TIpiIPINT
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TIpiIPINTCST
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TIpiIPINTCST
        <EnumMember(Value:="01")>
        <XmlEnum("01")>
        CST01
        <EnumMember(Value:="02")>
        <XmlEnum("02")>
        CST02
        <EnumMember(Value:="03")>
        <XmlEnum("03")>
        CST03
        <EnumMember(Value:="04")>
        <XmlEnum("04")>
        CST04
        <EnumMember(Value:="05")>
        <XmlEnum("05")>
        CST05
        <EnumMember(Value:="51")>
        <XmlEnum("51")>
        CST51
        <EnumMember(Value:="52")>
        <XmlEnum("52")>
        CST52
        <EnumMember(Value:="53")>
        <XmlEnum("53")>
        CST53
        <EnumMember(Value:="54")>
        <XmlEnum("54")>
        CST54
        <EnumMember(Value:="55")>
        <XmlEnum("55")>
        CST55
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TIpiIPITrib
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TIpiIPITribCST
        Public Property pIPI As String
        Public Property qUnid As String
        Public Property vBC As String
        Public Property vUnid As String
        Public Property vIPI As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TIpiIPITribCST
        <EnumMember(Value:="00")>
        <XmlEnum("00")>
        CST00
        <EnumMember(Value:="49")>
        <XmlEnum("49")>
        CST49
        <EnumMember(Value:="50")>
        <XmlEnum("50")>
        CST50
        <EnumMember(Value:="99")>
        <XmlEnum("99")>
        CST99
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoISSQN
        Public Property vBC As String
        Public Property vAliq As String
        Public Property vISSQN As String
        Public Property cMunFG As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property cListServ As TCListServ
        Public Property vDeducao As String
        Public Property vOutro As String
        Public Property vDescIncond As String
        Public Property vDescCond As String
        Public Property vISSRet As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property indISS As TNFeInfNFeDetImpostoISSQNIndISS
        Public Property cServico As String
        Public Property cMun As String
        Public Property cPais As String
        Public Property nProcesso As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property indIncentivo As TNFeInfNFeDetImpostoISSQNIndIncentivo
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TCListServ
        <EnumMember(Value:="01.01")>
        <XmlEnum("01.01")>
        Item0101
        <EnumMember(Value:="01.02")>
        <XmlEnum("01.02")>
        Item0102
        <EnumMember(Value:="01.03")>
        <XmlEnum("01.03")>
        Item0103
        <EnumMember(Value:="01.04")>
        <XmlEnum("01.04")>
        Item0104
        <EnumMember(Value:="01.05")>
        <XmlEnum("01.05")>
        Item0105
        <EnumMember(Value:="01.06")>
        <XmlEnum("01.06")>
        Item0106
        <EnumMember(Value:="01.07")>
        <XmlEnum("01.07")>
        Item0107
        <EnumMember(Value:="01.08")>
        <XmlEnum("01.08")>
        Item0108
        <EnumMember(Value:="01.09")>
        <XmlEnum("01.09")>
        Item0109
        <EnumMember(Value:="02.01")>
        <XmlEnum("02.01")>
        Item0201
        <EnumMember(Value:="03.02")>
        <XmlEnum("03.02")>
        Item0302
        <EnumMember(Value:="03.03")>
        <XmlEnum("03.03")>
        Item0303
        <EnumMember(Value:="03.04")>
        <XmlEnum("03.04")>
        Item0304
        <EnumMember(Value:="03.05")>
        <XmlEnum("03.05")>
        Item0305
        <EnumMember(Value:="04.01")>
        <XmlEnum("04.01")>
        Item0401
        <EnumMember(Value:="04.02")>
        <XmlEnum("04.02")>
        Item0402
        <EnumMember(Value:="04.03")>
        <XmlEnum("04.03")>
        Item0403
        <EnumMember(Value:="04.04")>
        <XmlEnum("04.04")>
        Item0404
        <EnumMember(Value:="04.05")>
        <XmlEnum("04.05")>
        Item0405
        <EnumMember(Value:="04.06")>
        <XmlEnum("04.06")>
        Item0406
        <EnumMember(Value:="04.07")>
        <XmlEnum("04.07")>
        Item0407
        <EnumMember(Value:="04.08")>
        <XmlEnum("04.08")>
        Item0408
        <EnumMember(Value:="04.09")>
        <XmlEnum("04.09")>
        Item0409
        <EnumMember(Value:="04.10")>
        <XmlEnum("04.10")>
        Item0410
        <EnumMember(Value:="04.11")>
        <XmlEnum("04.11")>
        Item0411
        <EnumMember(Value:="04.12")>
        <XmlEnum("04.12")>
        Item0412
        <EnumMember(Value:="04.13")>
        <XmlEnum("04.13")>
        Item0413
        <EnumMember(Value:="04.14")>
        <XmlEnum("04.14")>
        Item0414
        <EnumMember(Value:="04.15")>
        <XmlEnum("04.15")>
        Item0415
        <EnumMember(Value:="04.16")>
        <XmlEnum("04.16")>
        Item0416
        <EnumMember(Value:="04.17")>
        <XmlEnum("04.17")>
        Item0417
        <EnumMember(Value:="04.18")>
        <XmlEnum("04.18")>
        Item0418
        <EnumMember(Value:="04.19")>
        <XmlEnum("04.19")>
        Item0419
        <EnumMember(Value:="04.20")>
        <XmlEnum("04.20")>
        Item0420
        <EnumMember(Value:="04.21")>
        <XmlEnum("04.21")>
        Item0421
        <EnumMember(Value:="04.22")>
        <XmlEnum("04.22")>
        Item0422
        <EnumMember(Value:="04.23")>
        <XmlEnum("04.23")>
        Item0423
        <EnumMember(Value:="05.01")>
        <XmlEnum("05.01")>
        Item0501
        <EnumMember(Value:="05.02")>
        <XmlEnum("05.02")>
        Item0502
        <EnumMember(Value:="05.03")>
        <XmlEnum("05.03")>
        Item0503
        <EnumMember(Value:="05.04")>
        <XmlEnum("05.04")>
        Item0504
        <EnumMember(Value:="05.05")>
        <XmlEnum("05.05")>
        Item0505
        <EnumMember(Value:="05.06")>
        <XmlEnum("05.06")>
        Item0506
        <EnumMember(Value:="05.07")>
        <XmlEnum("05.07")>
        Item0507
        <EnumMember(Value:="05.08")>
        <XmlEnum("05.08")>
        Item0508
        <EnumMember(Value:="05.09")>
        <XmlEnum("05.09")>
        Item0509
        <EnumMember(Value:="06.01")>
        <XmlEnum("06.01")>
        Item0601
        <EnumMember(Value:="06.02")>
        <XmlEnum("06.02")>
        Item0602
        <EnumMember(Value:="06.03")>
        <XmlEnum("06.03")>
        Item0603
        <EnumMember(Value:="06.04")>
        <XmlEnum("06.04")>
        Item0604
        <EnumMember(Value:="06.05")>
        <XmlEnum("06.05")>
        Item0605
        <EnumMember(Value:="06.06")>
        <XmlEnum("06.06")>
        Item0606
        <EnumMember(Value:="07.01")>
        <XmlEnum("07.01")>
        Item0701
        <EnumMember(Value:="07.02")>
        <XmlEnum("07.02")>
        Item0702
        <EnumMember(Value:="07.03")>
        <XmlEnum("07.03")>
        Item0703
        <EnumMember(Value:="07.04")>
        <XmlEnum("07.04")>
        Item0704
        <EnumMember(Value:="07.05")>
        <XmlEnum("07.05")>
        Item0705
        <EnumMember(Value:="07.06")>
        <XmlEnum("07.06")>
        Item0706
        <EnumMember(Value:="07.07")>
        <XmlEnum("07.07")>
        Item0707
        <EnumMember(Value:="07.08")>
        <XmlEnum("07.08")>
        Item0708
        <EnumMember(Value:="07.09")>
        <XmlEnum("07.09")>
        Item0709
        <EnumMember(Value:="07.10")>
        <XmlEnum("07.10")>
        Item0710
        <EnumMember(Value:="07.11")>
        <XmlEnum("07.11")>
        Item0711
        <EnumMember(Value:="07.12")>
        <XmlEnum("07.12")>
        Item0712
        <EnumMember(Value:="07.13")>
        <XmlEnum("07.13")>
        Item0713
        <EnumMember(Value:="07.16")>
        <XmlEnum("07.16")>
        Item0716
        <EnumMember(Value:="07.17")>
        <XmlEnum("07.17")>
        Item0717
        <EnumMember(Value:="07.18")>
        <XmlEnum("07.18")>
        Item0718
        <EnumMember(Value:="07.19")>
        <XmlEnum("07.19")>
        Item0719
        <EnumMember(Value:="07.20")>
        <XmlEnum("07.20")>
        Item0720
        <EnumMember(Value:="07.21")>
        <XmlEnum("07.21")>
        Item0721
        <EnumMember(Value:="07.22")>
        <XmlEnum("07.22")>
        Item0722
        <EnumMember(Value:="08.01")>
        <XmlEnum("08.01")>
        Item0801
        <EnumMember(Value:="08.02")>
        <XmlEnum("08.02")>
        Item0802
        <EnumMember(Value:="09.01")>
        <XmlEnum("09.01")>
        Item0901
        <EnumMember(Value:="09.02")>
        <XmlEnum("09.02")>
        Item0902
        <EnumMember(Value:="09.03")>
        <XmlEnum("09.03")>
        Item0903
        <EnumMember(Value:="10.01")>
        <XmlEnum("10.01")>
        Item1001
        <EnumMember(Value:="10.02")>
        <XmlEnum("10.02")>
        Item1002
        <EnumMember(Value:="10.03")>
        <XmlEnum("10.03")>
        Item1003
        <EnumMember(Value:="10.04")>
        <XmlEnum("10.04")>
        Item1004
        <EnumMember(Value:="10.05")>
        <XmlEnum("10.05")>
        Item1005
        <EnumMember(Value:="10.06")>
        <XmlEnum("10.06")>
        Item1006
        <EnumMember(Value:="10.07")>
        <XmlEnum("10.07")>
        Item1007
        <EnumMember(Value:="10.08")>
        <XmlEnum("10.08")>
        Item1008
        <EnumMember(Value:="10.09")>
        <XmlEnum("10.09")>
        Item1009
        <EnumMember(Value:="10.10")>
        <XmlEnum("10.10")>
        Item1010
        <EnumMember(Value:="11.01")>
        <XmlEnum("11.01")>
        Item1101
        <EnumMember(Value:="11.02")>
        <XmlEnum("11.02")>
        Item1102
        <EnumMember(Value:="11.03")>
        <XmlEnum("11.03")>
        Item1103
        <EnumMember(Value:="11.04")>
        <XmlEnum("11.04")>
        Item1104
        <EnumMember(Value:="12.01")>
        <XmlEnum("12.01")>
        Item1201
        <EnumMember(Value:="12.02")>
        <XmlEnum("12.02")>
        Item1202
        <EnumMember(Value:="12.03")>
        <XmlEnum("12.03")>
        Item1203
        <EnumMember(Value:="12.04")>
        <XmlEnum("12.04")>
        Item1204
        <EnumMember(Value:="12.05")>
        <XmlEnum("12.05")>
        Item1205
        <EnumMember(Value:="12.06")>
        <XmlEnum("12.06")>
        Item1206
        <EnumMember(Value:="12.07")>
        <XmlEnum("12.07")>
        Item1207
        <EnumMember(Value:="12.08")>
        <XmlEnum("12.08")>
        Item1208
        <EnumMember(Value:="12.09")>
        <XmlEnum("12.09")>
        Item1209
        <EnumMember(Value:="12.10")>
        <XmlEnum("12.10")>
        Item1210
        <EnumMember(Value:="12.11")>
        <XmlEnum("12.11")>
        Item1211
        <EnumMember(Value:="12.12")>
        <XmlEnum("12.12")>
        Item1212
        <EnumMember(Value:="12.13")>
        <XmlEnum("12.13")>
        Item1213
        <EnumMember(Value:="12.14")>
        <XmlEnum("12.14")>
        Item1214
        <EnumMember(Value:="12.15")>
        <XmlEnum("12.15")>
        Item1215
        <EnumMember(Value:="12.16")>
        <XmlEnum("12.16")>
        Item1216
        <EnumMember(Value:="12.17")>
        <XmlEnum("12.17")>
        Item1217
        <EnumMember(Value:="13.02")>
        <XmlEnum("13.02")>
        Item1302
        <EnumMember(Value:="13.03")>
        <XmlEnum("13.03")>
        Item1303
        <EnumMember(Value:="13.04")>
        <XmlEnum("13.04")>
        Item1304
        <EnumMember(Value:="13.05")>
        <XmlEnum("13.05")>
        Item1305
        <EnumMember(Value:="14.01")>
        <XmlEnum("14.01")>
        Item1401
        <EnumMember(Value:="14.02")>
        <XmlEnum("14.02")>
        Item1402
        <EnumMember(Value:="14.03")>
        <XmlEnum("14.03")>
        Item1403
        <EnumMember(Value:="14.04")>
        <XmlEnum("14.04")>
        Item1404
        <EnumMember(Value:="14.05")>
        <XmlEnum("14.05")>
        Item1405
        <EnumMember(Value:="14.06")>
        <XmlEnum("14.06")>
        Item1406
        <EnumMember(Value:="14.07")>
        <XmlEnum("14.07")>
        Item1407
        <EnumMember(Value:="14.08")>
        <XmlEnum("14.08")>
        Item1408
        <EnumMember(Value:="14.09")>
        <XmlEnum("14.09")>
        Item1409
        <EnumMember(Value:="14.10")>
        <XmlEnum("14.10")>
        Item1410
        <EnumMember(Value:="14.11")>
        <XmlEnum("14.11")>
        Item1411
        <EnumMember(Value:="14.12")>
        <XmlEnum("14.12")>
        Item1412
        <EnumMember(Value:="14.13")>
        <XmlEnum("14.13")>
        Item1413
        <EnumMember(Value:="14.14")>
        <XmlEnum("14.14")>
        Item1414
        <EnumMember(Value:="15.01")>
        <XmlEnum("15.01")>
        Item1501
        <EnumMember(Value:="15.02")>
        <XmlEnum("15.02")>
        Item1502
        <EnumMember(Value:="15.03")>
        <XmlEnum("15.03")>
        Item1503
        <EnumMember(Value:="15.04")>
        <XmlEnum("15.04")>
        Item1504
        <EnumMember(Value:="15.05")>
        <XmlEnum("15.05")>
        Item1505
        <EnumMember(Value:="15.06")>
        <XmlEnum("15.06")>
        Item1506
        <EnumMember(Value:="15.07")>
        <XmlEnum("15.07")>
        Item1507
        <EnumMember(Value:="15.08")>
        <XmlEnum("15.08")>
        Item1508
        <EnumMember(Value:="15.09")>
        <XmlEnum("15.09")>
        Item1509
        <EnumMember(Value:="15.10")>
        <XmlEnum("15.10")>
        Item1510
        <EnumMember(Value:="15.11")>
        <XmlEnum("15.11")>
        Item1511
        <EnumMember(Value:="15.12")>
        <XmlEnum("15.12")>
        Item1512
        <EnumMember(Value:="15.13")>
        <XmlEnum("15.13")>
        Item1513
        <EnumMember(Value:="15.14")>
        <XmlEnum("15.14")>
        Item1514
        <EnumMember(Value:="15.15")>
        <XmlEnum("15.15")>
        Item1515
        <EnumMember(Value:="15.16")>
        <XmlEnum("15.16")>
        Item1516
        <EnumMember(Value:="15.17")>
        <XmlEnum("15.17")>
        Item1517
        <EnumMember(Value:="15.18")>
        <XmlEnum("15.18")>
        Item1518
        <EnumMember(Value:="16.01")>
        <XmlEnum("16.01")>
        Item1601
        <EnumMember(Value:="16.02")>
        <XmlEnum("16.02")>
        Item1602
        <EnumMember(Value:="17.01")>
        <XmlEnum("17.01")>
        Item1701
        <EnumMember(Value:="17.02")>
        <XmlEnum("17.02")>
        Item1702
        <EnumMember(Value:="17.03")>
        <XmlEnum("17.03")>
        Item1703
        <EnumMember(Value:="17.04")>
        <XmlEnum("17.04")>
        Item1704
        <EnumMember(Value:="17.05")>
        <XmlEnum("17.05")>
        Item1705
        <EnumMember(Value:="17.06")>
        <XmlEnum("17.06")>
        Item1706
        <EnumMember(Value:="17.08")>
        <XmlEnum("17.08")>
        Item1708
        <EnumMember(Value:="17.09")>
        <XmlEnum("17.09")>
        Item1709
        <EnumMember(Value:="17.10")>
        <XmlEnum("17.10")>
        Item1710
        <EnumMember(Value:="17.11")>
        <XmlEnum("17.11")>
        Item1711
        <EnumMember(Value:="17.12")>
        <XmlEnum("17.12")>
        Item1712
        <EnumMember(Value:="17.13")>
        <XmlEnum("17.13")>
        Item1713
        <EnumMember(Value:="17.14")>
        <XmlEnum("17.14")>
        Item1714
        <EnumMember(Value:="17.15")>
        <XmlEnum("17.15")>
        Item1715
        <EnumMember(Value:="17.16")>
        <XmlEnum("17.16")>
        Item1716
        <EnumMember(Value:="17.17")>
        <XmlEnum("17.17")>
        Item1717
        <EnumMember(Value:="17.18")>
        <XmlEnum("17.18")>
        Item1718
        <EnumMember(Value:="17.19")>
        <XmlEnum("17.19")>
        Item1719
        <EnumMember(Value:="17.20")>
        <XmlEnum("17.20")>
        Item1720
        <EnumMember(Value:="17.21")>
        <XmlEnum("17.21")>
        Item1721
        <EnumMember(Value:="17.22")>
        <XmlEnum("17.22")>
        Item1722
        <EnumMember(Value:="17.23")>
        <XmlEnum("17.23")>
        Item1723
        <EnumMember(Value:="17.24")>
        <XmlEnum("17.24")>
        Item1724
        <EnumMember(Value:="17.25")>
        <XmlEnum("17.25")>
        Item1725
        <EnumMember(Value:="18.01")>
        <XmlEnum("18.01")>
        Item1801
        <EnumMember(Value:="19.01")>
        <XmlEnum("19.01")>
        Item1901
        <EnumMember(Value:="20.01")>
        <XmlEnum("20.01")>
        Item2001
        <EnumMember(Value:="20.02")>
        <XmlEnum("20.02")>
        Item2002
        <EnumMember(Value:="20.03")>
        <XmlEnum("20.03")>
        Item2003
        <EnumMember(Value:="21.01")>
        <XmlEnum("21.01")>
        Item2101
        <EnumMember(Value:="22.01")>
        <XmlEnum("22.01")>
        Item2201
        <EnumMember(Value:="23.01")>
        <XmlEnum("23.01")>
        Item2301
        <EnumMember(Value:="24.01")>
        <XmlEnum("24.01")>
        Item2401
        <EnumMember(Value:="25.01")>
        <XmlEnum("25.01")>
        Item2501
        <EnumMember(Value:="25.02")>
        <XmlEnum("25.02")>
        Item2502
        <EnumMember(Value:="25.03")>
        <XmlEnum("25.03")>
        Item2503
        <EnumMember(Value:="25.04")>
        <XmlEnum("25.04")>
        Item2504
        <EnumMember(Value:="25.05")>
        <XmlEnum("25.05")>
        Item2505
        <EnumMember(Value:="26.01")>
        <XmlEnum("26.01")>
        Item2601
        <EnumMember(Value:="27.01")>
        <XmlEnum("27.01")>
        Item2701
        <EnumMember(Value:="28.01")>
        <XmlEnum("28.01")>
        Item2801
        <EnumMember(Value:="29.01")>
        <XmlEnum("29.01")>
        Item2901
        <EnumMember(Value:="30.01")>
        <XmlEnum("30.01")>
        Item3001
        <EnumMember(Value:="31.01")>
        <XmlEnum("31.01")>
        Item3101
        <EnumMember(Value:="32.01")>
        <XmlEnum("32.01")>
        Item3201
        <EnumMember(Value:="33.01")>
        <XmlEnum("33.01")>
        Item3301
        <EnumMember(Value:="34.01")>
        <XmlEnum("34.01")>
        Item3401
        <EnumMember(Value:="35.01")>
        <XmlEnum("35.01")>
        Item3501
        <EnumMember(Value:="36.01")>
        <XmlEnum("36.01")>
        Item3601
        <EnumMember(Value:="37.01")>
        <XmlEnum("37.01")>
        Item3701
        <EnumMember(Value:="38.01")>
        <XmlEnum("38.01")>
        Item3801
        <EnumMember(Value:="39.01")>
        <XmlEnum("39.01")>
        Item3901
        <EnumMember(Value:="40.01")>
        <XmlEnum("40.01")>
        Item4001
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoISSQNIndISS
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Exigivel
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        NaoIcidencia
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        Isencao
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        Exportacao
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        Imunidade
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ExigibilidadeSuspensaDecisaoJudicial
        <EnumMember(Value:="7")>
        <XmlEnum("7")>
        ExigibilidadeSuspensaProcessoAdministrativo
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoISSQNIndIncentivo
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Sim
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        Nao
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPIS
        Public Property PISAliq As TNFeInfNFeDetImpostoPISPISAliq
        Public Property PISNT As TNFeInfNFeDetImpostoPISPISNT
        Public Property PISOutr As TNFeInfNFeDetImpostoPISPISOutr
        Public Property PISQtde As TNFeInfNFeDetImpostoPISPISQtde
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISPISAliq
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoPISPISAliqCST
        Public Property vBC As String
        Public Property pPIS As String
        Public Property vPIS As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISPISAliqCST
        <EnumMember(Value:="01")>
        <XmlEnum("01")>
        CST01
        <EnumMember(Value:="02")>
        <XmlEnum("02")>
        CST02
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISPISNT
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoPISPISNTCST
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISPISNTCST
        <EnumMember(Value:="04")>
        <XmlEnum("04")>
        CST04
        <EnumMember(Value:="05")>
        <XmlEnum("05")>
        CST05
        <EnumMember(Value:="06")>
        <XmlEnum("06")>
        CST06
        <EnumMember(Value:="07")>
        <XmlEnum("07")>
        CST07
        <EnumMember(Value:="08")>
        <XmlEnum("08")>
        CST08
        <EnumMember(Value:="09")>
        <XmlEnum("09")>
        CST09
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISPISOutr
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoPISPISOutrCST
        Public Property pPIS As String
        Public Property qBCProd As String
        Public Property vAliqProd As String
        Public Property vBC As String
        Public Property vPIS As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISPISOutrCST
        <EnumMember(Value:="49")>
        <XmlEnum("49")>
        CST49
        <EnumMember(Value:="50")>
        <XmlEnum("50")>
        CST50
        <EnumMember(Value:="51")>
        <XmlEnum("51")>
        CST51
        <EnumMember(Value:="52")>
        <XmlEnum("52")>
        CST52
        <EnumMember(Value:="53")>
        <XmlEnum("53")>
        CST53
        <EnumMember(Value:="54")>
        <XmlEnum("54")>
        CST54
        <EnumMember(Value:="55")>
        <XmlEnum("55")>
        CST55
        <EnumMember(Value:="56")>
        <XmlEnum("56")>
        CST56
        <EnumMember(Value:="60")>
        <XmlEnum("60")>
        CST60
        <EnumMember(Value:="61")>
        <XmlEnum("61")>
        CST61
        <EnumMember(Value:="62")>
        <XmlEnum("62")>
        CST62
        <EnumMember(Value:="63")>
        <XmlEnum("63")>
        CST63
        <EnumMember(Value:="64")>
        <XmlEnum("64")>
        CST64
        <EnumMember(Value:="65")>
        <XmlEnum("65")>
        CST65
        <EnumMember(Value:="66")>
        <XmlEnum("66")>
        CST66
        <EnumMember(Value:="67")>
        <XmlEnum("67")>
        CST67
        <EnumMember(Value:="70")>
        <XmlEnum("70")>
        CST70
        <EnumMember(Value:="71")>
        <XmlEnum("71")>
        CST71
        <EnumMember(Value:="72")>
        <XmlEnum("72")>
        CST72
        <EnumMember(Value:="73")>
        <XmlEnum("73")>
        CST73
        <EnumMember(Value:="74")>
        <XmlEnum("74")>
        CST74
        <EnumMember(Value:="75")>
        <XmlEnum("75")>
        CST75
        <EnumMember(Value:="98")>
        <XmlEnum("98")>
        CST98
        <EnumMember(Value:="99")>
        <XmlEnum("99")>
        CST99
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISPISQtde
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoPISPISQtdeCST
        Public Property qBCProd As String
        Public Property vAliqProd As String
        Public Property vPIS As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoPISPISQtdeCST
        <EnumMember(Value:="03")>
        <XmlEnum("03")>
        CST03
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoPISST
        Public Property pPIS As String
        Public Property qBCProd As String
        Public Property vAliqProd As String
        Public Property vBC As String
        Public Property vPIS As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINS
        Public Property COFINSAliq As TNFeInfNFeDetImpostoCOFINSCOFINSAliq
        Public Property COFINSNT As TNFeInfNFeDetImpostoCOFINSCOFINSNT
        Public Property COFINSOutr As TNFeInfNFeDetImpostoCOFINSCOFINSOutr
        Public Property COFINSQtde As TNFeInfNFeDetImpostoCOFINSCOFINSQtde
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
        Public Property vBC As String
        Public Property pCOFINS As String
        Public Property vCOFINS As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
        <EnumMember(Value:="01")>
        <XmlEnum("01")>
        CST01
        <EnumMember(Value:="02")>
        <XmlEnum("02")>
        CST02
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSCOFINSNT
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
        <EnumMember(Value:="04")>
        <XmlEnum("04")>
        CST04
        <EnumMember(Value:="05")>
        <XmlEnum("05")>
        CST05
        <EnumMember(Value:="06")>
        <XmlEnum("06")>
        CST06
        <EnumMember(Value:="07")>
        <XmlEnum("07")>
        CST07
        <EnumMember(Value:="08")>
        <XmlEnum("08")>
        CST08
        <EnumMember(Value:="09")>
        <XmlEnum("09")>
        CST09
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
        Public Property pCOFINS As String
        Public Property qBCProd As String
        Public Property vAliqProd As String
        Public Property vBC As String
        Public Property vCOFINS As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
        <EnumMember(Value:="49")>
        <XmlEnum("49")>
        CST49
        <EnumMember(Value:="50")>
        <XmlEnum("50")>
        CST50
        <EnumMember(Value:="51")>
        <XmlEnum("51")>
        CST51
        <EnumMember(Value:="52")>
        <XmlEnum("52")>
        CST52
        <EnumMember(Value:="53")>
        <XmlEnum("53")>
        CST53
        <EnumMember(Value:="54")>
        <XmlEnum("54")>
        CST54
        <EnumMember(Value:="55")>
        <XmlEnum("55")>
        CST55
        <EnumMember(Value:="56")>
        <XmlEnum("56")>
        CST56
        <EnumMember(Value:="60")>
        <XmlEnum("60")>
        CST60
        <EnumMember(Value:="61")>
        <XmlEnum("61")>
        CST61
        <EnumMember(Value:="62")>
        <XmlEnum("62")>
        CST62
        <EnumMember(Value:="63")>
        <XmlEnum("63")>
        CST63
        <EnumMember(Value:="64")>
        <XmlEnum("64")>
        CST64
        <EnumMember(Value:="65")>
        <XmlEnum("65")>
        CST65
        <EnumMember(Value:="66")>
        <XmlEnum("66")>
        CST66
        <EnumMember(Value:="67")>
        <XmlEnum("67")>
        CST67
        <EnumMember(Value:="70")>
        <XmlEnum("70")>
        CST70
        <EnumMember(Value:="71")>
        <XmlEnum("71")>
        CST71
        <EnumMember(Value:="72")>
        <XmlEnum("72")>
        CST72
        <EnumMember(Value:="73")>
        <XmlEnum("73")>
        CST73
        <EnumMember(Value:="74")>
        <XmlEnum("74")>
        CST74
        <EnumMember(Value:="75")>
        <XmlEnum("75")>
        CST75
        <EnumMember(Value:="98")>
        <XmlEnum("98")>
        CST98
        <EnumMember(Value:="99")>
        <XmlEnum("99")>
        CST99
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property CST As TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
        Public Property qBCProd As String
        Public Property vAliqProd As String
        Public Property vCOFINS As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
        <EnumMember(Value:="03")>
        <XmlEnum("03")>
        CST03
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoCOFINSST
        Public Property pCOFINS As String
        Public Property qBCProd As String
        Public Property vAliqProd As String
        Public Property vBC As String
        Public Property vCOFINS As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoICMSUFDest
        Public Property vBCUFDest As String
        Public Property vBCFCPUFDest As String
        Public Property pFCPUFDest As String
        Public Property pICMSUFDest As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property pICMSInter As TNFeInfNFeDetImpostoICMSUFDestPICMSInter
        Public Property pICMSInterPart As String
        Public Property vFCPUFDest As String
        Public Property vICMSUFDest As String
        Public Property vICMSUFRemet As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeDetImpostoICMSUFDestPICMSInter
        <EnumMember(Value:="4.00")>
        <XmlEnum("4.00")>
        AliqInterestadualProducaoImportados
        <EnumMember(Value:="7.00")>
        <XmlEnum("7.00")>
        SulESudelteParaOutrasRegioes
        <EnumMember(Value:="12.00")>
        <XmlEnum("12.00")>
        DemaisCasos
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoDevol
        Public Property pDevol As String
        Public Property IPI As TNFeInfNFeDetImpostoDevolIPI
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeDetImpostoDevolIPI
        Public Property vIPIDevol As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTotal
        Public Property ICMSTot As TNFeInfNFeTotalICMSTot
        Public Property ISSQNtot As TNFeInfNFeTotalISSQNtot
        Public Property retTrib As TNFeInfNFeTotalRetTrib
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTotalICMSTot
        Public Property vBC As String
        Public Property vICMS As String
        Public Property vICMSDeson As String
        Public Property vFCPUFDest As String
        Public Property vICMSUFDest As String
        Public Property vICMSUFRemet As String
        Public Property vFCP As String
        Public Property vBCST As String
        Public Property vST As String
        Public Property vFCPST As String
        Public Property vFCPSTRet As String
        Public Property vProd As String
        Public Property vFrete As String
        Public Property vSeg As String
        Public Property vDesc As String
        Public Property vII As String
        Public Property vIPI As String
        Public Property vIPIDevol As String
        Public Property vPIS As String
        Public Property vCOFINS As String
        Public Property vOutro As String
        Public Property vNF As String
        Public Property vTotTrib As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTotalISSQNtot
        Public Property vServ As String
        Public Property vBC As String
        Public Property vISS As String
        Public Property vPIS As String
        Public Property vCOFINS As String
        Public Property dCompet As String
        Public Property vDeducao As String
        Public Property vOutro As String
        Public Property vDescIncond As String
        Public Property vDescCond As String
        Public Property vISSRet As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property cRegTrib As TNFeInfNFeTotalISSQNtotCRegTrib
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property cRegTribSpecified As Boolean
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeTotalISSQNtotCRegTrib
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        MicroempresaMunicipal
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        Estimativa
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        SociedadeProfissionais
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        Cooperativa
        <EnumMember(Value:="5")>
        <XmlEnum("5")>
        MEI
        <EnumMember(Value:="6")>
        <XmlEnum("6")>
        ME_EPP
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTotalRetTrib
        Public Property vRetPIS As String
        Public Property vRetCOFINS As String
        Public Property vRetCSLL As String
        Public Property vBCIRRF As String
        Public Property vIRRF As String
        Public Property vBCRetPrev As String
        Public Property vRetPrev As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTransp
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property modFrete As TNFeInfNFeTranspModFrete
        Public Property transporta As TNFeInfNFeTranspTransporta
        Public Property retTransp As TNFeInfNFeTranspRetTransp
        Public Property balsa As String
        Public Property reboque As TVeiculo
        Public Property vagao As String
        Public Property veicTransp As TVeiculo
        <XmlElement("vol")>
        Public Property vol As List(Of TNFeInfNFeTranspVol)
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeTranspModFrete
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        ContracaoFreteRemetente
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        ContracaoFreteDestinatario
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        ContracaoFreteTerceiros
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        TraspProprioRemetente
        <EnumMember(Value:="4")>
        <XmlEnum("4")>
        TraspProprioDestinatario
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        SemTransporte
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTranspTransporta
        Public Property CNPJ As String
        Public Property CPF As String
        Public Property xNome As String
        Public Property IE As String
        Public Property xEnder As String
        Public Property xMun As String
        Public Property UF As TUf
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property UFSpecified As Boolean
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTranspRetTransp
        Public Property vServ As String
        Public Property vBCRet As String
        Public Property pICMSRet As String
        Public Property vICMSRet As String
        Public Property CFOP As String
        Public Property cMunFG As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TVeiculo
        Public Property placa As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property UF As TUf
        Public Property RNTC As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTranspVol
        Public Property qVol As String
        Public Property esp As String
        Public Property marca As String
        Public Property nVol As String
        Public Property pesoL As String
        Public Property pesoB As String
        <XmlElement("lacres")>
        Public Property lacres As List(Of TNFeInfNFeTranspVolLacres)
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeTranspVolLacres
        Public Property nLacre As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCobr
        Public Property fat As TNFeInfNFeCobrFat
        <XmlElement("dup")>
        Public Property dup As List(Of TNFeInfNFeCobrDup)
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCobrFat
        Public Property nFat As String
        Public Property vOrig As String
        Public Property vDesc As String
        Public Property vLiq As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCobrDup
        Public Property nDup As String
        Public Property dVenc As String
        Public Property vDup As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFePag
        <XmlElement("detPag")>
        Public Property detPag As List(Of TNFeInfNFePagDetPag)
        Public Property vTroco As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFePagDetPag
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property indPag As TNFeInfNFePagDetPagIndPag
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property indPagSpecified As Boolean
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tPag As TNFeInfNFePagDetPagTPag
        Public Property vPag As String
        Public Property card As TNFeInfNFePagDetPagCard
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFePagDetPagIndPag
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        PagamanetoAVista
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        PagamentoAPrazo
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFePagDetPagTPag
        <EnumMember(Value:="01")>
        <XmlEnum("01")>
        Dinheiro
        <EnumMember(Value:="02")>
        <XmlEnum("02")>
        Cheque
        <EnumMember(Value:="03")>
        <XmlEnum("03")>
        CartaoCredito
        <EnumMember(Value:="04")>
        <XmlEnum("04")>
        CartaoDebito
        <EnumMember(Value:="05")>
        <XmlEnum("05")>
        CreditoLoja
        <EnumMember(Value:="10")>
        <XmlEnum("10")>
        ValeAlimentacao
        <EnumMember(Value:="11")>
        <XmlEnum("11")>
        ValeRefeicao
        <EnumMember(Value:="12")>
        <XmlEnum("12")>
        ValePresente
        <EnumMember(Value:="13")>
        <XmlEnum("13")>
        ValeCombustivel
        <EnumMember(Value:="15")>
        <XmlEnum("15")>
        BoletoBancario
        <EnumMember(Value:="90")>
        <XmlEnum("90")>
        SemPagamento
        <EnumMember(Value:="99")>
        <XmlEnum("99")>
        Outros
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFePagDetPagCard
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tpIntegra As TNFeInfNFePagDetPagCardTpIntegra
        Public Property CNPJ As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property tBand As TNFeInfNFePagDetPagCardTBand
        <XmlIgnore()>
        <JsonIgnore()>
        Public Property tBandSpecified As Boolean
        Public Property cAut As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFePagDetPagCardTpIntegra
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        Item1
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        Item2
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFePagDetPagCardTBand
        <EnumMember(Value:="01")>
        <XmlEnum("01")>
        Item01
        <EnumMember(Value:="02")>
        <XmlEnum("02")>
        Item02
        <EnumMember(Value:="03")>
        <XmlEnum("03")>
        Item03
        <EnumMember(Value:="04")>
        <XmlEnum("04")>
        Item04
        <EnumMember(Value:="05")>
        <XmlEnum("05")>
        Item05
        <EnumMember(Value:="06")>
        <XmlEnum("06")>
        Item06
        <EnumMember(Value:="07")>
        <XmlEnum("07")>
        Item07
        <EnumMember(Value:="08")>
        <XmlEnum("08")>
        Item08
        <EnumMember(Value:="09")>
        <XmlEnum("09")>
        Item09
        <EnumMember(Value:="99")>
        <XmlEnum("99")>
        Item99
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfAdic
        Public Property infAdFisco As String
        Public Property infCpl As String
        <XmlElement("obsCont")>
        Public Property obsCont As List(Of TNFeInfNFeInfAdicObsCont)
        <XmlElement("obsFisco")>
        Public Property obsFisco As List(Of TNFeInfNFeInfAdicObsFisco)
        <XmlElement("procRef")>
        Public Property procRef As List(Of TNFeInfNFeInfAdicProcRef)
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfAdicObsCont
        Public Property xTexto As String
        <XmlAttribute()>
        Public Property xCampo As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfAdicObsFisco
        Public Property xTexto As String
        <XmlAttribute()>
        Public Property xCampo As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeInfAdicProcRef
        Public Property nProc As String
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property indProc As TNFeInfNFeInfAdicProcRefIndProc
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Public Enum TNFeInfNFeInfAdicProcRefIndProc
        <EnumMember(Value:="0")>
        <XmlEnum("0")>
        SEFAZ
        <EnumMember(Value:="1")>
        <XmlEnum("1")>
        JusticaFederal
        <EnumMember(Value:="2")>
        <XmlEnum("2")>
        JusticaEstadual
        <EnumMember(Value:="3")>
        <XmlEnum("3")>
        Secex_RFB
        <EnumMember(Value:="9")>
        <XmlEnum("9")>
        Outros
    End Enum

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeExporta
        <JsonConverter(GetType(StringEnumConverter))>
        Public Property UFSaidaPais As TUfEmi
        Public Property xLocExporta As String
        Public Property xLocDespacho As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCompra
        Public Property xNEmp As String
        Public Property xPed As String
        Public Property xCont As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCana
        Public Property safra As String
        Public Property ref As String
        <XmlElement("forDia")>
        Public Property forDia As List(Of TNFeInfNFeCanaForDia)
        Public Property qTotMes As String
        Public Property qTotAnt As String
        Public Property qTotGer As String
        <XmlElement("deduc")>
        Public Property deduc As List(Of TNFeInfNFeCanaDeduc)
        Public Property vFor As String
        Public Property vTotDed As String
        Public Property vLiqFor As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCanaForDia
        Public Property qtde As String
        <XmlAttribute()>
        Public Property dia As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeCanaDeduc
        Public Property xDed As String
        Public Property vDed As String
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType([Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TInfRespTec
        Public Property CNPJ As String
        Public Property xContato As String
        Public Property email As String
        Public Property fone As String
        Public Property idCSRT As String
        <XmlElement(DataType:="base64Binary")>
        Public Property hashCSRT As Byte()
    End Class

    <System.CodeDom.Compiler.GeneratedCode("xsd", "4.8.3928.0")>
    <System.Serializable()>
    <System.Diagnostics.DebuggerStepThrough()>
    <System.ComponentModel.DesignerCategory("code")>
    <XmlType(AnonymousType:=True, [Namespace]:="http://www.portalfiscal.inf.br/nfe")>
    Partial Public Class TNFeInfNFeSupl
        Public Property qrCode As String
        Public Property urlChave As String
    End Class
End Namespace

Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Library.src.Requisicoes.NFe.Emissoes
Imports NSSuiteCoreVbNet.Library.NSSuiteCoreVbNet.Requisicoes._Genericos.Emissoes
Imports Xunit

Namespace NSSuiteCoreVbNet.Tests.Emissoes
    Public Class EmissaoSincronaDocumentos
        <Theory()>
        <MemberData(NameOf(GetNFe))>
        Public Sub RealizaUmaEmissaoSincronaDadoUmDFe(ByVal dfe As IEmissaoDFeSincrona)
            dfe.EnvioSincrono(TipoDownloadDFes.XML_PDF, "C:\Testes\EmissaoSincrona\NFe\", True)
        End Sub

        Public Shared ReadOnly Property GetNFe As IEnumerable(Of Object())
            Get
                Return {New Object() {New EnvioReqNFe With {
                    .infNFe = New TNFeInfNFe With {
                        .versao = "4.00",
                        .ide = New TNFeInfNFeIde With {
                            .cUF = TCodUfIBGE.RS,
                            .cNF = "00462186",
                            .natOp = "VENDA A PRAZO - S",
                            .[mod] = TMod.NFe,
                            .serie = "16",
                            .nNF = "102",
                            .dhEmi = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                            .tpNF = TNFeInfNFeIdeTpNF.Saida,
                            .idDest = TNFeInfNFeIdeIdDest.OpInterna,
                            .cMunFG = "4305108",
                            .tpImp = TNFeInfNFeIdeTpImp.DANFERetrato,
                            .tpAmb = TAmb.Homologacao,
                            .finNFe = TFinNFe.Normal,
                            .indFinal = TNFeInfNFeIdeIndFinal.ConsumidorFinal,
                            .indPres = TNFeInfNFeIdeIndPres.Outros,
                            .procEmi = TProcEmi.AplicativoContribuinte,
                            .verProc = "4.00"
                        },
                        .emit = New TNFeInfNFeEmit With {
                            .CNPJ = "07364617000135",
                            .xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                            .enderEmit = New TEnderEmi With {
                                .xLgr = "Rua Bento Osvaldo Trisch",
                                .nro = "777",
                                .xCpl = "CX POSTAL 91",
                                .xBairro = "Pendancino",
                                .cMun = "4303509",
                                .xMun = "Caxias do Sul",
                                .UF = TUfEmi.RS,
                                .CEP = "95046600"
                            },
                            .IE = "0170108708",
                            .CRT = TNFeInfNFeEmitCRT.SimplesNacional
                        },
                        .dest = New TNFeInfNFeDest With {
                            .CNPJ = "07364617000135",
                            .xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL",
                            .enderDest = New TEndereco With {
                                .xLgr = "AV ANTONIO DURO",
                                .nro = "0",
                                .xBairro = "OLARIA",
                                .cMun = "4303509",
                                .xMun = "CAMAQUA",
                                .UF = TUf.RS,
                                .CEP = "96180000",
                                .cPais = "1058",
                                .xPais = "BRASIL"
                            },
                            .indIEDest = TNFeInfNFeDestIndIEDest.ContribuinteICMS,
                            .IE = "0170108708"
                        },
                        .det = New List(Of TNFeInfNFeDet) From {
                            New TNFeInfNFeDet With {
                                .nItem = "1",
                                .prod = New TNFeInfNFeDetProd With {
                                    .cProd = "1440859X1_",
                                    .cEAN = "SEM GTIN",
                                    .xProd = "TESTE",
                                    .NCM = "87089990",
                                    .CEST = "0107500",
                                    .CFOP = "5101",
                                    .uCom = "UN",
                                    .qCom = "1.0000",
                                    .vUnCom = "13.50",
                                    .vProd = "13.50",
                                    .cEANTrib = "SEM GTIN",
                                    .uTrib = "UN",
                                    .qTrib = "1.0000",
                                    .vUnTrib = "13.50",
                                    .indTot = TNFeInfNFeDetProdIndTot.CompoeTotal,
                                    .nItemPed = "0",
                                    .cBenef = "SEM CBENEF"
                                },
                                .imposto = New TNFeInfNFeDetImposto With {
                                    .vTotTrib = "0.00",
                                    .ICMS = New TNFeInfNFeDetImpostoICMS With {
                                        .ICMSSN102 = New TNFeInfNFeDetImpostoICMSICMSSN102 With {
                                            .orig = Torig.Nacional,
                                            .CSOSN = TNFeInfNFeDetImpostoICMSICMSSN102CSOSN.CSOSN102
                                        }
                                    },
                                    .IPI = New TIpi With {
                                        .cEnq = "341",
                                        .IPINT = New TIpiIPINT With {
                                            .CST = TIpiIPINTCST.CST02
                                        }
                                    },
                                    .PIS = New TNFeInfNFeDetImpostoPIS With {
                                        .PISAliq = New TNFeInfNFeDetImpostoPISPISAliq With {
                                            .CST = TNFeInfNFeDetImpostoPISPISAliqCST.CST01,
                                            .vBC = "0.00",
                                            .pPIS = "0.00",
                                            .vPIS = "0.00"
                                        }
                                    },
                                    .COFINS = New TNFeInfNFeDetImpostoCOFINS With {
                                        .COFINSAliq = New TNFeInfNFeDetImpostoCOFINSCOFINSAliq With {
                                            .CST = TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST.CST01,
                                            .vBC = "0.00",
                                            .pCOFINS = "0.00",
                                            .vCOFINS = "0.00"
                                        }
                                    }
                                }
                            }
                        },
                        .total = New TNFeInfNFeTotal With {
                            .ICMSTot = New TNFeInfNFeTotalICMSTot With {
                                .vBC = "0.00",
                                .vICMS = "0.00",
                                .vICMSDeson = "0.00",
                                .vFCPUFDest = "0.00",
                                .vICMSUFDest = "0.00",
                                .vICMSUFRemet = "0.00",
                                .vFCP = "0.00",
                                .vBCST = "0.00",
                                .vST = "0.00",
                                .vFCPST = "0.00",
                                .vFCPSTRet = "0.00",
                                .vProd = "13.50",
                                .vFrete = "0.00",
                                .vSeg = "0.00",
                                .vDesc = "0.00",
                                .vII = "0.00",
                                .vIPI = "0.00",
                                .vIPIDevol = "0.00",
                                .vPIS = "0.00",
                                .vCOFINS = "0.00",
                                .vOutro = "0.00",
                                .vNF = "13.50",
                                .vTotTrib = "0.00"
                            }
                        },
                        .transp = New TNFeInfNFeTransp With {
                            .modFrete = TNFeInfNFeTranspModFrete.SemTransporte
                        },
                        .pag = New TNFeInfNFePag With {
                            .detPag = New List(Of TNFeInfNFePagDetPag) From {
                                New TNFeInfNFePagDetPag With {
                                    .indPag = TNFeInfNFePagDetPagIndPag.PagamanetoAVista,
                                    .tPag = TNFeInfNFePagDetPagTPag.Dinheiro,
                                    .vPag = "13.50"
                                }
                            },
                            .vTroco = "0.00"
                        },
                        .infAdic = New TNFeInfNFeInfAdic With {
                            .infCpl = "DOCUMENTO EMITIDO POR ME OU EPP OPTANTE PELO SIMPLES NACIONAL#BR#NÃO GERA DIREITO A CRÉDITO FISCAL DE ICMS, DE ISS E DE IPI#BR#"
                        }
                    }
                }}}
            End Get
        End Property
    End Class
End Namespace

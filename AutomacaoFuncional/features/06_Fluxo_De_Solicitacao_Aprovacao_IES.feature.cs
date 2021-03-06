﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomacaoFuncional.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("06_Fluxo_De_Solicitacao_Aprovacao_IES")]
    public partial class _06_Fluxo_De_Solicitacao_Aprovacao_IESFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "06_Fluxo_De_Solicitacao_Aprovacao_IES.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "06_Fluxo_De_Solicitacao_Aprovacao_IES", "\tUse before title fiture separed with \"-\":\r\n\t \'C\' for Chrome;\r\n\t \'I\' for Internet" +
                    " Explorer;\r\n\t \'F\' for FireFox Mozilla;\r\n\t \'E\' for Edge;\r\n\t \'H\' for Headless Chro" +
                    "me;\r\n\t Default: Chrome", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("01 Acessar o endereco")]
        [NUnit.Framework.CategoryAttribute("01_AcessarPagina")]
        public virtual void _01AcessarOEndereco()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("01 Acessar o endereco", null, new string[] {
                        "01_AcessarPagina"});
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
testRunner.Given("Acessar o endereco \"http://homologacao.fundacred.org.br/estudante-web/#/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
testRunner.Then("Validar o carregamento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("02 Iniciar Fluxo Comece Agora")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _02IniciarFluxoComeceAgora()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("02 Iniciar Fluxo Comece Agora", null, new string[] {
                        "02_1Etapa"});
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
testRunner.Given("Preencher os dados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
testRunner.When("Clicar em Comece agora sem compromisso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.Then("Validar se o fluxo e iniciado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("03 Iniciar Solicitacao")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _03IniciarSolicitacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("03 Iniciar Solicitacao", null, new string[] {
                        "02_1Etapa"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
testRunner.Given("Acessar a opcao solicitacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
testRunner.When("Clicar em quero solicitar o credito", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
testRunner.Then("Validar o direcionamento com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("04 Selecionar Instituicao")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _04SelecionarInstituicao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("04 Selecionar Instituicao", null, new string[] {
                        "02_1Etapa"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 31
testRunner.Given("Selecionar instituicao \"USF - UNIVERSIDADE SAO FRANCISCO\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
testRunner.When("Selecionar curso \"ADMINISTRAÇÃO-NOTURNO-BRAGANÇA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
testRunner.And("Clicar no botao aceito os termos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
testRunner.Then("Validar solicitacao enviada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("05 Validar DB")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _05ValidarDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("05 Validar DB", null, new string[] {
                        "02_1Etapa"});
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 40
testRunner.Then("Validar status de solicitacao no db \"Solicitacao\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("06 Preencher Dados Do Estudante")]
        [NUnit.Framework.CategoryAttribute("02_2Etapa")]
        public virtual void _06PreencherDadosDoEstudante()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("06 Preencher Dados Do Estudante", null, new string[] {
                        "02_2Etapa"});
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 48
testRunner.Given("Clicar no botao enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
testRunner.Then("Validar direcionamento para etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("07 Validar DB")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _07ValidarDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("07 Validar DB", null, new string[] {
                        "02_1Etapa"});
#line 52
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 53
testRunner.Then("Validar status de solicitacao no db \"Estudante\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("08 Preencher Dados Do Fiador")]
        [NUnit.Framework.CategoryAttribute("03_3Etapa")]
        public virtual void _08PreencherDadosDoFiador()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("08 Preencher Dados Do Fiador", null, new string[] {
                        "03_3Etapa"});
#line 57
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 58
testRunner.Given("Inserir nome e cpf \" Leonardo Barcellos Teste \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
testRunner.When("Inserir data de nasc e renda \"5.000,00-06/08/2000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
testRunner.And("Clicar no botao enviar etapa 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
testRunner.Then("Validar direcionamento para etapa 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("09 Validar DB")]
        [NUnit.Framework.CategoryAttribute("02_1Etapa")]
        public virtual void _09ValidarDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("09 Validar DB", null, new string[] {
                        "02_1Etapa"});
#line 64
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 65
testRunner.Then("Validar status de solicitacao no db \"Fiador\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("10 Preencher Dados Pessoais")]
        [NUnit.Framework.CategoryAttribute("04_4Etapa")]
        public virtual void _10PreencherDadosPessoais()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("10 Preencher Dados Pessoais", null, new string[] {
                        "04_4Etapa"});
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 69
testRunner.Given("Inserir os dados pessoais", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
testRunner.When("Inserir endereco e contato", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
testRunner.And("Clicar no botao proximo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
testRunner.Then("Validar direcionamento dados fiador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("11 Preencher Dados Completos Do Fiador")]
        [NUnit.Framework.CategoryAttribute("04_4Etapa")]
        public virtual void _11PreencherDadosCompletosDoFiador()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("11 Preencher Dados Completos Do Fiador", null, new string[] {
                        "04_4Etapa"});
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 76
testRunner.Given("Preencho os dados completos do fiador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
testRunner.When("Preencho contato e endereco", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
testRunner.And("Clico em proximo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
testRunner.Then("Validar direcionamento Dados Curso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("12 Validar DB")]
        [NUnit.Framework.CategoryAttribute("04_4Etapa")]
        public virtual void _12ValidarDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("12 Validar DB", null, new string[] {
                        "04_4Etapa"});
#line 82
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 83
testRunner.Then("Validar status de solicitacao no db \"PosFiador\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("13 Preencher Dados Do Curso")]
        [NUnit.Framework.CategoryAttribute("04_4Etapa")]
        public virtual void _13PreencherDadosDoCurso()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("13 Preencher Dados Do Curso", null, new string[] {
                        "04_4Etapa"});
#line 86
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 87
testRunner.Given("Preencho matricula e percentual", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 88
testRunner.When("Preencho ano e semestre", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
testRunner.And("Clico em documentos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
testRunner.Then("Validar direcionamento documentos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("14 Selecionar E Enviar Documentos")]
        [NUnit.Framework.CategoryAttribute("04_4Etapa")]
        public virtual void _14SelecionarEEnviarDocumentos()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("14 Selecionar E Enviar Documentos", null, new string[] {
                        "04_4Etapa"});
#line 93
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 94
testRunner.Given("Seleciono documentos do estudante", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
testRunner.When("Seleciono documentos do grupo familiar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
testRunner.And("Seleciono documentos do fiador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
testRunner.And("Seleciono documentos de renda do fiador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
testRunner.And("Clico em concluir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
testRunner.Then("Validar a conclusao da etapa 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("15 Validar DB")]
        [NUnit.Framework.CategoryAttribute("05_5Etapa")]
        public virtual void _15ValidarDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("15 Validar DB", null, new string[] {
                        "05_5Etapa"});
#line 103
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 104
testRunner.Then("Validar status de solicitacao no db \"Solicitação concluída\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("16 Atualizar Status SGCred")]
        [NUnit.Framework.CategoryAttribute("05_5Etapa")]
        public virtual void _16AtualizarStatusSGCred()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("16 Atualizar Status SGCred", null, new string[] {
                        "05_5Etapa"});
#line 107
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 108
testRunner.Given("Realizo update de status", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 109
testRunner.Then("Update realizado com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("17 Acessar o endereco")]
        [NUnit.Framework.CategoryAttribute("06_AcessarPagina")]
        public virtual void _17AcessarOEndereco()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("17 Acessar o endereco", null, new string[] {
                        "06_AcessarPagina"});
#line 112
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 114
testRunner.Given("Acessar o endereco \"http://homologacao.fundacred.org.br/ies/#/login\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 115
testRunner.Then("Validar Acesso ao portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("18 Realizar Login Portal IES")]
        [NUnit.Framework.CategoryAttribute("06_6Etapa")]
        public virtual void _18RealizarLoginPortalIES()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("18 Realizar Login Portal IES", null, new string[] {
                        "06_6Etapa"});
#line 118
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 119
testRunner.Given("Informo o email \"Cristiane@teste.org.br\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 120
testRunner.When("Informo a senha \"welcome1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
testRunner.And("Clico no botao Entrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
testRunner.Then("Validar login com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("19 iniciar Aprovacao")]
        [NUnit.Framework.CategoryAttribute("06_6Etapa")]
        public virtual void _19IniciarAprovacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("19 iniciar Aprovacao", null, new string[] {
                        "06_6Etapa"});
#line 125
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 126
testRunner.Given("Acesso a opcao aprovacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 127
testRunner.When("Pesquiso a solicitacao desejada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
testRunner.And("Clico em prosseguir confirmacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
testRunner.Then("Valido o acesso a tela aprovar solicitacao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("20 Finalizar Aprovacao")]
        [NUnit.Framework.CategoryAttribute("06_6Etapa")]
        public virtual void _20FinalizarAprovacao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("20 Finalizar Aprovacao", null, new string[] {
                        "06_6Etapa"});
#line 132
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 133
testRunner.Given("Preencho os dados pendentes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 134
testRunner.When("Preencho as informacoes de valores", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
testRunner.And("Clico em aprovar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
testRunner.Then("Valido solicitacao aprovada com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("21 Validar DB")]
        [NUnit.Framework.CategoryAttribute("06_6Etapa")]
        public virtual void _21ValidarDB()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("21 Validar DB", null, new string[] {
                        "06_6Etapa"});
#line 139
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 140
testRunner.Then("Validar status de solicitacao no db \"Solicitação aprovada\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

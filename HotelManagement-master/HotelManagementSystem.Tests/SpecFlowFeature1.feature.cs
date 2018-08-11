﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HotelManagementSystem.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Add hotel")]
    public partial class AddHotelFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeature1.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add hotel", "\tIn order to simulate hotel management system\r\n\tAs api consumer\r\n\tI want to be ab" +
                    "le to add hotel,get hotel details and book hotel", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User adds hotel in database by providing valid inputs")]
        [NUnit.Framework.CategoryAttribute("AddHotel")]
        [NUnit.Framework.TestCaseAttribute("1", "hotel1", null)]
        [NUnit.Framework.TestCaseAttribute("2", "hotel2", null)]
        [NUnit.Framework.TestCaseAttribute("3", "hotel3", null)]
        public virtual void UserAddsHotelInDatabaseByProvidingValidInputs(string id, string name, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AddHotel"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User adds hotel in database by providing valid inputs", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given(string.Format("User provided valid Id \'{0}\'  and \'{1}\'for hotel", id, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("Use has added required details for hotel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("User calls AddHotel api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("Hotel with name \'{0}\' should be present in the response", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User add hotel in database and then searches for hotel.")]
        [NUnit.Framework.TestCaseAttribute("6", "hotel4", null)]
        public virtual void UserAddHotelInDatabaseAndThenSearchesForHotel_(string id, string name, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User add hotel in database and then searches for hotel.", exampleTags);
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given(string.Format("User provided valid Id \'{0}\'  and \'{1}\'for hotel", id, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("Use has added required details for hotel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And(string.Format("the user specifies specifies an \'{0}\'", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("the user calls the hotel api", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then(string.Format("the hotel with specified hotel \'{0}\' should be present in the response", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User adds multiple hotels in the database and then verifies.")]
        [NUnit.Framework.TestCaseAttribute("10", "hotel10", null)]
        [NUnit.Framework.TestCaseAttribute("11", "hotel11", null)]
        [NUnit.Framework.TestCaseAttribute("12", "hotel12", null)]
        public virtual void UserAddsMultipleHotelsInTheDatabaseAndThenVerifies_(string id, string name, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User adds multiple hotels in the database and then verifies.", exampleTags);
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given(string.Format("User provided valid Id \'{0}\'  and \'{1}\'for hotel", id, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And("Use has added required details for hotel", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.When("the user calls the api to check weather the enteries are present or no.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then(string.Format("the added hotel enteries with all \'{0}\'should be present in the database.", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

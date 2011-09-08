// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.6.1.0
//      SpecFlow Generator Version:1.6.0.0
//      Runtime Version:4.0.30319.235
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.6.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Route Areas")]
    public partial class RouteAreasFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RouteAreas.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Areas", "", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            this.FeatureBackground();
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I generate the routes defined in the subject controllers");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes")]
        public virtual void GeneratingAreaRoutes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.When("I fetch the routes for the Areas controller\'s Index action");
#line 8
 testRunner.Then("the route url is \"Area/Index\"");
#line 9
  testRunner.And("the data token for \"area\" is \"Area\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes when route urls specify a duplicate area prefix")]
        public virtual void GeneratingAreaRoutesWhenRouteUrlsSpecifyADuplicateAreaPrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes when route urls specify a duplicate area prefix", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.When("I fetch the routes for the Areas controller\'s DuplicatePrefix action");
#line 13
 testRunner.Then("the route url is \"Area/DuplicatePrefix\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating absolute routes when a route area is defined")]
        public virtual void GeneratingAbsoluteRoutesWhenARouteAreaIsDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating absolute routes when a route area is defined", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.When("I fetch the routes for the Areas controller\'s Absolute action");
#line 17
 testRunner.Then("the route url is \"AreaAbsolute\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes when route url starts with the area prefix")]
        public virtual void GeneratingAreaRoutesWhenRouteUrlStartsWithTheAreaPrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes when route url starts with the area prefix", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.When("I fetch the routes for the Areas controller\'s RouteBeginsWithAreaName action");
#line 21
 testRunner.Then("the route url is \"Area/Areas\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes with an explicit area url")]
        public virtual void GeneratingAreaRoutesWithAnExplicitAreaUrl()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes with an explicit area url", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.When("I fetch the routes for the ExplicitAreaUrl controller\'s Index action");
#line 25
 testRunner.Then("the route url is \"ExplicitArea/Index\"");
#line 26
  testRunner.And("the data token for \"area\" is \"Area\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes with an explicit area url when route urls specify a duplic" +
            "ate area prefix")]
        public virtual void GeneratingAreaRoutesWithAnExplicitAreaUrlWhenRouteUrlsSpecifyADuplicateAreaPrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes with an explicit area url when route urls specify a duplic" +
                    "ate area prefix", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.When("I fetch the routes for the ExplicitAreaUrl controller\'s DuplicatePrefix action");
#line 30
 testRunner.Then("the route url is \"ExplicitArea/DuplicatePrefix\"");
#line 31
  testRunner.And("the data token for \"area\" is \"Area\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion

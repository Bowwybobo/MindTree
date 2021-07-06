using MindTree_Assessment.PageObjaect;
using System;
using TechTalk.SpecFlow;

namespace MindTree_Assessment.StepDefinition
{
    [Binding]
    public class SeleniumWebSteps
    {
        SeleniumPage seleniumPage;

        public SeleniumWebSteps()
        {
            seleniumPage = new SeleniumPage();
        }

            [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            seleniumPage.NavigateToWebsite(url);
        }


        [Given(@"I Click on download")]
        public void GivenIClickOnDownload()
        {
            seleniumPage.ClickOnDownload();
        }


        [Then(@"I Should see the download page")]
        public void ThenIShouldSeeTheDownloadPage()
        {
            seleniumPage.IsServerGridDisplayed();
        }



        [Given(@"I Click on About")]
        public void GivenIClickOnAbout()
        {
            seleniumPage.ClickAbout();
        }


        [Given(@"I Click on Govermance")]
        public void GivenIClickOnGovermance()
        {
            seleniumPage.ClickGovernance();
        }


        [Given(@"I Validate that am on Govermance")]
        public void GivenIValidateThatAmOnGovermance()
        {
            seleniumPage.IsProjectStructureAndGovernanceDisplayed();
        }


        [Given(@"I Click on learn more")]
        public void GivenIClickOnLearnMore()
        {
            seleniumPage.ClickLearnMore();
        }



        [Then(@"I Should see the sponsors page")]
        public void ThenIShouldSeeTheSponsorsPage()
        {
            seleniumPage.IsSeleniumSponsorDisplayed();
        }


        [Given(@"I Click on documentation")]
        public void GivenIClickOnDocumentation()
        {
            seleniumPage.ClickDocumentation();
        }



        [Given(@"I Search for ""(.*)""")]
        public void GivenISearchFor(string word)
        {
            seleniumPage.EnterSearchWord(word);
        }


        [Given(@"I Select the second option")]
        public void GivenISelectTheSecondOption()
        {
            seleniumPage.SelectResult();
        }



        [Then(@"I Can validate the result")]
        public void ThenICanValidateTheResult()
        {
            ScenarioContext.Current.Pending();
        }


    }
}

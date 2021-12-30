using Xunit;
using SeleniumHW;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace SeleniumTest
{
    public class UnitTest1 : BaseTest
    {
        private IWebDriver chrome;
        




        [Fact]
        public void Guru99AgileTestingTest()
        {
           

            chrome = StartDriverWithUrl("https://www.guru99.com/");
            
            IWebElement findElement = chrome.FindElement(By.CssSelector("a[ href='/agile-testing-course.html']"));
            findElement.Click();
            findElement = chrome.FindElement(By.CssSelector("a[href = 'agile-scrum-extreme-testing.html']"));
            findElement.Click();
            findElement = chrome.FindElement(By.ClassName("entry-title"));
            string actual = findElement.Text;
            string actualURL = chrome.Url;
            Assert.Equal("Agile Methodology: What is Agile Model in Software Testing?", actual);
            Assert.Equal("https://www.guru99.com/agile-scrum-extreme-testing.html", actualURL);
            chrome.Quit();




        }

        [Fact]
        public void GuruQuizTest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");
            //Test button press
            IWebElement findElement = chrome.FindElement(By.CssSelector("a[href = '/tests.html']"));
            findElement.Click();
            //Quiz1 button press
            findElement = chrome.FindElement(By.CssSelector("a[href = '/istqb-certification-quiz.html']"));
            findElement.Click();
            findElement = chrome.FindElement(By.ClassName("entry-title"));
            string actual = findElement.Text;
            Assert.Equal("ISTQB Foundation Level Certification Exam Online Mock Test – 1", actual);
            string actualUrl = chrome.Url;
            Assert.Equal("https://www.guru99.com/istqb-certification-quiz.html",actualUrl);
            chrome.Quit();



        }

        [Fact]
        public void CSharpGuruTest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");

            IWebElement findSharElement = chrome.FindElement(By.XPath("(//a[contains(@href, '/c-sharp-tutorial.html')])[2]"));
            findSharElement.Click();
            string actualSharpURL = chrome.Url;
            Assert.Equal("https://www.guru99.com/c-sharp-tutorial.html", actualSharpURL);
            IWebElement findBugReportElement = chrome.FindElement(By.XPath("//big"));
            findBugReportElement.Click();
            IWebElement findHowToDownload = chrome.FindElement(By.XPath("//a[contains(text(),'How to Download and Install Visual Studio for C# in Windows')]"));
            findHowToDownload.Click();
            string actualHowTo = chrome.Url;
            Assert.Equal("https://www.guru99.com/download-install-visual-studio.html", actualHowTo);
            IWebElement findRedirectionButton = chrome.FindElement(By.LinkText("https://visualstudio.microsoft.com/downloads/"));
            findRedirectionButton.Click();
            string isItDownloadSite = chrome.Url;
            Assert.Equal("https://visualstudio.microsoft.com/ru/downloads/", isItDownloadSite);
            chrome.Quit();





        }
        [Fact]
        public void HtmlAndJavaCodeCompilingTest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");

            IWebElement findExecHtmlElement = chrome.FindElement(By.LinkText("Execute HTML"));
            findExecHtmlElement.Click();
            Thread.Sleep(10000);
            IWebElement CodeCompileHtml = chrome.FindElement(By.XPath("(//input[@value='Run'])[2]"));
            CodeCompileHtml.Click();
            IWebElement CodeCompileJava = chrome.FindElement(By.LinkText("Compile and Execute Java Online"));
            CodeCompileJava.Click();
            Thread.Sleep(10000);
            CodeCompileJava = chrome.FindElement(By.Id("compile"));
            CodeCompileJava.Click();
            IWebElement finishJavaCompile = chrome.FindElement(By.Id("stdout"));
            Thread.Sleep(10000);
            string actUrl = chrome.Url;
            IWebElement entryTitle = chrome.FindElement(By.ClassName("entry-title"));
            string actualETitle = entryTitle.Text;
            Assert.Equal("Compile and Execute Java Online", actualETitle);
            Assert.Equal("https://www.guru99.com/try-java-editor.html",actUrl);
            chrome.Quit();
                                 
        }
        
        [Fact]
        public void HoverMoveToBigDatatest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");
            Actions act = new Actions(chrome);
            


            IWebElement bigData = chrome.FindElement(By.XPath("//li[@id='menu-item-3177']/a/span"));
            act.MoveToElement(bigData).Click().Build().Perform();
            bigData = chrome.FindElement(By.XPath("//li[@id='menu-item-4997']/a"));
            bigData.Click();
            IWebElement topicChoose = chrome.FindElement(By.LinkText("What is BIG DATA?"));
            topicChoose.Click();
            IWebElement actTopic = chrome.FindElement(By.ClassName("entry-title"));
            string actualTopic = actTopic.Text;
            Assert.Equal("What is Big Data? Introduction, Types, Characteristics, Examples", actualTopic);
            chrome.Quit();

        }

        [Fact]
        public void BlogTest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");

            IWebElement blog = chrome.FindElement(By.LinkText("Blog"));
            blog.Click();
            IWebElement chooseBlog = chrome.FindElement(By.LinkText("Entity Component System"));
            chooseBlog.Click();
            IWebElement choosePart = chrome.FindElement(By.LinkText("Composition"));
            choosePart.Click();
            IWebElement topicName = chrome.FindElement(By.XPath("//h2[contains(.,'Composition')]"));
            string actTopic = topicName.Text;
            Assert.Equal("Composition", actTopic);
            chrome.Quit();
        }


        [Fact]
        public void EthicalHAckingTest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");

            IWebElement findEthHacking = chrome.FindElement(By.XPath("(//a[contains(@href, '/ethical-hacking-tutorials.html')])[2]"));
            findEthHacking.Click();
            IWebElement joinLivePenTest = chrome.FindElement(By.LinkText("Live Penetration Testing Project"));
            joinLivePenTest.Click();
            string actUrl = chrome.Url;
            Assert.Equal("https://www.guru99.com/live-penetration-testing-project.html", actUrl);
            IWebElement regButton = chrome.FindElement(By.ClassName("button-liveproject"));
            regButton.Click();
            chrome.Quit();
        }

        [Fact]
        public void ChoosingBookTest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");
            IWebElement findBookElement = chrome.FindElement(By.LinkText("eBook"));
            findBookElement.Click();
            IWebElement bookChoose = chrome.FindElement(By.XPath("//article[@id='post-1614']/div/div/div[2]/div[2]/p/a/img"));
            bookChoose.Click();
            string actUrl = chrome.Url;
            Assert.Equal("https://www.guru99.com/ebook-pdf.html", actUrl);
            chrome.Quit();

        }

        [Fact]
        public void SoftTestCareerTest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");
            IWebElement softTest = chrome.FindElement(By.LinkText("Software Testing as a Career"));
            softTest.Click();
            IWebElement howTo = chrome.FindElement(By.LinkText("How to Become Software Tester"));
            howTo.Click();
            IWebElement tutorials = chrome.FindElement(By.XPath("(//a[contains(@href, 'software-testing.html')])[3]"));
            Thread.Sleep(2000);
            tutorials.Click();
            IWebElement check = chrome.FindElement(By.XPath("//h1"));
            string actTxt = check.Text;
            Assert.Equal("Software Testing Tutorial: Free QA Course", actTxt);
            chrome.Quit();

        }

        [Fact]
        public void AlgorythmsTest()
        {
            chrome = StartDriverWithUrl("https://www.guru99.com/");
            IWebElement moveTo = chrome.FindElement(By.XPath("(//a[contains(@href, '/design-analysis-algorithms-tutorial.html')])[3]"));
            moveTo.Click();
            IWebElement sortType = chrome.FindElement(By.LinkText("Selection Sort"));
            sortType.Click();
            IWebElement codeExplain = chrome.FindElement(By.XPath("//article[@id='post-2259']/div/div/h2[6]"));
            string actTxt = codeExplain.Text;
            codeExplain.Click();
            string actualUrl = chrome.Url;
            Assert.Equal("https://www.guru99.com/selection-sort-algorithm.html",actualUrl);
            Assert.Equal("Code Explanation", actTxt);
            chrome.Quit();
            



        }














    }
}
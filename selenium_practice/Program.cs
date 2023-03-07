using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace SeleniumFirefox;

class program{

IWebDriver driver;



public void start_Browser(){
    driver = new FirefoxDriver();
    driver.Manage().Window.Maximize();

}

  public void quit_Browser(){
    driver.Quit();
  }
}


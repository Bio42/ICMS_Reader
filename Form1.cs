using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICMS_Reader
{
	public partial class Form1 : Form
    {
		public Form1()
        {
            InitializeComponent();

			rbFirefox.Checked = true;
			rbMEC.Checked = true;

			tbWebPage.Text = WebPage;
			pbProgress.Maximum = 10;
		}

		string WebPage = @"https://icms.hs-hannover.de/";
        private const int MAX_LOAD_COUNT = 300; //*100ms

        private void btnGo_Click(object sender, EventArgs e)
        {
			IWebDriver driver;
            int loadCount = 0;

            string Studiengang = SelectStudy();            

            UpdateStatus("Treiber Laden...");
			pbProgress.Value = 1;

			driver = GetBrowserDriver();

			UpdateStatus("Fenster minimieren...");
			pbProgress.Value = 2;

			//driver.Manage().Window.Minimize();
			WindowControl.MinimizeWindowByTitle(Directory.GetCurrentDirectory() + @"\geckodriver.exe");

			UpdateStatus("Webseite Initial Laden...");
			pbProgress.Value = 3;

			WebPage = tbWebPage.Text;

			try
			{
				driver.Navigate().GoToUrl(WebPage);
			}
			catch (OpenQA.Selenium.WebDriverException)
			{
				lblErrorText.Text = "Fehler beim Laden der Webseite";
				ErrorReset();
				return;
			}

			UpdateStatus("Elemente auf der Webseite suchen...");
			pbProgress.Value = 4;

			IWebElement userlogin = null;
			IWebElement passwordlogin = null;
			IWebElement loginbutton = null;


			while (userlogin == null || passwordlogin == null || loginbutton == null)
			{
				try
				{
					userlogin = driver.FindElement(By.Id("asdf"));
					passwordlogin = driver.FindElement(By.Id("fdsa"));
					loginbutton = driver.FindElement(By.XPath("//input[@class=\"submit\"]"));
				}
				catch (Exception)
				{
					System.Threading.Thread.Sleep(100);
					loadCount++;

					if (loadCount > MAX_LOAD_COUNT)
					{
						throw new TimeoutException("Loading the UserLogin took too long");
					}
				}				
			}
			loadCount = 0;

			UpdateStatus("Benutzername und Passwort senden...");
			pbProgress.Value = 5;


			string username = tbUsername.Text;
			string password = tbPassword.Text;

			

			userlogin.SendKeys(username);
			passwordlogin.SendKeys(password);
			
			loginbutton.Click();

			UpdateStatus("Navigiere zu \"Prüfungen\"...");
			pbProgress.Value = 6;

			IWebElement pruefungButton = null;
			while (pruefungButton == null)
			{
				try
				{
					pruefungButton = driver.FindElement(By.LinkText("Prüfungen"));
				}
				catch (Exception)
				{
					System.Threading.Thread.Sleep(100);
					loadCount++;

					if (loadCount > MAX_LOAD_COUNT)
					{
						throw new TimeoutException("Loading the Prüfungen took too long");
					}
				}				
			}
			loadCount = 0;

			pruefungButton.Click();
			
			UpdateStatus("Navigiere zu \"Notenspiegel\"...");
			pbProgress.Value = 6;

			IWebElement notenspiegelButton = null;
			while (notenspiegelButton == null)
			{
				try
				{
					notenspiegelButton = driver.FindElement(By.LinkText("Notenspiegel"));
				}
				catch (Exception)
				{
					System.Threading.Thread.Sleep(100);
					loadCount++;

					if (loadCount > MAX_LOAD_COUNT)
					{
						throw new TimeoutException("Loading the Notenspiegel took too long");
					}
				}
			}
			loadCount = 0;
			
			notenspiegelButton.Click();

			IWebElement abschlussButton = null;
			while (abschlussButton == null)
			{
				try
				{
					abschlussButton = driver.FindElement(By.LinkText("Abschluss 84 Bachelor"));
				}
				catch (Exception)
				{
					System.Threading.Thread.Sleep(100);
					loadCount++;

					if (loadCount > MAX_LOAD_COUNT)
					{
						throw new TimeoutException("Loading the abschlussButton took too long");
					}
				}
			}
			loadCount = 0;

			abschlussButton.Click();

			IWebElement miniButton = null;
			while (miniButton == null)
			{
				try
				{
					miniButton = driver.FindElement(By.XPath("//a[contains(@title, 'Leistungen für " + Studiengang + "')]"));
				}
				catch (Exception)
				{
					System.Threading.Thread.Sleep(100);
					loadCount++;

					if (loadCount > MAX_LOAD_COUNT)
					{
						throw new TimeoutException("Loading the miniButton took too long");
					}
				}
			}
			loadCount = 0;

			miniButton.Click();

			IWebElement notenliste = null;
			while (notenliste == null)
			{
				try
				{
					notenliste = driver.FindElement(By.XPath("//table[@style]"));
				}
				catch (Exception)
				{
					System.Threading.Thread.Sleep(100);
					loadCount++;

					if (loadCount > MAX_LOAD_COUNT)
					{
						throw new TimeoutException("Loading the notenliste took too long");
					}
				}
			}
			loadCount = 0;

			//IWebElement notenliste = driver.FindElement(By.XPath("//table[@style]"));

			NotenListeVerarbeiten(notenliste.Text);

			Debug.WriteLine(notenliste.Text);

			pbProgress.Value = pbProgress.Maximum;
			UpdateStatus("Fertig!");


			driver.Close();
			driver.Quit();
		}

        private void NotenListeVerarbeiten(string text)
        {
			lbGrades.Items.Clear();
			//lbGrades.MultiColumn = true;

			var lines = text.Split('\n').ToList();
			lines.RemoveAt(0);

            foreach (string line in lines)
            {
				if (line.Contains("RT") || line.Contains("NGR") || line.Contains("Studienabschnitt"))
                {
					continue;
                }
				var spllitLine = line.Split(' ');
				spllitLine[0] = "";
				lbGrades.Items.Add(spllitLine[1] + spllitLine[2]);
            }
			
			//lbGrades.Items.AddRange(Noten);
		}

        private IWebDriver GetBrowserDriver()
        {
			if (this.rbFirefox.Checked)
			{
				FirefoxOptions options = new FirefoxOptions();
				
				options.AddArgument("-headless");
				//options.AddArgument("-background");
				return new FirefoxDriver(options);
			}
			else
			{
				return new ChromeDriver();
			}
		}

        private string SelectStudy()
        {
			if (rbMEC.Checked)
			{
				return "Mechatronik";
			}
			else if (rbEIT.Checked)
			{
				return "Elektrotechnik und Informationstechnik";
			}
			else
			{
				return "Mechatronik";
			}
		}

        private void ErrorReset()
        {
			lblProgressText.Text = "Error";
			pbProgress.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

		private void UpdateStatus(string text)
        {
			lblProgressText.Text = text;
        }

        private void rbEIT_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

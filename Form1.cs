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

			lvFiltered.Columns.Add("Fach", -2);
			lvFiltered.Columns.Add("Note", -2);
			lvFiltered.Columns.Add("Credits", -2 );
			lvFiltered.Columns.Add("Semester", - 2);
			lvFiltered.Columns.Add("Datum", -2);

			lvFiltered.View = View.Details;

			lvAll.Columns.Add("Fach", -2);
			lvAll.Columns.Add("Note", -2);
			lvAll.Columns.Add("Credits", -2);
			lvAll.Columns.Add("Semester", -2);
			lvFiltered.Columns.Add("Datum", -2);

			lvAll.View = View.Details;
		}

		string WebPage = @"https://icms.hs-hannover.de/";
        private const int MAX_LOAD_COUNT = 300; //*100ms

        private void btnGo_Click(object sender, EventArgs e)
        {
			lvAll.Items.Clear();
			lvFiltered.Items.Clear();

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

			string copyOfNotenListe = notenliste.Text;

			driver.Close();
			driver.Quit();

			//IWebElement notenliste = driver.FindElement(By.XPath("//table[@style]"));

			NotenListeVerarbeiten(copyOfNotenListe);

			Debug.WriteLine(copyOfNotenListe);

			pbProgress.Value = pbProgress.Maximum;
			UpdateStatus("Fertig!");

			tabPage2.BringToFront();
			tabPage4.BringToFront();
		}

        private void NotenListeVerarbeiten(string text)
        {
			// Erste Zeile wegwerfen
			var lines = text.Split('\n').ToList();
			lines.RemoveAt(0);

			var FachListe = new List<Benotung>();			
            foreach (string line in lines)
            {
                if (line.Contains("Studienabschnitt") || line.Contains("Bachelor") || line.Contains(" RT ") || line.Contains(" PV "))
                {
					continue;
                }

				string tmpLine = line.Substring(0, line.Length -1);
				Benotung ben = new Benotung();
				
				// Remove first Nnumber
				tmpLine = tmpLine.Substring(tmpLine.IndexOf(" ") + 1);
				
				int commaIndex = tmpLine.IndexOf(',');
				int endOfFachIndex = commaIndex - 5;

				if (commaIndex != -1)
                {
					ben.Note = tmpLine.Substring(commaIndex - 1, 3);
					ben.Fach = tmpLine.Substring(0, endOfFachIndex);

					ben.Credits = tmpLine.Substring(commaIndex + 6, 1);
                    if (ben.Credits != "5" && ben.Credits != "")
                    {
						ben.Credits = "2,5";
                    }

					tmpLine = tmpLine.Substring(commaIndex + 8);
					ben.Semester = tmpLine.Substring(tmpLine.LastIndexOf(" ") - 4);
				}
                else
                {
					continue;
                }

				//Distinct!
				if (cbDistinct.Checked && FachListe.Any(x => x.Fach == ben.Fach))
				{
					int i = FachListe.FindIndex(x => x.Fach == ben.Fach);
					FachListe.RemoveAt(i);
					lvFiltered.Items.RemoveAt(i);
					continue;
				}

				lvFiltered.Items.Add(new ListViewItem(new[] { ben.Fach, ben.Note, ben.Credits, ben.Semester , ben.SaveDate.ToString("dd.MM.yyyy") }));
				FachListe.Add(ben);
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

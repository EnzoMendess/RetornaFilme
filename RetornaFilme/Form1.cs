using NixPDC;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetornaFilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13025/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));

            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "Top 10 Filmes de Ação de acordo com o site adorocinema" + Environment.NewLine;

            for (int i = 0; i < 10; i++)
            {
                txtRetornaFilme.Text += i + 1 + "°: " + filmes[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
                txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
                txtRetornaFilme.Text += tempoDeFilme[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
            }

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnAventura_Click(object sender, EventArgs e)
        {
            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13001/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "Top 10 Filmes de Aventura de acordo com o site adorocinema" + Environment.NewLine;

            for (int i = 0; i < 10; i++)
            {
                txtRetornaFilme.Text += i + 1 + "°: " + filmes[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
                txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
                txtRetornaFilme.Text += tempoDeFilme[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
            }

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnTerror_Click(object sender, EventArgs e)
        {
            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13009/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }
            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "Top 10 Filmes de Terror de acordo com o site adorocinema" + Environment.NewLine;

            for (int i = 0; i < 10; i++)
            {
                txtRetornaFilme.Text += i + 1 + "°: " + filmes[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
                txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
                txtRetornaFilme.Text += tempoDeFilme[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
            }

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnDrama_Click(object sender, EventArgs e)
        {
            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13008/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "Top 10 Filmes de Drama de acordo com o site adorocinema" + Environment.NewLine;

            for (int i = 0; i < 10; i++)
            {
                txtRetornaFilme.Text += i + 1 + "°: " + filmes[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
                txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
                txtRetornaFilme.Text += tempoDeFilme[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
            }

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnComedia_Click(object sender, EventArgs e)
        {
            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13005/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "Top 10 Filmes de Comédia de acordo com o site adorocinema" + Environment.NewLine;

            for (int i = 0; i < 10; i++)
            {
                txtRetornaFilme.Text += i + 1 + "°: " + filmes[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
                txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
                txtRetornaFilme.Text += tempoDeFilme[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
            }

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnRomance_Click(object sender, EventArgs e)
        {
            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13024/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "Top 10 Filmes de Romance de acordo com o site adorocinema" + Environment.NewLine;

            for (int i = 0; i < 10; i++)
            {
                txtRetornaFilme.Text += i + 1 + "°: " + filmes[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
                txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
                txtRetornaFilme.Text += tempoDeFilme[i].Text + Environment.NewLine;
                txtRetornaFilme.Text += "" + Environment.NewLine;
            }

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnAcaoAleatorio_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int filme = rnd.Next(1, 11);

            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13025/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "A indicação aleatória é: " + Environment.NewLine;

            txtRetornaFilme.Text += filmes[filme].Text + Environment.NewLine;
            txtRetornaFilme.Text += "" + Environment.NewLine;
            txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
            txtRetornaFilme.Text += tempoDeFilme[filme].Text + Environment.NewLine;

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnAventuraAleatoria_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int filme = rnd.Next(1, 11);

            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13001/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "A indicação aleatória é: " + Environment.NewLine;

            txtRetornaFilme.Text += filmes[filme].Text + Environment.NewLine;
            txtRetornaFilme.Text += "" + Environment.NewLine;
            txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
            txtRetornaFilme.Text += tempoDeFilme[filme].Text + Environment.NewLine;

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnTerrorAleatorio_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int filme = rnd.Next(1, 11);

            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13009/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "A indicação aleatória é: " + Environment.NewLine;

            txtRetornaFilme.Text += filmes[filme].Text + Environment.NewLine;
            txtRetornaFilme.Text += "" + Environment.NewLine;
            txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
            txtRetornaFilme.Text += tempoDeFilme[filme].Text + Environment.NewLine;

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnDramaAleatorio_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int filme = rnd.Next(1, 11);

            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13008/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "A indicação aleatória é: " + Environment.NewLine;

            txtRetornaFilme.Text += filmes[filme].Text + Environment.NewLine;
            txtRetornaFilme.Text += "" + Environment.NewLine;
            txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
            txtRetornaFilme.Text += tempoDeFilme[filme].Text + Environment.NewLine;


            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnComediaAleatorio_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int filme = rnd.Next(1, 11);

            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13005/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "A indicação aleatória é: " + Environment.NewLine;

            txtRetornaFilme.Text += filmes[filme].Text + Environment.NewLine;
            txtRetornaFilme.Text += "" + Environment.NewLine;
            txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
            txtRetornaFilme.Text += tempoDeFilme[filme].Text + Environment.NewLine;

            SeleniumMetodos.fecharDriver(driver);
        }

        private void btnRomanceAleatorio_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int filme = rnd.Next(1, 11);

            IWebDriver driver;
            driver = SeleniumMetodos.criaDriver(false);

            SeleniumMetodos.navegarPara(driver, "https://www.adorocinema.com/filmes-todos/notas-espectadores/genero-13024/");
            FuncoesUteis.pausa(5000);

            try
            {
                SeleniumMetodos.clickPorClasse(driver, "close-hit");
            }
            catch (Exception)
            {
            }

            IWebElement todosFilmes = driver.FindElement(By.ClassName("gd-col-middle"));


            List<IWebElement> filmes = new List<IWebElement>();
            filmes = todosFilmes.FindElements(By.ClassName("meta-title-link")).ToList();

            List<IWebElement> tempoDeFilme = new List<IWebElement>();
            tempoDeFilme = todosFilmes.FindElements(By.ClassName("meta-body-info")).ToList();

            txtRetornaFilme.Text = "A indicação aleatória é: " + Environment.NewLine;

            txtRetornaFilme.Text += filmes[filme].Text + Environment.NewLine;
            txtRetornaFilme.Text += "" + Environment.NewLine;
            txtRetornaFilme.Text += "Lançamento/Duração/Genêro: " + Environment.NewLine;
            txtRetornaFilme.Text += tempoDeFilme[filme].Text + Environment.NewLine;

            SeleniumMetodos.fecharDriver(driver);
        }
    }
}

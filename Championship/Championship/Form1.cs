using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Championship
{
    public partial class Form1 : Form
    {
        private string path = Directory.GetCurrentDirectory();
        private Random random = new Random();
        private List<Country> Countries = new List<Country>();
        public Form1()
        {
            InitializeComponent();

            CreateCountries();

            StartPosition();

            background.ImageLocation = path + "\\Sheme.jpg";
        }

        public void CreateCountries()
        {
            Countries.Add(new Country("Россия", path + "\\Россия.jpg", 10));
            Countries.Add(new Country("Бразилия", path + "\\Бразилия.jpg", 10));
            Countries.Add(new Country("Франция", path + "\\Франция.jpg", 7));
            Countries.Add(new Country("Италия", path + "\\Италия.jpg", 8));
            Countries.Add(new Country("Германия", path + "\\Германия.jpg", 6));
            Countries.Add(new Country("Британия", path + "\\Британия.jpg", 8));
            Countries.Add(new Country("Америка", path + "\\Америка.jpg", 5));
            Countries.Add(new Country("Испания", path + "\\Испания.jpg", 4));
        }

        public void StartPosition()
        {
            country1.ImageLocation = Countries[0].Path;
            country2.ImageLocation = Countries[1].Path;
            country3.ImageLocation = Countries[2].Path;
            country4.ImageLocation = Countries[3].Path;
            country5.ImageLocation = Countries[4].Path;
            country6.ImageLocation = Countries[5].Path;
            country7.ImageLocation = Countries[6].Path;
            country8.ImageLocation = Countries[7].Path;
        }

        private int PoissonDistribution(int lambda)
        {
            var m = -1;
            double S = 0;
            do
            {
                m++;
                var alpha = random.NextDouble();
                S += Math.Log(alpha);
            } while (S >= -lambda);
            return m;
        }

        private MatchResult GetMatchResult(Country counrty1, Country counrty2)
        {
            MatchResult result = new MatchResult();

            var lambda1 = Countries.Where(x => x.Name == counrty1.Name).Single().Lambda;
            var lambda2 = Countries.Where(x => x.Name == counrty2.Name).Single().Lambda;

            var сountryResult1 = PoissonDistribution(lambda1);
            var сountryResult2 = PoissonDistribution(lambda2);

            if (сountryResult1 == сountryResult2)
            {
                result.isNeedExtraGoal = true;
                var counrtyExtraGoal1 = PoissonDistribution(lambda1);
                var counrtyExtraGoal2 = PoissonDistribution(lambda2);
                while (counrtyExtraGoal1 == counrtyExtraGoal2)
                {
                    counrtyExtraGoal1 = PoissonDistribution(lambda1);
                    counrtyExtraGoal2 = PoissonDistribution(lambda2);
                }
                if (counrtyExtraGoal1 > counrtyExtraGoal2)
                    result.Winner = counrty1;
                else
                    result.Winner = counrty2;
            }
            else
            {
                result.isNeedExtraGoal = false;
                if (сountryResult1 > сountryResult2)
                    result.Winner = counrty1;
                else
                    result.Winner = counrty2;
            }

            result.Country1 = counrty1;
            result.Country2 = counrty2;
            result.CountryResult1 = сountryResult1;
            result.CountryResult2 = сountryResult2;

            return result;
        }

        private void FirstMatches()
        {
            var matchResult1 = GetMatchResult(Countries[0], Countries[1]);
            game11.Text = Countries[0].Name;
            game12.Text = Countries[1].Name;
            res1.Text = $"{matchResult1.CountryResult1} : {matchResult1.CountryResult2}";
            if (matchResult1.isNeedExtraGoal)
                res1.Text += $"\n{matchResult1.Winner.Name} сделала доп. гол";
            semifinal1.ImageLocation = matchResult1.Winner.Path;

            var matchResult2 = GetMatchResult(Countries[2], Countries[3]);
            game21.Text = Countries[2].Name;
            game22.Text = Countries[3].Name;
            res2.Text = $"{matchResult2.CountryResult1} : {matchResult2.CountryResult2}";
            if (matchResult2.isNeedExtraGoal)
                res2.Text += $"\n{matchResult2.Winner.Name} сделала доп. гол";
            semifinal2.ImageLocation = matchResult2.Winner.Path;

            var matchResult3 = GetMatchResult(Countries[4], Countries[5]);
            game31.Text = Countries[4].Name;
            game32.Text = Countries[5].Name;
            res3.Text = $"{matchResult3.CountryResult1} : {matchResult3.CountryResult2}";
            if (matchResult3.isNeedExtraGoal)
                res3.Text += $"\n{matchResult3.Winner.Name} сделала доп. гол";
            semifinal3.ImageLocation = matchResult3.Winner.Path;

            var matchResult4 = GetMatchResult(Countries[6], Countries[7]);
            game41.Text = Countries[6].Name;
            game42.Text = Countries[7].Name;
            res4.Text = $"{matchResult4.CountryResult1} : {matchResult4.CountryResult2}";
            if (matchResult4.isNeedExtraGoal)
                res4.Text += $"\n{matchResult4.Winner.Name} сделала доп. гол";
            semifinal4.ImageLocation = matchResult4.Winner.Path;

            buttonStart.Text = "Полуфинал";
        }

        private void SemiFinal()
        {
            var country1 = Countries.Where(x => x.Path == semifinal1.ImageLocation).Single();
            var country2 = Countries.Where(x => x.Path == semifinal2.ImageLocation).Single();
            var matchResult1 = GetMatchResult(country1, country2);
            game11.Text = country1.Name;
            game12.Text = country2.Name;
            res1.Text = $"{matchResult1.CountryResult1} : {matchResult1.CountryResult2}";
            if (matchResult1.isNeedExtraGoal)
                res1.Text += $"\n{matchResult1.Winner.Name} сделала доп. гол";
            final1.ImageLocation = matchResult1.Winner.Path;

            country1 = Countries.Where(x => x.Path == semifinal3.ImageLocation).Single();
            country2 = Countries.Where(x => x.Path == semifinal4.ImageLocation).Single();
            var matchResult2 = GetMatchResult(country1, country2);
            game21.Text = country1.Name;
            game22.Text = country2.Name;
            res2.Text = $"{matchResult2.CountryResult1} : {matchResult2.CountryResult2}";
            if (matchResult2.isNeedExtraGoal)
                res2.Text += $"\n{matchResult2.Winner.Name} сделала доп. гол";
            final2.ImageLocation = matchResult2.Winner.Path;

            buttonStart.Text = "Финал";
        }

        private void Final()
        {
            var country1 = Countries.Where(x => x.Path == final1.ImageLocation).Single();
            var country2 = Countries.Where(x => x.Path == final2.ImageLocation).Single();
            var matchResult1 = GetMatchResult(country1, country2);
            game11.Text = country1.Name;
            game12.Text = country2.Name;
            res1.Text = $"{matchResult1.CountryResult1} : {matchResult1.CountryResult2}";
            if (matchResult1.isNeedExtraGoal)
                res1.Text += $"\n{matchResult1.Winner.Name} сделала доп. гол";
            winner.ImageLocation = matchResult1.Winner.Path;

            buttonStart.Text = "Начать";
        }

        private void ClearPlayOff()
        {
            semifinal1.ImageLocation = "";
            semifinal2.ImageLocation = "";
            semifinal3.ImageLocation = "";
            semifinal4.ImageLocation = "";

            final1.ImageLocation = "";
            final2.ImageLocation = "";

            winner.ImageLocation = "";
        }

        private void ClearInfo()
        {
            game11.Text = "";
            game12.Text = "";
            res1.Text = "";

            game21.Text = "";
            game22.Text = "";
            res2.Text = "";

            game31.Text = "";
            game32.Text = "";
            res3.Text = "";

            game41.Text = "";
            game42.Text = "";
            res4.Text = "";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ClearInfo();
            if (buttonStart.Text == "Начать")
            {
                ClearPlayOff();
                FirstMatches();
            }
            else if (buttonStart.Text == "Полуфинал")
                SemiFinal();
            else
                Final();
        }
    }
}

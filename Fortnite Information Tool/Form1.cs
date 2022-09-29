using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using Fortnite_Information_Tool.Discord;
using MetroFramework.Forms;
using Newtonsoft.Json;
using static Fortnite_Information_Tool.Fortnite.CosmeticClass;
using System.Net.Http;
using System.IO;
using System.Threading;
using Fortnite_Information_Tool.Properties;
using System.Runtime.CompilerServices;
using Fortnite_Information_Tool.Fortnite;
namespace Fortnite_Information_Tool
{
    public partial class Form1 : MetroForm
    {
        Discord.DiscordRPC RPC = new Discord.DiscordRPC();
        private string DataLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\\Athena.txt";
        private string Json;
        private string Json2;
        private string AccountID;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(DataLocation)) File.Delete(DataLocation);
            RPC.Connect();
            label1.Text = $"Welcome | {Environment.UserName}";
        }
        private void gunaCirclePictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCaAzOHc9k-kWh-lxAOhDc-Q");
        }
        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Kyro999");
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            string API = $"https://fortnite-api.com/v2/cosmetics/br/{metroTextBox1.Text}";
            WebClient wb = new WebClient();
            try
            {
                Json = wb.DownloadString(API);
            } catch (Exception)
            {
                MessageBox.Show("[❌]: ERROR, the cosmetic was not found or has not yet been added to the featured api.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Root root = JsonConvert.DeserializeObject<Root>(Json);
            if (root.status == 200)
            {
                richTextBox2.Clear();
                richTextBox2.AppendText($"[✅]: Cosmetic Found - ({DateTime.Now})");
                pictureBox1.Load(root.data.images.icon);
                ItemName.Text = $"{root.data.name}";
                ID.Text = $"{root.data.id}";
                PakPath.Text = $"{root.data.path}";
                Rarity.Text = $"{root.data.rarity.displayValue}";
                Description.Text = $"{root.data.description}";
            }
        }
        private async void metroButton2_Click(object sender, EventArgs e)
        {
            GC.Collect();
            //NOTE: Convert
            string API = $"https://account-public-service-prod.ol.epicgames.com/account/api/public/account/displayName/{metroTextBox2.Text}";
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(API);
            request.Method = HttpMethod.Get;
            request.Headers.Add("Authorization", "bearer 022ca69c51234108b9660b16cb1093a8");
            HttpResponseMessage response = await client.SendAsync(request);
            dynamic responseString = await response.Content.ReadAsStringAsync();
            NameToID.Root results = JsonConvert.DeserializeObject<NameToID.Root>(responseString);
            //SEPERATION
            string API1 = $"https://fortnite-api.com/v2/stats/br/v2/{results.id}";
            HttpClient clientsecond = new HttpClient();
            HttpRequestMessage requestsecond = new HttpRequestMessage();
            requestsecond.RequestUri = new Uri(API1);
            requestsecond.Method = HttpMethod.Get;
            requestsecond.Headers.Add("Authorization", "9b65ca6d-4f27-42be-9f66-2761c96c4c16");
            HttpResponseMessage responsesecond = await clientsecond.SendAsync(requestsecond);
            dynamic responseString2 = await responsesecond.Content.ReadAsStringAsync();
            StatClass.RootSecond result = JsonConvert.DeserializeObject<StatClass.RootSecond>(responseString2);
            //NOTE: Display Stats
            PName.Text = $"Name: {result.data.account.name}";
            Progress.Text = $"Progress: {result.data.battlePass.progress}";
            BattlePassLVL.Text = $"BP LVL: {result.data.battlePass.level}";
            SoloWin.Text = $"Total Wins: {result.data.stats.all.overall.wins}";
            Kills.Text = $"Total Kills: {result.data.stats.all.overall.kills}";
            Matches.Text = $"Total Matches Played: {result.data.stats.all.overall.matches}";
            Deaths.Text = $"Total Deaths: {result.data.stats.all.overall.deaths}";
            KD.Text = $"K/D: {result.data.stats.all.overall.kd}";
            MinutesPlayed.Text = $"Total Minutes Played: {result.data.stats.all.overall.minutesPlayed}";
            HoursPlayed.Text = $"Total Hours Played: {result.data.stats.all.overall.minutesPlayed / 60}";
            DaysPlayed.Text = $"Total Days Played: {result.data.stats.all.overall.minutesPlayed / 60 / 24}";
            Score.Text = $"Total Score: {result.data.stats.all.overall.score}";
            TopTen.Text = $"Times Placed Top 10: {result.data.stats.all.overall.top10}";
            Top5.Text = $"Times Placed Top 10: {result.data.stats.all.overall.top5}";
            Top3.Text = $"Times Placed Top 10: {result.data.stats.all.overall.top3}";
            WinRate.Text = $"Win Rate: {result.data.stats.all.overall.winRate}";
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            PName.Text = $"Name: 0";
            Progress.Text = $"Progress: 0";
            BattlePassLVL.Text = $"BP LVL: 0";
            SoloWin.Text = $"Total Wins: 0";
            Kills.Text = $"Total Kills: 0";
            Matches.Text = $"Total Matches Played: 0";
            Deaths.Text = $"Total Deaths: 0";
            KD.Text = $"K/D: 0";
            MinutesPlayed.Text = $"Total Minutes Played: 0";
            Score.Text = $"Total Score: 0";
            TopTen.Text = $"Times Placed Top 10: 0";
            Top5.Text = $"Times Placed Top 10: 0";
            Top3.Text = $"Times Placed Top 10: 0";
            WinRate.Text = $"Win Rate: 0";
        }
        private void metroButton6_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/1gVDgnzNyMCafIWa-dBO3mgNUHmHzgA9O5sWbfQy2Yfg/edit#gid=0");
        }
        private void metroButton5_Click(object sender, EventArgs e)
        {
            ItemName.Text = "Name | Null";
            ID.Text = "ID | Null";
            PakPath.Text = "Pak Path | Null";
            Rarity.Text = "Rarity | Null";
            Introduction.Text = "Introduced | Null";
            Description.Text = "Description | Null";
            pictureBox1.Load("https://cdn.discordapp.com/attachments/978861735102541854/1022362377926225930/unknown3.png");
            MessageBox.Show("Cleared!", "Fortnite Information Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void metroButton7_Click(object sender, EventArgs e)
        {
            File.Create(DataLocation).Close();
            FileStream fs = new FileStream(DataLocation, FileMode.Open, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write($"Name: {ItemName.Text}\nID: {ID.Text}\nPak Path: {PakPath.Text}\nRarity: {Rarity.Text}\nIntroduction: {Introduction.Text}\nDescription: {Description.Text}");
            sw.Close();
            MessageBox.Show($"Data has been saved!\n\nLocation: {DataLocation}", "Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.epicgames.com/account/personal?lang=en&productName=epicgames");
            MessageBox.Show("You have been re-directed to an EpicGames account information page, your id will be listed right there.\n\nMake sure your logged in to view it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FN_Status_Click(object sender, EventArgs e)
        {
            Process.Start("https://status.epicgames.com/");
        }
    }
}
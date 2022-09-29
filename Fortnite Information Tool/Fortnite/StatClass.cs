using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fortnite_Information_Tool.Fortnite
{
    public class StatClass
    {
        public class Account
        {
            public string id { get; set; }
            public string name { get; set; }
        }

        public class All
        {
            public Overall overall { get; set; }
            public Solo solo { get; set; }
            public Duo duo { get; set; }
            public object trio { get; set; }
            public Squad squad { get; set; }
            public Ltm ltm { get; set; }
        }

        public class BattlePass
        {
            public int level { get; set; }
            public int progress { get; set; }
        }

        public class Data
        {
            public Account account { get; set; }
            public BattlePass battlePass { get; set; }
            public object image { get; set; }
            public Stats stats { get; set; }
        }

        public class Duo
        {
            public int score { get; set; }
            public double scorePerMin { get; set; }
            public double scorePerMatch { get; set; }
            public int wins { get; set; }
            public int top5 { get; set; }
            public int top12 { get; set; }
            public int kills { get; set; }
            public double killsPerMin { get; set; }
            public double killsPerMatch { get; set; }
            public int deaths { get; set; }
            public double kd { get; set; }
            public int matches { get; set; }
            public double winRate { get; set; }
            public int minutesPlayed { get; set; }
            public int playersOutlived { get; set; }
            public DateTime lastModified { get; set; }
        }
        public class Gamepad
        {
            public Overall overall { get; set; }
            public Solo solo { get; set; }
            public Duo duo { get; set; }
            public object trio { get; set; }
            public Squad squad { get; set; }
            public Ltm ltm { get; set; }
        }

        public class KeyboardMouse
        {
            public Overall overall { get; set; }
            public object solo { get; set; }
            public Duo duo { get; set; }
            public object trio { get; set; }
            public Squad squad { get; set; }
            public Ltm ltm { get; set; }
        }
        public class Ltm
        {
            public int score { get; set; }
            public double scorePerMin { get; set; }
            public double scorePerMatch { get; set; }
            public int wins { get; set; }
            public int kills { get; set; }
            public double killsPerMin { get; set; }
            public double killsPerMatch { get; set; }
            public int deaths { get; set; }
            public double kd { get; set; }
            public int matches { get; set; }
            public double winRate { get; set; }
            public int minutesPlayed { get; set; }
            public int playersOutlived { get; set; }
            public DateTime lastModified { get; set; }
        }
        public class Overall
        {
            public int score { get; set; }
            public double scorePerMin { get; set; }
            public double scorePerMatch { get; set; }
            public int wins { get; set; }
            public int top3 { get; set; }
            public int top5 { get; set; }
            public int top6 { get; set; }
            public int top10 { get; set; }
            public int top12 { get; set; }
            public int top25 { get; set; }
            public int kills { get; set; }
            public double killsPerMin { get; set; }
            public double killsPerMatch { get; set; }
            public int deaths { get; set; }
            public double kd { get; set; }
            public int matches { get; set; }
            public double winRate { get; set; }
            public int minutesPlayed { get; set; }
            public int playersOutlived { get; set; }
            public DateTime lastModified { get; set; }

        }
        public class RootSecond
        {
            public int status { get; set; }
            public Data data { get; set; }
        }
        public class Solo
        {
            public int score { get; set; }
            public double scorePerMin { get; set; }
            public double scorePerMatch { get; set; }
            public int wins { get; set; }
            public int top10 { get; set; }
            public int top25 { get; set; }
            public int kills { get; set; }
            public double killsPerMin { get; set; }
            public double killsPerMatch { get; set; }
            public int deaths { get; set; }
            public double kd { get; set; }
            public int matches { get; set; }
            public double winRate { get; set; }
            public int minutesPlayed { get; set; }
            public int playersOutlived { get; set; }
            public DateTime lastModified { get; set; }
        }

        public class Squad
        {
            public int score { get; set; }
            public double scorePerMin { get; set; }
            public double scorePerMatch { get; set; }
            public int wins { get; set; }
            public int top3 { get; set; }
            public int top6 { get; set; }
            public int kills { get; set; }
            public double killsPerMin { get; set; }
            public double killsPerMatch { get; set; }
            public int deaths { get; set; }
            public double kd { get; set; }
            public int matches { get; set; }
            public double winRate { get; set; }
            public int minutesPlayed { get; set; }
            public int playersOutlived { get; set; }
            public DateTime lastModified { get; set; }
        }

        public class Stats
        {
            public All all { get; set; }
            public KeyboardMouse keyboardMouse { get; set; }
            public Gamepad gamepad { get; set; }
            public Touch touch { get; set; }
        }

        public class Touch
        {
            public Overall overall { get; set; }
            public Solo solo { get; set; }
            public Duo duo { get; set; }
            public object trio { get; set; }
            public Squad squad { get; set; }
            public Ltm ltm { get; set; }
        }
    }
}
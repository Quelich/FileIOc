using System;
using System.Collections.Generic;
using System.IO;
namespace IOReader {
    
    public class Utils {
        protected static Utils myUtil = new Utils();
        protected static Info myInfo = new Info();

        public Dictionary<int, string> _songDir = new Dictionary<int, string>();
        
        
        public static Random myRandom = new Random();
        public enum Emotion_Reference {
            Interest,
            Joy,
            Surprise,
            Sadness,
            Anger,
            Disgust,
            Contempt,
            Self_Hostility,
            Fear,
            Shame,
            Shyness,
            Guilt
        }
        /// <summary>
        /// Dictionary of the Indicator words to compare the words of song
        /// </summary>
        /// <typeparam name="int"> Key</typeparam>
        /// <typeparam name="string[]"> Value </typeparam>
        /// <returns>null</returns>
        public static Dictionary<int, string[]> _indicatorWords = new Dictionary<int, string[]>();
        /// <summary>
        /// Contains data about emotions
        /// </summary>
        /// <value> reference emotions[x]</value>
        public List<SentimentData> emotions = new List<SentimentData> {

            new SentimentData ("Interest", (int) Emotion_Reference.Interest, 5f), //emotions[0]
            new SentimentData ("Joy", (int) Emotion_Reference.Joy, 10f), //emotions[1]
            new SentimentData ("Surprise", (int) Emotion_Reference.Surprise, 15f), //emotions[2]
            new SentimentData ("Sadness", (int) Emotion_Reference.Sadness, 20f), //emotions[3]
            new SentimentData ("Anger", (int) Emotion_Reference.Anger, 25f), //emotions[4]
            new SentimentData ("Disgust", (int) Emotion_Reference.Disgust, 30f), //emotions[5]
            new SentimentData ("Contempt", (int) Emotion_Reference.Contempt, 35f), //emotions[6]
            new SentimentData ("SHostility", (int) Emotion_Reference.Self_Hostility, 40f), //emotions[7]
            new SentimentData ("Fear", (int) Emotion_Reference.Fear, 45f), //emotions[8]
            new SentimentData ("Shame", (int) Emotion_Reference.Shame, 50f), //emotions[9]
            new SentimentData ("Shyness", (int) Emotion_Reference.Shyness, 55f), //emotions[10]
            new SentimentData ("Guilt", (int) Emotion_Reference.Guilt, 60f), //emotions[11]
        };
       
        #region Writers 
       
        public void StreamWriter () {
            string[] lines = { "100", "150", "200", "Third" };
            using (StreamWriter file = new StreamWriter (@"D:\GitRepos\FileIOc\IOReader\FinalSong.txt")) {
                foreach (var line in lines) {
                    if (line.Contains ("Third")) {
                        file.WriteLine (line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter (@"D:\GitRepos\FileIOc\IOReader\FinalSong.txt", true)) {
                file.WriteLine ("Additional test line");
            }
        }
      
        public void IOWriter(string _fileDir, string[] _parsedPhrase)
        {
         
            //File.WriteAllLines(@"D:\GitRepos\FileIOc\IOReader\WrittenText.txt", _parsedPhrase);
            File.WriteAllLines(_fileDir, _parsedPhrase);
        }
        #endregion

        #region Readers 
       
        public void IOReader(string _path)
        {
          
            string Text = File.ReadAllText(_path);
            System.Console.WriteLine("********************************");
            Console.WriteLine($"{Text}");
            System.Console.WriteLine("********************************");
            Detection(Text);
            Console.ReadKey();
        }
        #endregion
      
        public void Detection (string _phrase) {
            string toParse = _phrase;
            string[] parsedPhrase = toParse.Split (' ');
            foreach (var element in parsedPhrase) {
                
            }

        }
      
        #region RandomSong
        public void _songDirInit()
        {
            _songDir.Add(0,@"D:\GitRepos\FileIOc\IOReader\Songs\FinalSong.txt");
            _songDir.Add(1,@"D:\GitRepos\FileIOc\IOReader\Songs\Ritual_RitaOra.txt");
            _songDir.Add(2,@"D:\GitRepos\FileIOc\IOReader\Songs\Swizznife - Moments ft. JAYNIE.txt");
        }
        public void ShowLibrary()
        {
            foreach (var item in _songDir)
            {
                System.Console.WriteLine(item);
            }
        }
        public int GetRandomSong(int min, int max)
        {
            if ( min >= 0 && max >= 0)
            {
                return myRandom.Next(min, max);
            }
            return -1;
        } 
        #endregion
    }
}
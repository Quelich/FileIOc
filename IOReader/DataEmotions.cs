using System;
using System.IO;
using System.Collections.Generic;
using IOReader;
//TODO Add Indicator for emotions
namespace IOReader
{
    public class DataEmotions {
        public string Name { get; set; } 
        public int ID { get; set; }
        public float Point { get; set; } // Will be given a point with respect to Emotion
        public string[] IndicatorWords{ get;  set; }


        public DataEmotions(){}
        public DataEmotions(string _name, int _id, float _point) {
            this.Name = _name;
            this.ID = _id;
            this.Point = _point;
            this.IndicatorWords = new string[1];
        }
        public override string ToString()
        {
            return String.Format($" ID<{this.ID}> | Name<{this.Name}> | Point<{this.Point}> | Indicators {this.IndicatorWords}");
        }
    }
}
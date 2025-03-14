using System;
using System.Collections.Generic;
using System.Linq;

namespace สร้างคลาส_GPACalculator__ให้สมบูรณ์
{
    public class GPACalculator
    {
        private List<double> scores = new List<double>();

        public void AddScore(double score)
        {
            scores.Add(score);
        }

        public int GetCount()
        {
            return scores.Count;
        }

        public double GetMaxScore()
        {
            return scores.Count > 0 ? scores.Max() : 0;
        }

        public double GetMinScore()
        {
            return scores.Count > 0 ? scores.Min() : 0;
        }

        public double GetGPAx()
        {
            return scores.Count > 0 ? scores.Average() : 0;
        }
      
    }

}

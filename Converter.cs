using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Converter
    {
        private double usdRate, eurRate, rubRate;

        public Converter(double usd, double eur, double rub)
        {
            usdRate = usd;
            eurRate = eur;
            rubRate = rub;
        }

        public double ConvertBYNtoUSD(double byn)
        {
            return byn / usdRate;
        }

        public double ConvertBYNtoEUR(double byn)
        {
            return byn / eurRate;
        }

        public double ConvertBYNtoRUB(double byn)
        {
            return byn / rubRate;
        }

        public double ConvertUSDtoBYN(double usd)
        {
            return usd * usdRate;
        }

        public double ConvertEURtoBYN(double eur)
        {
            return eur * eurRate;
        }

        public double ConvertRUBtoBYN(double rub)
        {
            return rub * rubRate;
        }
    }
}

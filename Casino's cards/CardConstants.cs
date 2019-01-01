using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_s_cards
{
    public class CardConstants
    {
        public const string C2 = "2C";
        public const string D2 = "2D";
        public const string H2 = "2H";
        public const string S2 = "2S";

        public const string C3 = "3C";
        public const string D3 = "3D";
        public const string H3 = "3H";
        public const string S3 = "3S";

        public const string C4 = "4C";
        public const string D4 = "4D";
        public const string H4 = "4H";
        public const string S4 = "4S";

        public const string C5 = "5C";
        public const string D5 = "5D";
        public const string H5 = "5H";
        public const string S5 = "5S";

        public const string C6 = "6C";
        public const string D6 = "6D";
        public const string H6 = "6H";
        public const string S6 = "6S";

        public const string C7 = "7C";
        public const string D7 = "7D";
        public const string H7 = "7H";
        public const string S7 = "7S";

        public const string C8 = "8C";
        public const string D8 = "8D";
        public const string H8 = "8H";
        public const string S8 = "8S";

        public const string C9 = "9C";
        public const string D9 = "9D";
        public const string H9 = "9H";
        public const string S9 = "9S";

        public const string CT = "TC";
        public const string DT = "TD";
        public const string HT = "TH";
        public const string ST = "TS";

        public const string CJ = "JC";
        public const string DJ = "JD";
        public const string HJ = "JH";
        public const string SJ = "JS";

        public const string CQ = "QC";
        public const string DQ = "QD";
        public const string HQ = "QH";
        public const string SQ = "QS";

        public const string CK = "KC";
        public const string DK = "KD";
        public const string HK = "KH";
        public const string SK = "KS";

        public const string CA = "AC";
        public const string DA = "AD";
        public const string HA = "AH";
        public const string SA = "AS";

        private static readonly CardConstants _source = new CardConstants();

        public static IEnumerable<string> GetCardTypes()
        {
            return typeof(CardConstants).GetFields().Where(t => t.IsLiteral && !t.IsInitOnly).Select(t => t.GetValue(_source).ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer2 {
	public class TK {

		// need a set of symbols as tokens like '\u0FF0'
		public static string Token(string s, ref int i, char c) {
            string ST = "";
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString())) {
                    ST = ST + s.Substring(i, 1);
                    i += 1;
                }
                i += 1;
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }
            
            return ST;
        }

        public static string Peek(string s, ref int i, char c) {
            string ST = "";
            int j = i;
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString())) {
                    ST = ST + s.Substring(i, 1);
                    i += 1;
                }
                i = j;
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }

            return ST;
        }

        public static string Peek(string s, char c) {
            string ST = "";
            int i = 0;
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString())) {
                    ST = ST + s.Substring(i, 1);
                    i += 1;
                }
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }

            return ST;
        }

		public static void TokenSkip (string s, ref int i, char c, int SkipTimes) {
			try {
				for (int t = 0; t < SkipTimes; t++){
					while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString())) i += 1;
					i += 1;
				}
			}
			catch (ArgumentOutOfRangeException) { return; }
		}

		public static string WordsPass (string s, int wordsN, char c = ' ') {
            StringBuilder ST = new StringBuilder();
            if (wordsN <= 0 || s == "") return s;
            string [] sAr = s.Split(new [] {c});
            for (int i = wordsN; i < sAr.Length; i++) ST.Append ( sAr[i] + " ");
            return ST.ToString();
        }

        public static string strReverse(string s) {
            char[] tempAr = s.ToCharArray();
            Array.Reverse(tempAr);
            return new string(tempAr);
        }

		public static List<string> TokenStringList (string s, ref int i, char c, char C) { 
            List <string> Result = new List<string>();
            string ST = "";
            
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(C.ToString())) {
                    while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString()) && !s.Substring(i, 1).Equals(C.ToString())) {
                        ST = ST + s.Substring(i, 1);
                        i += 1;
                    }
                    
                    Result.Add (ST); ST = "";
                    //Console.WriteLine ("Check Token: " + s[i]);
                    if (s[i] == C) { i++; return Result; }
                    i++;
                }
                i += 1;
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }

            return Result;
        }

        public static List<int> TokenIntList (string s, ref int i, char c, char C) { 
            List <int> Result = new List<int>();
            string ST = "";
            
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(C.ToString())) {
                    while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString()) && !s.Substring(i, 1).Equals(C.ToString())) {
                        ST = ST + s.Substring(i, 1);
                        i += 1;
                    }
                    
                    Result.Add (int.Parse(ST)); ST = "";
                    //Console.WriteLine ("Check Token: " + s[i]);
                    if (i == s.Length || s[i] == C) { i++; return Result; }
                    i++;
                }
                i += 1;
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }

            return Result;
        }

		public static List<long> TokenLongList (string s, ref int i, char c, char C) { 
            List <long> Result = new List<long>();
            string ST = "";
            
            try {
                while (i < s.Length && !s.Substring(i, 1).Equals(C.ToString())) {
                    while (i < s.Length && !s.Substring(i, 1).Equals(c.ToString()) && !s.Substring(i, 1).Equals(C.ToString())) {
                        ST = ST + s.Substring(i, 1);
                        i += 1;
                    }
                    
                    Result.Add (long.Parse(ST)); ST = "";
                    //Console.WriteLine ("Check Token: " + s[i]);
                    if (i == s.Length || s[i] == C) { i++; return Result; }
                    i++;
                }
                i += 1;
            }
            catch (ArgumentOutOfRangeException) { if (ST.Length == 0) { return null;} }

            return Result;
        }
        public static string IntListToString (List<int> Ar, char c) {
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < Ar.Count; i++) SB.Append(Ar[i] + c.ToString());
            return SB.ToString();
        }

		public static string StringListToString (List<string> Ar, char c) {
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < Ar.Count; i++) SB.Append(Ar[i] + c);
            return SB.ToString();
        }
	}
}

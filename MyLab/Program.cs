using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace MyLab
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120));
            //==============================================================================
            //Console.WriteLine(MonthName(0));
            //=======================================================================
            //var a = MultiplyByLength(new int[] { 1, 3, 5, 6 });
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}
            //================================================================================

            //Console.WriteLine(
            //    DiagonalDifference( new List<List<int>>()
            //    { 
            //        new List<int>(){ 11, 2, 4 }, 
            //        new List<int>() { 4, 5, 6 }, 
            //        new List<int>() { 10, 8, -12} 
            //    }));
            //==================================================================================

            //PlusMinus(new List<int> { -4, 3, -9, 0, 4, 1 });
            //====================================================================

            //Staircase(9);
            //========================================================================

            //MiniMaxSum(new List<int> { 1, 3, 5, 7, 9 });
            //MiniMaxSum(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
            //===================================================================================

            //Console.WriteLine(ReverseWord("afe"));
            //=======================================================================================

            //Console.WriteLine(TimeConversion("07:05:45PM"));
            //========================================================================================
            //Console.WriteLine(MinimumDistances(new List<int> { 1, 2, 3, 4, 3, 6, 7, 2, 9 }));

            //=========================================================================================
            //var tt = PrintDateTimeFormats();
            //for (int i = 0; i < tt.Length; i++)
            //{

            //    Console.WriteLine($"{tt[i]} --- {i}");
            //}
            //===============================================================================================

            //Console.WriteLine(HowManyGames(20, 3, 6, 80));
            //=========================================================================================

            //Console.WriteLine(Factorial(5));
            //======================================================================================

            //Console.WriteLine(RandomNum());
            //====================================================================================

            //for (int i = 0; i < 5000; i++)
            //{
            //    Console.WriteLine(ExtractNumberFromString(Guid.NewGuid().ToString()));
            //}
            //========================================================================================

            //Console.WriteLine(FirstDayOfYear(DateTime.Now));
            //================================================================================

            //var people = GenerateSn();
            //foreach (var item in people)
            //{
            //    Console.WriteLine($"No: {item.Sn} Name: {item.Name}");

            //}

            //===================================================================================================
            //var dics = ConvertJsonToDic("{\"CcyCode\":\"GMD\",\"CountryCode\":\"GMB\",\"EncryptLogin\":false,\"EnforcePwdDays\":4,\"MaxiPasswordLength\":10}");
            //foreach (var item in dics)
            //{
            //    Console.WriteLine($"key: {item.Key} || value: {item.Value}");
            //}
            //====================================================================================================
            //int[] data = new int[] {3,6,2,8,1,5,4,10,9,7 };

            //==========================================================================================================
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\AdMiN\OneDrive\Desktop\algorithm\1000line.txt");
            //List<int> numbers = new List<int>();
            //// Display the file contents by using a foreach loop.
            //foreach (string line in lines)
            //{
            //    //Console.WriteLine(line);
            //    numbers.Add(int.Parse(line));
            //}

            //int[] data = numbers.ToArray();
            ////ArraySort(data);

            //data.MySort();

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //==========================================================================================================

            //var bbody = new RequstDetails();

            //Console.WriteLine("enter prn then tin");
            //bbody.prn =  Console.ReadLine();
            //bbody.tin = Console.ReadLine();
            //string[] st = new string[] {"afe","ayokunle", "bole" };

            //var res = st.OrderByDescending(x=>x);


            //CallNRA(bbody);

            //==============================================================================

            //Console.WriteLine(ValidateNullableDate("2001-12-29"));

            //string strg = null;

            //Console.WriteLine(strg ?? string.Join("", strg.Take(10)));

            //int value = 8;
            //string binary = Convert.ToString(value, 2);

            //Console.WriteLine(RepeatingChar("bookkeepping"));

            //===========================================================================

            //DateTime dt = DateTime.FromOADate(39938);
            //Console.WriteLine(dt);
            //===========================================================================

            //Console.WriteLine(NameDescription("Ayokunle").Name);
            //Console.WriteLine(NameDescription("Ayokunle").isValid);
            //Console.WriteLine(NameDescription("Ayokunle").Lenth);
            //===========================================================================

            //Console.WriteLine(Regex.Replace("My name IS Afe", @"s", ""));
            //Console.WriteLine("My name IS Afe".Replace(@" ", ""));
            //==========================================================================

            //var result = DynamicResult(1);

            //string resultStr = JsonConvert.SerializeObject(result.ReturnObj);

            //var sst = result.ReturnObj.ToString();

            //PersonInfo personInfoo = JsonConvert.DeserializeObject<PersonInfo>(resultStr);
            //=========================================================================================================

            //StructureOrClass();
            //========================================================================================

            //var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            //Console.WriteLine(student.GetType().Name);
            //=========================================================================================

            // Culture culture = new Culture();

            // culture = MyLibrary.GetCultureInfo();

            //foreach (var item in Fibofibo(16))
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("-------");
            //Console.WriteLine("-------");

            //for (int i = 0; i < 16; i++)
            //{
            //    Console.Write(Fibonacci(i) + " ");
            //}
            //=============================================================================================

            //int n, r, sum = 0, temp;
            //Console.Write("Enter the Number: ");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = (sum * 10) + r;
            //    n = n / 10;
            //}
            //if (temp == sum)
            //    Console.Write("Number is Palindrome.");
            //else
            //    Console.Write("Number is not Palindrome");
            //======================================================

            //ReadDigits(4535);
            //=========================================================

            //string str = "One two     three\n four\tfive ";
            //int i = 0;
            //int wc = 0;
            //bool toCount = false;fibo
            //while (i < str.Length)
            //{

            //    if (str[i] == ' ' || str[i] == '\t' || str[i] == '\n')
            //    {
            //        toCount = false;
            //    }
            //    else if (!toCount)
            //    {
            //        toCount = true;
            //        wc++;
            //    }
            //    i++;
            //}


            //Console.WriteLine(wc);
            //=======================================================================================

            //search("Amen hallelujah amen amen amen", "Amen");

            //==========================================================================================

            //RemoveDup("BookKEepping");

            //==================================================================================

            //string mystr = "jdghd6dndfdn,dfd7nfdksdn8dlccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccsdfkjdlkflidudnvioyiodnvldjf9dsdfmdbkdmndkjdfhdkflndfndmn";
            //char[] s = mystr.ToCharArray();
            //Array.Sort(s);

            //var ans = s.GroupBy(x => x.ToString());
            //var jj = ans.OrderByDescending(y => y.Count()).First().Key;
            //Console.WriteLine();
            //Console.WriteLine(string.Join("",s));

            //=================================================================================

            string mystr = "jdghd6dndfdn,dfd7nfdksdn8dlccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccsdfkjdlkflidudnvioyiodnvldjf9dsdfmdbkdmndkjdfhdkflndfndmn"; 
           
            int[] count = new int[256];
            int max = int.MinValue;
            var result = ' ';
            for (int i = 0; i < mystr.Length; i++)
            {
                count[mystr[i]]++;
                if (max < count[mystr[i]])
                {
                    max = count[mystr[i]];
                    result = mystr[i];
                }
            }

            int[] myaa = new int[256];

            Console.WriteLine("{0}{1}", "charValue:", myaa['d']);

            foreach (var item in myaa)
            {
                Console.Write(item + " ");
            }


            //var ans = s.GroupBy(x => x.ToString());
            //var jj = ans.OrderByDescending(y => y.Count()).First().Key;
            //foreach (var item in count)
            //{
            //    Console.Write(item + " ");
            //}
            Console.WriteLine("----------");
            Console.WriteLine("----------");
            Console.WriteLine(mystr);
            Console.WriteLine(result);

            //=========================================================================================
            var kk = Fibonacci(8);

            Console.WriteLine(Fibonacci(5));

            Console.ReadLine();
        }

        static char[] removeDuplicateBST(char[] str, int n)
        {

            // Create a set using String characters
            // excluding '\0'
            HashSet<char> s = new HashSet<char>(n - 1);
            foreach (char x in str)
                s.Add(x);

            char[] st = new char[s.Count];

            // Print content of the set
            int i = 0;
            foreach (char x in s)
                st[i++] = x;

            return st;
        }

        static string RemoveDup(string str)
        {
            char[] letters = str.ToLower().ToCharArray();
            HashSet<char> s = new HashSet<char>();
            foreach (char x in letters)
            {
                s.Add(x);
            }
            
            string res = string.Join("", s);

            return res; 
        }

        static String removeDuplicate(char[] str, int n)
        {
            // Used as index in the modified string
            int index = 0;

            // Traverse through all characters
            for (int i = 0; i < n; i++)
            {

                // Check if str[i] is present before it
                int j;
                for (j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        break;
                    }
                }

                // If not present, then add it to
                // result.
                if (j == i)
                {
                    str[index++] = str[i];
                }
            }
            char[] ans = new char[index];
            Array.Copy(str, ans, index);
            return String.Join("", ans);
        }


        static int ASCII_SIZE = 256;

        static char getMaxOccuringChar(String str)
        {
            // Create array to keep the count of
            // individual characters and
            // initialize the array as 0
            int[] count = new int[ASCII_SIZE];

            // Construct character count array
            // from the input string.
            int len = str.Length;
            for (int i = 0; i < len; i++)
                count[str[i]]++;

            var bb = count[str[2]]++;

            int max = -1; // Initialize max count
            char result = ' '; // Initialize result

            // Traversing through the string and
            // maintaining the count of each character
            for (int i = 0; i < len; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }

            return result;
        }

        //search pattern
        static int countFreq(String pat, String txt)
        {
            int M = pat.Length;
            int N = txt.Length;
            int res = 0;

            /* A loop to slide pat[] one by one */
            for (int i = 0; i <= N - M; i++)
            {
                /* For current index i, check for
            pattern match */
                int j;
                for (j = 0; j < M; j++)
                {
                    if (txt[i + j] != pat[j])
                    {
                        break;
                    }
                }

                // if pat[0...M-1] = txt[i, i+1, ...i+M-1]
                if (j == M)
                {
                    res++;
                    j = 0;
                }
            }
            return res;
        }

        //search pattern
        public static void search(String txt, String pat)
        {
            int M = pat.Length;
            int N = txt.Length;

            /* A loop to slide pat one by one */
            for (int i = 0; i <= N - M; i++)
            {
                int j;

                /* For current index i, check for pattern
                match */
                for (j = 0; j < M; j++)
                    if (txt[i + j] != pat[j])
                        break;

                // if pat[0...M-1] = txt[i, i+1, ...i+M-1]
                if (j == M)
                    Console.WriteLine("Pattern found at index " + i);
            }
        }

        static char encodedChar(string str, int k)
        {
            // expand string variable is
            // used to store final string
            // after decompressing string str
            String expand = "";

            String temp = ""; // Current substring
            int freq = 0; // Count of current substring

            for (int i = 0; i < str.Length;)
            {
                temp = ""; // Current substring
                freq = 0; // count frequency of current
                          // substring

                // read characters until you
                // find a number or end of string
                while (i < str.Length && str[i] >= 'a'
                                      && str[i] <= 'z')
                {
                    // push character in temp
                    temp += str[i];
                    i++;
                }

                // read number for how many times
                // string temp will be repeated
                // in decompressed string
                while (i < str.Length && str[i] >= '1'
                                      && str[i] <= '9')
                {
                    // generating frequency of temp
                    freq = freq * 10 + str[i] - '0';
                    i++;
                }

                // now append string temp into
                // expand equal to its frequency
                for (int j = 1; j <= freq; j++)
                    expand += temp;
            }

            // this condition is to handle
            // the case when string str is
            // ended with alphabets not
            // with numeric value
            if (freq == 0)
                expand += temp;

            return expand[k - 1];
        }


        public static void ReadDigits(int n)
        {
            int temp, r, sum = 0;
            temp = n;
            while(n > 0)
            {
                r = n % 10;
                Console.WriteLine(r);
                sum = sum + r;
                n = n / 10;
            }
        }

        //Fibonacci Series linear
        public static int[] Fibofibo(int noItm)
        {
            int[] result = new int[noItm];
            for (int i = 0; i < noItm; i++)
            {
                if (i == 0 || i == 1)
                {
                    result[i] = i;
                }
                else
                {
                    result[i] = result[i - 1] + result[i - 2];
                }

                
            }
            return result;
        }

        //Fibonacci Series Recursive
        public static int Fibonacci(int len)
        {
            int[] res = new int[len];
            if (len == 0) return 0;
            if (len == 1) return 1;
            return Fibonacci(len - 1) + Fibonacci(len - 2);
        }


        public static void StructureOrClass()
        {
            MyStructure[] objStruct = new MyStructure[1000];
            MyClass[] objClass = new MyClass[1000];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                objStruct[i] = new MyStructure();
                objStruct[i].Name = "Sourav";
                objStruct[i].Surname = "Kayal";
            }
            sw.Stop();
            Console.WriteLine("For Structure:- " + sw.ElapsedTicks);
            sw.Restart();
            for (int i = 0; i < 1000; i++)
            {
                objClass[i] = new MyClass();
                objClass[i].Name = "Sourav";
                objClass[i].Surname = "Kayal";
            }
            sw.Stop();
            Console.WriteLine("For Class:- " + sw.ElapsedTicks);
            Console.ReadLine();
        }

        public static ReturnModel DynamicResult(int val)
        {
            if (val == 1)
            {
                return new ReturnModel
                {
                    Status = true,
                    Message = "This is person info",
                    ReturnObj = new PersonInfo { Name = "Afe", Sn = 1 } 
                };
            }

            if (val == 2)
            {
                return new ReturnModel
                {
                    Status = true,
                    Message = "This is prn",
                    ReturnObj = new { prn = "Afek87789", tin = "897986766987" }
                };
            }

            return null;
        }

        public static (string Name, bool isValid, int Lenth) NameDescription(string name)
        {
            return ($"Your name is {name}", !string.IsNullOrEmpty(name), name.Length);
        }

        public static DateTime? ValidateNullableDate(string Param)
        {
            if (string.IsNullOrWhiteSpace(Param))
            {
                return null;
            }

            try
            {
                DateTime decChck;

                bool val = DateTime.TryParse(Param, out decChck);

                if (val)
                {
                    return decChck;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                var exM = ex == null ? ex.InnerException.Message : ex.Message;
                return null;
            }

        }


        public static string RepeatingChar(string str)
        {
            char[] splited = str.ToCharArray();
            char[] splitedCheck = str.ToCharArray();

            //foreach (char item in str)
            //{
            //    Array.Fill(splited, item);
            //    Array.Fill(splitedCheck, item);
            //}
            string stringRes = string.Empty;
            for (int i = 0; i < splited.Length; i++)
            {
                char[] found = Array.FindAll(splitedCheck, x => x == splited[i]);
                if (found.Length > 1)
                {
                    if (!stringRes.Contains(found[0]))
                    {
                        stringRes = stringRes + found[0];
                    }
                    
                    
                }
                
            }
            var newarr = stringRes.ToCharArray();
            Array.Sort(newarr);

            return string.Join("", newarr);

        }


        public static async void CallNRA(RequstDetails details)
        {
            var json = JsonConvert.SerializeObject(details);
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44385/api/Renda/getPaymentDetails"),

                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request);

            var responseInfo = await response.Content.ReadAsStringAsync() ;

            Console.WriteLine("");

        }

        //var client = new RestClient("https://localhost:44385/api/Renda/getPaymentDetails");
        //client.Timeout = -1;
        //var request = new RestRequest(Method.GET);
        //request.AddHeader("Content-Type", "application/json");
        //var body = JsonConvert.SerializeObject(details);
        //request.AddParameter("application/json", body, ParameterType.RequestBody);
        //IRestResponse response = client.Execute(request);
        //Console.WriteLine(response.Content);


        // I want to change this to extension method
        //public static void GenerateSn(this List<object> value)
        //{
        //    //List<PersonInfo> personInfos = new List<PersonInfo>()
        //    //{
        //    //    new PersonInfo{Name = "Afe"},
        //    //    new PersonInfo{Name = "Tayo"}
        //    //};

        //    int count = 1;
        //    value.ForEach(x => x.GetType().GetProperty("Sn"));

        //}

        public static void ArraySort(int[] data)
        {
            int i, j;
            int N = data.Length;
            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1]) exchange(data, i, i + 1);

                }
            }

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

       

        private static void exchange(int[] data, int i, int v)
        {
            var x = data[i];
            var y = data[v];

            data[i] = y;
            data[v] = x;
        }

        public static Dictionary<string, string> ConvertJsonToDic(string json)
        {
            var converted = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return converted;
        }


        public static DateTime FirstDayOfMonth(DateTime value)
        {
            var t = new DateTime(value.Year, value.Month, 1);
            return t;
        }

        public static DateTime FirstDayOfYear(DateTime value)
        {
            return new DateTime(value.Year, 1, 1);
        }

        public static string ExtractNumberFromString(string strg)
        {
            string res = string.Empty;
            //string numericPhone = new String(strg.Where(Char.IsDigit).ToArray());
            string numericPhone = new string(strg.Where(char.IsDigit).ToArray());
            if (numericPhone.Length < 6)
            {
                var urgment = new string(Guid.NewGuid().ToString().Where(char.IsDigit).ToArray());
                res = numericPhone + urgment.Substring(0, (6 - numericPhone.Length));
            }
            else
            {
                res = numericPhone.Substring(0, 6);
            }
            return res;
        }


        public static int HowManyGames(int p, int d, int m, int s)
        {

            int count = 0;
            while (s >= p)
            {
                count++;
                s -= p;
                p = Math.Max(p - d, m);
            }
            return count;


            //s = s - p;
            //int count = 1;
            //int lastesPrice = p;

            //do
            //{
            //    count++;
            //    if(lastesPrice > m) lastesPrice = lastesPrice - d;
            //    s = s - lastesPrice;
            //} while (s > m);

            //return count;
        }



        public static int Factorial(int num)
        {
            if (num == 0) return 1;
            return num * Factorial(num - 1);


        }


        public static int MinimumDistances(List<int> a)
        {
            if (a.Distinct().Count() == a.Count) return -1;

            int earliest = 0;
            int latest = 0;

            var minidis = int.MaxValue;
            
            for (int i = 0; i < a.Count; i++)
            {

                var currentNo = a[i];
                earliest = i;
                latest = a.LastIndexOf(currentNo) ;
                if(earliest != latest)
                {
                    minidis = (latest - earliest) < minidis ? (latest - earliest) : minidis;
                }
                
            }
            return minidis;
        }


        public static string[] PrintDateTimeFormats()
        {

            var mytime = DateTime.Parse("7:55:30PM").GetDateTimeFormats();

            return mytime;
        }




        public static string TimeConversion(string s)
        {
            var mytime = DateTime.Parse(s).ToString("HH:mm:ss");

            return mytime;
        }


        public static void MiniMaxSum(List<int> arr)
        {
            long mini = long.MaxValue;
            long mx = 0;
            List<long> tempArr;
            for (int i = 0; i < arr.Count; i++)
            {
                
                tempArr = arr.Select(x => Convert.ToInt64(x)).ToList();
                tempArr.RemoveAt(i);
                mini =  tempArr.Sum() < mini ? tempArr.Sum(): mini;
                mx = tempArr.Sum() > mx ? tempArr.Sum() : mx;
                tempArr.Clear();
            }
            Console.WriteLine($"minimum = {mini}, max = {mx}");
        }


        public static string ReverseWord(string word)
        {
            //var rev = word.Reverse<char>().ToString();
            var rev = string.Concat(word.Reverse<char>());
            return rev;
        }


        public static int FindHishest(List<int> cand)
        {
            var max = cand.Max();
            int res = cand.Count(x => x == max);
            return res;
        }

        public static string Interview(int[] arr, int tot)
        {
            if (arr.Length < 8) return "Disqualified";
            if(tot > 120) return "Disqualified";
            if (arr[0]>5 || arr[1] > 5) return "Disqualified";
            if (arr[2] > 10 || arr[3] > 10) return "Disqualified";
            if (arr[4] > 15 || arr[5] > 15) return "Disqualified";
            if (arr[6] > 20 || arr[7] > 20) return "Disqualified";
            return "Qualified";

        }

        public static string MonthName(int num)
        {
            string[] months = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            num = num > 12 ? 12 : num < 1 ? 1 : num;
            return months[num - 1];
        }

        public static int[] MultiplyByLength(int[] arr)
        {
            int arrLength = arr.Length;

            int[] resultArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i+=2)
            {
                var result = arrLength * arr[i];
                resultArray[i] = result;

            }
            return resultArray;
        }

        public static int RandomNum()
        {
            return new Random().Next(100, 1099);
            // Random random = new Random();
            //return random.Next(50, 100);
        }

        public static int MultiDimensionalArray(int[,] el)
        {
            int len = el.GetLength(1);
            return len;
        }


        public static int DiagonalDifference(List<List<int>> arr)
        {
            int primary = 0;
            int sec = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                List<int> arrEl = arr[i];
                primary += arrEl[i];
                sec += arrEl[arr.Count - (i+1)];
            }

            return Math.Abs(primary - sec);
        }

        public static void PlusMinus(List<int> arr)
        {
            //ration of positive
            Console.WriteLine(decimal.Round(Convert.ToDecimal(arr.Count(x => x > 0)) / arr.Count, 6));
            //ratio of negatives
            Console.WriteLine(decimal.Round(Convert.ToDecimal(arr.Count(x => x < 0)) / arr.Count, 6));
            //ratio of zeros
            Console.WriteLine(decimal.Round(Convert.ToDecimal(arr.Count(x => x == 0)) / arr.Count, 6));
            
        }

        public static void Staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('#', i+1).PadLeft(n, ' '));
            }
        }

        


    }

    public static class MyArraySort
    {
        public static void MySort(this int[] data)
        {
            int i, j;
            int N = data.Length;
            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        var x = data[i];
                        var y = data[i + 1];

                        data[i] = y;
                        data[i + 1] = x;
                    }
                }
            }
        }
    }

    public class PersonInfo
    {
        public int Sn { get; set; }
        public string Name { get; set; }
    }

    public class RequstDetails
    {
        public string prn { get; set; }
        public string tin { get; set; }
    }

    public class ReturnModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object ReturnObj { get; set; }
    }


    public struct MyStructure
    {
        public string Name;
        public string Surname;
    }
    public class MyClass
    {
        public string Name;
        public string Surname;
    }

    public class Culture
    {
       public string Language { get; set; }
       public string Food { get; set; }
       public string Music { get; set; }
       public string Cloth { get; set; }
    }



    public static class MyLibrary
    {
        public static object GetCultureInfo()
        {
            return new
            {
                Language = "Spanish",
                Food = "Paella Valenciana",
                Music = " flamenco and classical guitar",
                Cloth = "El abrigo"
            };
        }
    }
}

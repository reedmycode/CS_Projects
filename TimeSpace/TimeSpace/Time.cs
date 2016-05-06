using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpace
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        //Constructors
        public Time(int h, int m, int s)
        {
            if (h < 0 || h > 23)
            {
                hour = 0;
            }
            else
            {
                hour = h;
            }
            if (m < 0 || m > 59)
            {
                minute = 0;
            }
            else
            {
                minute = m;
            }
            if (s < 0 || s > 59)
            {
                second = 0;
            }
            else
            {
                second = s;
            }
        }
        public Time()
        {
            DateTime current = DateTime.Now;
            hour = current.Hour;
            minute = current.Minute;
            second = current.Second;
        }
        //Methods 
        public bool setTime(int h, int m, int s)
        {
            bool hrStatus = SetHour(h);
            bool minStatus = SetMinute(m);
            bool secStatus = SetSecond(s);
            if (hrStatus && minStatus && secStatus)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end setTime
        public int[] getTime()
        {
            int[] curTime = new int[3];
            curTime[0] = GetHour();
            curTime[1] = GetMinute();
            curTime[2] = GetSecond();
            return curTime;
        }//end GetTime
        public bool SetHour(int h)
        {
            if (h < 0 || h > 23)
            {
                Console.Out.Write("Invalid hour:{0}", h);
                Console.Out.WriteLine(" Setting hour to 0.");
                hour = 0;
                return false;
            }
            else
            {
                hour = h;
                return true;
            }//endif
        }//end SetHour
        public bool SetMinute(int m)
        {
            if (m < 0 || m > 59)
            {
                Console.Out.Write("Invalid minute:{0}", m);
                Console.Out.WriteLine(" Setting minute to 0.");
                minute = 0;
                return false;
            }
            else
            {
                minute = m;
                return true;
            }//endif
        }//end SetMinute
        public bool SetSecond(int s)
        {
            if (s < 0 || s > 59)
            {
                Console.Out.Write("Invalid second:{0}", s);
                Console.Out.WriteLine(" Setting second to 0.");
                second = 0;
                return false;
            }
            else
            {
                second = s;
                return true;
            }//endif
        }//end SetSecond
        public int GetHour()
        {
            return hour;
        }//end GetHour
        public int GetMinute()
        {
            return minute;
        }//end GetMinute
        public int GetSecond()
        {
            return second;
        }//end GetSecond
        public void AddHour()
        {
            Console.Out.WriteLine("Adding hour...");
            if (hour == 23)
            {
                hour = 0;
            }
            else
            {
                hour++;
            }//endif
        }//end AddHour
        public void AddMinute()
        {
            Console.Out.WriteLine("Adding minute...");
            if (minute == 59)
            {
                minute = 0;
                AddHour();
            }
            else
            {
                minute++;
            }//endif
        }//end AddMinute
        public void AddSecond()
        {
            Console.Out.WriteLine("Adding second...");
            if (second == 59)
            {
                second = 0;
                AddMinute();
            }
            else
            {
                second++;
            }//endif
        }//endAddSecond
        public void DisplayCivilian()
        {
            string hourStr, minStr, secStr, ampm;
            if (hour == 0)
            {
                ampm = "am";
                hourStr = "12";
            }
            else if (hour == 12)
            {
                ampm = "pm";
                hourStr = hour.ToString();
            }
            else if (hour > 12)
            {
                ampm = "pm";
                int temp = hour - 12;
                if (temp < 10)
                {
                    hourStr = "0" + temp.ToString();
                }
                else
                {
                    hourStr = temp.ToString();
                }//endif
            }
            else
            {
                ampm = "am";
                if (hour < 10)
                {
                    hourStr = "0" + hour.ToString();
                }
                else
                {
                    hourStr = hour.ToString();
                }//endif
            }//endif

            if (minute < 10)
            {
                minStr = "0" + minute.ToString();
            }
            else
            {
                minStr = minute.ToString();
            }//endif

            if (second < 10)
            {
                secStr = "0" + second.ToString();
            }
            else
            {
                secStr = second.ToString();
            }//endif
            Console.Out.WriteLine("Civilian time->{0}:{1}:{2}{3}", hourStr, minStr, secStr, ampm);
        }//end DisplayCivilian
        public void DisplayMilitary()
        {
            string hourStr, minStr, secStr;
            if (hour < 10)
            {
                hourStr = "0" + hour.ToString();
            }
            else
            {
                hourStr = hour.ToString();
            }//endif

            if (minute < 10)
            {
                minStr = "0" + minute.ToString();
            }
            else
            {
                minStr = minute.ToString();
            }//endif

            if (second < 10)
            {
                secStr = "0" + second.ToString();
            }
            else
            {
                secStr = second.ToString();
            }//endif

            Console.Out.WriteLine("Military time->{0}:{1}:{2}", hourStr, minStr, secStr);
        }//end DisplayMilitary
        public void Equals(Time t)
        {
            if ((hour == t.hour) && (minute == t.minute) && (second == t.second))
            {
                Console.Out.WriteLine("You have a match");
            }
            else
            {
                Console.Out.WriteLine("No match");
            }//endif
            DisplayMilitary();
            t.DisplayMilitary();
        }//end Equals
    }//end Time
}//end TimeSpace

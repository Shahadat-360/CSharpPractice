//DateTime datetime = new DateTime(2024,12,21,17,20,33,13,13);
//Console.WriteLine(datetime.ToString());

//DateTime nowTime = DateTime.Now;
//Console.WriteLine(nowTime);

//DateTime utcTime = DateTime.UtcNow;
//Console.WriteLine(utcTime.ToString());

//DateTime dt1 = new DateTime(DateTime.MaxValue.Ticks);
//Console.WriteLine(DateTime.MaxValue.Ticks);
//Console.WriteLine(dt1);
//Console.WriteLine(DateTime.MaxValue);

//DateTime date1 = new DateTime(2010, 8, 18, 16, 32, 18, 500);
//Console.WriteLine(date1.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
// The example displays the following output, in this case for en-us culture:
//      8/18/2010 4:32:18.500 PM

//DateTime date1 = new DateTime(2010, 8, 18, 16, 32, 0, DateTimeKind.Utc);
//Console.WriteLine("{0} {1}", date1, date1.Kind);

//DateTime d=new DateTime (int year, int month, int day, System.Globalization.Calendar calendar);

//using System.Globalization;

//DateTime dt = new DateTime(2024, 12, 20, new HijriCalendar());
//Console.WriteLine(dt.ToString());

// Calculate what day of the week is 36 days from this instant.
//System.DateTime today = System.DateTime.Now;
//System.TimeSpan duration = new System.TimeSpan(48, 0, 0, 0);
//System.DateTime answer = today.Add(duration);
//System.Console.WriteLine("{0:dddd}", answer);

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Parsing
    {
            //    List<string> dataList = File.ReadAllLines(@"C:\Users\user\Desktop\4.txt").ToList();
            //    List<Services> servicesList = new List<Services>();

            //    foreach (string data in dataList)
            //    {
            //        string[] splitData = data.Split(',');

            //        Services services = new Services
            //        {
            //            Name = splitData[0].Trim(),
            //            Time = ParseTime(splitData[1].Trim()),
            //            Cost = int.Parse(splitData[2].Trim()),
            //            Sale = ParseSale(splitData[3].Trim())
            //        };

            //        servicesList.Add(services);
            //    }
            //}

            //public static int ParseTime(string time)
            //{
            //    if (time.Contains("мин."))
            //    {
            //        string minutesStr = time.Replace("мин.", "").Trim();
            //        int minutes = int.Parse(minutesStr);
            //        int seconds = minutes * 60;
            //        return seconds;
            //    }
            //    else if (time.Contains("сек."))
            //    {
            //        string secondsStr = time.Replace("сек.", "").Trim();
            //        int seconds = int.Parse(secondsStr);
            //        return seconds;
            //    }

            //    return 0;
            //}
            //public static int ParseSale(string sale)
            //{
            //    if (sale.ToLower() == "нет")
            //    {
            //        return 0;
            //    }
            //    else
            //    {
            //        string salePercentageStr = sale.Replace("%", "").Trim();
            //        int salePercentage = int.Parse(salePercentageStr);
            //        return salePercentage;
            //    }
        }
    }

    



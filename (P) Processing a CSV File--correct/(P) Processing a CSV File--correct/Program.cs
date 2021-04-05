using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Processing_a_CSV_File__correct
{
    class Program
    {
        static void Main(string[] args)
        {

                string[] lines = File.ReadAllLines("sales_data_sample.csv");

                double total_for2003 = 0;
                double total_for2004 = 0;
                double total_for2005 = 0;

                double[] monthly_sales = new double[13];

                // monthly_sales[0] = 0; dont need becasue we are kipping since 0 inst a month
                monthly_sales[1] = 0;
                monthly_sales[2] = 0;
                monthly_sales[3] = 0;
                monthly_sales[4] = 0;
                monthly_sales[5] = 0;
                monthly_sales[6] = 0;
                monthly_sales[7] = 0;
                monthly_sales[8] = 0;
                monthly_sales[9] = 0;
                monthly_sales[10] = 0;
                monthly_sales[11] = 0;
                monthly_sales[12] = 0;

                for (int i = 1; i < lines.Length; i++)
                {
                    //      0           1               2           3           4       5       6       7       8       9       10      11      12             13       14      15
                    // ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE

                    string line = lines[i];

                    string[] pieces = line.Split(",");

                    string status = pieces[6];
                    int year = Convert.ToInt32(pieces[9]);
                    int month = Convert.ToInt32(pieces[8]);
                    double sales = Convert.ToDouble(pieces[4]);

                    if (pieces[6].ToLower() == "shipped")
                    {

                        switch (year)
                        {
                            case 2003:
                                total_for2003 += sales;
                                break;
                            case 2004:
                                total_for2004 += sales;
                                break;
                            case 2005:
                                total_for2005 += sales;
                                break;

                        }

                        monthly_sales[month] += sales;
                    }

                } // end of for

                for (int i = 1; i < monthly_sales.Length; i++)
                {

                    if (i == 1)
                    {
                        Console.WriteLine($"January sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine($"February sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine($"March sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine($"April sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 5)
                    {
                        Console.WriteLine($"May sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 6)
                    {
                        Console.WriteLine($"June sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 7)
                    {
                        Console.WriteLine($"July sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 8)
                    {
                        Console.WriteLine($"August sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 9)
                    {
                        Console.WriteLine($"September sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 10)
                    {
                        Console.WriteLine($"October sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 11)
                    {
                        Console.WriteLine($"November sales total is {monthly_sales[i].ToString("C")}");
                    }
                    else if (i == 12)
                    {
                        Console.WriteLine($"December sales total is {monthly_sales[i].ToString("C")}");
                    }
                }

                Console.WriteLine($"The total sales for shipped items for 2003 is {total_for2003.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items for 2004 is {total_for2004.ToString("C")}!");
                Console.WriteLine($"The total sales for shipped items for 2005 is {total_for2005.ToString("C")}!");

            }
        }
    }
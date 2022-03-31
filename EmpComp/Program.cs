using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Prob.EmpComp
{
    class Program
    {
        public static string EmpWage;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to RFP-131Batch");
            Console.WriteLine("1:EmployeeWageComputations\n2:DailyWage\n3:PartTimeWage\n4:SwitchUser\n5:MonthlyWage\n6:TotalyHrMonthCondition\n7");
            int option = Convert.ToInt32(Console.ReadLine());//"1"
            switch (option)
            {
                case 1:
                    EmployeeWage employeeWage = new EmployeeWage();
                    employeeWage.EmployeeAttendance();
                    Console.WriteLine();
                    break;

                case 2:
                    DailyWage dailyWage = new DailyWage();
                    dailyWage.DailyWages();
                    Console.WriteLine();
                    break;
                case 3:
                    PartTimeWage partTimeWage = new PartTimeWage();
                    partTimeWage.PartTimeEmpWage();
                    Console.WriteLine();
                    break;
                case 4:
                    SwitchUser switchUser = new SwitchUser();
                    switchUser.SwitchCase();
                    Console.WriteLine();
                    break;
                case 5:
                    MonthlyWage monthlyWage = new MonthlyWage();
                    monthlyWage.MonthlyEmpWage();
                    Console.WriteLine();
                    break;
                case 6:
                    UC2_emp_total_hr_month_wages totalHrCondition = new UC2_emp_total_hr_month_wages();
                    totalHrCondition.TotalHrMonthConditions();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Please choose number within range");
                    break;
            }
            Console.ReadLine();

        }
    }
}
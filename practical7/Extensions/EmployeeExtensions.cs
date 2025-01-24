using practical7.Models;

namespace practical7.Extensions
{
    public static class EmployeeExtensions
    {
        public static decimal CalculateAnnualBonus(this Employee employee, decimal bonusPercentage)
        {
            return employee.Salary * bonusPercentage / 100;
        }
    }
}

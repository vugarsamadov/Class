using Nov29Practice.CoreModels;
using Nov29Practice.Helpers;
using System.Data;

namespace Nov29Practice.Services
{
    public class EmployeeService
    {


        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            DataTable datas = await SqlHelper.GetDatasAsync("Select * from EmployeeData");
            return datas.AsEnumerable()                             
                .Select((DataRow dataRow) => new Employee()
                {
                    Id = (int)dataRow["Id"],
                    PositionName = (string)dataRow["Position"],
                    Name = (string)dataRow["Name"],
                    Office = (string)dataRow["Office"],
                    Age = (int)dataRow["Age"],
                    StartDate = (DateTime)dataRow["StartDate"],
                    EndDate= (DateTime)dataRow["EndDate"],
                    Salary = (decimal)dataRow["Salary"]
                }
                ).ToList();
        }


    }
}

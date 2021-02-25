using AllShowMVC.Dao;
using AllShowMVC.Models;
using AllShowMVC.Models.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Service
{
    public class EmployeeService: BaseService<Employee>
    {
        public int CreateEmployee(VW_Employee model)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VW_Employee, Employee>();
            });
            IMapper mapper = config.CreateMapper();
            Employee saveModel = mapper.Map<VW_Employee, Employee>(model);

            return Create(saveModel);
        }
    }
}

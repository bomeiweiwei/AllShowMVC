using AllShowMVC.Dao;
using AllShowMVC.Dao.sql;
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
        readonly EmployeeDao dao;
        public EmployeeService()
        {
            dao = new EmployeeDao();
        }
        public int CreateEmployee(VW_Employee model)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VW_Employee, Employee>();
            });
            IMapper mapper = config.CreateMapper();
            Employee saveModel = mapper.Map<VW_Employee, Employee>(model);

            return dao.Create(saveModel);//Create(saveModel);
        }

        public int EditEmployee(VW_Employee model)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VW_Employee, Employee>();
            });
            IMapper mapper = config.CreateMapper();
            Employee saveModel = mapper.Map<VW_Employee, Employee>(model);

            return dao.Update(saveModel);//Update(saveModel);
        }

        public int DeleteEmployee(int empNo)
        {
            return dao.Delete(empNo);
        }

        public VW_Employee GetEmployee(int EmpNo)
        {
            Employee employee = FindOne(m => m.EmpNo == EmpNo);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, VW_Employee>();
            });
            IMapper mapper = config.CreateMapper();
            VW_Employee editModel = mapper.Map<Employee, VW_Employee>(employee);
            return editModel;
        }
    }
}

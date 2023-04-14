using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProjectService
    {
        public static List<ProjectDTO> Get()
        {

            var data = DataAccessFactory.ProjectData().Get();
            return Convert(data);

        }


        public static List<ProjectDTO> Get10()
        {
            var emps = DataAccessFactory.ProjectData().Get();
            var data = (from e in emps
                        where e.Id < 11
                        select e).ToList();
            return Convert(data);
        }

        public static object Get(string status)
        {
            throw new NotImplementedException();
        }

        public static ProjectDTO Get(int id)
        {
            return Convert(DataAccessFactory.ProjectData().Get(id));
        }
        public static bool Create(ProjectDTO employee)
        {
            var data = Convert(employee);
            var res = DataAccessFactory.ProjectData().Insert(data);

            if (res != null) return true;
            return false;
        }
        public static bool Update(ProjectDTO project)
        {
            var data = Convert(project);
            var res = DataAccessFactory.ProjectData().Update(data);

            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ProjectData().Delete(id);
        }

        static List<ProjectDTO> Convert(List<Project> projects)
        {
            var data = new List<ProjectDTO>();
            foreach (var project in projects)
            {
                data.Add(new ProjectDTO()
                {
                    Id = project.Id,
                    Title = project.Title,
                    Status = project.Status,
                    StartDate =project.StartDate,
                    EndDate= project.EndDate

                });
            }
            return data;

        }
        static Project Convert(ProjectDTO project)
        {
            return new Project()
            {
                Id = project.Id,
                Title = project.Title,
                Status = project.Status,
                StartDate = project.StartDate,
                EndDate = project.EndDate

            };
        }
        static ProjectDTO Convert(Project project)
        {
            return new ProjectDTO()
            {
                Id = project.Id,
                Title = project.Title,
                Status = project.Status,
                StartDate = project.StartDate,
                EndDate = project.EndDate

            };
        }
    }
}

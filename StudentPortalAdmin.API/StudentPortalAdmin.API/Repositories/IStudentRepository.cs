using System;
using StudentPortalAdmin.API.DataModel;

namespace StudentPortalAdmin.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}


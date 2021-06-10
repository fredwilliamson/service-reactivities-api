using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace API.Services
{
    public interface IActivitiesServices
    {
        Task<Activity> FindActivityById(Guid id);

        IEnumerable<Activity> FindActivitiesByIds(IEnumerable<Guid> ids);
        
        Task<List<Activity>>  FindAllActivities();
    }
}
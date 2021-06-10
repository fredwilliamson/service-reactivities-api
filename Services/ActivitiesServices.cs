using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Services
{
    public class ActivitiesServices :IActivitiesServices
    {
        private readonly DataContext _dataContext;

        public ActivitiesServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Activity> FindActivityById(Guid id)
        {
           return await _dataContext.Activities.FindAsync(id);
        }

        public IEnumerable<Activity> FindActivitiesByIds(IEnumerable<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Activity>> FindAllActivities()
        {
            return await _dataContext.Activities.ToListAsync();
        }
    }
}
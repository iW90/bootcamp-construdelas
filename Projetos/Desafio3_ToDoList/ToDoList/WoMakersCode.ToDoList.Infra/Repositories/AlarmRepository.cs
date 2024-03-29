﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WoMakersCode.ToDoList.Core.Entities;
using WoMakersCode.ToDoList.Core.Interfaces;
using WoMakersCode.ToDoList.Infra.Database;

namespace WoMakersCode.ToDoList.Infra.Repositories
{
    public class AlarmRepository : IAlarmRepository
    {
        private readonly ApplicationContext _context;
        public AlarmRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task InsertAlarm(List<Alarm> alarm)
        {
            _context.AddRange(alarm);
            await _context.SaveChangesAsync();
        }
    }
}

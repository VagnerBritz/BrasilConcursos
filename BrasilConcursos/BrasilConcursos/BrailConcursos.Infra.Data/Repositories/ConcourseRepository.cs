﻿using BrasilConcursos.Domain.Entities;
using BrasilConcursos.Domain.Interfaces;
using BrasilConcursos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BrasilConcursos.Infra.Data.Repositories
{
    public class ConcourseRepository : IConcourseRepository
    {
        private readonly ApplicationDbContext _context;
        public ConcourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Concourse>> GetConcoursesAsync()
        {
            return await _context.Concourses
                .Where(x => x.RegistrationEndDate >= DateTime.Today)
                .Include("Positions")
                .ToListAsync();
        }

        public async Task<Concourse> GetConcourseByIdAsync(Guid id)
        {

            //var concourse = await _context.Concourses.FindAsync(id);
            var concourse = await _context.Concourses
                .Include("Positions")
                .FirstOrDefaultAsync(x => x.Id == id); //pra voltar o null
            return concourse;
        }

        public async Task<Concourse> CreateAsync(Concourse concourse)
        {
            _context.Concourses.Add(concourse);
            await _context.SaveChangesAsync();
            return concourse;
        }

        public async Task<Concourse> UpdateAsync(Concourse concourse)
        {
            //_context.ChangeTracker.Clear();

            _context.Update(concourse);

            await _context.SaveChangesAsync();

            return concourse; // tirar esse retorno a hora q refatorar
        }

        public async Task DeleteAsync(Concourse concourse)
        {
            _context.Concourses.Remove(concourse);
            await _context.SaveChangesAsync();

        }

    }
}

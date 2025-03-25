﻿using MediatorAndAggregate.DbContexts;
using MediatorAndAggregate.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatorAndAggregate.Repositories
{
    public class AlumnoRepository : IAlumnoRepository
    {
        private DbSet<Alumno> Alumnos;
        
        public AlumnoRepository(WriteDbContext context)
        {
            Alumnos = context.Alumnos;
        }
        
        public async Task CreateAsync(Alumno obj)
        {
            await Alumnos.AddAsync(obj);
        }

        public async Task<Alumno> FindById(Guid id)
        {
            Alumno? alumno = await Alumnos.FindAsync(id);
            if (alumno != null)
                return alumno;

            return new Alumno(Guid.Empty, "");
        }

        public bool RegistrarAlumno(Guid alumnoId, Guid materiaId)
        {
            throw new NotImplementedException();
        }
    }
}

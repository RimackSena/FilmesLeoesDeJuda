﻿using FIlmesLeoesDeJuda.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIlmesLeoesDeJuda.DAL.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
         Task Adicionar(Usuario usuario);
    }
}
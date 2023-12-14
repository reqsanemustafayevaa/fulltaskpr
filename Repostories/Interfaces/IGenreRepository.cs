﻿using SonProeject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonProeject.Core.Repostories.Interfaces
{
    public interface IGenreRepository : IGenericRepostory<Genre>
    {
        Task GetByIdAsync(int ıd);
    }
}

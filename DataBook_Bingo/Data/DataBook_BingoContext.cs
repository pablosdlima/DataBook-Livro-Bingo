﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataBook_Bingo.Models;

    public class DataBook_BingoContext : DbContext
    {
        public DataBook_BingoContext (DbContextOptions<DataBook_BingoContext> options)
            : base(options)
        {
        }

        public DbSet<DataBook_Bingo.Models.Aldeia> Aldeia { get; set; }
    }
using System;
using Microsoft.EntityFrameworkCore;

namespace backend.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    
}

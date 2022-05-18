using System;
using Microsoft.EntityFrameworkCore;
using tutorialdotnetsixweb.Models;

namespace tutorialdotnetsixweb.Data
{
	public class ApplicationDbContext :DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }
	}
}


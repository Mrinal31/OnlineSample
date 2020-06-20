using Microsoft.EntityFrameworkCore;
using System;

namespace InMemoryDatabse
{
	public class DataBase:  DbContext
	{
		public DataBase (DbContextOptions<DataBase> options) : base(options) { }
	}
}

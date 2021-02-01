﻿using System.Linq;

namespace YourNews.DAL.Interfaces
{
	public interface IRepository<T> where T : class
	{
		IQueryable<T> GetAll();
		T Get(int id);
		void Create(T item);
		void Update(T item);
		void Delete(int id);
	}
}

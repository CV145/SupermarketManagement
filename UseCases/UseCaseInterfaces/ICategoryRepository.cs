﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.UseCaseInterfaces
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> GetCategories();
		void AddCategory(Category category);
		void UpdateCategory(Category category);
		Category GetCategoryById(int id);
		void DeleteCategory(int id);
	}
}

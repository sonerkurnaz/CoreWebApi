﻿using HttpStatusCode.Models.Entities.Concrete;

namespace HttpStatusCode.Infrastructure.Repository.Abstract
{
    public interface ICategoryDAL : IBaseRepository<Category>
    {
        bool CheckName(string name);

    }
}

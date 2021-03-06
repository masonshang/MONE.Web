﻿using MONE.IBLL;
using MONE.IDAL;

namespace MONE.BLL
{
    /// <summary>
    /// 服务基类
    /// <remarks>创建：2016.04.12</remarks>
    /// </summary>
    public abstract class BaseService<T> : InterfaceBaseService<T> where T : class
    {
        protected InterfaceBaseRepository<T> CurrentRepository { get; set; }

        public BaseService(InterfaceBaseRepository<T> currentRepository) { CurrentRepository = currentRepository; }

        public T Add(T entity) { return CurrentRepository.Add(entity); }

        public bool Update(T entity) { return CurrentRepository.Update(entity); }

        public bool Delete(T entity) { return CurrentRepository.Delete(entity); }
    }
}
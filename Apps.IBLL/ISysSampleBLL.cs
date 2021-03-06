﻿using System.Collections.Generic;
using Apps.Models;


namespace Apps.IBLL
{

    public interface ISysSampleBLL
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pager">JQgrid分页</param>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>列表</returns>
        List<SysSample> GetList(string queryStr);
        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        bool Create(SysSample model);
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="id">id</param>
        /// <returns>是否成功</returns>
        bool Delete(string id);

        /// <summary>
        /// 修改一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="model">模型</param>
        /// <returns>是否成功</returns>
        bool Edit(SysSample model);
        /// <summary>
        /// 根据ID获得一个Model实体
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Model实体</returns>
        SysSample GetById(string id);
        /// <summary>
        /// 判断是否存在实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>是否存在</returns>
        bool IsExist(string id);
    }
}
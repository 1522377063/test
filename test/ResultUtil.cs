/*************************************
** Company： 宁波市安贞信息科技有限公司
** auth：    xy
** date：    2018/7/13
** desc：    数据库操作转换实现类
** Ver.:     V1.0.0
**************************************/




using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using test.model;

namespace test.utils
{
    public class ResultUtil
    {

        #region 返回规范结果集
        /// <summary>
        /// 返回规范结果集
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="message">描述</param>
        /// <param name="obj">结果</param>
        /// <returns>string</returns>
        public static string getStandardResult(int status, string message, object obj)
        {
            //new对象
            Result result = new Result();
            //状态
            result.status = status.ToString();
            //描述
            result.message = message;
            //结果
            result.result = obj;

            return JsonConvert.SerializeObject(result);
        }
        #endregion
    }
}
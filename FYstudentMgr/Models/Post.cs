﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FYstudentMgr.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int RoleId { get; set; }//岗位对应的角色id
        public string PostName { get; set; }//岗位名称
        public int UserId { get; set; }//在岗的人员Id
        public int? SupperId { get; set; }//上机主管岗位id
        public int CreateId { get; set; }//创建岗位的岗位id
        public bool State { get; set; }//岗位状态
        public DateTime CreateTime { get; set; }//岗位创建时间
    }
}
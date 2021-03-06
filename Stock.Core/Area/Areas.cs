﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Stock.Areas
{
    [Table("TblArea")]
    public class Area:Entity<string>
    {
        public const int MaxIDLength = 6;

        public const int MaxNameLength = 50;
        /// <summary>
        /// 地区名称
        /// </summary>
        public virtual string Name { get; set; }

        public virtual string ParentId { get; set; }
    }
}

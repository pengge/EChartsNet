using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsNet
{
    /************************************************************************************ 
   * Copyright (c) 2016  All Rights Reserved. 
   * CLR版本： 4.0.30319.34014 
   * 机器名称：CP 
   * 公司名称： 
   * 命名空间：EChartsNet 
   * 文件名：  Series 
   * 版本号：  V1.0.0.0 
   * 创建人：  caipeng
   * 电子邮箱：530566495@qq.com 
   * 创建时间：2016-07-11 16:01:43 
   * 描述    :
   * =====================================================================
   * 修改时间：2016-07-11 16:01:43 
   * 修改人  ：  
   * 版本号  ： V1.0.0.0 
   * 描述    ：
  */
    public class Series
    {
        public string name;

        public string type;

        public List<int> data;//这里要用int 不能用String 不然前台显示不正常（特别是在做数学运算的时候）  

        public Series(string name, string type, List<int> data)
        {
            this.name = name;
            this.type = type;
            this.data = data;
        }
    }
}

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
     * 文件名：  EchartData 
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
    /// <summary>
    /// EchartData 的摘要说明
    /// </summary>
    public class EchartData
    {
        public List<string> legend = new List<string>();//数据分组
        public List<string> category = new List<string>();//横坐标
        public List<Series> series = new List<Series>();//纵坐标 

        public EchartData(List<string> legendList, List<string> categoryList, List<Series> seriesList)
        {
            this.legend = legendList;
            this.category = categoryList;
            this.series = seriesList;
        }
    }

}




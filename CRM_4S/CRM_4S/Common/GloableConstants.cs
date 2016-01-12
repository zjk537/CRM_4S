using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_4S
{
    public class GloableConstants
    {
        public static List<string> SexName = new List<string>() { "未知", "男", "女" };

        public static List<string> CustomerNature = new List<string>() { "新增到店","再次到店","电销邀约","外展留档","二级网点","其它到店"};

        public static List<string> CustomerLevel = new List<string>() {"","A","B","C","H" };

        /// <summary>
        /// 汽车品牌
        /// </summary>
        public static List<string> CarBrand = new List<string>() {"丰田","BYD","广汽" };

        public static List<string> CarLicence = new List<string>() { "已有牌照", "待拍牌照", "旧车退牌", "郊区牌照", "外省上牌" };

        public static List<string> DriveStatus = new List<string>() { "试驾", "未试驾", "未知" };

        public static List<string> DCCSource = new List<string>() { "易车", "汽车之家", "第一车市","厂家平台","其它渠道","展厅战败" };

        /// <summary>
        /// DCC 线索甄别
        /// </summary>
        public static List<string> DCCStatus = new List<string>() { "有效", "无效", "重复" };

        public static List<string> BooleanDesc = new List<string>() { "是", "否", "" };


    }
}

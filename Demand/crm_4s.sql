/*
Navicat MySQL Data Transfer

Source Server         : MySql(172.0.0.1)
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : crm_4s

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-02-16 17:06:54
*/

SET FOREIGN_KEY_CHECKS=0;

CREATE DATABASE IF NOT EXISTS crm_4s DEFAULT CHARSET utf8 COLLATE utf8_general_ci;
use crm_4s;
-- ----------------------------
-- Table structure for analyse_kpi
-- ----------------------------
DROP TABLE IF EXISTS `analyse_kpi`;
CREATE TABLE `analyse_kpi` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT '' COMMENT '指标名称',
  `KValue` int(11) DEFAULT NULL COMMENT '指标临界值',
  `KUnit` varchar(100) DEFAULT NULL COMMENT '指标临界值单位',
  `Perform` varchar(200) DEFAULT NULL COMMENT '主要表现',
  `Reason` varchar(200) DEFAULT NULL COMMENT '主要原因',
  `Suggest` varchar(200) DEFAULT NULL COMMENT '主要建议',
  `Desc` varchar(200) DEFAULT NULL COMMENT '备注',
  `OperatorId` int(11) NOT NULL COMMENT '最后一次操作人',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of analyse_kpi
-- ----------------------------

-- ----------------------------
-- Table structure for basic_constant
-- ----------------------------
DROP TABLE IF EXISTS `basic_constant`;
CREATE TABLE `basic_constant` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ShopId` int(11) NOT NULL DEFAULT '0' COMMENT '店面Id',
  `Name` varchar(100) DEFAULT NULL COMMENT '基础数据描述',
  `Order` int(11) NOT NULL DEFAULT '1' COMMENT '展示排序',
  `TypeKey` varchar(50) DEFAULT NULL COMMENT '分类Key',
  `TypeValue` int(11) NOT NULL DEFAULT '1',
  `Remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of basic_constant
-- ----------------------------
INSERT INTO `basic_constant` VALUES ('1', '0', '全部', '1', 'QType', '2', '问题类型', null, '2016-02-14 09:37:04');
INSERT INTO `basic_constant` VALUES ('2', '0', '店面前台', '2', 'QType', '2', '问题类型', null, '2016-02-14 09:37:04');
INSERT INTO `basic_constant` VALUES ('3', '0', 'DCC专员', '3', 'QType', '2', '问题类型', null, '2016-02-14 09:37:04');
INSERT INTO `basic_constant` VALUES ('4', '0', '新增到店', '1', 'CNature', '3', '顾客性质', null, '2016-02-14 09:37:04');
INSERT INTO `basic_constant` VALUES ('5', '0', '再次到店', '2', 'CNature', '3', '顾客性质', null, '2016-02-14 09:37:04');
INSERT INTO `basic_constant` VALUES ('6', '0', '电销邀约', '3', 'CNature', '3', '顾客性质', null, '2016-02-14 09:37:04');
INSERT INTO `basic_constant` VALUES ('7', '0', '外展留档', '4', 'CNature', '3', '顾客性质', null, '2016-02-14 09:37:04');
INSERT INTO `basic_constant` VALUES ('8', '0', '二级网点', '5', 'CNature', '3', '顾客性质', null, '2016-02-14 09:37:04');
INSERT INTO `basic_constant` VALUES ('9', '0', '其它到店', '6', 'CNature', '3', '顾客性质', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('10', '0', '已有牌照', '1', 'CarLicence', '4', '牌照状况', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('11', '0', '待拍牌照', '2', 'CarLicence', '4', '牌照状况', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('12', '0', '旧车退牌', '2', 'CarLicence', '4', '牌照状况', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('13', '0', '郊区牌照', '3', 'CarLicence', '4', '牌照状况', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('14', '0', '外省上牌', '4', 'CarLicence', '4', '牌照状况', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('15', '0', '自然到店', '1', 'FrontSource', '5', '前台用户来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('16', '0', '网站预约', '2', 'FrontSource', '5', '前台用户来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('17', '0', '朋友介绍', '3', 'FrontSource', '5', '前台用户来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('18', '0', '丰田', '1', 'CarBrand', '6', '汽车品牌', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('19', '0', 'BYD', '2', 'CarBrand', '6', '汽车品牌', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('20', '0', '广汽', '3', 'CarBrand', '6', '汽车品牌', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('21', '0', '哈弗', '4', 'CarBrand', '6', '汽车品牌', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('22', '0', '宝马', '5', 'CarBrand', '6', '汽车品牌', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('23', '0', '其他', '6', 'CarBrand', '6', '汽车品牌', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('24', '0', '易车', '1', 'DCCSource', '7', 'DCC 线索来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('25', '0', '汽车之家', '2', 'DCCSource', '7', 'DCC 线索来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('26', '0', '第一车市', '3', 'DCCSource', '7', 'DCC 线索来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('27', '0', '厂家平台', '4', 'DCCSource', '7', 'DCC 线索来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('28', '0', '展厅战败', '5', 'DCCSource', '7', 'DCC 线索来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('29', '0', '其它渠道', '6', 'DCCSource', '7', 'DCC 线索来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('30', '0', '未完成', '1', 'TaskStauts', '11', '销售顾问任务状态', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('31', '0', '已完成', '2', 'TaskStauts', '11', '销售顾问任务状态', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('32', '0', '未知', '3', 'TaskStauts', '11', '销售顾问任务状态', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('33', '0', '邀约', '0', 'FrontSource', '5', '导入前台客户来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('34', '0', '自然进店', '0', 'FrontSource', '5', '导入前台客户来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('35', '0', '网络', '0', 'FrontSource', '5', '导入前台客户来源', null, '2016-02-14 09:37:05');
INSERT INTO `basic_constant` VALUES ('36', '0', ' 汽车垂直网站 ', '0', 'DCCSource', '5', '导入DCC客户来源', null, '2016-02-14 09:37:05');

-- ----------------------------
-- Table structure for car_type
-- ----------------------------
DROP TABLE IF EXISTS `car_type`;
CREATE TABLE `car_type` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '汽车类型Id ',
  `BrandId` int(11) NOT NULL COMMENT '汽车品牌Id',
  `Brand` varchar(100) NOT NULL COMMENT '汽车品牌',
  `Name` varchar(100) NOT NULL COMMENT '汽车类型名称',
  `Desc` varchar(100) DEFAULT NULL COMMENT '汽车类型描述',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of car_type
-- ----------------------------
INSERT INTO `car_type` VALUES ('1', '0', '其他', '301', '前台_导入车型', null, '2016-02-14 09:50:36');
INSERT INTO `car_type` VALUES ('2', '0', '其他', '308', '前台_导入车型', null, '2016-02-14 09:50:36');
INSERT INTO `car_type` VALUES ('3', '0', '其他', '2008', '前台_导入车型', null, '2016-02-14 09:50:36');
INSERT INTO `car_type` VALUES ('4', '0', '其他', '3008', '前台_导入车型', null, '2016-02-14 09:50:36');
INSERT INTO `car_type` VALUES ('5', '0', '其他', '其他', '前台_导入车型', null, '2016-02-14 09:50:36');
INSERT INTO `car_type` VALUES ('6', '0', '其他', '新408', '前台_导入车型', null, '2016-02-14 09:50:36');
INSERT INTO `car_type` VALUES ('7', '0', '其他', '508', '前台_导入车型', null, '2016-02-14 09:50:36');

-- ----------------------------
-- Table structure for customer
-- ----------------------------
DROP TABLE IF EXISTS `customer`;
CREATE TABLE `customer` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ShopId` int(11) NOT NULL COMMENT '店面Id',
  `Name` varchar(100) DEFAULT NULL COMMENT '客户名称',
  `Sex` int(2) DEFAULT NULL COMMENT '性别：1男 2女',
  `Phone` varchar(50) DEFAULT NULL COMMENT '客户联系方式',
  `ToShopNum` int(11) DEFAULT NULL COMMENT '到店次数',
  `CurCar` varchar(100) DEFAULT NULL COMMENT '现有车型',
  `Nature` int(11) DEFAULT NULL COMMENT '客户性质：对应 basic_constant.TypeKey = CNature',
  `OriginNature` int(11) DEFAULT NULL COMMENT '原始客户性质',
  `Type` varchar(50) DEFAULT NULL COMMENT '客户类型：Front前台客户 DCC:DCC客户',
  `Industry` varchar(100) DEFAULT NULL COMMENT '行业',
  `RegionId` int(11) DEFAULT NULL COMMENT '所在区域Id',
  `Address` varchar(200) DEFAULT NULL COMMENT '居住地址',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=135 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customer
-- ----------------------------
INSERT INTO `customer` VALUES ('1', '1', '李先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('2', '1', '赵先生', null, '13963659086', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('3', '1', '王先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('4', '1', '方先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('5', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('6', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('7', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('8', '1', '郭女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('9', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('10', '1', '孙女士', null, '15006568928', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('11', '1', '崔先生', null, '18953608716', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('12', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('13', '1', '王先生', null, '15966112728', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('14', '1', '冯先生', null, '15154491777', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('15', '1', '程先生', null, '18263608598', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('16', '1', '陈先生', null, '15265689621', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('17', '1', '王先生', null, '13465718831', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('18', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('19', '1', '郭先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('20', '1', '刘先生', null, '15689862558', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('21', '1', '孟先生', null, '18253620410', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('22', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('23', '1', '苏先生', null, '15662570886', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('24', '1', '马先生', null, '15553631597', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('25', '1', '周先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('26', '1', '曲女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('27', '1', '李先生', null, '13098187876', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('28', '1', '王女士', null, '18653663800', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('29', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('30', '1', '王先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('31', '1', '郭先生', null, '13792681865', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('32', '1', '马先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('33', '1', '吴先生', null, '15054572167', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('34', '1', '黄女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('35', '1', '尹先生', null, '13854430622', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('36', '1', '苏先生', null, '15095205588', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 09:50:36');
INSERT INTO `customer` VALUES ('64', '1', ' 范宁波 ', '1', ' 15916981358 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('65', '1', ' 舒清林 ', '1', ' 18823306888 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('66', '1', ' 邓根兴 ', '1', ' 13544610432 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('67', '1', ' 王涛 ', '1', ' 13712761002 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('68', '1', ' 覃生 ', '1', ' 18520811538 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('69', '1', ' 马卫周 ', '1', ' 15711162697 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('70', '1', ' 张 ', '1', ' 13686630309 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('71', '1', ' 李 ', '1', ' 18771078679 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('72', '1', ' 尹才庭 ', '1', ' 18928237205 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('73', '1', ' 汤汤 ', '1', ' 13826960611 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('74', '1', ' 潘国美 ', '1', ' 18650095676 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('75', '1', ' 凌振 ', '1', ' 13826957027 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('76', '1', ' 18988727509 ', '1', ' 18802691558 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('77', '1', ' 叶文波 ', '1', ' 18988727509 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('78', '1', ' 谢佩伶 ', '1', ' 13532387109 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('79', '1', ' 吴耿文 ', '1', ' 15918352331 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('80', '1', ' 易车网2015070137 ', '1', ' 13902601734 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('81', '1', ' 叶 ', '2', ' 051082447009 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('82', '1', ' 麦伟峰 ', '2', ' 18666462392 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('83', '1', ' 王锐标 ', '2', ' 13431429517 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('84', '1', ' 易车网2014120740 ', '2', ' 18922947888 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('85', '1', ' 徐 旭 ', '2', ' 15915440979 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('86', '1', ' 程 ', '2', ' 13450086448 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('87', '1', ' 胡望平 ', '2', ' 13790342750 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('88', '1', ' 张 ', '2', ' 18664061146 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('89', '1', ' 官瑞城 ', '2', ' 13724438302 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('90', '1', ' 易车网2015070167 ', '2', ' 13827220903 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('91', '1', ' 李若彤唐 ', '2', ' 18128661998 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('92', '1', ' 汤应兵 ', '2', ' 15322426993 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('93', '1', ' 李先生 ', '2', ' 15992863708 ', null, null, null, null, 'dcc', null, null, null, null, '2016-02-14 10:40:00');
INSERT INTO `customer` VALUES ('95', '1', '李先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('96', '1', '王先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('97', '1', '方先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('98', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('99', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('100', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('101', '1', '郭女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('102', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('103', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('104', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('105', '1', '郭先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('106', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('107', '1', '周先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('108', '1', '曲女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('109', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('110', '1', '王先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('111', '1', '马先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('112', '1', '黄女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-14 17:09:30');
INSERT INTO `customer` VALUES ('113', '1', '刘', null, '18500519101', '1', null, '4', null, '0', '不知道', '1', '胡同', null, '2016-02-15 12:18:58');
INSERT INTO `customer` VALUES ('114', '1', '李先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('115', '1', '王先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('116', '1', '方先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('117', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('118', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('119', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('120', '1', '郭女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('121', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('122', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('123', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('124', '1', '郭先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('125', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('126', '1', '周先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('127', '1', '曲女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('128', '1', 'X先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('129', '1', '王先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('130', '1', '马先生', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('131', '1', '黄女士', null, '', '1', '无', null, null, 'front', null, null, null, null, '2016-02-15 12:30:09');
INSERT INTO `customer` VALUES ('132', '1', '11', '1', '11', '1', '11', '4', '4', 'front', '11', '1', '111', '2016-02-16 13:16:02', '2016-02-15 13:50:57');
INSERT INTO `customer` VALUES ('133', '1', '123', '2', '123', '1', null, null, null, null, null, '1', '123', null, '2016-02-16 12:49:18');
INSERT INTO `customer` VALUES ('134', '1', null, '2', null, '1', null, null, null, null, null, '1', null, null, '2016-02-16 12:54:13');

-- ----------------------------
-- Table structure for dcc_record
-- ----------------------------
DROP TABLE IF EXISTS `dcc_record`;
CREATE TABLE `dcc_record` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) NOT NULL COMMENT '客户Id',
  `ShopId` int(11) NOT NULL COMMENT '店面Id',
  `DCCRecallerId` int(11) DEFAULT NULL COMMENT 'DCC专员Id',
  `VisitTime` datetime DEFAULT NULL COMMENT 'DCC留言时间',
  `DurationTime` varchar(50) DEFAULT NULL COMMENT '回访间隔时间',
  `RecallTime` datetime DEFAULT NULL COMMENT '回访时间',
  `PurposeCar` int(11) DEFAULT NULL COMMENT '意向车型',
  `LevelCode` varchar(100) DEFAULT NULL COMMENT '意向级别',
  `Source` int(11) DEFAULT NULL COMMENT '线索来源：对应 basic_constant.TypeKey = DCCSource',
  `Status` int(11) DEFAULT NULL COMMENT 'DCC状态：对应 basic_constant.TypeKey = DCCStatus',
  `ToShop` int(2) DEFAULT NULL COMMENT '承诺到店：1:是；2:否',
  `ToShopTime` datetime DEFAULT NULL COMMENT '预约到店时间',
  `Installment` int(2) DEFAULT NULL COMMENT '是否分期还款 1 是； 2 否',
  `RecallDesc` varchar(200) DEFAULT NULL COMMENT '回访详情记录',
  `Recorder` varchar(100) DEFAULT NULL COMMENT '录入人员',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of dcc_record
-- ----------------------------
INSERT INTO `dcc_record` VALUES ('1', '64', '1', '10', '2015-07-01 00:00:00', '05:51:16.000000', '2015-07-01 05:51:16', '1', ' H ', '36', null, null, '2015-07-01 05:51:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('2', '65', '1', '10', '2015-07-01 00:00:00', '05:51:16.000000', '2015-07-01 05:51:16', '2', ' H ', '36', null, null, '2015-07-01 05:51:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('3', '66', '1', '10', '2015-07-01 00:00:00', '05:51:16.000000', '2015-07-01 05:51:16', '3', ' H ', '36', null, null, '2015-07-01 05:51:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('4', '67', '1', '11', '2015-07-01 00:00:00', '05:51:55.000000', '2015-07-01 05:51:55', '4', ' H ', '36', null, null, '2015-07-01 05:51:55', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('5', '68', '1', '11', '2015-07-01 00:00:00', '05:51:55.000000', '2015-07-01 05:51:55', '5', ' H ', '36', null, null, '2015-07-01 05:51:55', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('6', '69', '1', '11', '2015-07-01 00:00:00', '05:51:55.000000', '2015-07-01 05:51:55', '2', ' H ', '36', null, null, '2015-07-01 05:51:55', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('7', '70', '1', '11', '2015-07-01 00:00:00', '05:51:55.000000', '2015-07-01 05:51:55', '5', ' H ', '36', null, null, '2015-07-01 05:51:55', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('8', '71', '1', '11', '2015-07-01 00:00:00', '05:51:55.000000', '2015-07-01 05:51:55', '1', ' H ', '36', null, null, '2015-07-01 05:51:55', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('9', '72', '1', '12', '2015-07-01 00:00:00', '05:53:16.000000', '2015-07-01 05:53:16', '2', ' H ', '36', null, null, '2015-07-01 05:53:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('10', '73', '1', '12', '2015-07-01 00:00:00', '05:53:16.000000', '2015-07-01 05:53:16', '3', ' H ', '36', null, null, '2015-07-01 05:53:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('11', '74', '1', '12', '2015-07-01 00:00:00', '05:53:16.000000', '2015-07-01 05:53:16', '4', ' H ', '36', null, null, '2015-07-01 05:53:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('12', '75', '1', '12', '2015-07-01 00:00:00', '05:53:16.000000', '2015-07-01 05:53:16', '5', ' H ', '36', null, null, '2015-07-01 05:53:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('13', '76', '1', '12', '2015-07-01 00:00:00', '05:53:16.000000', '2015-07-01 05:53:16', '2', ' H ', '36', null, null, '2015-07-01 05:53:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('14', '77', '1', '12', '2015-07-01 00:00:00', '05:53:16.000000', '2015-07-01 05:53:16', '5', ' H ', '36', null, null, '2015-07-01 05:53:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('15', '78', '1', '12', '2015-07-01 00:00:00', '05:53:16.000000', '2015-07-01 05:53:16', '1', ' H ', '36', null, null, '2015-07-01 05:53:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('16', '79', '1', '13', '2015-07-01 00:00:00', '34:38:29.000000', '2015-07-02 10:38:29', '2', ' H ', '36', null, null, '2015-07-02 10:38:29', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('17', '80', '1', '13', '2015-07-01 00:00:00', '34:38:29.000000', '2015-07-02 10:38:29', '3', ' H ', '36', null, null, '2015-07-02 10:38:29', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('18', '81', '1', '13', '2015-07-01 00:00:00', '34:38:29.000000', '2015-07-02 10:38:29', '4', ' H ', '36', null, null, '2015-07-02 10:38:29', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('19', '82', '1', '13', '2015-07-01 00:00:00', '34:36:16.000000', '2015-07-02 10:36:16', '5', ' H ', '36', null, null, '2015-07-02 10:36:16', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('20', '83', '1', '14', '2015-07-01 00:00:00', '34:32:04.000000', '2015-07-02 10:32:04', '2', ' H ', '36', null, null, '2015-07-02 10:32:04', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('21', '84', '1', '14', '2015-07-01 00:00:00', '34:32:04.000000', '2015-07-02 10:32:04', '5', ' H ', '36', null, null, '2015-07-02 10:32:04', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('22', '85', '1', '14', '2015-07-01 00:00:00', '34:29:04.000000', '2015-07-02 10:29:04', '1', ' H ', '36', null, null, '2015-07-02 10:29:04', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('23', '86', '1', '14', '2015-07-01 00:00:00', '34:29:04.000000', '2015-07-02 10:29:04', '2', ' H ', '36', null, null, '2015-07-02 10:29:04', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('24', '87', '1', '14', '2015-07-01 00:00:00', '34:29:04.000000', '2015-07-02 10:29:04', '3', ' H ', '36', null, null, '2015-07-02 10:29:04', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('25', '88', '1', '15', '2015-07-01 00:00:00', '27:41:01.000000', '2015-07-02 03:41:01', '4', ' H ', '36', null, null, '2015-07-02 03:41:01', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('26', '89', '1', '15', '2015-07-01 00:00:00', '27:41:01.000000', '2015-07-02 03:41:01', '5', ' H ', '36', null, null, '2015-07-02 03:41:01', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('27', '90', '1', '15', '2015-07-01 00:00:00', '27:41:01.000000', '2015-07-02 03:41:01', '2', ' H ', '36', null, null, '2015-07-02 03:41:01', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('28', '91', '1', '15', '2015-07-01 00:00:00', '27:41:01.000000', '2015-07-02 03:41:01', '5', ' H ', '36', null, null, '2015-07-02 03:41:01', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('29', '92', '1', '15', '2015-07-01 00:00:00', '27:41:01.000000', '2015-07-02 03:41:01', '4', ' H ', '36', null, null, '2015-07-02 03:41:01', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('30', '93', '1', '15', '2015-07-01 00:00:00', '27:41:01.000000', '2015-07-02 03:41:01', '5', ' H ', '36', null, null, '2015-07-02 03:41:01', '2', '导入dcc登记记录:', '张生', null, '2016-02-14 10:40:00');
INSERT INTO `dcc_record` VALUES ('31', '133', '1', '3', '2016-02-13 12:49:05', '00:00:13', '2016-02-16 12:49:19', '1', 'H', '24', null, null, '2016-02-19 12:49:05', null, null, null, null, '2016-02-16 12:49:19');
INSERT INTO `dcc_record` VALUES ('32', '132', '1', '4', '2016-02-11 12:53:29', '00:22:35', '2016-02-16 13:16:05', '1', 'B', '24', '1', null, '2016-02-24 12:53:29', null, '123', null, '2016-02-16 13:16:04', '2016-02-16 12:54:21');

-- ----------------------------
-- Table structure for deal_record
-- ----------------------------
DROP TABLE IF EXISTS `deal_record`;
CREATE TABLE `deal_record` (
  `Id` int(11) NOT NULL,
  `CustomerId` int(11) NOT NULL COMMENT '客户Id',
  `ShopId` int(11) NOT NULL COMMENT '店面Id',
  `RecorderId` int(11) NOT NULL COMMENT '录入人员Id',
  `ConsultantId` int(11) DEFAULT NULL COMMENT '销售顾问Id',
  `CarType` varchar(100) DEFAULT NULL COMMENT '成交车型',
  `Remark` varchar(200) DEFAULT NULL COMMENT '成交备注',
  `CreatedDate` datetime DEFAULT NULL COMMENT '成交时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of deal_record
-- ----------------------------

-- ----------------------------
-- Table structure for evaluate_question
-- ----------------------------
DROP TABLE IF EXISTS `evaluate_question`;
CREATE TABLE `evaluate_question` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ShopId` int(11) NOT NULL COMMENT '店面Id',
  `QDesc` varchar(200) DEFAULT NULL COMMENT '顾客评估问题描述',
  `QType` int(2) DEFAULT NULL COMMENT '问题类型：对应 basic_constant.TypeKey = QType',
  `QLevel` int(11) DEFAULT NULL COMMENT '问题权重',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of evaluate_question
-- ----------------------------

-- ----------------------------
-- Table structure for front_record
-- ----------------------------
DROP TABLE IF EXISTS `front_record`;
CREATE TABLE `front_record` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) NOT NULL COMMENT '客户Id',
  `ShopId` int(11) NOT NULL COMMENT '店面Id',
  `ConsultantId` int(11) NOT NULL COMMENT '销售顾问Id',
  `CustomerNum` int(11) NOT NULL DEFAULT '1' COMMENT '接待人数',
  `CarLicence` int(11) DEFAULT NULL COMMENT '牌照状况：对应 basic_constant.TypeKey = CarLicence',
  `PurposeCar` int(11) DEFAULT NULL COMMENT '意向车型',
  `LevelCode` varchar(100) DEFAULT NULL COMMENT '意向级别',
  `DriveStatus` int(2) DEFAULT NULL COMMENT '试驾状态：1是 2否',
  `Source` int(11) DEFAULT NULL COMMENT '客户来源',
  `Replace` int(2) DEFAULT NULL COMMENT '是否二手置换 1是2否',
  `Installment` int(2) DEFAULT NULL COMMENT '是否分期付款 1是 2 否',
  `Remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `ArrivalTime` datetime DEFAULT NULL COMMENT '到店时间',
  `LeaveTime` datetime DEFAULT NULL COMMENT '离开时间',
  `DurationTime` varchar(50) DEFAULT NULL COMMENT '接待时长',
  `Recorder` varchar(100) DEFAULT NULL COMMENT '录入人员 姓名',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=139 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of front_record
-- ----------------------------
INSERT INTO `front_record` VALUES ('1', '1', '1', '3', '0', null, '1', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('2', '2', '1', '4', '1', null, '2', 'A', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('3', '3', '1', '5', '0', null, '3', 'B', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('4', '4', '1', '5', '1', null, '4', 'O', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('5', '5', '1', '6', '1', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('6', '6', '1', '5', '1', null, '2', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('7', '7', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('8', '8', '1', '5', '0', null, '3', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('9', '9', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('10', '10', '1', '3', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('11', '11', '1', '5', '0', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('12', '12', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('13', '13', '1', '5', '0', null, '6', 'B', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('14', '14', '1', '4', '4', null, '2', 'H', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('15', '15', '1', '5', '3', null, '7', 'B', '1', '35', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('16', '16', '1', '7', '2', null, '6', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('17', '17', '1', '4', '0', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('18', '18', '1', '6', '1', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('19', '19', '1', '3', '1', null, '1', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('20', '20', '1', '4', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('21', '21', '1', '5', '1', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('22', '22', '1', '7', '1', null, '2', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('23', '23', '1', '7', '0', null, '1', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('24', '2', '1', '4', '1', null, '4', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('25', '24', '1', '7', '1', null, '1', 'H', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('26', '25', '1', '3', '1', null, '6', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('27', '26', '1', '3', '2', null, '1', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('28', '27', '1', '5', '3', null, '6', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('29', '28', '1', '3', '1', null, '3', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('30', '29', '1', '7', '1', null, '1', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('31', '30', '1', '8', '3', null, '5', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('32', '31', '1', '7', '1', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('33', '32', '1', '8', '1', null, '4', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('34', '33', '1', '4', '0', null, '1', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('35', '34', '1', '9', '4', null, '4', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('36', '35', '1', '3', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('37', '36', '1', '7', '1', null, '6', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 09:50:36');
INSERT INTO `front_record` VALUES ('64', '2', '1', '4', '1', null, '2', 'A', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('65', '2', '1', '4', '1', null, '4', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('66', '10', '1', '3', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('67', '11', '1', '5', '0', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('68', '13', '1', '5', '0', null, '6', 'B', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('69', '14', '1', '4', '4', null, '2', 'H', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('70', '15', '1', '5', '3', null, '7', 'B', '1', '35', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('71', '16', '1', '7', '2', null, '6', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('72', '17', '1', '4', '0', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('73', '20', '1', '4', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('74', '21', '1', '5', '1', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('75', '23', '1', '7', '0', null, '1', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('76', '24', '1', '7', '1', null, '1', 'H', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('77', '27', '1', '5', '3', null, '6', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('78', '28', '1', '3', '1', null, '3', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('79', '31', '1', '7', '1', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('80', '33', '1', '4', '0', null, '1', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('81', '35', '1', '3', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('82', '36', '1', '7', '1', null, '6', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('83', '95', '1', '3', '0', null, '1', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('84', '96', '1', '5', '0', null, '3', 'B', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('85', '97', '1', '5', '1', null, '4', 'O', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('86', '98', '1', '6', '1', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('87', '99', '1', '5', '1', null, '2', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('88', '100', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('89', '101', '1', '5', '0', null, '3', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('90', '102', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('91', '103', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('92', '104', '1', '6', '1', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('93', '105', '1', '3', '1', null, '1', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('94', '106', '1', '7', '1', null, '2', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('95', '107', '1', '3', '1', null, '6', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('96', '108', '1', '3', '2', null, '1', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('97', '109', '1', '7', '1', null, '1', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('98', '110', '1', '8', '3', null, '5', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('99', '111', '1', '8', '1', null, '4', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('100', '112', '1', '9', '4', null, '4', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-14 17:09:30');
INSERT INTO `front_record` VALUES ('101', '132', '1', '3', '1', null, '1', 'H', '1', '33', '1', '1', 'test1', '2016-02-15 11:28:06', '2016-02-15 14:04:47', '02:36:40', '张生', '2016-02-15 14:04:46', '2016-02-15 11:28:06');
INSERT INTO `front_record` VALUES ('102', '2', '1', '4', '1', null, '2', 'A', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('103', '2', '1', '4', '1', null, '4', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('104', '10', '1', '3', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('105', '11', '1', '5', '0', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('106', '13', '1', '5', '0', null, '6', 'B', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('107', '14', '1', '4', '4', null, '2', 'H', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('108', '15', '1', '5', '3', null, '7', 'B', '1', '35', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('109', '16', '1', '7', '2', null, '6', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('110', '17', '1', '4', '0', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('111', '20', '1', '4', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('112', '21', '1', '5', '1', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('113', '23', '1', '7', '0', null, '1', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('114', '24', '1', '7', '1', null, '1', 'H', '1', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('115', '27', '1', '5', '3', null, '6', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('116', '28', '1', '3', '1', null, '3', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('117', '31', '1', '7', '1', null, '1', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('118', '33', '1', '4', '0', null, '1', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('119', '35', '1', '3', '1', null, '2', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('120', '36', '1', '7', '1', null, '6', 'A', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('121', '114', '1', '3', '0', null, '1', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('122', '115', '1', '5', '0', null, '3', 'B', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('123', '116', '1', '5', '1', null, '4', 'O', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('124', '117', '1', '6', '1', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('125', '118', '1', '5', '1', null, '2', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('126', '119', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('127', '120', '1', '5', '0', null, '3', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('128', '121', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('129', '122', '1', '6', '0', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('130', '123', '1', '6', '1', null, '5', '其他', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('131', '124', '1', '3', '1', null, '1', 'H', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('132', '125', '1', '7', '1', null, '2', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('133', '126', '1', '3', '1', null, '6', 'H', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('134', '127', '1', '3', '2', null, '1', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('135', '128', '1', '7', '1', null, '1', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('136', '129', '1', '8', '3', null, '5', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('137', '130', '1', '8', '1', null, '4', 'C', '2', '34', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');
INSERT INTO `front_record` VALUES ('138', '131', '1', '9', '4', null, '4', 'O', '2', '33', '2', '2', '导入前台登记记录', '2015-12-02 09:10:00', '2015-12-02 09:20:00', '00:10:00', '张生', null, '2016-02-15 12:30:09');

-- ----------------------------
-- Table structure for import_dcc_temp
-- ----------------------------
DROP TABLE IF EXISTS `import_dcc_temp`;
CREATE TABLE `import_dcc_temp` (
  `ShopId` int(11) DEFAULT NULL,
  `Recorder` varchar(50) DEFAULT NULL,
  `VisitTime` date DEFAULT NULL,
  `RecallTime` datetime DEFAULT NULL,
  `CPhone` varchar(50) DEFAULT NULL,
  `CName` varchar(100) DEFAULT NULL,
  `CSex` varchar(10) DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  `PurposeCar` varchar(100) DEFAULT NULL,
  `PurposeLevel` varchar(100) DEFAULT NULL,
  `CSource` varchar(100) DEFAULT NULL,
  `ToShopTime` datetime DEFAULT NULL,
  `ConsultantName` varchar(100) DEFAULT NULL,
  `Region` varchar(200) DEFAULT NULL,
  `Installment` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of import_dcc_temp
-- ----------------------------
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:51:16', ' 15916981358 ', ' 范宁波 ', '男', '', '301', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:51:16', ' 谢文杰 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:51:16', ' 18823306888 ', ' 舒清林 ', '男', '', '308', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:51:16', ' 谢文杰 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:51:16', ' 13544610432 ', ' 邓根兴 ', '男', '', '2008', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:51:16', ' 谢文杰 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:51:55', ' 13712761002 ', ' 王涛 ', '男', '', '3008', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:51:55', ' 甘子劲 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:51:55', ' 18520811538 ', ' 覃生 ', '男', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:51:55', ' 甘子劲 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:51:55', ' 15711162697 ', ' 马卫周 ', '男', '', '308', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:51:55', ' 甘子劲 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:51:55', ' 13686630309 ', ' 张 ', '男', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:51:55', ' 甘子劲 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:51:55', ' 18771078679 ', ' 李 ', '男', '', '301', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:51:55', ' 甘子劲 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:53:16', ' 18928237205 ', ' 尹才庭 ', '男', '', '308', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:53:16', ' 李明娟 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:53:16', ' 13826960611 ', ' 汤汤 ', '男', '', '2008', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:53:16', ' 李明娟 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:53:16', ' 18650095676 ', ' 潘国美 ', '男', '', '3008', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:53:16', ' 李明娟 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:53:16', ' 13826957027 ', ' 凌振 ', '男', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:53:16', ' 李明娟 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:53:16', ' 18802691558 ', ' 18988727509 ', '男', '', '308', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:53:16', ' 李明娟 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:53:16', ' 18988727509 ', ' 叶文波 ', '男', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:53:16', ' 李明娟 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-01 05:53:16', ' 13532387109 ', ' 谢佩伶 ', '男', '', '301', ' H ', ' 汽车垂直网站 ', '2015-07-01 05:53:16', ' 李明娟 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:38:29', ' 15918352331 ', ' 吴耿文 ', '男', '', '308', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:38:29', ' 赵金星 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:38:29', ' 13902601734 ', ' 易车网2015070137 ', '男', '', '2008', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:38:29', ' 赵金星 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:38:29', ' 051082447009 ', ' 叶 ', '女', '', '3008', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:38:29', ' 赵金星 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:36:16', ' 18666462392 ', ' 麦伟峰 ', '女', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:36:16', ' 赵金星 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:32:04', ' 13431429517 ', ' 王锐标 ', '女', '', '308', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:32:04', ' 梁艺 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:32:04', ' 18922947888 ', ' 易车网2014120740 ', '女', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:32:04', ' 梁艺 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:29:04', ' 15915440979 ', ' 徐 旭 ', '女', '', '301', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:29:04', ' 梁艺 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:29:04', ' 13450086448 ', ' 程 ', '女', '', '308', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:29:04', ' 梁艺 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 10:29:04', ' 13790342750 ', ' 胡望平 ', '女', '', '2008', ' H ', ' 汽车垂直网站 ', '2015-07-02 10:29:04', ' 梁艺 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 03:41:01', ' 18664061146 ', ' 张 ', '女', '', '3008', ' H ', ' 汽车垂直网站 ', '2015-07-02 03:41:01', ' 黄国春 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 03:41:01', ' 13724438302 ', ' 官瑞城 ', '女', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-02 03:41:01', ' 黄国春 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 03:41:01', ' 13827220903 ', ' 易车网2015070167 ', '女', '', '308', ' H ', ' 汽车垂直网站 ', '2015-07-02 03:41:01', ' 黄国春 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 03:41:01', ' 18128661998 ', ' 李若彤唐 ', '女', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-02 03:41:01', ' 黄国春 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 03:41:01', ' 15322426993 ', ' 汤应兵 ', '女', '', '3008', ' H ', ' 汽车垂直网站 ', '2015-07-02 03:41:01', ' 黄国春 ', '', '');
INSERT INTO `import_dcc_temp` VALUES ('1', '张生', '2015-07-01', '2015-07-02 03:41:01', ' 15992863708 ', ' 李先生 ', '女', '', '其他', ' H ', ' 汽车垂直网站 ', '2015-07-02 03:41:01', ' 黄国春 ', '', '');

-- ----------------------------
-- Table structure for import_front_temp
-- ----------------------------
DROP TABLE IF EXISTS `import_front_temp`;
CREATE TABLE `import_front_temp` (
  `ShopId` int(11) DEFAULT NULL,
  `Recorder` varchar(100) DEFAULT NULL COMMENT '导入人员真名',
  `RecordDate` date DEFAULT NULL COMMENT '记录时间',
  `CName` varchar(100) DEFAULT NULL COMMENT '客户改名',
  `CNum` int(11) DEFAULT NULL COMMENT '接待人数：陪同人数+1',
  `CPhone` varchar(50) DEFAULT NULL COMMENT '客户电话',
  `CRemark` varchar(200) DEFAULT NULL COMMENT '备注',
  `PurposeCar` varchar(100) DEFAULT NULL COMMENT '意向车型',
  `PurposeLevel` varchar(100) DEFAULT NULL COMMENT '意向级别',
  `ArrivalTime` time DEFAULT NULL COMMENT '到店时间',
  `CSource` varchar(100) DEFAULT NULL COMMENT '客户来源',
  `ToShopNum` varchar(100) DEFAULT NULL COMMENT '来店次数',
  `DriveStatus` varchar(50) DEFAULT NULL COMMENT '是否试驾',
  `LeaveTime` time DEFAULT NULL COMMENT '离店时间',
  `ConsultantName` varchar(100) DEFAULT NULL COMMENT '销售顾问真名',
  `CCurCar` varchar(100) DEFAULT NULL COMMENT '客户现有车型',
  `Replace` varchar(50) DEFAULT NULL COMMENT '是否转换',
  `Installment` varchar(50) DEFAULT NULL COMMENT '是否分期'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of import_front_temp
-- ----------------------------
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '李先生', '0', '1', '配钥匙', '301', 'H', '09:10:00', '邀约', '多次', '否', '09:20:00', '高潍东', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '赵先生', '1', '13963659086', '', '308', 'A', '09:10:00', '自然进店', '首次', '是', '09:20:00', '董清平', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '王先生', '0', '2', '保养客户', '2008', 'B', '09:10:00', '自然进店', '多次', '否', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '方先生', '1', '3', '贴膜、王莲客户', '3008', 'O', '09:10:00', '自然进店', '多次', '否', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', 'X先生', '1', '4', '找张保成', '其他', '其他', '09:10:00', '自然进店', '首次', '否', '09:20:00', '郭勇', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', 'X先生', '1', '5', '保养客户', '308', 'O', '09:10:00', '邀约', '多次', '否', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', 'X先生', '0', '6', '事故车找曹健', '其他', '其他', '09:10:00', '自然进店', '首次', '否', '09:20:00', '郭勇', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '郭女士', '0', '7', '贴膜', '2008', 'O', '09:10:00', '邀约', '多次', '否', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', 'X先生', '0', '8', '送快递', '其他', '其他', '09:10:00', '自然进店', '多次', '否', '09:20:00', '郭勇', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '孙女士', '1', '15006568928', '', '308', 'H', '09:10:00', '邀约', '多次', '否', '09:20:00', '高潍东', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '崔先生', '0', '18953608716', '', '301', 'A', '09:10:00', '自然进店', '首次', '否', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', 'X先生', '0', '9', '送快递', '其他', '其他', '09:10:00', '自然进店', '多次', '否', '09:20:00', '郭勇', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '王先生', '0', '15966112728', '', '新408', 'B', '09:10:00', '自然进店', '首次', '否', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '冯先生', '4', '15154491777', '', '308', 'H', '09:10:00', '自然进店', '首次', '是', '09:20:00', '董清平', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '程先生', '3', '18263608598', '', '508', 'B', '09:10:00', '网络', '首次', '是', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '陈先生', '2', '15265689621', '', '新408', 'A', '09:10:00', '自然进店', '首次', '否', '09:20:00', '王建', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '王先生', '0', '13465718831', '', '301', 'A', '09:10:00', '自然进店', '首次', '否', '09:20:00', '董清平', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', 'X先生', '1', '10', '找满经理', '其他', '其他', '09:10:00', '自然进店', '首次', '否', '09:20:00', '郭勇', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '郭先生', '1', '11', '装导航', '301', 'H', '09:10:00', '邀约', '多次', '否', '09:20:00', '高潍东', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '刘先生', '1', '15689862558', '', '308', 'H', '09:10:00', '邀约', '首次', '否', '09:20:00', '董清平', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '孟先生', '1', '18253620410', '', '301', 'A', '09:10:00', '自然进店', '首次', '否', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', 'X先生', '1', '12', '未留', '308', 'C', '09:10:00', '自然进店', '首次', '否', '09:20:00', '王建', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '苏先生', '0', '15662570886', '', '301', 'H', '09:10:00', '自然进店', '首次', '否', '09:20:00', '王建', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '赵先生', '1', '13963659086', '', '3008', 'H', '09:10:00', '邀约', '首次', '否', '09:20:00', '董清平', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '马先生', '1', '15553631597', '', '301', 'H', '09:10:00', '自然进店', '首次', '是', '09:20:00', '王建', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '周先生', '1', '13', '拿合格证', '新408', 'H', '09:10:00', '自然进店', '多次', '否', '09:20:00', '高潍东', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '曲女士', '2', '14', '未留', '301', 'C', '09:10:00', '自然进店', '首次', '否', '09:20:00', '高潍东', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '李先生', '3', '13098187876', '', '新408', 'H', '09:10:00', '自然进店', '首次', '否', '09:20:00', '余康', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '王女士', '1', '18653663800', '', '2008', 'A', '09:10:00', '自然进店', '首次', '否', '09:20:00', '高潍东', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', 'X先生', '1', '15', '未留', '301', 'C', '09:10:00', '自然进店', '首次', '否', '09:20:00', '王建', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '王先生', '3', '16', '未留', '其他', 'C', '09:10:00', '自然进店', '首次', '否', '09:20:00', '付慧娟', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '郭先生', '1', '13792681865', '', '301', 'A', '09:10:00', '自然进店', '首次', '否', '09:20:00', '王建', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '马先生', '1', '17', '未留', '3008', 'C', '09:10:00', '自然进店', '首次', '否', '09:20:00', '付慧娟', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '吴先生', '0', '15054572167', '', '301', 'H', '09:10:00', '自然进店', '首次', '否', '09:20:00', '董清平', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '黄女士', '4', '18', '提车', '3008', 'O', '09:10:00', '邀约', '多次', '否', '09:20:00', '孟祥开', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '尹先生', '1', '13854430622', '', '308', 'H', '09:10:00', '邀约', '多次', '否', '09:20:00', '高潍东', '无', '否', '');
INSERT INTO `import_front_temp` VALUES ('1', '张生', '2015-12-02', '苏先生', '1', '15095205588', '', '新408', 'A', '09:10:00', '自然进店', '首次', '否', '09:20:00', '王建', '无', '否', '');

-- ----------------------------
-- Table structure for purpose_level
-- ----------------------------
DROP TABLE IF EXISTS `purpose_level`;
CREATE TABLE `purpose_level` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '意向级别Id',
  `Code` varchar(100) NOT NULL COMMENT '意向级别代码',
  `Desc` varchar(200) DEFAULT NULL COMMENT '意向级别描述',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of purpose_level
-- ----------------------------
INSERT INTO `purpose_level` VALUES ('1', 'H', '前台_导入意向级别', null, '2016-02-14 09:50:36');
INSERT INTO `purpose_level` VALUES ('2', 'A', '前台_导入意向级别', null, '2016-02-14 09:50:36');
INSERT INTO `purpose_level` VALUES ('3', 'B', '前台_导入意向级别', null, '2016-02-14 09:50:36');
INSERT INTO `purpose_level` VALUES ('4', 'O', '前台_导入意向级别', null, '2016-02-14 09:50:36');
INSERT INTO `purpose_level` VALUES ('5', '其他', '前台_导入意向级别', null, '2016-02-14 09:50:36');
INSERT INTO `purpose_level` VALUES ('6', 'C', '前台_导入意向级别', null, '2016-02-14 09:50:36');
INSERT INTO `purpose_level` VALUES ('8', ' H ', 'DCC_导入意向级别', null, '2016-02-14 10:40:00');

-- ----------------------------
-- Table structure for region
-- ----------------------------
DROP TABLE IF EXISTS `region`;
CREATE TABLE `region` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ShopId` int(11) NOT NULL DEFAULT '0' COMMENT '店面Id',
  `Province` varchar(100) DEFAULT NULL COMMENT '省',
  `City` varchar(100) DEFAULT NULL COMMENT '市',
  `Region` varchar(100) DEFAULT NULL COMMENT '县/区',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of region
-- ----------------------------
INSERT INTO `region` VALUES ('1', '0', null, '北京', '东城区', null, '2016-02-14 09:37:04');
INSERT INTO `region` VALUES ('2', '0', null, '北京', '西域区', null, '2016-02-14 09:37:04');
INSERT INTO `region` VALUES ('3', '0', null, '北京', '海淀区', null, '2016-02-14 09:37:04');
INSERT INTO `region` VALUES ('4', '0', null, '北京', '朝阳区', null, '2016-02-14 09:37:04');
INSERT INTO `region` VALUES ('5', '0', null, '北京', '昌平区', null, '2016-02-14 09:37:04');

-- ----------------------------
-- Table structure for role
-- ----------------------------
DROP TABLE IF EXISTS `role`;
CREATE TABLE `role` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '角色Id',
  `Name` varchar(100) DEFAULT NULL COMMENT '角色名称',
  `Desc` varchar(100) NOT NULL COMMENT '角色描述',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of role
-- ----------------------------
INSERT INTO `role` VALUES ('1', '系统管理员', '跨系统所有权限', '2016-02-14 09:37:04');
INSERT INTO `role` VALUES ('2', '总经理', '某个系统的所有权限', '2016-02-14 09:37:04');
INSERT INTO `role` VALUES ('3', '销售经理', '销售系统管理', '2016-02-14 09:37:04');
INSERT INTO `role` VALUES ('4', '市场经理', '市场系统管理', '2016-02-14 09:37:04');
INSERT INTO `role` VALUES ('5', '销售前台', '前台信息录入', '2016-02-14 09:37:04');
INSERT INTO `role` VALUES ('6', '销售顾问-展厅', '客户信息维护', '2016-02-14 09:37:04');
INSERT INTO `role` VALUES ('7', '销售顾问-DCC', '客户信息维护', null);
INSERT INTO `role` VALUES ('8', '销售顾问-实习', '客户信息维护', null);

-- ----------------------------
-- Table structure for shop
-- ----------------------------
DROP TABLE IF EXISTS `shop`;
CREATE TABLE `shop` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '店铺Id',
  `Name` varchar(200) NOT NULL COMMENT '店铺名称',
  `Phone` varchar(50) DEFAULT NULL COMMENT '店铺联系方式',
  `RegionId` int(11) DEFAULT '0' COMMENT '所在区域Id',
  `Address` varchar(200) DEFAULT NULL COMMENT '店铺地址',
  `Desc` varchar(200) DEFAULT NULL COMMENT '店铺介绍',
  `UpdateDate` datetime DEFAULT NULL COMMENT '店铺信息最近一次更新',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of shop
-- ----------------------------
INSERT INTO `shop` VALUES ('1', '北京朝阳店', '11', '4', '国贸', null, null, '2016-02-14 09:47:04');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '用户Id',
  `ShopId` int(11) NOT NULL COMMENT '店面Id',
  `RoleId` int(11) NOT NULL COMMENT '用户角色Id',
  `GroupId` int(11) NOT NULL COMMENT '销顾用户分组',
  `UserName` varchar(100) NOT NULL COMMENT '登录用户名',
  `Pwd` varchar(100) NOT NULL COMMENT '用户密码',
  `RealName` varchar(100) DEFAULT NULL COMMENT '用户真实姓名',
  `Sex` int(2) DEFAULT NULL COMMENT '用户性别 1男 2女',
  `Status` int(2) DEFAULT NULL COMMENT '用户状态：1:在职; 2:离职; 3:休假',
  `Phone` varchar(50) NOT NULL COMMENT '用户手机号码',
  `Telephone` varchar(50) DEFAULT NULL COMMENT '用户座机号码',
  `UpdateDate` datetime DEFAULT NULL COMMENT '店铺信息最近一次更新',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '0', '1', '0', 'Admin', '7a57a5a743894a0e', 'Admin', '2', null, '12345678', null, null, '2016-02-14 09:37:04');
INSERT INTO `user` VALUES ('2', '1', '2', '0', 'xj', 'cb6720b002105b44', '张生', '1', '1', '111', null, null, '2016-02-14 09:48:13');
INSERT INTO `user` VALUES ('3', '1', '6', '0', '高潍东', '49ba59abbe56e057', '高潍东', null, null, '', null, null, '2016-02-14 09:50:36');
INSERT INTO `user` VALUES ('4', '1', '6', '1', '董清平', '49ba59abbe56e057', '董清平', null, null, '', null, null, '2016-02-14 09:50:36');
INSERT INTO `user` VALUES ('5', '1', '6', '1', '余康', '49ba59abbe56e057', '余康', null, null, '', null, null, '2016-02-14 09:50:36');
INSERT INTO `user` VALUES ('6', '1', '6', '0', '郭勇', '49ba59abbe56e057', '郭勇', null, null, '', null, null, '2016-02-14 09:50:36');
INSERT INTO `user` VALUES ('7', '1', '6', '3', '王建', '49ba59abbe56e057', '王建', null, null, '', null, null, '2016-02-14 09:50:36');
INSERT INTO `user` VALUES ('8', '1', '6', '3', '付慧娟', '49ba59abbe56e057', '付慧娟', null, null, '', null, null, '2016-02-14 09:50:36');
INSERT INTO `user` VALUES ('9', '1', '6', '3', '孟祥开', '49ba59abbe56e057', '孟祥开', null, null, '', null, null, '2016-02-14 09:50:36');
INSERT INTO `user` VALUES ('10', '1', '6', '3', ' 谢文杰 ', '49ba59abbe56e057', ' 谢文杰 ', null, null, '', null, null, '2016-02-14 10:40:00');
INSERT INTO `user` VALUES ('11', '1', '6', '0', ' 甘子劲 ', '49ba59abbe56e057', ' 甘子劲 ', null, null, '', null, null, '2016-02-14 10:40:00');
INSERT INTO `user` VALUES ('12', '1', '6', '0', ' 李明娟 ', '49ba59abbe56e057', ' 李明娟 ', null, null, '', null, null, '2016-02-14 10:40:00');
INSERT INTO `user` VALUES ('13', '1', '6', '4', ' 赵金星 ', '49ba59abbe56e057', ' 赵金星 ', null, null, '', null, null, '2016-02-14 10:40:00');
INSERT INTO `user` VALUES ('14', '1', '6', '4', ' 梁艺 ', '49ba59abbe56e057', ' 梁艺 ', null, null, '', null, null, '2016-02-14 10:40:00');
INSERT INTO `user` VALUES ('15', '1', '6', '0', ' 黄国春 ', '49ba59abbe56e057', ' 黄国春 ', null, null, '', null, null, '2016-02-14 10:40:00');

-- ----------------------------
-- Table structure for user_group
-- ----------------------------
DROP TABLE IF EXISTS `user_group`;
CREATE TABLE `user_group` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ShopId` int(11) NOT NULL COMMENT '店面Id',
  `Name` varchar(200) DEFAULT NULL COMMENT '分组名称',
  `Desc` varchar(200) DEFAULT NULL COMMENT '分组描述',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user_group
-- ----------------------------
INSERT INTO `user_group` VALUES ('1', '1', '分组1', '添加分组-分组1', null, '2016-02-15 17:17:18');
INSERT INTO `user_group` VALUES ('2', '1', 'test', '添加分组-test', null, '2016-02-16 10:02:07');
INSERT INTO `user_group` VALUES ('3', '1', 'aa', '添加分组-aa', null, '2016-02-16 10:18:01');
INSERT INTO `user_group` VALUES ('4', '1', 'bb', '添加分组-bb', null, '2016-02-16 10:37:42');
INSERT INTO `user_group` VALUES ('5', '1', 'cc', '添加分组-cc', null, '2016-02-16 10:38:29');
INSERT INTO `user_group` VALUES ('6', '1', '23', '添加分组-23', null, '2016-02-16 10:50:40');

-- ----------------------------
-- Table structure for user_task
-- ----------------------------
DROP TABLE IF EXISTS `user_task`;
CREATE TABLE `user_task` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ConsultantId` int(11) NOT NULL COMMENT '销售顾问Id',
  `StartDate` datetime DEFAULT NULL COMMENT '任务开始时间',
  `EndDate` datetime DEFAULT NULL COMMENT '任务结束时间',
  `CarTypeId` int(11) DEFAULT NULL COMMENT '汽车类型Id',
  `Status` int(11) DEFAULT '1' COMMENT '完成状态：1 未完成 2 已完成',
  `Cnt` int(11) DEFAULT NULL COMMENT '任务数量',
  `FinishCnt` int(11) DEFAULT NULL COMMENT '已完成数量',
  `Desc` varchar(255) DEFAULT NULL COMMENT '任务描述',
  `OperatorId` int(11) DEFAULT NULL COMMENT '安排任务者',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user_task
-- ----------------------------

-- ----------------------------
-- Procedure structure for uspAddAnalyseKPI
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddAnalyseKPI`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddAnalyseKPI`(IN `pAnalyseKpiName` varchar(100),IN `pAnalyseKpiKValue` int,IN `pAnalyseKpiKUnit` varchar(100),IN `pAnalyseKpiPerform` varchar(200),IN `pAnalyseKpiReason` varchar(200),IN `pAnalyseKpiSuggest` varchar(200),IN `pAnalyseKpiDesc` varchar(200),IN `pAnalyseKpiOperatorId` int)
BEGIN
	 INSERT INTO `analyse_kpi`(
        `Name`
        ,`KValue`
        ,`KUnit`
        ,`Perform`
        ,`Reason`
        ,`Suggest`
				,`Desc`
        ,`OperatorId`
        ,`CreatedDate`
    ) VALUES (
        pAnalyseKpiName        
        ,pAnalyseKpiKValue        
        ,pAnalyseKpiKUnit        
        ,pAnalyseKpiPerform        
        ,pAnalyseKpiReason        
        ,pAnalyseKpiSuggest
				,pAnalyseKpiDesc       
        ,pAnalyseKpiOperatorId        
        ,NOW()        
    );
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddBasicContant
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddBasicContant`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddBasicContant`(IN `pBasicConstantShopId` int,IN `pBasicConstantName` varchar(100),IN `pBasicConstantTypeKey` varchar(50),IN `pBasicConstantTypeValue` int,IN `pBasicConstantRemark` varchar(200))
BEGIN

	INSERT INTO `basic_constant`(
        `ShopId`
        ,`Name`
        ,`Order`
        ,`TypeKey`
        ,`TypeValue`
        ,`Remark`
        ,`CreatedDate`
    ) VALUES (
        pBasicConstantShopId        
        ,pBasicConstantName        
        ,(SELECT MAX(`Order`) + 1
					FROM `basic_constant`
					WHERE
						`basic_constant`.`TypeValue` = pBasicConstantTypeValue)        
        ,pBasicConstantTypeKey        
        ,pBasicConstantTypeValue        
        ,pBasicConstantRemark        
        ,NOW()        
    );
	
	select @@identity as Id;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddCarType
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddCarType`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddCarType`(IN `pCarTypeBrandId` int,IN `pCarTypeBrand` varchar(100),IN `pCarTypeName` varchar(100),IN `pCarTypeDesc` varchar(100))
BEGIN
	INSERT INTO `car_type`(
				`BrandId`
        ,`Brand`				
        ,`Name`
        ,`Desc`
        ,`CreatedDate`
    ) VALUES (
				pCarTypeBrandId
        ,pCarTypeBrand        
        ,pCarTypeName        
        ,pCarTypeDesc        
        ,NOW()        
    );

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddCustomer
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddCustomer`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddCustomer`(IN `pCustomerShopId` int,IN `pCustomerName` varchar(100),IN `pCustomerSex` int,IN `pCustomerPhone` varchar(50),IN `pCustomerCurCar` varchar(100),IN `pCustomerNature` int,IN `pCustomerType` varchar(50),IN `pCustomerIndustry` varchar(100),IN `pCustomerRegionId` int,IN `pCustomerAddress` varchar(200))
BEGIN
INSERT INTO `customer`(
        `ShopId`
        ,`Name`
        ,`Sex`
        ,`Phone`
        ,`ToShopNum`
        ,`CurCar`
        ,`Nature`
        #,`OriginNature`
        ,`Type`
        ,`Industry`
        ,`RegionId`
        ,`Address`
        ,`CreatedDate`
    ) VALUES (
        pCustomerShopId        
        ,pCustomerName        
        ,pCustomerSex        
        ,pCustomerPhone        
        ,1        
        ,pCustomerCurCar        
        ,pCustomerNature        
        #,NULL
        ,pCustomerType        
        ,pCustomerIndustry        
        ,pCustomerRegionId        
        ,pCustomerAddress        
        ,NOW()
    );
	select @@identity as Id;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddDCCRecord
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddDCCRecord`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddDCCRecord`(IN `pDccRecordCustomerId` int,IN `pDccRecordShopId` int,IN `pDccRecordDCCRecallerId` int,IN `pDccRecordVisitTime` datetime,IN `pDccRecordDurationTime` varchar(50),IN `pDccRecordRecallTime` datetime,IN `pDccRecordPurposeCar` int,IN `pDccRecordLevelCode` varchar(100),IN `pDccRecordSource` int,IN `pDccRecordStatus` int,IN `pDccRecordToShop` int,IN `pDccRecordToShopTime` datetime,IN `pDccRecordInstallment` int,IN `pDccRecordRecallDesc` varchar(200),IN `pDccRecordRecorder` varchar(100))
BEGIN
	INSERT INTO `dcc_record`(
        `CustomerId`
        ,`ShopId`
        ,`DCCRecallerId`
        ,`VisitTime`
        ,`DurationTime`
        ,`RecallTime`
        ,`PurposeCar`
        ,`LevelCode`
        ,`Source`
        ,`Status`
        ,`ToShop`
        ,`ToShopTime`
        ,`Installment`
        ,`RecallDesc`
        ,`Recorder`
        ,`CreatedDate`
    ) VALUES (
        pDccRecordCustomerId        
        ,pDccRecordShopId        
        ,pDccRecordDCCRecallerId        
        ,pDccRecordVisitTime        
        ,pDccRecordDurationTime        
        ,pDccRecordRecallTime        
        ,pDccRecordPurposeCar        
        ,pDccRecordLevelCode        
        ,pDccRecordSource        
        ,pDccRecordStatus        
        ,pDccRecordToShop        
        ,pDccRecordToShopTime        
        ,pDccRecordInstallment        
        ,pDccRecordRecallDesc        
        ,pDccRecordRecorder        
        ,NOW()        
    );
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddEvaluateQuestion
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddEvaluateQuestion`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddEvaluateQuestion`(IN `pEvaluateQuestionShopId` int,IN `pEvaluateQuestionQDesc` varchar(200),IN `pEvaluateQuestionQType` int,IN `pEvaluateQuestionQLevel` int)
BEGIN
INSERT INTO `evaluate_question`(
				`ShopId`
        ,`QDesc`
        ,`QType`
        ,`QLevel`
        ,`CreatedDate`
    ) VALUES (
				pEvaluateQuestionShopId
        ,pEvaluateQuestionQDesc        
        ,pEvaluateQuestionQType        
        ,pEvaluateQuestionQLevel        
        ,NOW()        
    );
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddFrontRecord
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddFrontRecord`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddFrontRecord`(IN `pFrontRecordShopId` int,IN `pFrontRecordConsultantId` int,IN `pFrontRecordCustomerNum` int,IN `pFrontRecordRemark` varchar(200),IN `pFrontRecordArrivalTime` datetime,IN `pFrontRecordRecorder` varchar(100))
BEGIN
	INSERT INTO `front_record`(
				`CustomerId`
        ,`ShopId`
        ,`ConsultantId`
        ,`CustomerNum`
        ,`Remark`
        ,`ArrivalTime`
        ,`Recorder`
        ,`CreatedDate`
    ) VALUES (
				0 #默认用户为空
        ,pFrontRecordShopId        
        ,pFrontRecordConsultantId        
        ,pFrontRecordCustomerNum   
        ,pFrontRecordRemark        
        ,pFrontRecordArrivalTime  
        ,pFrontRecordRecorder  
        ,NOW()        
    );

END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddGroup
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddGroup`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddGroup`(IN `pUserGroupShopId` int,IN `pUserGroupName` varchar(200),IN `pUserGroupDesc` varchar(200))
BEGIN
	 INSERT INTO `user_group`(
        `ShopId`
        ,`Name`
        ,`Desc`
        ,`CreatedDate`
    ) VALUES (
        pUserGroupShopId        
        ,pUserGroupName        
        ,pUserGroupDesc        
        ,NOW()        
    );
	select @@identity as Id;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddPurposeLevel
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddPurposeLevel`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddPurposeLevel`(IN `pPurposeLevelCode` varchar(100),IN `pPurposeLevelDesc` varchar(200))
BEGIN
INSERT INTO `purpose_level`(
        `Code`
        ,`Desc`
        ,`CreatedDate`
    ) VALUES (
        pPurposeLevelCode        
        ,pPurposeLevelDesc        
        ,NOW()         
    );
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddShop
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddShop`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddShop`(IN `pShopName` varchar(200),IN `pShopPhone` varchar(50),IN `pShopRegionId` int,IN `pShopAddress` varchar(200),IN `pShopDesc` varchar(200))
BEGIN
 INSERT INTO `shop`(
        `Name`
        ,`Phone`
				,`RegionId`
        ,`Address`
        ,`Desc`
        ,`CreatedDate`
    ) VALUES (
        pShopName        
        ,pShopPhone
				,pShopRegionId
        ,pShopAddress        
        ,pShopDesc         
        ,NOW()       
    );
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddUser`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddUser`(IN `pUserShopId` int,IN `pUserRoleId` int,IN `pUserUserName` varchar(100),IN `pUserPwd` varchar(100),IN `pUserRealName` varchar(100),IN `pUserSex` int,IN `pUserStatus` int,IN `pUserPhone` varchar(50),IN `pUserTelephone` varchar(50))
BEGIN
	INSERT INTO `user`(
        `ShopId`
        ,`RoleId`
        ,`UserName`
        ,`Pwd`
        ,`RealName`
        ,`Sex`
				,`Status`
        ,`Phone`
        ,`Telephone`
        ,`CreatedDate`
    ) VALUES (
        pUserShopId        
        ,pUserRoleId          
        ,pUserUserName        
        ,pUserPwd        
        ,pUserRealName        
        ,pUserSex
				,pUserStatus
        ,pUserPhone        
        ,pUserTelephone        
        ,NOW()        
    );
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddUserTask
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddUserTask`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddUserTask`(IN `pUserTaskConsultantId` int,IN `pUserTaskStartDate` datetime,IN `pUserTaskEndDate` datetime,IN `pUserTaskCarTypeId` int,IN `pUserTaskCnt` int,IN `pUserTaskDesc` varchar(255),IN `pUserTaskOperatorId` int)
BEGIN
	INSERT INTO `user_task`(
        `ConsultantId`
        ,`StartDate`
        ,`EndDate`
        ,`CarTypeId`
        ,`Status`
        ,`Cnt`
        ,`FinishCnt`
        ,`Desc`
        ,`OperatorId`
        ,`CreatedDate`
    ) VALUES (
        pUserTaskConsultantId        
        ,pUserTaskStartDate        
        ,pUserTaskEndDate        
        ,pUserTaskCarTypeId        
        ,1        
        ,pUserTaskCnt        
        ,0        
        ,pUserTaskDesc        
        ,pUserTaskOperatorId        
        ,NOW()        
    );
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspClearDccTemp
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspClearDccTemp`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspClearDccTemp`()
BEGIN
	#Routine body goes here...
	TRUNCATE TABLE `import_dcc_temp`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspClearFrontTemp
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspClearFrontTemp`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspClearFrontTemp`()
BEGIN
	#Routine body goes here...
	TRUNCATE TABLE `import_front_temp`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspDeleteAnalyseKPI
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspDeleteAnalyseKPI`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspDeleteAnalyseKPI`(IN `pAnalyseKpiId` int)
BEGIN
	DELETE FROM `analyse_kpi`
    WHERE
        Id=pAnalyseKpiId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspDeleteCarType
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspDeleteCarType`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspDeleteCarType`(IN `pCarTypeId` int)
BEGIN
	#Routine body goes here...
	DELETE FROM `car_type`
    WHERE
        Id=pCarTypeId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspDeleteEvaluateQuestion
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspDeleteEvaluateQuestion`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspDeleteEvaluateQuestion`(IN `pEvaluateQuestionId` int)
BEGIN
	  DELETE FROM `evaluate_question`
    WHERE
        Id=pEvaluateQuestionId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspDeletePurposeLevel
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspDeletePurposeLevel`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspDeletePurposeLevel`(IN `pPurposeLevelId` int)
BEGIN
	DELETE FROM `customer_level`
    WHERE
        Id=pPurposeLevelId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspDeleteShop
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspDeleteShop`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspDeleteShop`(IN `pShopId` int)
BEGIN
	DELETE FROM `shop`
    WHERE
        Id=pShopId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspDeleteUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspDeleteUser`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspDeleteUser`(IN `pUserId` int)
BEGIN
	UPDATE `user`
    SET
        `user`.`Status` = 3
        ,`user`.`UpdateDate` = NOW()
    WHERE
        Id=pUserId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspDeleteUserTask
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspDeleteUserTask`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspDeleteUserTask`(IN `pUserTaskId` int)
BEGIN
	DELETE FROM `user_task`
    WHERE
        Id=pUserTaskId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetAnalyseKPIs
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetAnalyseKPIs`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetAnalyseKPIs`()
BEGIN
	 SELECT 
        `analyse_kpi`.`Id` as `AnalyseKpiId`        
        ,`analyse_kpi`.`Name` as `AnalyseKpiName`        
        ,`analyse_kpi`.`KValue` as `AnalyseKpiKValue`        
        ,`analyse_kpi`.`KUnit` as `AnalyseKpiKUnit`        
        ,`analyse_kpi`.`Perform` as `AnalyseKpiPerform`        
        ,`analyse_kpi`.`Reason` as `AnalyseKpiReason`        
        ,`analyse_kpi`.`Suggest` as `AnalyseKpiSuggest` 
				,`analyse_kpi`.`Desc` as `AnalyseKpiDesc` 
        ,`analyse_kpi`.`OperatorId` as `AnalyseKpiOperatorId`        
        ,`analyse_kpi`.`UpdateDate` as `AnalyseKpiUpdateDate`        
        ,`analyse_kpi`.`CreatedDate` as `AnalyseKpiCreatedDate`        
    FROM
        `analyse_kpi`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetBasicConstants
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetBasicConstants`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetBasicConstants`(IN `pBasicConstantShopId` int)
BEGIN
	   SELECT 
        `basic_constant`.`Id` as `BasicConstantId`        
        ,`basic_constant`.`ShopId` as `BasicConstantShopId`        
        ,`basic_constant`.`Name` as `BasicConstantName`        
        ,`basic_constant`.`Order` as `BasicConstantOrder`        
        ,`basic_constant`.`TypeKey` as `BasicConstantTypeKey`        
        ,`basic_constant`.`TypeValue` as `BasicConstantTypeValue`        
        ,`basic_constant`.`Remark` as `BasicConstantRemark`        
        ,`basic_constant`.`UpdateDate` as `BasicConstantUpdateDate`        
        ,`basic_constant`.`CreatedDate` as `BasicConstantCreatedDate`        
    FROM
        `basic_constant`
		WHERE 
				`basic_constant`.`ShopId` = 0
		OR
				`basic_constant`.`ShopId` = case when pBasicConstantShopId = 0 then `basic_constant`.`ShopId` else pBasicConstantShopId end
		ORDER BY `basic_constant`.`Order`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetCarTypes
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetCarTypes`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetCarTypes`()
BEGIN
	SELECT 
        `car_type`.`Id` as `CarTypeId` 
				,`car_type`.`BrandId` as `CarTypeBrandId`     
        ,`car_type`.`Brand` as `CarTypeBrand`        
        ,`car_type`.`Name` as `CarTypeName`        
        ,`car_type`.`Desc` as `CarTypeDesc`        
        ,`car_type`.`UpdateDate` as `CarTypeUpdateDate`        
        ,`car_type`.`CreatedDate` as `CarTypeCreatedDate`        
    FROM
        `car_type`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetCustomerByIds
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetCustomerByIds`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetCustomerByIds`(IN `pCustomerIds`  varchar(255))
BEGIN
	declare cnt int default 0; 
	declare i int default 0; 
	set cnt = func_split_length(pCustomerIds,','); 
	
	DROP TABLE IF EXISTS `tb_cid`;
  CREATE TEMPORARY TABLE `tb_cid`(`cid` int not null);
	
	while i < cnt 
		do 
			set i = i + 1; 
			insert into tb_cid(`cid`) values (func_split(pCustomerIds,',',i)); 
	end while;

	SELECT 
        `customer`.`Id` as `CustomerId`        
        ,`customer`.`ShopId` as `CustomerShopId`        
        ,`customer`.`Name` as `CustomerName`        
        ,`customer`.`Sex` as `CustomerSex`        
        ,`customer`.`Phone` as `CustomerPhone`        
        ,`customer`.`ToShopNum` as `CustomerToShopNum`        
        ,`customer`.`CurCar` as `CustomerCurCar`        
        ,`customer`.`Nature` as `CustomerNature`        
        ,`customer`.`OriginNature` as `CustomerOriginNature`        
        ,`customer`.`Type` as `CustomerType`        
        ,`customer`.`Industry` as `CustomerIndustry`        
        ,`customer`.`RegionId` as `CustomerRegionId`        
        ,`customer`.`Address` as `CustomerAddress`        
        ,`customer`.`UpdateDate` as `CustomerUpdateDate`        
        ,`customer`.`CreatedDate` as `CustomerCreatedDate`        
    FROM
        `customer`
		INNER JOIN `tb_cid` ON `customer`.`Id` = `tb_cid`.`cid`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetCustomers
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetCustomers`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetCustomers`(IN `pCustomerShopId` int,IN `pCustomerPhone` varchar(50))
BEGIN
	 SELECT 
        `customer`.`Id` as `CustomerId`        
        ,`customer`.`ShopId` as `CustomerShopId`        
        ,`customer`.`Name` as `CustomerName`        
        ,`customer`.`Sex` as `CustomerSex`        
        ,`customer`.`Phone` as `CustomerPhone`        
        ,`customer`.`ToShopNum` as `CustomerToShopNum`        
        ,`customer`.`CurCar` as `CustomerCurCar`        
        ,`customer`.`Nature` as `CustomerNature`        
        ,`customer`.`OriginNature` as `CustomerOriginNature`        
        ,`customer`.`Type` as `CustomerType`        
        ,`customer`.`Industry` as `CustomerIndustry`        
        ,`customer`.`RegionId` as `CustomerRegionId`        
        ,`customer`.`Address` as `CustomerAddress`        
        ,`customer`.`UpdateDate` as `CustomerUpdateDate`        
        ,`customer`.`CreatedDate` as `CustomerCreatedDate`        
    FROM
        `customer`
		LEFT JOIN `front_record` on `customer`.`Id` = `front_record`.`CustomerId`
		WHERE
				`customer`.`ShopId` = case when pCustomerShopId = 0 then `customer`.`ShopId` else pCustomerShopId end
		AND
				`customer`.`Phone` = case when pCustomerPhone is null then `customer`.`Phone` else pCustomerPhone end;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetDCCCustomerRecords
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetDCCCustomerRecords`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetDCCCustomerRecords`(IN `pCustomerId` int,IN `pShopId` int,IN `pStartDate` datetime,IN `pEndDate` datetime)
BEGIN
	 SELECT 
        `dcc_record`.`Id` as `DccRecordId`        
        ,`dcc_record`.`CustomerId` as `DccRecordCustomerId`        
        ,`dcc_record`.`ShopId` as `DccRecordShopId`        
        ,`dcc_record`.`DCCRecallerId` as `DccRecordDCCRecallerId`        
        ,`dcc_record`.`VisitTime` as `DccRecordVisitTime`        
        ,`dcc_record`.`DurationTime` as `DccRecordDurationTime`        
        ,`dcc_record`.`RecallTime` as `DccRecordRecallTime`        
        ,`dcc_record`.`PurposeCar` as `DccRecordPurposeCar`        
        ,`dcc_record`.`LevelCode` as `DccRecordLevelCode`        
        ,`dcc_record`.`Source` as `DccRecordSource`        
        ,`dcc_record`.`Status` as `DccRecordStatus`        
        ,`dcc_record`.`ToShop` as `DccRecordToShop`        
        ,`dcc_record`.`ToShopTime` as `DccRecordToShopTime`        
        ,`dcc_record`.`Installment` as `DccRecordInstallment`        
        ,`dcc_record`.`RecallDesc` as `DccRecordRecallDesc`        
        ,`dcc_record`.`Recorder` as `DccRecordRecorder`        
        ,`dcc_record`.`UpdateDate` as `DccRecordUpdateDate`        
        ,`dcc_record`.`CreatedDate` as `DccRecordCreatedDate`        
    FROM
        `dcc_record`
		WHERE
				`dcc_record`.`CustomerId` = case when pCustomerId = 0 OR pCustomerId IS NULL then `dcc_record`.`CustomerId` else pCustomerId end
		AND
				`dcc_record`.`ShopId` = case when pShopId = 0 OR pShopId IS NULL then `dcc_record`.`CustomerId` else pShopId end
		AND 
			CASE WHEN pStartDate IS NULL THEN TRUE ELSE `dcc_record`.`VisitTime`>= pStartDate END
		AND 
			CASE WHEN pEndDate IS NULL THEN TRUE ELSE `dcc_record`.`VisitTime` <= pEndDate END
		ORDER BY 
				`dcc_record`.`CreatedDate` DESC;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetEvaluateQuestions
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetEvaluateQuestions`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetEvaluateQuestions`()
BEGIN
	SELECT 
        `evaluate_question`.`Id` as `EvaluateQuestionId`
				,`evaluate_question`.`ShopId` as `EvaluateQuestionShopId`
        ,`evaluate_question`.`QDesc` as `EvaluateQuestionQDesc`        
        ,`evaluate_question`.`QType` as `EvaluateQuestionQType`        
        ,`evaluate_question`.`QLevel` as `EvaluateQuestionQLevel`        
        ,`evaluate_question`.`UpdateDate` as `EvaluateQuestionUpdateDate`        
        ,`evaluate_question`.`CreatedDate` as `EvaluateQuestionCreatedDate`        
    FROM
        `evaluate_question`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetFrontCustomerRecords
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetFrontCustomerRecords`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetFrontCustomerRecords`(IN `pRecordId` int,IN `pCustomerId` int,IN `pShopId` int,IN `pStartDate` datetime,IN `pEndDate` datetime)
BEGIN

	SELECT 
        `front_record`.`Id` as `FrontRecordId`        
        ,`front_record`.`CustomerId` as `FrontRecordCustomerId`        
        ,`front_record`.`ShopId` as `FrontRecordShopId`        
        ,`front_record`.`ConsultantId` as `FrontRecordConsultantId`        
        ,`front_record`.`CustomerNum` as `FrontRecordCustomerNum`        
        ,`front_record`.`CarLicence` as `FrontRecordCarLicence`        
        ,`front_record`.`PurposeCar` as `FrontRecordPurposeCar`        
        ,`front_record`.`LevelCode` as `FrontRecordLevelCode`        
        ,`front_record`.`DriveStatus` as `FrontRecordDriveStatus`        
        ,`front_record`.`Source` as `FrontRecordSource`        
        ,`front_record`.`Replace` as `FrontRecordReplace`        
        ,`front_record`.`Installment` as `FrontRecordInstallment`        
        ,`front_record`.`Remark` as `FrontRecordRemark`        
        ,`front_record`.`ArrivalTime` as `FrontRecordArrivalTime`        
        ,`front_record`.`LeaveTime` as `FrontRecordLeaveTime`        
        ,`front_record`.`DurationTime` as `FrontRecordDurationTime`        
        ,`front_record`.`Recorder` as `FrontRecordRecorder`        
        ,`front_record`.`UpdateDate` as `FrontRecordUpdateDate`        
        ,`front_record`.`CreatedDate` as `FrontRecordCreatedDate`         
    FROM
        `front_record`
		WHERE
				`front_record`.`Id` = case when pRecordId = 0 OR pRecordId IS NULL then `front_record`.`Id` else pRecordId end
		AND
				`front_record`.`CustomerId` = CASE WHEN pCustomerId = 0 OR pCustomerId IS NULL THEN `front_record`.`CustomerId` ELSE pCustomerId END
		AND
				`front_record`.`ShopId` = CASE WHEN pShopId = 0 OR pShopId IS NULL  THEN `front_record`.`CustomerId` ELSE pShopId END
		AND 
			CASE WHEN pStartDate IS NULL THEN TRUE ELSE `front_record`.`ArrivalTime` >= pStartDate END
		AND 
			CASE WHEN pEndDate IS NULL THEN TRUE ELSE `front_record`.`ArrivalTime` <= pEndDate END
		ORDER BY `front_record`.`CreatedDate` DESC;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetGroups
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetGroups`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetGroups`(IN `pUserGroupShopId` int)
BEGIN
	 SELECT 
        `user_group`.`Id` as `UserGroupId`        
        ,`user_group`.`ShopId` as `UserGroupShopId`        
        ,`user_group`.`Name` as `UserGroupName`        
        ,`user_group`.`Desc` as `UserGroupDesc`        
        ,`user_group`.`UpdateDate` as `UserGroupUpdateDate`        
        ,`user_group`.`CreatedDate` as `UserGroupCreatedDate`        
    FROM
        `user_group`
		WHERE
			`user_group`.`ShopId` = pUserGroupShopId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetPurposeLevels
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetPurposeLevels`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetPurposeLevels`()
BEGIN
	SELECT 
        `purpose_level`.`Id` as `PurposeLevelId`        
        ,`purpose_level`.`Code` as `PurposeLevelCode`        
        ,`purpose_level`.`Desc` as `PurposeLevelDesc`        
        ,`purpose_level`.`UpdateDate` as `PurposeLevelUpdateDate`        
        ,`purpose_level`.`CreatedDate` as `PurposeLevelCreatedDate`        
    FROM
        `purpose_level`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetRegions
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetRegions`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetRegions`(IN `pRegionShopId` int)
BEGIN
	 SELECT 
        `region`.`Id` as `RegionId`        
        ,`region`.`ShopId` as `RegionShopId`        
        ,`region`.`Province` as `RegionProvince`        
        ,`region`.`City` as `RegionCity`        
        ,`region`.`Region` as `RegionRegion`        
        ,`region`.`UpdateDate` as `RegionUpdateDate`        
        ,`region`.`CreatedDate` as `RegionCreatedDate`        
    FROM
        `region`
		WHERE
			`region`.`ShopId` = 0
		OR
			`region`.`ShopId` = case when pRegionShopId = 0 then `region`.`ShopId` else pRegionShopId end;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetRoles
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetRoles`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetRoles`()
BEGIN
	SELECT 
        role.Id as RoleId
				,role.`Name` as RoleName
				,role.`Desc` as RoleDesc
				,role.CreatedDate as RoleCreatedDate
    FROM
        role;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetShops
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetShops`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetShops`()
BEGIN
	SELECT 
        `shop`.`Id` as `ShopId`        
        ,`shop`.`Name` as `ShopName`        
        ,`shop`.`Phone` as `ShopPhone` 
				,`shop`.`RegionId` as `ShopRegionId` 
        ,`shop`.`Address` as `ShopAddress`        
        ,`shop`.`Desc` as `ShopDesc`        
        ,`shop`.`UpdateDate` as `ShopUpdateDate`        
        ,`shop`.`CreatedDate` as `ShopCreatedDate`        
    FROM
        `shop`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetUserByName
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetUserByName`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetUserByName`(IN `pUserUserName` varchar(100),IN `pUserPwd` varchar(100))
BEGIN
		SELECT 
        `user`.`Id` as `UserId`        
        ,`user`.`ShopId` as `UserShopId`        
        ,`user`.`RoleId` as `UserRoleId`        
        ,`user`.`GroupId` as `UserGroupId`        
        ,`user`.`UserName` as `UserUserName`        
        ,`user`.`Pwd` as `UserPwd`        
        ,`user`.`RealName` as `UserRealName`        
        ,`user`.`Sex` as `UserSex`        
        ,`user`.`Status` as `UserStatus`        
        ,`user`.`Phone` as `UserPhone`        
        ,`user`.`Telephone` as `UserTelephone`        
        ,`user`.`UpdateDate` as `UserUpdateDate`        
        ,`user`.`CreatedDate` as `UserCreatedDate`     
    FROM
        `user`
		WHERE
			`user`.`UserName` = pUserUserName
		AND
			`user`.`Pwd` = pUserPwd;
		
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetUsers
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetUsers`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetUsers`(IN `pUserShopId` int,IN `pUserRoleId` int)
BEGIN
		SELECT 
        `user`.`Id` as `UserId`        
        ,`user`.`ShopId` as `UserShopId`        
        ,`user`.`RoleId` as `UserRoleId`        
        ,`user`.`GroupId` as `UserGroupId`        
        ,`user`.`UserName` as `UserUserName`        
        ,`user`.`Pwd` as `UserPwd`        
        ,`user`.`RealName` as `UserRealName`        
        ,`user`.`Sex` as `UserSex`        
        ,`user`.`Status` as `UserStatus`        
        ,`user`.`Phone` as `UserPhone`        
        ,`user`.`Telephone` as `UserTelephone`        
        ,`user`.`UpdateDate` as `UserUpdateDate`        
        ,`user`.`CreatedDate` as `UserCreatedDate`     
    FROM
        `user`
		WHERE
			`user`.`ShopId` = case when pUserShopId = 0 then `user`.`ShopId` else pUserShopId end
		AND
			`user`.`RoleId` = case when pUserRoleId = 0 then `user`.`RoleId` else pUserRoleId end;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspGetUserTasks
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetUserTasks`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetUserTasks`()
BEGIN
	  SELECT 
        `user_task`.`Id` as `UserTaskId`        
        ,`user_task`.`ConsultantId` as `UserTaskConsultantId` 
				,`user`.`RealName` as `UserTaskConsultantName`        
        ,`user_task`.`StartDate` as `UserTaskStartDate`        
        ,`user_task`.`EndDate` as `UserTaskEndDate`        
        ,`user_task`.`CarTypeId` as `UserTaskCarTypeId`        
        ,`user_task`.`Status` as `UserTaskStatus`        
        ,`user_task`.`Cnt` as `UserTaskCnt`        
        ,`user_task`.`FinishCnt` as `UserTaskFinishCnt`        
        ,`user_task`.`Desc` as `UserTaskDesc`        
        ,`user_task`.`OperatorId` as `UserTaskOperatorId`        
        ,`user_task`.`UpdateDate` as `UserTaskUpdateDate`        
        ,`user_task`.`CreatedDate` as `UserTaskCreatedDate`        
    FROM
        `user_task` INNER JOIN `user` ON `user`.Id = `user_task`.`ConsultantId`;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspSyncDccRecords
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspSyncDccRecords`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspSyncDccRecords`()
BEGIN
	DECLARE tError INTEGER DEFAULT 0; #异常标记
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET tError = 1;#sql 异常时继续执行，如果最后为1 事务回滚

	START TRANSACTION;
		
		#1、 同步车型信息
	  INSERT INTO `car_type`(`Name`,`BrandId`,`Brand`,`Desc`,`CreatedDate`)
		SELECT DISTINCT `PurposeCar`,0,'其他','DCC_导入车型',NOW()
		FROM `import_dcc_temp`
		WHERE
			`import_dcc_temp`.`PurposeCar` NOT IN(
					SELECT `Name` FROM `car_type`
			)
		AND `import_dcc_temp`.`PurposeCar` IS NOT NULL
		AND `import_dcc_temp`.`PurposeCar` <> '';

		#2、 同步客户级别
		INSERT INTO `purpose_level`(`Code`,`Desc`,`CreatedDate`)
		SELECT DISTINCT `PurposeLevel`,'DCC_导入意向级别',NOW()
		FROM `import_dcc_temp`
		WHERE
			`import_dcc_temp`.`PurposeLevel` NOT IN(
				SELECT `Code` FROM `purpose_level`
			)
		AND `import_dcc_temp`.`PurposeLevel` IS NOT NULL
		AND `import_dcc_temp`.`PurposeLevel` <> '';
		
		#3、 同步客户来源
		INSERT INTO `basic_constant`(`Name`,`Order`,`TypeKey`,`TypeValue`,`Remark`,`CreatedDate`)
		SELECT DISTINCT `CSource`,0,'DCCSource',5,'导入DCC客户来源',NOW()
		FROM `import_dcc_temp`
		WHERE
			`import_dcc_temp`.`CSource` NOT IN(
				SELECT `Name` FROM `basic_constant` WHERE `basic_constant`.`TypeKey` = 'DCCSource'
			)
		AND `import_dcc_temp`.`CSource` IS NOT NULL
		AND `import_dcc_temp`.`CSource` <> '';
	
		#4、 同步客户区域信息
		SELECT @ShopId := ShopId
		FROM import_dcc_temp LIMIT 1;

		INSERT INTO `region` (`Region`,`ShopId`,`CreatedDate`)
		SELECT DISTINCT `Region`,@ShopId,NOW()
		FROM `import_dcc_temp`
		WHERE `import_dcc_temp`.`Region` NOT IN(
			SELECT `region`.`Region` FROM `region`
		)
		AND `import_dcc_temp`.`Region` IS NOT NULL
		AND `import_dcc_temp`.`Region` <> '';

		#5、 同步客户信息
		INSERT INTO `customer`(`Phone`,`Name`,`ShopId`,`Sex`,`Type`,`RegionId`,`CreatedDate`)
		SELECT DISTINCT `CPhone`,`CName`,@ShopId
		,CASE WHEN `import_dcc_temp`.`CSex` = '男' THEN 1 ELSE 2 END
		,'dcc',`region`.`Id`,NOW()
		FROM `import_dcc_temp`
		LEFT JOIN `region` on `region`.`Region` = `import_dcc_temp`.`Region`
		WHERE 
			`import_dcc_temp`.`CPhone` NOT IN(
				SELECT `Phone` FROM `customer` 
				WHERE `customer`.`Phone` IS NOT NULL
				AND `customer`.`Phone` <>''
			)
		AND `import_dcc_temp`.`CPhone` IS NOT NULL
		AND `import_dcc_temp`.`CPhone` <> '';
		
		#6、 同步销售顾问信息
		INSERT INTO `user`(`RealName`,`ShopId`,`RoleId`,`UserName`,`Pwd`,`CreatedDate`)
		SELECT DISTINCT `ConsultantName`,`ShopId`,7,`ConsultantName`,'49ba59abbe56e057',NOW() #RoleId = 7 销售顾问-dcc  DCC专员Id 待定 密码 123456
		FROM `import_dcc_temp`
		WHERE
			`import_dcc_temp`.`ConsultantName` NOT IN(
				SELECT `RealName` FROM `user` 
				WHERE `user`.`ShopId` = @ShopId
			);
		#7、 同步客户进店记录
		INSERT INTO `dcc_record`(
        `CustomerId`
        ,`ShopId`
        ,`DCCRecallerId`
        ,`VisitTime`
        ,`DurationTime`
        ,`RecallTime`
        ,`PurposeCar`
        ,`LevelCode`
        ,`Source`
        ,`ToShopTime`
        ,`Installment`
        ,`RecallDesc`
        ,`Recorder`
        ,`CreatedDate`
    )
		   SELECT 
				`customer`.`Id`
        ,`import_dcc_temp`.`ShopId`
				,`user`.Id
        ,`import_dcc_temp`.`VisitTime`
				, TIMEDIFF(`import_dcc_temp`.`RecallTime`,CONCAT(`import_dcc_temp`.`VisitTime`,' 00:00:00'))
				,`import_dcc_temp`.`RecallTime`
				,`car_type`.`Id`
        ,`import_dcc_temp`.`PurposeLevel`
				,`tb_source`.`Id`
				,`import_dcc_temp`.`ToShopTime`
				,CASE WHEN `import_dcc_temp`.`Installment` = '是' THEN 1 ELSE 2 END
				,CONCAT('导入dcc登记记录:',`import_dcc_temp`.`Remark`)
        ,`import_dcc_temp`.`Recorder`
        ,NOW()
    FROM
        `import_dcc_temp`
		INNER JOIN `customer` on `customer`.`Phone` = `import_dcc_temp`.`CPhone`
		INNER JOIN `user` on `user`.`RealName` = `import_dcc_temp`.`ConsultantName`
		INNER JOIN `car_type` on `car_type`.`Name` = `import_dcc_temp`.`PurposeCar`
		INNER JOIN (
			SELECT `Id`,`Name` FROM `basic_constant` 
			WHERE `basic_constant`.`TypeKey` = 'DCCSource'
		) as `tb_source` ON `tb_source`.`Name` = `import_dcc_temp`.`CSource`;

		#8、 清空预置的 客户手机号码，预置客户手机号，为了防止客户创建时对应不上的
		UPDATE `customer`
		SET `customer`.`Phone` = ''
		WHERE LENGTH(`customer`.`Phone`) < 11;
	IF tError = 1 THEN
		ROLLBACK;
	ELSE
		COMMIT;
	END IF;
	
	SELECT tError; #返回事务状态 0成功 1失败
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspSyncFrontRecords
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspSyncFrontRecords`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspSyncFrontRecords`()
BEGIN
	DECLARE tError INTEGER DEFAULT 0; #异常标记
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET tError = 1;#sql 异常时继续执行，如果最后为1 事务回滚

	START TRANSACTION;
		
		#1、 同步车型信息
	  INSERT INTO `car_type`(`Name`,`BrandId`,`Brand`,`Desc`,`CreatedDate`)
		SELECT DISTINCT `PurposeCar`,0,'其他','前台_导入车型',NOW()
		FROM `import_front_temp`
		WHERE
			`import_front_temp`.`PurposeCar` NOT IN(
					SELECT `Name` FROM `car_type`
			)
		AND `import_front_temp`.`PurposeCar` IS NOT NULL
		AND `import_front_temp`.`PurposeCar` <> '';

		#2、 同步客户级别
		INSERT INTO `purpose_level`(`Code`,`Desc`,`CreatedDate`)
		SELECT DISTINCT `PurposeLevel`,'前台_导入意向级别',NOW()
		FROM `import_front_temp`
		WHERE
			`import_front_temp`.`PurposeLevel` NOT IN(
				SELECT `Code` FROM `purpose_level`
			)
		AND `import_front_temp`.`PurposeLevel` IS NOT NULL
		AND `import_front_temp`.`PurposeLevel` <> '';
		
		#3、 同步客户来源
		INSERT INTO `basic_constant`(`Name`,`Order`,`TypeKey`,`TypeValue`,`Remark`,`CreatedDate`)
		SELECT DISTINCT `CSource`,0,'FrontSource',5,'导入前台客户来源',NOW()
		FROM `import_front_temp`
		WHERE
			`import_front_temp`.`CSource` NOT IN(
				SELECT `Name` FROM `basic_constant` WHERE `basic_constant`.`TypeKey` = 'FrontSource'
			)
		AND `import_front_temp`.`CSource` IS NOT NULL
		AND `import_front_temp`.`CSource` <> '';
		
		#4、 同步客户信息
		INSERT INTO `customer`(`Phone`,`Name`,`ShopId`,`ToShopNum`,`CurCar`,`Type`,`CreatedDate`)
		SELECT DISTINCT `CPhone`,`CName`,`ShopId`,1,`CCurCar`,'front',NOW()
		FROM `import_front_temp`
		WHERE 
			`import_front_temp`.`CPhone` NOT IN(
				SELECT `Phone` FROM `customer` 
				WHERE `customer`.`Phone` IS NOT NULL
				AND `customer`.`Phone` <>''
			)
		AND `import_front_temp`.`CPhone` IS NOT NULL
		AND `import_front_temp`.`CPhone` <> '';
		
		#5、 同步销售顾问信息
		SELECT @ShopId := ShopId
		FROM import_front_temp LIMIT 1;
			
		INSERT INTO `user`(`RealName`,`ShopId`,`RoleId`,`UserName`,`Pwd`,`CreatedDate`)
		SELECT DISTINCT `ConsultantName`,`ShopId`,6,`ConsultantName`,'49ba59abbe56e057',NOW()#Pwd = 123456 6:销售顾问-展厅
		FROM `import_front_temp`
		WHERE
			`import_front_temp`.`ConsultantName` NOT IN(
				SELECT `RealName` FROM `user` 
				WHERE `user`.`ShopId` = @ShopId
			);
		#6、 同步客户进店记录
		INSERT INTO `front_record`(
        `CustomerId`
        ,`ShopId`
        ,`ConsultantId`
        ,`CustomerNum`
        ,`PurposeCar`
        ,`LevelCode`
        ,`DriveStatus`
        ,`Source`
        ,`Replace`
        ,`Installment`
        ,`Remark`
        ,`ArrivalTime`
        ,`LeaveTime`
        ,`DurationTime`
        ,`Recorder`
        ,`CreatedDate`
    )
		   SELECT 
				`customer`.`Id`
        ,`import_front_temp`.`ShopId`
				,`user`.Id
        ,`import_front_temp`.`CNum`
				,`car_type`.`Id`
        ,`import_front_temp`.`PurposeLevel`
				,CASE WHEN `import_front_temp`.`DriveStatus` = '是' THEN 1 ELSE 2 END
				,`tb_source`.`Id`
				,CASE WHEN `import_front_temp`.`Replace` = '是' THEN 1 ELSE 2 END
				,CASE WHEN `import_front_temp`.`Installment` = '是' THEN 1 ELSE 2 END
				,'导入前台登记记录'
				,CONCAT(`import_front_temp`.`RecordDate`,' ',`import_front_temp`.`ArrivalTime`)
				,CONCAT(`import_front_temp`.`RecordDate`,' ',`import_front_temp`.`LeaveTime`)
				,TIMEDIFF(`import_front_temp`.`LeaveTime`,`import_front_temp`.`ArrivalTime`)
        ,`import_front_temp`.`Recorder`
        ,NOW()
    FROM
        `import_front_temp`
		INNER JOIN `customer` on `customer`.`Phone` = `import_front_temp`.`CPhone`
		INNER JOIN `user` on `user`.`RealName` = `import_front_temp`.`ConsultantName`
		INNER JOIN `car_type` on `car_type`.`Name` = `import_front_temp`.`PurposeCar`
		INNER JOIN (
			SELECT `Id`,`Name` FROM `basic_constant` 
			WHERE `basic_constant`.`TypeKey` = 'FrontSource'
		) as `tb_source` ON `tb_source`.`Name` = `import_front_temp`.`CSource`;

		#7 清空预置的 客户手机号码，预置客户手机号，为了防止客户创建时对应不上的
		UPDATE `customer`
		SET `customer`.`Phone` = ''
		WHERE LENGTH(`customer`.`Phone`) < 11;
	IF tError = 1 THEN
		ROLLBACK;
	ELSE
		COMMIT;
	END IF;
	
	SELECT tError; #返回事务状态 0成功 1失败
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateAnalyseKPI
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateAnalyseKPI`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateAnalyseKPI`(IN `pAnalyseKpiId` int,IN `pAnalyseKpiName` varchar(100),IN `pAnalyseKpiKValue` int,IN `pAnalyseKpiKUnit` varchar(100),IN `pAnalyseKpiPerform` varchar(200),IN `pAnalyseKpiReason` varchar(200),IN `pAnalyseKpiSuggest` varchar(200),IN `pAnalyseKpiDesc` varchar(200),IN `pAnalyseKpiOperatorId` int)
BEGIN
	UPDATE `analyse_kpi`
    SET
        `analyse_kpi`.`Name` = case when pAnalyseKpiName is null then `analyse_kpi`.`Name` else pAnalyseKpiName end
        ,`analyse_kpi`.`KValue` = case when pAnalyseKpiKValue is null then `analyse_kpi`.`KValue` else pAnalyseKpiKValue end
        ,`analyse_kpi`.`KUnit` = case when pAnalyseKpiKUnit is null then `analyse_kpi`.`KUnit` else pAnalyseKpiKUnit end
        ,`analyse_kpi`.`Perform` = case when pAnalyseKpiPerform is null then `analyse_kpi`.`Perform` else pAnalyseKpiPerform end
        ,`analyse_kpi`.`Reason` = case when pAnalyseKpiReason is null then `analyse_kpi`.`Reason` else pAnalyseKpiReason end
        ,`analyse_kpi`.`Suggest` = case when pAnalyseKpiSuggest is null then `analyse_kpi`.`Suggest` else pAnalyseKpiSuggest end
        ,`analyse_kpi`.`Desc` = case when pAnalyseKpiDesc is null then `analyse_kpi`.`Desc` else pAnalyseKpiDesc end
				,`analyse_kpi`.`OperatorId` = case when pAnalyseKpiOperatorId is null then `analyse_kpi`.`OperatorId` else pAnalyseKpiOperatorId end
        ,`analyse_kpi`.`UpdateDate` = NOW()
    WHERE
        Id=pAnalyseKpiId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateCarType
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateCarType`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateCarType`(IN `pCarTypeId` int,IN `pCarTypeBrandId` int,IN `pCarTypeBrand` varchar(100),IN `pCarTypeName` varchar(100),IN `pCarTypeDesc` varchar(100))
BEGIN
	UPDATE `car_type`
    SET
				`car_type`.`BrandId` = case when pCarTypeBrandId is null then `car_type`.`BrandId` else pCarTypeBrandId end
        ,`car_type`.`Brand` = case when pCarTypeBrand is null then `car_type`.`Brand` else pCarTypeBrand end
        ,`car_type`.`Name` = case when pCarTypeName is null then `car_type`.`Name` else pCarTypeName end
        ,`car_type`.`Desc` = case when pCarTypeDesc is null then `car_type`.`Desc` else pCarTypeDesc end
        ,`car_type`.`UpdateDate` = NOW()        
    WHERE
        Id=pCarTypeId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateCustomer
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateCustomer`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateCustomer`(IN `pCustomerId` int,IN `pCustomerShopId` int,IN `pCustomerName` varchar(100),IN `pCustomerSex` int,IN `pCustomerPhone` varchar(50),IN `pCustomerCurCar` varchar(100),IN `pCustomerNature` int,IN `pCustomerType` varchar(50),IN `pCustomerIndustry` varchar(100),IN `pCustomerRegionId` int,IN `pCustomerAddress` varchar(200))
BEGIN
	SELECT @ToShopNum := COUNT(0)
	FROM `front_record`
	WHERE
		`front_record`.`CustomerId` = pCustomerId;
	
	UPDATE `customer`
    SET
        `customer`.`ShopId` = case when pCustomerShopId is null then `customer`.`ShopId` else pCustomerShopId end
        ,`customer`.`Name` = case when pCustomerName is null then `customer`.`Name` else pCustomerName end
        ,`customer`.`Sex` = case when pCustomerSex is null then `customer`.`Sex` else pCustomerSex end
				,`customer`.`Phone` = case when pCustomerPhone is null then `customer`.`Phone` else pCustomerPhone end
				,`customer`.`ToShopNum` = @ToShopNum
				,`customer`.`CurCar` = case when pCustomerCurCar is null then `customer`.`CurCar` else pCustomerCurCar end
        ,`customer`.`Nature` = case when pCustomerNature is null then `customer`.`Nature` else pCustomerNature end
        ,`customer`.`OriginNature` = case when `customer`.`OriginNature` is null then pCustomerNature else `customer`.`OriginNature` end
        ,`customer`.`Type` = case when pCustomerType is null then `customer`.`Type` else pCustomerType end
        ,`customer`.`Industry` = case when pCustomerIndustry is null then `customer`.`Industry` else pCustomerIndustry end
        ,`customer`.`RegionId` = case when pCustomerRegionId is null then `customer`.`RegionId` else pCustomerRegionId end
        ,`customer`.`Address` = case when pCustomerAddress is null then `customer`.`Address` else pCustomerAddress end
        ,`customer`.`UpdateDate` = NOW()
    WHERE
        Id=pCustomerId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateDCCRecord
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateDCCRecord`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateDCCRecord`(IN `pDccRecordCustomerId` int,IN `pDccRecordId` int,IN `pDccRecordDCCRecallerId` int,IN `pDccRecordVisitTime` datetime,IN `pDccRecordDurationTime` varchar(50),IN `pDccRecordRecallTime` datetime,IN `pDccRecordPurposeCar` int,IN `pDccRecordLevelCode` varchar(100),IN `pDccRecordSource` int,IN `pDccRecordStatus` int,IN `pDccRecordToShop` int,IN `pDccRecordToShopTime` datetime,IN `pDccRecordInstallment` int,IN `pDccRecordRecallDesc` varchar(200),IN `pDccRecordRecorder` varchar(100))
BEGIN
	 UPDATE `dcc_record`
    SET
				`dcc_record`.`CustomerId` = case when pDccRecordCustomerId is null then `dcc_record`.`CustomerId` else pDccRecordCustomerId end
				,`dcc_record`.`DCCRecallerId` = case when pDccRecordDCCRecallerId is null then `dcc_record`.`DCCRecallerId` else pDccRecordDCCRecallerId end
        ,`dcc_record`.`VisitTime` = case when pDccRecordVisitTime is null then `dcc_record`.`VisitTime` else pDccRecordVisitTime end
        ,`dcc_record`.`DurationTime` = case when pDccRecordDurationTime is null then `dcc_record`.`DurationTime` else pDccRecordDurationTime end
        ,`dcc_record`.`RecallTime` = case when pDccRecordRecallTime is null then `dcc_record`.`RecallTime` else pDccRecordRecallTime end
        ,`dcc_record`.`PurposeCar` = case when pDccRecordPurposeCar is null then `dcc_record`.`PurposeCar` else pDccRecordPurposeCar end
        ,`dcc_record`.`LevelCode` = case when pDccRecordLevelCode is null then `dcc_record`.`LevelCode` else pDccRecordLevelCode end
        ,`dcc_record`.`Source` = case when pDccRecordSource is null then `dcc_record`.`Source` else pDccRecordSource end
        ,`dcc_record`.`Status` = case when pDccRecordStatus is null then `dcc_record`.`Status` else pDccRecordStatus end
        ,`dcc_record`.`ToShop` = case when pDccRecordToShop is null then `dcc_record`.`ToShop` else pDccRecordToShop end
        ,`dcc_record`.`ToShopTime` = case when pDccRecordToShopTime is null then `dcc_record`.`ToShopTime` else pDccRecordToShopTime end
        ,`dcc_record`.`Installment` = case when pDccRecordInstallment is null then `dcc_record`.`Installment` else pDccRecordInstallment end
        ,`dcc_record`.`RecallDesc` = case when pDccRecordRecallDesc is null then `dcc_record`.`RecallDesc` else pDccRecordRecallDesc end
        ,`dcc_record`.`Recorder` = case when pDccRecordRecorder is null then `dcc_record`.`Recorder` else pDccRecordRecorder end
        ,`dcc_record`.`UpdateDate` = NOW()
    WHERE
        Id=pDccRecordId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateEvaluateQuestion
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateEvaluateQuestion`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateEvaluateQuestion`(IN `pEvaluateQuestionId` int,IN `pEvaluateQuestionShopId` int,IN `pEvaluateQuestionQDesc` varchar(200),IN `pEvaluateQuestionQType` int,IN `pEvaluateQuestionQLevel` int)
BEGIN
	 UPDATE `evaluate_question`
    SET
				`evaluate_question`.`ShopId` = case when pEvaluateQuestionShopId is null then `evaluate_question`.`ShopId` else pEvaluateQuestionShopId end
        ,`evaluate_question`.`QDesc` = case when pEvaluateQuestionQDesc is null then `evaluate_question`.`QDesc` else pEvaluateQuestionQDesc end
        ,`evaluate_question`.`QType` = case when pEvaluateQuestionQType is null then `evaluate_question`.`QType` else pEvaluateQuestionQType end
        ,`evaluate_question`.`QLevel` = case when pEvaluateQuestionQLevel is null then `evaluate_question`.`QLevel` else pEvaluateQuestionQLevel end
        ,`evaluate_question`.`UpdateDate` = NOW()
    WHERE
        Id=pEvaluateQuestionId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateFrontRecord
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateFrontRecord`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateFrontRecord`(IN `pFrontRecordId` int,IN `pFrontRecordCustomerId` int,IN `pFrontRecordShopId` int,IN `pFrontRecordConsultantId` int,IN `pFrontRecordCustomerNum` int,IN `pFrontRecordCarLicence` int,IN `pFrontRecordPurposeCar` int,IN `pFrontRecordLevelCode` varchar(100),IN `pFrontRecordDriveStatus` int,IN `pFrontRecordSource` int,IN `pFrontRecordReplace` int,IN `pFrontRecordInstallment` int,IN `pFrontRecordRemark` varchar(200),IN `pFrontRecordLeaveTime` datetime,IN `pFrontRecordDurationTime` varchar(50))
BEGIN
	UPDATE `front_record`
    SET
				`front_record`.`CustomerId` = case when pFrontRecordCustomerId is null then `front_record`.`CustomerId` else pFrontRecordCustomerId end
        ,`front_record`.`ShopId` = case when pFrontRecordShopId is null then `front_record`.`ShopId` else pFrontRecordShopId end
        ,`front_record`.`ConsultantId` = case when pFrontRecordConsultantId is null then `front_record`.`ConsultantId` else pFrontRecordConsultantId end
        ,`front_record`.`CustomerNum` = case when pFrontRecordCustomerNum is null then `front_record`.`CustomerNum` else pFrontRecordCustomerNum end
        ,`front_record`.`CarLicence` = case when pFrontRecordCarLicence is null then `front_record`.`CarLicence` else pFrontRecordCarLicence end
        ,`front_record`.`PurposeCar` = case when pFrontRecordPurposeCar is null then `front_record`.`PurposeCar` else pFrontRecordPurposeCar end
        ,`front_record`.`LevelCode` = case when pFrontRecordLevelCode is null then `front_record`.`LevelCode` else pFrontRecordLevelCode end
        ,`front_record`.`DriveStatus` = case when pFrontRecordDriveStatus is null then `front_record`.`DriveStatus` else pFrontRecordDriveStatus end
        ,`front_record`.`Source` = case when pFrontRecordSource is null then `front_record`.`Source` else pFrontRecordSource end
        ,`front_record`.`Replace` = case when pFrontRecordReplace is null then `front_record`.`Replace` else pFrontRecordReplace end
        ,`front_record`.`Installment` = case when pFrontRecordInstallment is null then `front_record`.`Installment` else pFrontRecordInstallment end
        ,`front_record`.`Remark` = case when pFrontRecordRemark is null then `front_record`.`Remark` else pFrontRecordRemark end
        ,`front_record`.`LeaveTime` = case when pFrontRecordLeaveTime is null then `front_record`.`LeaveTime` else pFrontRecordLeaveTime end
        ,`front_record`.`DurationTime` = case when pFrontRecordDurationTime is null then `front_record`.`DurationTime` else pFrontRecordDurationTime end
        ,`front_record`.`UpdateDate` = NOW()
    WHERE
        Id=pFrontRecordId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdatePurposeLevel
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdatePurposeLevel`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdatePurposeLevel`(IN `pPurposeLevelId` int,IN `pPurposeLevelCode` varchar(10),IN `pPurposeLevelDesc` varchar(200))
BEGIN
	 UPDATE `customer_level`
    SET
        `purpose_level`.`Code` = case when pPurposeLevelCode is null then `purpose_level`.`Code` else pPurposeLevelCode end
        ,`purpose_level`.`Desc` = case when pPurposeLevelDesc is null then `purpose_level`.`Desc` else pPurposeLevelDesc end
				,`purpose_level`.`UpdateDate` = NOW()
    WHERE
        Id=pPurposeLevelId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateShop
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateShop`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateShop`(IN `pShopId` int,IN `pShopName` varchar(200),IN `pShopPhone` varchar(50),IN `pShopRegionId` int,IN `pShopAddress` varchar(200),IN `pShopDesc` varchar(200),IN `pShopUpdateDate` datetime)
BEGIN
	  UPDATE `shop`
    SET
        `shop`.`Name` = case when pShopName is null then `shop`.`Name` else pShopName end
        ,`shop`.`Phone` = case when pShopPhone is null then `shop`.`Phone` else pShopPhone end
				,`shop`.`RegionId` = case when pShopRegionId is null then `shop`.`RegionId` else pShopRegionId end
        ,`shop`.`Address` = case when pShopAddress is null then `shop`.`Address` else pShopAddress end
        ,`shop`.`Desc` = case when pShopDesc is null then `shop`.`Desc` else pShopDesc end
        ,`shop`.`UpdateDate` = NOW()
    WHERE
        Id=pShopId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateUser
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateUser`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateUser`(IN `pUserId` int,IN `pUserShopId` int,IN `pUserRoleId` int,IN `pUserGroupId` int,IN `pUserUserName` varchar(100),IN `pUserPwd` varchar(100),IN `pUserRealName` varchar(100),IN `pUserSex` int,IN `pUserStatus` int,IN `pUserPhone` varchar(50),IN `pUserTelephone` varchar(50))
BEGIN
	UPDATE `user`
    SET
        `user`.`ShopId` = case when pUserShopId is null then `user`.`ShopId` else pUserShopId end
        ,`user`.`RoleId` = case when pUserRoleId is null then `user`.`RoleId` else pUserRoleId end
        ,`user`.`GroupId` = case when pUserGroupId is null then `user`.`GroupId` else pUserGroupId end
        ,`user`.`UserName` = case when pUserUserName is null then `user`.`UserName` else pUserUserName end
        ,`user`.`Pwd` = case when pUserPwd is null then `user`.`Pwd` else pUserPwd end
        ,`user`.`RealName` = case when pUserRealName is null then `user`.`RealName` else pUserRealName end
        ,`user`.`Sex` = case when pUserSex is null then `user`.`Sex` else pUserSex end
        ,`user`.`Status` = case when pUserStatus is null then `user`.`Status` else pUserStatus end
				,`user`.`Phone` = case when pUserPhone is null then `user`.`Phone` else pUserPhone end
        ,`user`.`Telephone` = case when pUserTelephone is null then `user`.`Telephone` else pUserTelephone end
        ,`user`.`UpdateDate` = NOW()
    WHERE
        Id=pUserId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateUserGroup
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateUserGroup`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateUserGroup`(IN `pUserIds`  varchar(255),IN `pGroupId` int)
BEGIN
SET @groupId = pGroupId;

SET @updateSql = 'UPDATE `user`
									SET
										`user`.`GroupId` = ?
										,`user`.`UpdateDate` = NOW()
									WHERE
										`user`.`Id` IN (';
IF pGroupId IS  NULL OR pGroupId = 0 THEN
	SET @groupId = 0;
END IF;

IF pUserIds IS  NULL OR pUserIds = '' THEN
	SET @updateSql = CONCAT(@updateSql,'0)');
ELSE
	SET @updateSql = CONCAT(@updateSql,pUserIds,')');
END IF;

PREPARE stmt FROM @updateSql;

EXECUTE stmt USING @groupId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateUserTask
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateUserTask`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateUserTask`(IN `pUserTaskId` int,IN `pUserTaskConsultantId` int,IN `pUserTaskStartDate` datetime,IN `pUserTaskEndDate` datetime,IN `pUserTaskCarTypeId` int,IN `pUserTaskCnt` int,IN `pUserTaskDesc` varchar(255),IN `pUserTaskOperatorId` int)
BEGIN
		UPDATE `user_task`
    SET
        `user_task`.`ConsultantId` = case when pUserTaskConsultantId is null then `user_task`.`ConsultantId` else pUserTaskConsultantId end
        ,`user_task`.`StartDate` = case when pUserTaskStartDate is null then `user_task`.`StartDate` else pUserTaskStartDate end
        ,`user_task`.`EndDate` = case when pUserTaskEndDate is null then `user_task`.`EndDate` else pUserTaskEndDate end
        ,`user_task`.`CarTypeId` = case when pUserTaskCarTypeId is null then `user_task`.`CarTypeId` else pUserTaskCarTypeId end
        #,`user_task`.`Status` = case when pUserTaskStatus is null then `user_task`.`Status` else pUserTaskStatus end
        ,`user_task`.`Cnt` = case when pUserTaskCnt is null then `user_task`.`Cnt` else pUserTaskCnt end
        #,`user_task`.`FinishCnt` = case when pUserTaskFinishCnt is null then `user_task`.`FinishCnt` else pUserTaskFinishCnt end
        ,`user_task`.`Desc` = case when pUserTaskDesc is null then `user_task`.`Desc` else pUserTaskDesc end
        ,`user_task`.`OperatorId` = case when pUserTaskOperatorId is null then `user_task`.`OperatorId` else pUserTaskOperatorId end
        ,`user_task`.`UpdateDate` = NOW()
    WHERE
        Id=pUserTaskId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspValidateUserName
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspValidateUserName`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspValidateUserName`(IN `pUserId` int,IN `pUserUserName` varchar(100))
BEGIN
	 SELECT 
        `user`.`Id` as `UserId`
	 FROM
        `user`
    WHERE
			`user`.`Id` != case when pUserId is null then `user`.`Id` else pUserId end
		AND `user`.`UserName` = pUserUserName;
END
;;
DELIMITER ;

-- ----------------------------
-- Function structure for func_split
-- ----------------------------
DROP FUNCTION IF EXISTS `func_split`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `func_split`(f_string varchar(1000),f_delimiter varchar(5),f_order int) RETURNS int(11)
BEGIN 

declare result varchar(255) default ''; 
set result = reverse(substring_index(reverse(substring_index(f_string,f_delimiter,f_order)),f_delimiter,1)); 
return result; 
END
;;
DELIMITER ;

-- ----------------------------
-- Function structure for func_split_length
-- ----------------------------
DROP FUNCTION IF EXISTS `func_split_length`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `func_split_length`(f_string varchar(10000),f_delimiter varchar(50)) RETURNS int(11)
BEGIN 
return 1+(length(f_string) - length(replace(f_string,f_delimiter,''))); 
END
;;
DELIMITER ;

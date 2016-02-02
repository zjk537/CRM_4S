/*
Navicat MySQL Data Transfer

Source Server         : MySql(172.0.0.1)
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : crm_4s

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-01-29 10:56:46
*/

-- ----------------------------
-- Records of role
-- ----------------------------
INSERT INTO `role` VALUES ('1', '系统管理员', '跨系统所有权限', NOW());
INSERT INTO `role` VALUES ('2', '总经理', '某个系统的所有权限', NOW());
INSERT INTO `role` VALUES ('3', '销售经理', '销售系统管理', NOW());
INSERT INTO `role` VALUES ('4', '市场经理', '市场系统管理', NOW());
INSERT INTO `role` VALUES ('5', '销售前台', '前台信息录入', NOW());
INSERT INTO `role` VALUES ('6', '销售顾问', '客户信息维护', NOW());

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '0', '1', '0', 'Admin', 'admin', 'Admin', '2', null, '12345678', null, null, NOW());


-- ----------------------------
-- Records of region
-- ----------------------------
INSERT INTO `region` VALUES ( '0', null, '北京', '东城区', null,  NOW());
INSERT INTO `region` VALUES ( '0', null, '北京', '西域区', null,  NOW());
INSERT INTO `region` VALUES ('0', null, '北京', '海淀区', null,  NOW());
INSERT INTO `region` VALUES ('0', null, '北京', '朝阳区', null,  NOW());
INSERT INTO `region` VALUES ('0', null, '北京', '昌平区', null,  NOW());

-- ----------------------------
-- Records of basic_constant
-- ----------------------------
INSERT INTO `basic_constant` VALUES ('1', '0', '未知', '1', 'Sex', '1', '性别', null, NOW());
INSERT INTO `basic_constant` VALUES ('2', '0', '男', '2', 'Sex', '1', '性别', null, NOW());
INSERT INTO `basic_constant` VALUES ('3', '0', '女', '3', 'Sex', '1', '性别', null, NOW());
INSERT INTO `basic_constant` VALUES ('4', '0', '全部', '1', 'QType', '2', '问题类型', null, NOW());
INSERT INTO `basic_constant` VALUES ('5', '0', '店面前台', '2', 'QType', '2', '问题类型', null, NOW());
INSERT INTO `basic_constant` VALUES ('6', '0', 'DCC专员', '3', 'QType', '2', '问题类型', null, NOW());
INSERT INTO `basic_constant` VALUES ('7', '0', '新增到店', '1', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('8', '0', '再次到店', '2', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('9', '0', '电销邀约', '3', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('10', '0', '外展留档', '4', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('11', '0', '二级网点', '5', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('12', '0', '其它到店', '6', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('13', '0', '已有牌照', '1', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('14', '0', '待拍牌照', '2', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('15', '0', '旧车退牌', '2', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('16', '0', '郊区牌照', '3', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('17', '0', '外省上牌', '4', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('18', '0', '自然到店', '1', 'FrontSource', '5', '前台用户来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('19', '0', '网站预约', '2', 'FrontSource', '5', '前台用户来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('20', '0', '朋友介绍', '3', 'FrontSource', '5', '前台用户来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('21', '0', '丰田', '1', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('22', '0', 'BYD', '2', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('23', '0', '广汽', '3', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('24', '0', '哈弗', '4', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('25', '0', '宝马', '5', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('26', '0', '其他', '6', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('27', '0', '易车', '1', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('28', '0', '汽车之家', '2', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('29', '0', '第一车市', '3', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('30', '0', '厂家平台', '4', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('31', '0', '展厅战败', '5', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('32', '0', '其它渠道', '6', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('33', '0', '有效', '1', 'DCCStatus', '8', 'DCC 线索状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('34', '0', '无效', '2', 'DCCStatus', '8', 'DCC 线索状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('35', '0', '重复', '3', 'DCCStatus', '8', 'DCC 线索状态', null, NOW());

INSERT INTO `basic_constant` VALUES ('36', '0', '是', '1', 'DCCStatus', '9', '承诺到店', null, NOW());
INSERT INTO `basic_constant` VALUES ('37', '0', '否', '2', 'DCCStatus', '9', '承诺到店', null, NOW());
INSERT INTO `basic_constant` VALUES ('38', '0', '需跟进', '3', 'DCCStatus', '9', '承诺到店', null, NOW());

INSERT INTO `basic_constant` VALUES ('39', '0', '是', '1', 'LoginStatus', '10', '是否到店', null, NOW());
INSERT INTO `basic_constant` VALUES ('40', '0', '否', '2', 'LoginStatus', '10', '是否到店', null, NOW());
INSERT INTO `basic_constant` VALUES ('41', '0', '未知', '3', 'LoginStatus', '10', '是否到店', null, NOW());

INSERT INTO `basic_constant` VALUES ('42', '0', '在职', '1', 'UserStatus', '11', '系统用户状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('43', '0', '离职', '2', 'UserStatus', '11', '系统用户状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('44', '0', '休假', '3', 'UserStatus', '11', '系统用户状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('45', '0', '删除', '4', 'UserStatus', '11', '系统用户状态', null, NOW());

INSERT INTO `basic_constant` VALUES ('46', '0', '未完成', '1', 'TaskStauts', '11', '销售顾问任务状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('47', '0', '已完成', '2', 'TaskStauts', '11', '销售顾问任务状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('48', '0', '未知', '3', 'TaskStauts', '11', '销售顾问任务状态', null, NOW());

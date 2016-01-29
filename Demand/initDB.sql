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

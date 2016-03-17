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
-- Records of shop
-- ----------------------------
INSERT INTO `shop` VALUES ('1', '北京朝阳店', '11', '4', '国贸', null, null, '2016-02-14 09:47:04');

-- ----------------------------
-- Records of role
-- ----------------------------
INSERT INTO `role` VALUES ('1', '系统管理员', '跨系统所有权限', NOW());
INSERT INTO `role` VALUES ('2', '总经理', '某个系统的所有权限', NOW());
INSERT INTO `role` VALUES ('3', '销售经理', '销售系统管理', NOW());
INSERT INTO `role` VALUES ('4', '市场经理', '市场系统管理', NOW());
INSERT INTO `role` VALUES ('5', '销售前台', '前台信息录入', NOW());
INSERT INTO `role` VALUES ('6', '销售顾问-展厅', '客户信息维护', NOW());
INSERT INTO `role` VALUES ('7', '销售顾问-DCC', '客户信息维护', NOW());
INSERT INTO `role` VALUES ('8', '销售顾问-实习', '客户信息维护', NOW());

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '0', '1', '0', 'Admin', '7a57a5a743894a0e', 'Admin', '2', null, '12345678', null, null, NOW());
INSERT INTO `user` VALUES ('2', '1', '2', '0', 'xj', 'cb6720b002105b44', '张生', '1', '1', '111', null, null, '2016-02-14 09:48:13');

-- ----------------------------
-- Records of region
-- ----------------------------
INSERT INTO `region` VALUES ('1', '0', null, '北京', '东城区', null, NOW());
INSERT INTO `region` VALUES ('2', '0', null, '北京', '西域区', null, NOW());
INSERT INTO `region` VALUES ('3', '0', null, '北京', '海淀区', null, NOW());
INSERT INTO `region` VALUES ('4', '0', null, '北京', '朝阳区', null, NOW());
INSERT INTO `region` VALUES ('5', '0', null, '北京', '昌平区', null, NOW());

-- ----------------------------
-- Records of basic_constant
-- ----------------------------
INSERT INTO `basic_constant` VALUES ('1', '0', '全部', '1', 'QType', '2', '问题类型', null, NOW());
INSERT INTO `basic_constant` VALUES ('2', '0', '店面前台', '2', 'QType', '2', '问题类型', null, NOW());
INSERT INTO `basic_constant` VALUES ('3', '0', 'DCC专员', '3', 'QType', '2', '问题类型', null, NOW());
INSERT INTO `basic_constant` VALUES ('4', '0', '新增到店', '1', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('5', '0', '再次到店', '2', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('6', '0', '电销邀约', '3', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('7', '0', '外展留档', '4', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('8', '0', '二级网点', '5', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('9', '0', '其它到店', '6', 'CNature', '3', '顾客性质', null, NOW());
INSERT INTO `basic_constant` VALUES ('10', '0', '已有牌照', '1', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('11', '0', '待拍牌照', '2', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('12', '0', '旧车退牌', '2', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('13', '0', '郊区牌照', '3', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('14', '0', '外省上牌', '4', 'CarLicence', '4', '牌照状况', null, NOW());
INSERT INTO `basic_constant` VALUES ('15', '0', '自然到店', '1', 'FrontSource', '5', '前台用户来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('16', '0', '网站预约', '2', 'FrontSource', '5', '前台用户来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('17', '0', '朋友介绍', '3', 'FrontSource', '5', '前台用户来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('18', '0', '丰田', '1', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('19', '0', 'BYD', '2', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('20', '0', '广汽', '3', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('21', '0', '哈弗', '4', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('22', '0', '宝马', '5', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('23', '0', '其他', '6', 'CarBrand', '6', '汽车品牌', null, NOW());
INSERT INTO `basic_constant` VALUES ('24', '0', '易车', '1', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('25', '0', '汽车之家', '2', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('26', '0', '第一车市', '3', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('27', '0', '厂家平台', '4', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('28', '0', '展厅战败', '5', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('29', '0', '其它渠道', '6', 'DCCSource', '7', 'DCC 线索来源', null, NOW());
INSERT INTO `basic_constant` VALUES ('30', '0', '未完成', '1', 'TaskStauts', '11', '销售顾问任务状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('31', '0', '已完成', '2', 'TaskStauts', '11', '销售顾问任务状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('32', '0', '未知', '3', 'TaskStauts', '11', '销售顾问任务状态', null, NOW());
INSERT INTO `basic_constant` VALUES ('33', '0', '首次接待量', '1', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('34', '0', '首次有效率', '2', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('35', '0', '再次有效率', '3', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('36', '0', '邀约到店率', '4', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('37', '0', '首次接待时长', '5', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('38', '0', '首次试驾率', '6', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('39', '0', '再次接待时长', '7', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('40', '0', '再次试驾率', '8', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('41', '0', '首次转化率', '9', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('42', '0', '二次转化率', '10', 'FrontKPI', '13', '展厅销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('43', '0', '新增线索量', '1', 'DCCKPI', '14', 'DCC销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('44', '0', '首次跟进率', '2', 'DCCKPI', '14', 'DCC销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('45', '0', '有效潜客量', '3', 'DCCKPI', '14', 'DCC销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('46', '0', '首次到店率', '4', 'DCCKPI', '14', 'DCC销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('47', '0', '首次到店转化率', '5', 'DCCKPI', '14', 'DCC销售顾问考核指标', null, NOW());
INSERT INTO `basic_constant` VALUES ('48', '0', '二次到店转化率', '6', 'DCCKPI', '14', 'DCC销售顾问考核指标', null, NOW());

-- ----------------------------
-- Records of analyse_kpi
-- ----------------------------
INSERT INTO `analyse_kpi` VALUES ('1', '首次接待量', '33', '15', '%', '新增客户数低于均值15%：销售顾问接待数量偏少', '1.留存订单较多、交车占用时间较多;2.休假时间较多；3.个人比较懒散', '1.安排交车时间；2.根据客流高峰期调整展厅值班时间，多接待客户。', null, '2', null, '2016-03-17 12:24:18');
INSERT INTO `analyse_kpi` VALUES ('2', '首次有效率', '34', '8', '%', '新增客户留档率低于均值8%：留档率偏低', '1.接待非购车客户较多，具体可能表现为客户数高于均值较多，首次接待时长低于均值;2.客户接待能力有待提升，具体可能表现为接待时长偏短;3.个人比较懒散，二次开口率低', '1.建议增加接待时长，在销售流程中增加留档几率;2.提升多次开口率，通过噱头增加留档几率。', null, '2', null, '2016-03-17 12:25:17');
INSERT INTO `analyse_kpi` VALUES ('3', '再次有效率', '35', '5', '%', '再次到店客户数低于均值5%：再次邀约率偏低', '1.客户回访数量偏少;2.客户邀约能力有待提升;3.基盘客户质量较差', '1.增加客户邀约频次;2.旁听他人电话邀约过程，提升自身邀约能力;3.对重点疑难客户进行交叉回访。', null, '2', null, '2016-03-17 12:26:20');
INSERT INTO `analyse_kpi` VALUES ('4', '邀约到店率', '36', '5', '%', '再次邀约占比低于均值5%：再次邀约率偏低', '1.客户回访数量偏少;2.客户邀约能力有待提升;3.基盘客户质量较差', '1.增加客户邀约频次;2.旁听他人电话邀约过程，提升自身邀约能力;3.对重点疑难客户进行交叉回访。', null, '2', null, '2016-03-17 12:27:07');
INSERT INTO `analyse_kpi` VALUES ('5', '首次接待时长', '37', '20', '%', '首次接待时长低于均值20%：首次接待时长偏短', '1.首次接待非购车客户偏多;2.能力有待提升，接待客户过程不善于引导;3.个人主观挑选客户问题严重。', '1.积极引导客户落座，完善需求分析，提升试乘试驾率;2.避免凭借个人主观判断挑选客户。', null, '2', null, '2016-03-17 12:27:58');
INSERT INTO `analyse_kpi` VALUES ('6', '首次试驾率', '38', '5', '%', '首次客户试乘试驾率低于均值5%：试乘试驾率偏低', '1.试乘试驾推荐开口率偏低;2.推荐试乘试驾节点不正确;3.销售顾问能力较强，可能表现在成交率和成交量良好，主观认为不需要试乘试驾。', '提升开口率，积极引导客户试乘试驾。', null, '2', null, '2016-03-17 12:28:37');
INSERT INTO `analyse_kpi` VALUES ('7', '再次接待时长', '39', '20', '%', '再次接待时长低于均值20%：再次接待时长偏短', '1.销售顾问客户把控能力偏弱，可能表现为成交率偏低;2.销售顾问接待流程有疏漏，可能表现为再次接待试乘试驾率等偏低;3.销售顾问急于签单，客户再次报价较低，可能表现为整车毛利偏低。', '1.把控能力较弱销售顾问，建议按照销售流程接待客户，不要跳项，同事多旁听他人客户接待过程；2.规范展厅报价机制，禁止越级报价。', null, '2', null, '2016-03-17 12:29:27');
INSERT INTO `analyse_kpi` VALUES ('8', '再次试驾率', '40', '5', '%', '再次客户试乘试驾率低于均值5%：试乘试驾率偏低', '1.试乘试驾推荐开口率偏低;2.推荐试乘试驾节点不正确;3.销售顾问能力较强，可能表现在成交率和成交量良好，主观认为不需要试乘试驾。', '提升开口率，积极引导客户试乘试驾。', null, '2', null, '2016-03-17 12:30:07');


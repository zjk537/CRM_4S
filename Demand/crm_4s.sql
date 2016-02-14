/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : crm_4s

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-02-13 16:47:38
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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddCustomer`(IN `pCustomerShopId` int,IN `pCustomerName` varchar(100),IN `pCustomerSex` int,IN `pCustomerPhone` varchar(50),IN `pCustomerCurCar` varchar(100),IN `pCustomerNature` int,IN `pCustomerOriginNature` int,IN `pCustomerType` int,IN `pCustomerIndustry` varchar(100),IN `pCustomerRegionId` int,IN `pCustomerAddress` varchar(200))
BEGIN
	 INSERT INTO `customer`(
        `ShopId`
        ,`Name`
				,`Sex`
        ,`Phone`
				,`ToShopNum`
        ,`CurCar`
        ,`Nature`
        ,`OriginNature`
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
        ,pCustomerOriginNature        
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
		SELECT DISTINCT `ConsultantName`,`ShopId`,6,`ConsultantName`,'49ba59abbe56e057',NOW() #RoleId = 6 销售顾问  DCC专员Id 待定 密码 123456
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
		SELECT DISTINCT `ConsultantName`,`ShopId`,6,`ConsultantName`,'49ba59abbe56e057',NOW()#Pwd = 123456
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateCustomer`(IN `pCustomerId` int,IN `pCustomerShopId` int,IN `pCustomerName` varchar(100),IN `pCustomerSex` int,IN `pCustomerPhone` varchar(50),IN `pCustomerCurCar` varchar(100),IN `pCustomerNature` int,IN `pCustomerOriginNature` int,IN `pCustomerType` int,IN `pCustomerIndustry` varchar(100),IN `pCustomerRegionId` int,IN `pCustomerAddress` varchar(200))
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
        ,`customer`.`OriginNature` = case when pCustomerOriginNature is null then `customer`.`OriginNature` else pCustomerOriginNature end
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateDCCRecord`(IN `pDccRecordId` int,IN `pDccRecordDCCRecallerId` int,IN `pDccRecordVisitTime` datetime,IN `pDccRecordDurationTime` varchar(50),IN `pDccRecordRecallTime` datetime,IN `pDccRecordPurposeCar` int,IN `pDccRecordLevelCode` varchar(100),IN `pDccRecordSource` int,IN `pDccRecordStatus` int,IN `pDccRecordToShop` int,IN `pDccRecordToShopTime` datetime,IN `pDccRecordInstallment` int,IN `pDccRecordRecallDesc` varchar(200),IN `pDccRecordRecorder` varchar(100))
BEGIN
	 UPDATE `dcc_record`
    SET
				`dcc_record`.`DCCRecallerId` = case when pDccRecordDCCRecallerId is null then `dcc_record`.`DCCRecallerId` else pDccRecordDCCRecallerId end
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

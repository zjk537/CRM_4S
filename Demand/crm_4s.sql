/*
Navicat MySQL Data Transfer

Source Server         : MySql(172.0.0.1)
Source Server Version : 50617
Source Host           : localhost:3306
Source Database       : crm_4s

Target Server Type    : MYSQL
Target Server Version : 50617
File Encoding         : 65001

Date: 2016-01-29 10:55:29
*/
CREATE DATABASE IF NOT EXISTS crm_4s DEFAULT CHARSET utf8 COLLATE utf8_general_ci;

use crm_4s;


SET FOREIGN_KEY_CHECKS=0;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for car_type
-- ----------------------------
DROP TABLE IF EXISTS `car_type`;
CREATE TABLE `car_type` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '汽车类型Id ',
  `Brand` varchar(100) NOT NULL COMMENT '汽车品牌',
  `Name` varchar(100) NOT NULL COMMENT '汽车类型名称',
  `Desc` varchar(100) DEFAULT NULL COMMENT '汽车类型描述',
  `UpdateDate` datetime DEFAULT NULL,
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
  `Phone` varchar(50) DEFAULT NULL COMMENT '客户联系方式',
  `LevelCode` varchar(10) DEFAULT NULL COMMENT '客户级别',
  `Nature` int(2) DEFAULT NULL COMMENT '客户性质：新增到店；再次到店；电销邀约；外展留档；二级网点；其它到店',
  `OriginNature` int(2) DEFAULT NULL COMMENT '原始客户性质',
  `Industry` varchar(100) DEFAULT NULL COMMENT '行业',
  `Address` varchar(255) DEFAULT NULL COMMENT '居住地址',
  `UpdateDate` datetime DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for customer_level
-- ----------------------------
DROP TABLE IF EXISTS `customer_level`;
CREATE TABLE `customer_level` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '顾客级别Id',
  `Code` varchar(10) NOT NULL COMMENT '顾客级别代码',
  `Desc` varchar(200) DEFAULT NULL COMMENT '顾客级别描述',
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
  `DurationTime` varchar(50) DEFAULT NULL,
  `RecallTime` datetime DEFAULT NULL,
  `PurposeCar` int(11) DEFAULT NULL COMMENT '意向车型',
  `Source` int(11) DEFAULT NULL COMMENT '线索来源："易车", "汽车之家", "第一车市", "厂家平台", "其它渠道", "展厅战败"',
  `Status` int(2) DEFAULT NULL COMMENT 'DCC状态：有效；无效；重复',
  `PromiseShop` int(2) DEFAULT NULL COMMENT '承诺到店：是；否；还需要跟进',
  `IsLogin` int(2) DEFAULT NULL COMMENT '是否登录',
  `RecallDesc` varchar(200) DEFAULT NULL COMMENT '回访详情记录',
  `ToShopTime` datetime DEFAULT NULL COMMENT '预约到店时间',
  `OperatorId` int(11) DEFAULT NULL,
  `UpdateDate` datetime DEFAULT NULL,
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
  `QType` int(2) DEFAULT NULL COMMENT '问题类型：1、店面；2、DCC',
  `QLevel` int(11) DEFAULT NULL COMMENT '问题权重',
  `UpdateDate` datetime DEFAULT NULL COMMENT '最后一次更新时间',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
  `CarLicence` int(2) DEFAULT NULL COMMENT '牌照状况：已有牌照；待拍牌照；旧车退牌；郊区牌照；外省上牌',
  `PurposeCar` int(11) DEFAULT NULL COMMENT '意向车型',
  `DriveStatus` int(2) DEFAULT NULL COMMENT '试驾状态：0""; 1是; 2否;',
  `Remark` varchar(200) DEFAULT NULL COMMENT '备注',
  `ArrivalTime` datetime DEFAULT NULL COMMENT '到店时间',
  `LeaveTime` datetime DEFAULT NULL COMMENT '离开时间',
  `DurationTime` varchar(50) DEFAULT NULL COMMENT '接待时长',
  `OperatorId` int(11) NOT NULL COMMENT '录入人员Id',
  `UpdateDate` datetime DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL,
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
  `Address` varchar(200) DEFAULT NULL COMMENT '店铺地址',
  `Desc` varchar(200) DEFAULT NULL COMMENT '店铺介绍',
  `UpdateDate` datetime DEFAULT NULL COMMENT '店铺信息最近一次更新',
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

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
  `Sex` int(2) DEFAULT '0' COMMENT '用户性别 0:未知 1:男   2:女',
  `Status` int(2) DEFAULT NULL COMMENT '用户状态：1：正常；2：离职；3：删除',
  `Phone` varchar(50) NOT NULL COMMENT '用户手机号码',
  `Telephone` varchar(50) DEFAULT NULL COMMENT '用户座机号码',
  `UpdateDate` datetime DEFAULT NULL,
  `CreatedDate` datetime DEFAULT NULL COMMENT '创建时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddCarType`(IN `pCarTypeBrand` varchar(100),IN `pCarTypeName` varchar(100),IN `pCarTypeDesc` varchar(100))
BEGIN
	INSERT INTO `car_type`(
        `Brand`
        ,`Name`
        ,`Desc`
        ,`CreatedDate`
    ) VALUES (
        pCarTypeBrand        
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddCustomer`(IN `pCustomerShopId` int,IN `pCustomerName` varchar(100),IN `pCustomerPhone` varchar(50),IN `pCustomerLevelCode` varchar(10),IN `pCustomerNature` int,IN `pCustomerIndustry` varchar(100),IN `pCustomerAddress` varchar(255))
BEGIN
	 INSERT INTO `customer`(
				`ShopId`
        ,`Name`
        ,`Phone`
        ,`LevelCode`
        ,`Nature`
        ,`OriginNature`
        ,`Industry`
        ,`Address`
        ,`CreatedDate`
    ) VALUES (
				pCustomerShopId
        ,pCustomerName        
        ,pCustomerPhone        
        ,pCustomerLevelCode        
        ,pCustomerNature        
        ,pCustomerNature        
        ,pCustomerIndustry        
        ,pCustomerAddress        
        ,NOW()        
    );

	select @@identity as Id;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddCustomerLevel
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddCustomerLevel`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddCustomerLevel`(IN `pCustomerLevelCode` varchar(10),IN `pCustomerLevelDesc` varchar(200),IN `pCustomerLevelCreatedDate` datetime)
BEGIN
	INSERT INTO `customer_level`(
        `Code`
        ,`Desc`
        ,`CreatedDate`
    ) VALUES (
				pCustomerLevelCode        
        ,pCustomerLevelDesc           
        ,NOW()        
    );
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspAddDCCRecord
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspAddDCCRecord`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddDCCRecord`(IN `pDccRecordCustomerId` int,IN `pDccRecordShopId` int,IN `pDccRecordVisitTime` datetime,IN `pDccRecordPurposeCar` int,IN `pDccRecordSource` int,IN `pDccRecordOperatorId` int)
BEGIN
	INSERT INTO `dcc_record`(
        `CustomerId`
        ,`ShopId`
        ,`VisitTime`
        ,`PurposeCar`
        ,`Source`
        ,`OperatorId`
        ,`CreatedDate`
    ) VALUES (
        pDccRecordCustomerId        
        ,pDccRecordShopId             
        ,pDccRecordVisitTime        
        ,pDccRecordPurposeCar        
        ,pDccRecordSource        
        ,pDccRecordOperatorId        
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddFrontRecord`(IN `pFrontRecordShopId` int,IN `pFrontRecordConsultantId` int,IN `pFrontRecordCustomerNum` int,IN `pFrontRecordRemark` varchar(200),IN `pFrontRecordArrivalTime` datetime,IN `pFrontRecordOperatorId` int)
BEGIN
	INSERT INTO `front_record`(
				`CustomerId`
        ,`ShopId`
        ,`ConsultantId`
        ,`CustomerNum`
        ,`Remark`
        ,`ArrivalTime`
        ,`OperatorId`
        ,`CreatedDate`
    ) VALUES (
				0 #默认用户为空
        ,pFrontRecordShopId        
        ,pFrontRecordConsultantId        
        ,pFrontRecordCustomerNum   
        ,pFrontRecordRemark        
        ,pFrontRecordArrivalTime  
        ,pFrontRecordOperatorId  
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspAddShop`(IN `pShopName` varchar(200),IN `pShopPhone` varchar(50),IN `pShopAddress` varchar(200),IN `pShopDesc` varchar(200))
BEGIN
 INSERT INTO `shop`(
        `Name`
        ,`Phone`
        ,`Address`
        ,`Desc`
        ,`CreatedDate`
    ) VALUES (
        pShopName        
        ,pShopPhone        
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
-- Procedure structure for uspDeleteCustomerLevel
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspDeleteCustomerLevel`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspDeleteCustomerLevel`(IN `pCustomerLevelId` int)
BEGIN
	DELETE FROM `customer_level`
    WHERE
        Id=pCustomerLevelId;
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
-- Procedure structure for uspGetCarTypes
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetCarTypes`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetCarTypes`()
BEGIN
	SELECT 
        `car_type`.`Id` as `CarTypeId`        
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
-- Procedure structure for uspGetCustomerLevels
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspGetCustomerLevels`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetCustomerLevels`()
BEGIN
	SELECT 
        `customer_level`.`Id` as `CustomerLevelId`        
        ,`customer_level`.`Code` as `CustomerLevelCode`        
        ,`customer_level`.`Desc` as `CustomerLevelDesc`        
        ,`customer_level`.`UpdateDate` as `CustomerLevelUpdateDate`        
        ,`customer_level`.`CreatedDate` as `CustomerLevelCreatedDate`        
    FROM
        `customer_level`;
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
        ,`customer`.`Phone` as `CustomerPhone`        
        ,`customer`.`LevelCode` as `CustomerLevelCode`        
        ,`customer`.`Nature` as `CustomerNature`        
        ,`customer`.`OriginNature` as `CustomerOriginNature`        
        ,`customer`.`Industry` as `CustomerIndustry`        
        ,`customer`.`Address` as `CustomerAddress`        
        ,`customer`.`UpdateDate` as `CustomerUpdateDate`        
        ,`customer`.`CreatedDate` as `CustomerCreatedDate`        
    FROM
        `customer`
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetDCCCustomerRecords`(IN `pDccRecordCustomerId` int,IN `pDccRecordShopId` int)
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
        ,`dcc_record`.`Source` as `DccRecordSource`        
        ,`dcc_record`.`Status` as `DccRecordStatus`        
        ,`dcc_record`.`PromiseShop` as `DccRecordPromiseShop`        
        ,`dcc_record`.`IsLogin` as `DccRecordIsLogin`        
        ,`dcc_record`.`RecallDesc` as `DccRecordRecallDesc`        
        ,`dcc_record`.`ToShopTime` as `DccRecordToShopTime`        
        ,`dcc_record`.`OperatorId` as `DccRecordOperatorId`        
        ,`dcc_record`.`UpdateDate` as `DccRecordUpdateDate`        
        ,`dcc_record`.`CreatedDate` as `DccRecordCreatedDate`        
    FROM
        `dcc_record`
		WHERE
				`dcc_record`.`CustomerId` = case when pDccRecordCustomerId = 0 then `dcc_record`.`CustomerId` else pDccRecordCustomerId end
		AND
				`dcc_record`.`ShopId` = case when pDccRecordShopId = 0 then `dcc_record`.`CustomerId` else pDccRecordShopId end
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspGetFrontCustomerRecords`(IN `pFrontRecordId` int,IN `pFrontRecordCustomerId` int,IN `pFrontRecordShopId` int)
BEGIN
	SELECT 
        `front_record`.`Id` as `FrontRecordId`        
        ,`front_record`.`CustomerId` as `FrontRecordCustomerId`        
        ,`front_record`.`ShopId` as `FrontRecordShopId`        
        ,`front_record`.`ConsultantId` as `FrontRecordConsultantId`        
        ,`front_record`.`CustomerNum` as `FrontRecordCustomerNum`        
        ,`front_record`.`CarLicence` as `FrontRecordCarLicence`        
        ,`front_record`.`PurposeCar` as `FrontRecordPurposeCar`        
        ,`front_record`.`DriveStatus` as `FrontRecordDriveStatus`        
        ,`front_record`.`Remark` as `FrontRecordRemark`        
        ,`front_record`.`ArrivalTime` as `FrontRecordArrivalTime`        
        ,`front_record`.`LeaveTime` as `FrontRecordLeaveTime`        
        ,`front_record`.`DurationTime` as `FrontRecordDurationTime`        
        ,`front_record`.`OperatorId` as `FrontRecordOperatorId`        
        ,`front_record`.`UpdateDate` as `FrontRecordUpdateDate`        
        ,`front_record`.`CreatedDate` as `FrontRecordCreatedDate`        
    FROM
        `front_record`
		WHERE
				`front_record`.`Id` = case when pFrontRecordId = 0 then `front_record`.`Id` else pFrontRecordId end
		AND
				`front_record`.`CustomerId` = CASE WHEN pFrontRecordCustomerId = 0 THEN `front_record`.`CustomerId` ELSE pFrontRecordCustomerId END
		AND
				`front_record`.`ShopId` = CASE WHEN pFrontRecordShopId = 0 THEN `front_record`.`CustomerId` ELSE pFrontRecordShopId END
		
		ORDER BY `front_record`.`CreatedDate` DESC;
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
			`user`.`ShopId` = case when pUserShopId is null then `user`.`ShopId` else pUserShopId end
		AND
			`user`.`RoleId` = case when pUserRoleId is null then `user`.`RoleId` else pUserRoleId end;
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateCarType`(IN `pCarTypeId` int,IN `pCarTypeBrand` varchar(100),IN `pCarTypeName` varchar(100),IN `pCarTypeDesc` varchar(100))
BEGIN
	UPDATE `car_type`
    SET
        `car_type`.`Brand` = case when pCarTypeBrand is null then `car_type`.`Brand` else pCarTypeBrand end
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateCustomer`(IN `pCustomerId` int,IN `pCustomerName` varchar(100),IN `pCustomerPhone` varchar(50),IN `pCustomerLevelCode` varchar(10),IN `pCustomerNature` int,IN `pCustomerIndustry` varchar(100),IN `pCustomerAddress` varchar(255))
BEGIN
	UPDATE `customer`
    SET
        `customer`.`Name` = case when pCustomerName is null then `customer`.`Name` else pCustomerName end
        ,`customer`.`Phone` = case when pCustomerPhone is null then `customer`.`Phone` else pCustomerPhone end
        ,`customer`.`LevelCode` = case when pCustomerLevelCode is null then `customer`.`LevelCode` else pCustomerLevelCode end
        ,`customer`.`Nature` = case when pCustomerNature is null then `customer`.`Nature` else pCustomerNature end
        ,`customer`.`OriginNature` = case when `customer`.`OriginNature` is null then pCustomerNature else NULL end
        ,`customer`.`Industry` = case when pCustomerIndustry is null then `customer`.`Industry` else pCustomerIndustry end
        ,`customer`.`Address` = case when pCustomerAddress is null then `customer`.`Address` else pCustomerAddress end
        ,`customer`.`UpdateDate` = NOW()
    WHERE
        Id=pCustomerId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateCustomerLevel
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateCustomerLevel`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateCustomerLevel`(IN `pCustomerLevelId` int,IN `pCustomerLevelCode` varchar(10),IN `pCustomerLevelDesc` varchar(200))
BEGIN
	 UPDATE `customer_level`
    SET
        `customer_level`.`Code` = case when pCustomerLevelCode is null then `customer_level`.`Code` else pCustomerLevelCode end
        ,`customer_level`.`Desc` = case when pCustomerLevelDesc is null then `customer_level`.`Desc` else pCustomerLevelDesc end
        ,`customer_level`.`UpdateDate` = NOW()
    WHERE
        Id=pCustomerLevelId;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for uspUpdateDCCRecord
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateDCCRecord`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateDCCRecord`(IN `pDccRecordId` int,IN `pDccRecordDCCRecallerId` int,IN `pDccRecordDurationTime` varchar(50),IN `pDccRecordRecallTime` datetime,IN `pDccRecordPurposeCar` int,IN `pDccRecordSource` int,IN `pDccRecordStatus` int,IN `pDccRecordPromiseShop` int,IN `pDccRecordIsLogin` int,IN `pDccRecordRecallDesc` varchar(200),IN `pDccRecordToShopTime` datetime,IN `pDccRecordOperatorId` int)
BEGIN
	 UPDATE `dcc_record`
    SET
        `dcc_record`.`DCCRecallerId` = case when pDccRecordDCCRecallerId is null then `dcc_record`.`DCCRecallerId` else pDccRecordDCCRecallerId end
        ,`dcc_record`.`DurationTime` = case when pDccRecordDurationTime is null then `dcc_record`.`DurationTime` else pDccRecordDurationTime end
        ,`dcc_record`.`RecallTime` = case when pDccRecordRecallTime is null then `dcc_record`.`RecallTime` else pDccRecordRecallTime end
        ,`dcc_record`.`PurposeCar` = case when pDccRecordPurposeCar is null then `dcc_record`.`PurposeCar` else pDccRecordPurposeCar end
        ,`dcc_record`.`Source` = case when pDccRecordSource is null then `dcc_record`.`Source` else pDccRecordSource end
        ,`dcc_record`.`Status` = case when pDccRecordStatus is null then `dcc_record`.`Status` else pDccRecordStatus end
        ,`dcc_record`.`PromiseShop` = case when pDccRecordPromiseShop is null then `dcc_record`.`PromiseShop` else pDccRecordPromiseShop end
        ,`dcc_record`.`IsLogin` = case when pDccRecordIsLogin is null then `dcc_record`.`IsLogin` else pDccRecordIsLogin end
        ,`dcc_record`.`RecallDesc` = case when pDccRecordRecallDesc is null then `dcc_record`.`RecallDesc` else pDccRecordRecallDesc end
        ,`dcc_record`.`ToShopTime` = case when pDccRecordToShopTime is null then `dcc_record`.`ToShopTime` else pDccRecordToShopTime end
        ,`dcc_record`.`OperatorId` = case when pDccRecordOperatorId is null then `dcc_record`.`OperatorId` else pDccRecordOperatorId end
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateFrontRecord`(IN `pFrontRecordCustomerId` int,IN `pFrontRecordId` int,IN `pFrontRecordCustomerNum` int,IN `pFrontRecordCarLicence` int,IN `pFrontRecordPurposeCar` int,IN `pFrontRecordDriveStatus` int,IN `pFrontRecordRemark` varchar(200),IN `pFrontRecordLeaveTime` datetime,IN `pFrontRecordDurationTime` varchar(50))
BEGIN
	UPDATE `front_record`
    SET
				`front_record`.`CustomerId` = case when pFrontRecordCustomerId is null then `front_record`.`CustomerId` else pFrontRecordCustomerId end
        ,`front_record`.`CustomerNum` = case when pFrontRecordCustomerNum is null then `front_record`.`CustomerNum` else pFrontRecordCustomerNum end
        ,`front_record`.`CarLicence` = case when pFrontRecordCarLicence is null then `front_record`.`CarLicence` else pFrontRecordCarLicence end
        ,`front_record`.`PurposeCar` = case when pFrontRecordPurposeCar is null then `front_record`.`PurposeCar` else pFrontRecordPurposeCar end
        ,`front_record`.`DriveStatus` = case when pFrontRecordDriveStatus is null then `front_record`.`DriveStatus` else pFrontRecordDriveStatus end
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
-- Procedure structure for uspUpdateShop
-- ----------------------------
DROP PROCEDURE IF EXISTS `uspUpdateShop`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `uspUpdateShop`(IN `pShopId` int,IN `pShopName` varchar(200),IN `pShopPhone` varchar(50),IN `pShopAddress` varchar(200),IN `pShopDesc` varchar(200),IN `pShopUpdateDate` datetime)
BEGIN
	  UPDATE `shop`
    SET
        `shop`.`Name` = case when pShopName is null then `shop`.`Name` else pShopName end
        ,`shop`.`Phone` = case when pShopPhone is null then `shop`.`Phone` else pShopPhone end
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

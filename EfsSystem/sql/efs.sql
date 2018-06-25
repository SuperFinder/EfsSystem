/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.6.16 : Database - efs
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`efs` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `efs`;

/*Table structure for table `customer` */

DROP TABLE IF EXISTS `customer`;

CREATE TABLE `customer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(50) DEFAULT NULL COMMENT '单位名称',
  `address` varchar(80) DEFAULT NULL COMMENT '单位地址',
  `responsible_user_name` varchar(10) DEFAULT NULL COMMENT '负责人',
  `tel` varchar(30) DEFAULT NULL COMMENT '电话',
  `fax` varchar(30) DEFAULT NULL COMMENT '传真',
  `email` varchar(50) DEFAULT NULL COMMENT '邮箱',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

/*Data for the table `customer` */

insert  into `customer`(`id`,`unit_name`,`address`,`responsible_user_name`,`tel`,`fax`,`email`) values (8,'1','11','1','1','1','1'),(9,'2','2','2','2','2','2'),(10,'3','3','3','33','3','3'),(11,'4','4','4','4','4','4'),(12,'4','5','5','5','5','3'),(13,'11','11','11','11','111','11');

/*Table structure for table `equips` */

DROP TABLE IF EXISTS `equips`;

CREATE TABLE `equips` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL COMMENT '装备名称',
  `number` varchar(50) DEFAULT NULL COMMENT '装备编号',
  `version` varchar(50) DEFAULT NULL COMMENT '型号',
  `specification` varchar(50) DEFAULT NULL COMMENT '规格',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

/*Data for the table `equips` */

insert  into `equips`(`id`,`name`,`number`,`version`,`specification`) values (1,'1','1','1','1'),(2,'2','2','2','2'),(3,'3','3','3','3'),(4,'4','4','4','5'),(5,'','','',''),(6,'','','',''),(7,'444','44','44','44');

/*Table structure for table `falut_infos` */

DROP TABLE IF EXISTS `falut_infos`;

CREATE TABLE `falut_infos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `equip_name` varchar(30) DEFAULT NULL COMMENT '装备名称',
  `equip_version` varchar(30) DEFAULT NULL COMMENT '装备编号',
  `falut_info` varchar(100) DEFAULT NULL COMMENT '故障现象',
  `maintenance mode` varchar(10) DEFAULT NULL COMMENT '维修方式',
  `spare_part_name` varchar(30) DEFAULT NULL COMMENT '备件名称',
  `spare_part_version` varchar(30) DEFAULT NULL COMMENT '备件型号',
  `spare_part_specification` varchar(30) DEFAULT NULL COMMENT '备件规格',
  `spare_part_count` int(4) DEFAULT NULL COMMENT '备件数量',
  `service_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `falut_infos` */

/*Table structure for table `leave_over_infos` */

DROP TABLE IF EXISTS `leave_over_infos`;

CREATE TABLE `leave_over_infos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `equip_name` varchar(30) DEFAULT NULL COMMENT '装备名称',
  `equip_version` varchar(30) DEFAULT NULL COMMENT '装备编号',
  `falut_info` varchar(100) DEFAULT NULL COMMENT '故障现象',
  `maintenance mode` varchar(10) DEFAULT NULL COMMENT '维修方式',
  `spare_part_name` varchar(30) DEFAULT NULL COMMENT '备件名称',
  `spare_part_version` varchar(30) DEFAULT NULL COMMENT '备件型号',
  `spare_part_specification` varchar(30) DEFAULT NULL COMMENT '备件规格',
  `spare_part_count` int(4) DEFAULT NULL COMMENT '备件数量',
  `service_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `leave_over_infos` */

/*Table structure for table `services` */

DROP TABLE IF EXISTS `services`;

CREATE TABLE `services` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `info_name` varchar(50) DEFAULT NULL COMMENT '工单名称',
  `receiver_name` varchar(10) DEFAULT NULL COMMENT '信息接收人',
  `brief` varchar(100) DEFAULT NULL COMMENT '信息简要',
  `basic_info` varchar(100) DEFAULT NULL COMMENT '基本信息',
  `work_order_number` varchar(20) DEFAULT NULL COMMENT '工作令号',
  `unit_name` varchar(50) DEFAULT NULL COMMENT '单位名称',
  `address` varchar(80) DEFAULT NULL COMMENT '单位地址',
  `responsible_customer_name` varchar(10) DEFAULT NULL COMMENT '客户负责人',
  `responsible_customer_tel` varchar(30) DEFAULT NULL COMMENT '客户负责人电话',
  `responsible_customer_fax` varchar(30) DEFAULT NULL COMMENT '客户负责人传真',
  `responsible_user_name` varchar(10) DEFAULT NULL COMMENT '带队人',
  `responsible_user_tel` varchar(30) DEFAULT NULL COMMENT '带队人电话',
  `start_date` datetime DEFAULT NULL COMMENT '开始日期',
  `end_date` datetime DEFAULT NULL COMMENT '结束日期',
  `user_names` varchar(100) DEFAULT NULL COMMENT '人员',
  `user_count` int(3) DEFAULT NULL COMMENT '人数',
  `equips_count` int(3) DEFAULT NULL COMMENT '装备数量',
  `fault_info` varchar(100) DEFAULT NULL COMMENT '故障信息',
  `return_money` varchar(30) DEFAULT NULL COMMENT '回款',
  `explain` varchar(100) DEFAULT NULL COMMENT '说明',
  `satisfied_quality` varchar(10) DEFAULT NULL COMMENT '满意度-质量',
  `satisfied_service` varchar(10) DEFAULT NULL COMMENT '满意度-服务',
  `satisfied_deliver` varchar(10) DEFAULT NULL COMMENT '满意度-交付',
  `satisfied_price` varchar(10) DEFAULT NULL COMMENT '满意度-价格',
  `suggest_appearance` varchar(100) DEFAULT NULL COMMENT '建议-外观,性能,可靠性',
  `suggest_attitude` varchar(100) DEFAULT NULL COMMENT '建议-态度，速度，产品维护，备件供应',
  `suggest_price` varchar(100) DEFAULT NULL COMMENT '建议-产品价格，改进建议',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `services` */

/*Table structure for table `spare_parts` */

DROP TABLE IF EXISTS `spare_parts`;

CREATE TABLE `spare_parts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `spare_part_name` varchar(30) DEFAULT NULL COMMENT '备件名称',
  `spare_part_version` varchar(30) DEFAULT NULL COMMENT '备件型号',
  `spare_part_specification` varchar(30) DEFAULT NULL COMMENT '备件规格',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `spare_parts` */

insert  into `spare_parts`(`id`,`spare_part_name`,`spare_part_version`,`spare_part_specification`) values (1,'1','1','1'),(2,'1','1','2'),(3,'3','3','3');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(10) DEFAULT NULL COMMENT '员工姓名',
  `department` varchar(20) DEFAULT NULL,
  `position` varchar(20) DEFAULT NULL COMMENT '职位',
  `tel` varchar(14) DEFAULT NULL COMMENT '电话',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `user` */

insert  into `user`(`id`,`user_name`,`department`,`position`,`tel`) values (1,'11','1','po001','tel001'),(2,'1','1','1','1'),(3,'3','333','3','4'),(4,'4','4','4','4');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

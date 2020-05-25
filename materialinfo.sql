-- create database if not exists materialinfo;
-- alter database materialinfo set character utf8;
-- use materialinfo;

-- create table if not exists material_type(
--     material_type_id char(3) not null primary key,
--     material_type_name varchar(20) not null unique
-- ); 

-- insert into materialinfo.material_type (material_type_id, material_type_name) values 
-- ('001', '铜材'),
-- ('002','铁芯'),
-- ('003','化工'),
-- ('004','绝缘'),
-- ('005','配件'),
-- ('006','标准件'),
-- ('007','耗材');

-- update materialinfo.material_type set material_type_name = '绝缘材料' where material_type_id = '004';
-- update materialinfo.material_type set material_type_name = '产品配件' where material_type_id = '005';
-- update materialinfo.material_type set material_type_name = '化工类' where material_type_id = '003';


-- create table if not exists fundamental_material(
--     fm_id char(7) not null primary key,
--     fm_type char(3),
--     fm_name varchar(50) not null unique,
--     foreign key (fm_type) references material_type(material_type_id)
-- );

-- alter table materialinfo.fundamental_material 
-- add column fm_inventory decimal not null default 0 after fm_name,
-- add column fm_unit varchar(10) after fm_inventory;

-- insert into materialinfo.fundamental_material (fm_id, fm_type, fm_name) values 
-- ('0010001','001','漆包线(Φ0.18)'),
-- ('0010002','001','漆包线(Φ0.21)'),
-- ('0010003','001','漆包线(Φ0.51)'),
-- ('0010004','001','漆包线(Φ0.75)'),
-- ('0010005','001','漆包线(Φ0.95)'),
-- ('0010006','001','漆包线(Φ1.5)'),
-- ('0010007','001','漆包线(Φ1.8)'),
-- ('0020001','002','硅钢铁芯(Φ75*Φ115*40)'),
-- ('0020002','002','硅钢铁芯(Φ85*Φ120*60)'),
-- ('0020003','002','卷绕铁芯(122/232*241/306*Φ70)'),
-- ('0020004','002','卷绕铁芯(55/145*144/234*Φ53)'),
-- ('0020005','002','微晶铁芯(Φ85*Φ115*25)'),
-- ('0020006','002','微晶铁芯(Φ46*Φ74*30)'),
-- ('0030001','003','高速光亮锡'),
-- ('0030002','003','硅微粉'),
-- ('0030003','003','硅橡胶(A)'),
-- ('0030004','003','硅橡胶(B)'),
-- ('0030005','003','环氧树脂(A)'),
-- ('0030006','003','环氧树脂(B)'),
-- ('0030007','003','环氧树脂(CY5832)'),
-- ('0030008','003','环氧树脂(HY5832)'),
-- ('0030009','003','偶联剂'),
-- ('0040001','004','DMD(0.1*80)'),
-- ('0040002','004','PMP(0.06*100)'),
-- ('0040003','004','PMP(0.06*40)'),
-- ('0040004','004','PMP(0.06*80)'),
-- ('0050001','005','BH外壳'),
-- ('0050002','005','防护盖(60*75)'),
-- ('0060001','006','螺钉(3*15)'),
-- ('0060002','006','螺钉(M10*48)'),
-- ('0060003','006','螺钉(M6*15)'),
-- ('0070001','007','打磨片(240#)'),
-- ('0070002','007','砂纸(320#)');

-- update materialinfo.fundamental_material 
-- set fm_unit = '公斤' where fm_type = '001' or fm_type = '003' or fm_type = '004';
-- update materialinfo.fundamental_material 
-- set fm_unit = '个' where fm_type = '002' or fm_type = '005' or fm_type = '006' or fm_type = '007';


-- create table if not exists intermediate_material(
--     im_id char(8) not null primary key,
--     im_name char(50) not null,
--     im_parent char(8),
--     foreign key (im_parent) references intermediate_material(im_id) on update no action on delete no action
-- );

-- insert into materialinfo.intermediate_material (im_id, im_name,im_parent) values 
-- ('10010013','ZW32',null),
-- ('10010014','JDZ-10', null),
-- ('10010015','JLSZV3',null),
-- ('10010016','LZZBJ9',null),
-- ('10010017','BH-0.66',null),
-- ('10010008','压铸体','10010013'),
-- ('10010011','总装体','10010014'),
-- ('10010010','美化体','10010015'),
-- ('10010005','浇筑体','10010016'),
-- ('10010012','电流二次线圈','10010008'),
-- ('10010007','浇筑体','10010011'),
-- ('10010009','压铸体','10010010'),
-- ('10010001','电流线圈','10010005'),
-- ('10010006','浇筑体','10010009'),
-- ('10010002','电流线圈','10010006'),
-- ('10010003','电压线圈','10010006'),
-- ('10010004','电压线圈','10010007');
-- -----------------------------------------------------------------------

-- create table if not exists iron_core(
--     ic_item_id char(8) not null primary key,
--     imm_id char(8) not null,
--     m0020001 int not null default 0,
--     m0020002 int not null default 0,
--     m0020003 int not null default 0,
--     m0020004 int not null default 0,
--     m0020005 int not null default 0,
--     m0020006 int not null default 0,
--     foreign key (imm_id) references intermediate_material(im_id)
-- );

-- alter table materialinfo.iron_core modify imm_id char(8) not null unique;
-- alter table materialinfo.iron_core drop primary key;
-- alter table materialinfo.iron_core change column ic_item_id ic_id char(8) not null primary key;

-- insert into materialinfo.iron_core values
-- ('00000001','10010012',1,0,0,0,0,0),
-- ('00000002','10010001',0,1,0,0,1,0),
-- ('00000003','10010002',0,0,0,0,1,0),
-- ('00000004','10010003',0,0,1,0,0,0),
-- ('00000005','10010004',0,0,0,1,0,0),
-- ('00000006','10010017',0,0,0,0,0,1);


-- create table if not exists copper(
--     copper_item_id char(8) not null primary key,
--     imm_id char(8) not null unique,
--     m0010001 float not null default 0,
--     m0010002 float not null default 0,
--     m0010003 float not null default 0,
--     m0010004 float not null default 0,
--     m0010005 float not null default 0,
--     m0010006 float not null default 0,
--     m0010007 float not null default 0,
--     foreign key (imm_id) references intermediate_material(im_id)
-- );

-- alter table materialinfo.copper drop primary key;
-- alter table materialinfo.copper change column copper_item_id copper_id char(8) not null primary key;

-- insert into materialinfo.copper values 
-- ('00000001','10010017',0,0,0.18,0,0.23,0,0),
-- ('00000002','10010012',0,0,0.12,0.38,0.45,1,0),
-- ('00000003','10010001',0,0,0.1,0.35,0.41,0,0),
-- ('00000004','10010002',0,0,0.11,0,0,0.48,0),
-- ('00000005','10010003',0,0.97,0,0,0,0,0.18),
-- ('00000006','10010004',0.67,0,0,0,0,0.6,0);

-- create table if not exists chemical(
--     chemical_id char(8) not null primary key,
--     imm_id char(8) not null unique,
--     m0030001 float not null default 0,
--     m0030002 float not null default 0,
--     m0030003 float not null default 0,
--     m0030004 float not null default 0,
--     m0030005 float not null default 0,
--     m0030006 float not null default 0,
--     m0030007 float not null default 0,
--     m0030008 float not null default 0,
--     m0030009 float not null default 0,
--     foreign key (imm_id) references intermediate_material(im_id)
-- );

-- insert into materialinfo.chemical values 
-- ('00000001','10010008',0,0.9,0,0,0.3,0.24,0,0,0),
-- ('00000002','10010005',0,6,0,0,0,0,2,1.6,0),
-- ('00000003','10010006',0,33,0,0,0,0,11,8.8,0),
-- ('00000004','10010009',0,0,0,0,2,2,0,0,.001),
-- ('00000005','10010010',0.001,0,0,0,0,0,0,0,0),
-- ('00000006','10010007',0,33,0,0,0,0,11,8.8,0);


-- create table if not exists insulated(
--     insulated_id char(8) not null primary key,
--     imm_id char(8) not null unique,
--     m0040001 float not null default 0,
--     m0040002 float not null default 0,
--     m0040003 float not null default 0,
--     m0040004 float not null default 0,
--     foreign key (imm_id) references intermediate_material(im_id)
-- );

-- insert into materialinfo.insulated values 
-- ('00000001','10010003',0,0.12,0.56,0),
-- ('00000002','10010004',0.089,0,0,0.47);


-- create table if not exists product_part(
--     pp_id char(8) not null primary key,
--     imm_id char(8) not null unique,
--     m0050001 int not null default 0,
--     m0050002 int not null default 0,
--     foreign key (imm_id) references intermediate_material(im_id)
-- );

-- insert into materialinfo.product_part values ('00000001','10010017',1,1);


-- create table if not exists standard_part(
--     sp_id char(8) not null primary key,
--     imm_id char(8) not null unique,
--     m0060001 int not null default 0,
--     m0060002 int not null default 0,
--     m0060003 int not null default 0,
--     foreign key (imm_id) references intermediate_material(im_id)
-- );

-- insert into materialinfo.standard_part values 
-- ('00000001','10010011',0,2,4),
-- ('00000002','10010017',4,0,0);

-- create table if not exists consumables(
--     con_id char(8) not null primary key,
--     imm_id char(8) not null unique,
--     m0070001 int not null default 0,
--     m0070002 int not null default 0,
--     foreign key (imm_id) references intermediate_material(im_id)
-- );

-- insert into materialinfo.consumables values ('00000001','10010010',1,1);

-- bug: 单价的单位和采购量的单位可能会不同，
-- 触发器：自动计算total
-- drop table if exists purchase_table;
-- create table if not exists purchase_table(
--     order_id  int unsigned auto_increment primary key, 
--     material_type char(3) not null,
--     material_name char(7) not null,
--     amount decimal not null default 0,
--     price decimal not null default 0,
--     total decimal not null default 0,
--     order_time date not null,
--     dead_line date not null,
--     factory varchar(50),
--     person_in_charge varchar(50),
--     is_completed char(1) default 'N',
--     foreign key (material_type) references material_type(material_type_id),
--     foreign key (material_name) references fundamental_material(fm_id)
-- )auto_increment=1;

-- drop table if exists order_table;
-- create table if not exists order_table(
--     order_id int unsigned auto_increment primary key,
--     product_name char(8) not null,
--     amount decimal default 0,
--     price decimal default 0,
--     profit decimal default 0,
--     salesperson varchar(100) not null,
--     factory varchar(100) not null,
--     delivery_address varchar(100) not null,
--     order_time date not null,
--     dead_line date not null,
--     is_completed char(1) default 'N',
--     foreign key (product_name) references intermediate_material(im_id)
-- )auto_increment = 1;

-- delimiter $$
-- create trigger purchase_material 
-- after update on purchase_table 
-- for each row 
-- begin
--     select amount into @amount from purchase_table
--         where new.is_completed = 'Y';
--     if @amount is not null then
--         update fundamental_material set fm_inventory = fm_inventory + @amount
--             where fm_id = new.material_name; 
--     end if;
-- end;
-- $$
-- delimiter ;

-- update purchase_table set is_completed = 'N';

-- create view order_view(order_id, product_name, amount, dead_line)
-- as select order_id,im_name,amount,dead_line from intermediate_material, order_table
-- where intermediate_material.im_id = order_table.product_name;

-- alter view order_view as
-- select order_id,im_name,amount,dead_line from intermediate_material, order_table
-- where intermediate_material.im_id = order_table.product_name 
-- and order_table.dead_line >= curdate()
-- and order_table.dead_line < date_add(curdate(),interval 7 day);



-- select * from order_view;

-- alter table intermediate_material 
-- add column im_intentory int not null default 0;

-- create view product_view 
-- as select im_id, im_name, im_intentory  from intermediate_material where im_parent is null;

-- select * from product_view;
use `materialinfo`;
-- drop view order_amount_view;
-- create view order_amount_view as
-- select im_name,dead_line,sum(amount) as total from order_view
-- group by im_name,dead_line;






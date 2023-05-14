﻿-- Типы инструментов

insert into dbo.InstrumentType([Name])
values (N'Резцы'), (N'Протяжки'), (N'Фрезы'), (N'Ролики резьбонакатные'), (N'Зенкеры'), (N'Метчики'), (N'Развертки'), (N'Инструмент с механическим креплением')
go

-- Типы остастки

insert into dbo.OsnastkaType([Name])
values (N'Штампы'), (N'Пресс-формы'), (N'Модельная оснастка'), (N'Приспособление')
go

-- ГОСТы

insert into dbo.Gost([Name], [Link])
values
(N'ГОСТ 24359', N'https://www.gzsito.by/upload/iblock/240/6tx6ja6427l45nichnaqt9no0jfwbwyl.pdf'),
(N'ГОСТ 18884', N'https://www.gzsito.by/upload/iblock/17b/qp1y2f46twwvmgzvussviqe5zjdtptaa.pdf'),
(N'ГОСТ 18880', N'https://www.gzsito.by/upload/iblock/4c4/3nspk6yxsrjy94zq6de00557m2249dcr.pdf'),
(N'ГОСТ 18877', N'https://www.gzsito.by/upload/iblock/194/6ccmzlw1innhvvi6i5nas37j1m1o152a.pdf'),
(N'ГОСТ 18878', N'https://www.gzsito.by/upload/iblock/265/dsa1qw27qw6bm3xyk6unjnzf0cffvcte.pdf'),
(N'ГОСТ 18879', N'https://www.gzsito.by/upload/iblock/c99/hinr67y48lzdmu6x1f9n9mvd5winlbkp.pdf'),
(N'ГОСТ 18883', N'https://www.gzsito.by/upload/iblock/7ae/tq9semzta0nq604j1a9uz9av4wap8tk2.pdf'),
(N'ГОСТ 18882', N'https://www.gzsito.by/upload/iblock/22b/f311r5s15ryd2xmp39ocft2d51zd7251.pdf'),
(N'ГОСТ 18885', N'https://www.gzsito.by/upload/iblock/463/kokwvvwyeu19cha7j34w94fgh8ihfl6f.pdf'),
(N'ГОСТ 18881', N'https://www.gzsito.by/upload/iblock/c5a/azq5resd5escqnr2hzyayqrnp0enw6zk.pdf')
go

-- Инструменты

insert into dbo.Instrument([Name], [Code], [Dimensions], [Measure], [Price], [GostId], [InstrumentTypeId], [Picture])
values 
(N'Резец отрезной.', N'2130-0001 ВК8', N'16х10х100', N'шт', 2.37, 2, 1, null),
(N'Резец отрезной.', N'2130-0001 Т5К10', N'16х10х100', N'шт', 2.35, 2, 1, null),
(N'Резец отрезной.', N'2130-0001Т15К6', N'16х10х100', N'шт', 2.35, 2, 1, null),
(N'Резец отрезной.', N'2130-0005 ВК8', N'20х12х120', N'шт', 3.37, 2, 1, null),
(N'Резец отрезной.', N'2130-0005 Т15К6', N'20х12х120', N'шт', 3.31, 2, 1, null),
(N'Резец отрезной.', N'2130-0005 Т5К10', N'20х12х120', N'шт', 3.31, 2, 1, null),
(N'Резец отрезной.', N'2130-0009 ВК8', N'25х16х140', N'шт', 4.83, 2, 1, null),
(N'Резец отрезной.', N'2130-0009 Т15К6', N'25х16х140', N'шт', 4.83, 2, 1, null),
(N'Резец отрезной.', N'2130-0009 Т5К10', N'25х16х140', N'шт', 4.83, 2, 1, null),
(N'Резец отрезной.', N'2130-0013 ВК8', N'32х20х170', N'шт', 8.42, 2, 1, null),
(N'Резец отрезной.', N'2130-0013 Т15К6', N'32х20х170', N'шт', 8.18, 2, 1, null),
(N'Резец отрезной.', N'2130-0013 Т5К10', N'32х20х170', N'шт', 8.18, 2, 1, null),
(N'Резец отрезной.', N'2130-0017 ВК8', N'40х25х200', N'шт', 14.26, 2, 1, null),
(N'Резец отрезной.', N'2130-0017 Т15К6', N'40х25х200', N'шт', 13.77, 2, 1, null),
(N'Резец отрезной.', N'2130-0017 Т5К10', N'40х25х200', N'шт', 13.77, 2, 1, null);
go

insert into dbo.Instrument([Name], [Code], [Dimensions], [Measure], [Price], [GostId], [InstrumentTypeId], [Picture])
values 
(N'Резец резьб. для внутр. резьбы', N'2662-0001 ВК8', N'10х10х120', N'шт', 4.64, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0001 Т15К6', N'10х10х120', N'шт', 4.55, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0003 ВК8', N'12х12х140', N'шт', 5.23, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0003 Т15К6', N'12х12х140', N'шт', 5.15, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0003 Т5К10', N'12х12х140', N'шт', 5.15, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0005 ВК8', N'16х16х170', N'шт', 5.94, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0005 Т15К6', N'16х16х170', N'шт', 5.77, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0005 Т30К4', N'16х16х170', N'шт', 5.77, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0005 Т5К10', N'16х16х170', N'шт', 5.77, 9, 1, null),
(N'Резец резьб. для внутр. резьбы', N'2662-0007 ВК8', N'20х20х200', N'шт', 9.25, 9, 1, null)
go

insert into dbo.Instrument([Name], [Code], [Dimensions], [Measure], [Price], [GostId], [InstrumentTypeId], [Picture])
values 
(N'Резец чист.шир.', N'2120-0052 ВК8', N'20х12х125', N'шт', 4.84, 10, 1, null),
(N'Резец чист.шир.', N'2120-0052 Т15К6', N'20х12х125', N'шт', 4.57, 10, 1, null),
(N'Резец чист.шир.', N'2120-0052 Т5К10', N'20х12х125', N'шт', 4.57, 10, 1, null),
(N'Резец чист.шир.', N'2120-0053 ВК8', N'25х16х140', N'шт', 7.76, 10, 1, null),
(N'Резец чист.шир.', N'2120-0054 Т15К6', N'32х20х170', N'шт', 12.23, 10, 1, null)
go

-- Оснастка

insert into dbo.Osnastka([Name], [Description], [OsnastkaTypeId], [Picture])
values 
(N'Штампы последовательного действия', N'Штампы последовательного действия применяются для производства изделия сложных форм – это один из наиболее производительных способов изготовления, позволяющий обеспечивать высокую производительность в сочетании с простотой и дешевизной производственного процесса.', 1, null),
(N'Штампы для горячей штамповки', N'Горячий штамп в процессе пользования находится в сложных условия нагрузки, которые выражаются в увеличенном напряжении (уровень которого подчас достигает предела текучести стали), высоких температурах нагрева и химического влияния деформирующихся материалов.', 1, null),
(N'Приспособления сварочные', N'Сварочные и сборочные приспособления, устройства подачи деталей  помогают в автоматизации и  механизации работы. Все приспособления для сварки делятся на виды: шаблоны, указатели, стенды, зажимы, приспособления для работы с изготавливаемой продукцией и её перемещения.', 4, null),
(N'Ротационные формы', N'Ротационное формование является одним методов переработки пластмасс, используются в производстве изделий уже более полувека. За последние годы  интерес к этому методу значительно повысился благодаря возможности получать относительно сложной конфигурации изделия из полимеров без внутренних напряжений по недорогой стоимости.', 2, null),
(N'Выдувные пресс-формы', N'Прессформа – производственный инструмент, применяющийся для выдува ПЭТ-бутылок. Благодаря таре, изготавливаемой из пластика, придаются заданные размер и конфигурация. На одной и той же машине можно выдувать ПЭТ-бутылки, различающиеся вместительностью и формой – это зависит от характеристик агрегата для выдува. К примеру, выдувной автомат «ПВ-700» позволяет получать емкости 0.2 – 10 л.', 2, null),
(N'Модели литниковой системы', N'Литниковая система – это совокупность углублений и полостей в форме, сквозь которые жидкий металл-расплав (или пластик) подается в канал пресс-формы (литьевой формы) для литья под давлением.', 3, null)
go
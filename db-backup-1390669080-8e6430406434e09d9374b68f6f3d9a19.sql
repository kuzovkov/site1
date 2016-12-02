DROP TABLE IF EXISTS chatmodels;

CREATE TABLE `chatmodels` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `user` varchar(32) NOT NULL DEFAULT '',
  `password` varchar(32) NOT NULL DEFAULT '',
  `email` varchar(32) NOT NULL DEFAULT '',
  `sex` varchar(10) NOT NULL DEFAULT 'woman',
  `dir` varchar(255) NOT NULL DEFAULT '',
  `language` varchar(12) NOT NULL DEFAULT '',
  `language2` varchar(12) NOT NULL DEFAULT '',
  `lang` varchar(3) NOT NULL DEFAULT 'en',
  `birthDate` int(11) NOT NULL DEFAULT '0',
  `braSize` varchar(12) DEFAULT NULL,
  `birthSign` varchar(12) DEFAULT NULL,
  `weight` varchar(12) DEFAULT '0',
  `weightMeasure` varchar(12) DEFAULT NULL,
  `height` varchar(12) DEFAULT '0',
  `heightMeasure` varchar(12) DEFAULT NULL,
  `eyeColor` varchar(12) DEFAULT NULL,
  `ethnicity` varchar(32) DEFAULT NULL,
  `message` varchar(32) DEFAULT NULL,
  `position` varchar(255) DEFAULT NULL,
  `fantasies` varchar(255) DEFAULT NULL,
  `hobby` varchar(255) DEFAULT NULL,
  `hairColor` varchar(32) DEFAULT NULL,
  `hairLength` varchar(32) DEFAULT NULL,
  `pubicHair` varchar(32) DEFAULT NULL,
  `tImage` varchar(32) NOT NULL DEFAULT '',
  `cpm` smallint(6) NOT NULL DEFAULT '0',
  `epercentage` tinyint(4) NOT NULL DEFAULT '0',
  `minimum` int(11) NOT NULL DEFAULT '500',
  `category` varchar(32) NOT NULL DEFAULT '',
  `name` varchar(32) NOT NULL DEFAULT '',
  `country` varchar(32) NOT NULL DEFAULT '',
  `state` varchar(32) NOT NULL DEFAULT '',
  `city` varchar(32) NOT NULL DEFAULT '',
  `zip` varchar(12) NOT NULL DEFAULT '',
  `adress` varchar(32) NOT NULL DEFAULT '',
  `actImage` varchar(32) NOT NULL DEFAULT '',
  `pMethod` varchar(12) DEFAULT NULL,
  `pInfo` varchar(255) DEFAULT NULL,
  `dateRegistered` int(11) NOT NULL DEFAULT '0',
  `owner` varchar(32) DEFAULT NULL,
  `lastLogIn` int(11) NOT NULL DEFAULT '0',
  `phone` varchar(16) NOT NULL DEFAULT '',
  `fax` varchar(16) DEFAULT NULL,
  `idtype` varchar(32) NOT NULL DEFAULT '',
  `idmonth` varchar(32) NOT NULL DEFAULT '',
  `idyear` varchar(4) NOT NULL DEFAULT '',
  `idnumber` varchar(32) NOT NULL DEFAULT '',
  `birthplace` varchar(32) NOT NULL DEFAULT '',
  `ssnumber` varchar(32) DEFAULT NULL,
  `msn` varchar(32) DEFAULT NULL,
  `yahoo` varchar(32) DEFAULT NULL,
  `icq` varchar(32) DEFAULT NULL,
  `broadcastplace` varchar(32) DEFAULT NULL,
  `emailtype` enum('text','html') NOT NULL DEFAULT 'text',
  `status` varchar(8) NOT NULL DEFAULT '',
  `lastupdate` int(11) DEFAULT NULL,
  `onlinemembers` tinyint(4) NOT NULL DEFAULT '0',
  `monday` varchar(4) NOT NULL DEFAULT '0000',
  `tuesday` varchar(4) NOT NULL DEFAULT '0000',
  `wednesday` varchar(4) NOT NULL DEFAULT '0000',
  `thursday` varchar(4) NOT NULL DEFAULT '0000',
  `friday` varchar(4) NOT NULL DEFAULT '0000',
  `sunday` varchar(4) NOT NULL DEFAULT '0000',
  `saturday` varchar(4) NOT NULL DEFAULT '0000',
  `gmt` varchar(5) NOT NULL DEFAULT '+0',
  PRIMARY KEY (`id`),
  KEY `id` (`id`,`user`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=cp1251;

INSERT INTO chatmodels SET `id`='1',`user`='emma',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='woman',`dir`='00a809937eddc44521da9521269e75c6',`language`='Russian',`language2`='English',`lang`='ru',`birthDate`='62370000',`weight`='50',`weightMeasure`='kg',`height`='160',`heightMeasure`='kg',`message`='hello',`hobby`='sex',`tImage`='Thumbnail Image',`cpm`='295',`epercentage`='50',`minimum`='100',`name`='Эмма',`country`='1',`state`='Московская',`city`='Москва',`zip`='101000',`adress`='ул. Ленина д.1',`actImage`='IdentityImage',`pMethod`='WebMoney',`pInfo`='Z372647995119',`dateRegistered`='1350472921',`owner`='none',`lastLogIn`='1390589773',`phone`='7232323',`idmonth`='January',`idyear`='1980',`idnumber`='991234234235',`birthplace`='г. Киров',`broadcastplace`='Например : Моя Спальня',`emailtype`='text',`status`='offline',`lastupdate`='1390587967',;
INSERT INTO chatmodels SET `id`='2',`user`='olga',`password`='85c6508b22098e575b67b17297fa7fa7',`email`='dionis20095@rambler.ru',`sex`='woman',`dir`='e44d46e0bb9691cf448a9bb19391e8ab',`language`='Russian',`language2`='Russian',`lang`='ru',`birthDate`='31521600',`weight`='50',`weightMeasure`='kg',`tImage`='Thumbnail Image',`cpm`='295',`epercentage`='50',`minimum`='100',`name`='Ольга',`country`='1',`state`='Московская',`city`='Москва',`zip`='101000',`adress`='ул. Ленина д.1',`actImage`='IdentityImage',`pMethod`='WebMoney',`pInfo`='Z372647995119',`dateRegistered`='1350472921',`owner`='none',`lastLogIn`='1383637065',`phone`='7232323',`idtype`='IDcard',`idmonth`='January',`idyear`='1980',`idnumber`='991234234234',`birthplace`='г. Москва',`broadcastplace`='Например : Моя Спальня',`emailtype`='text',`status`='offline',`lastupdate`='1383643181',`onlinemembers`='1',`monday`='0000',`tuesday`='0000',`wednesday`='0000',`thursday`='0000',`friday`='0000',`sunday`='0000',`saturday`='0000',`gmt`='+0';
INSERT INTO chatmodels SET `id`='3',`user`='tania',`password`='85c6508b22098e575b67b17297fa7fa7',`email`='dionis20095@rambler.ru',`sex`='woman',`dir`='916229a8d4ef288e7f4880ad356800aa',`language`='Russian',`language2`='Russian',`lang`='ru',`birthDate`='31521600',`weight`='50',`weightMeasure`='kg',`tImage`='Thumbnail Image',`cpm`='295',`epercentage`='50',`minimum`='100',`name`='Таня',`country`='1',`state`='Московская',`city`='Москва',`zip`='101000',`adress`='ул. Ленина д.1',`actImage`='IdentityImage',`pMethod`='WebMoney',`pInfo`='Z372647995119',`dateRegistered`='1350472921',`owner`='none',`lastLogIn`='1383637065',`phone`='7232323',`idtype`='IDcard',`idmonth`='January',`idyear`='1980',`idnumber`='991234234234',`birthplace`='г. Москва',`broadcastplace`='Например : Моя Спальня',`emailtype`='text',`status`='offline',`lastupdate`='1383643181',`onlinemembers`='1',`monday`='0000',`tuesday`='0000',`wednesday`='0000',`thursday`='0000',`friday`='0000',`sunday`='0000',`saturday`='0000',`gmt`='+0';
INSERT INTO chatmodels SET `id`='4',`user`='nina',`password`='85c6508b22098e575b67b17297fa7fa7',`email`='dionis20095@rambler.ru',`sex`='woman',`dir`='f2ceea1536ac1b8fed1a167a9c8bf04d',`language`='Russian',`language2`='Russian',`lang`='ru',`birthDate`='31521600',`weight`='50',`weightMeasure`='kg',`tImage`='Thumbnail Image',`cpm`='295',`epercentage`='50',`minimum`='100',`name`='Нина',`country`='1',`state`='Московская',`city`='Москва',`zip`='101000',`adress`='ул. Ленина д.1',`actImage`='IdentityImage',`pMethod`='WebMoney',`pInfo`='Z372647995119',`dateRegistered`='1350472921',`owner`='none',`lastLogIn`='1383637065',`phone`='7232323',`idtype`='IDcard',`idmonth`='January',`idyear`='1980',`idnumber`='991234234234',`birthplace`='г. Москва',`broadcastplace`='Например : Моя Спальня',`emailtype`='text',`status`='offline',`lastupdate`='1383643181',`onlinemembers`='1',`monday`='0000',`tuesday`='0000',`wednesday`='0000',`thursday`='0000',`friday`='0000',`sunday`='0000',`saturday`='0000',`gmt`='+0';
INSERT INTO chatmodels SET `id`='5',`user`='dasha',`password`='85c6508b22098e575b67b17297fa7fa7',`email`='dionis20095@rambler.ru',`sex`='woman',`dir`='4bea249142664d11a289ffdf30225a91',`language`='Russian',`language2`='Russian',`lang`='ru',`birthDate`='31521600',`weight`='50',`weightMeasure`='kg',`tImage`='Thumbnail Image',`cpm`='295',`epercentage`='50',`minimum`='100',`name`='Даша',`country`='1',`state`='Московская',`city`='Москва',`zip`='101000',`adress`='ул. Ленина д.1',`actImage`='IdentityImage',`pMethod`='WebMoney',`pInfo`='Z372647995119',`dateRegistered`='1350472921',`owner`='none',`lastLogIn`='1383637065',`phone`='7232323',`idtype`='IDcard',`idmonth`='January',`idyear`='1980',`idnumber`='991234234234',`birthplace`='г. Москва',`broadcastplace`='Например : Моя Спальня',`emailtype`='text',`status`='offline',`lastupdate`='1383643181',`onlinemembers`='1',`monday`='0000',`tuesday`='0000',`wednesday`='0000',`thursday`='0000',`friday`='0000',`sunday`='0000',`saturday`='0000',`gmt`='+0';
INSERT INTO chatmodels SET `id`='6',`user`='kira',`password`='85c6508b22098e575b67b17297fa7fa7',`email`='dionis20095@rambler.ru',`sex`='woman',`dir`='7a61721ed4832664aa3ce8e2234dcdb4',`language`='Russian',`language2`='Russian',`lang`='ru',`birthDate`='31521600',`weight`='50',`weightMeasure`='kg',`tImage`='Thumbnail Image',`cpm`='295',`epercentage`='50',`minimum`='100',`name`='Кира',`country`='1',`state`='Московская',`city`='Москва',`zip`='101000',`adress`='ул. Ленина д.1',`actImage`='IdentityImage',`pMethod`='WebMoney',`pInfo`='Z372647995119',`dateRegistered`='1350472921',`owner`='none',`lastLogIn`='1383637065',`phone`='7232323',`idtype`='IDcard',`idmonth`='January',`idyear`='1980',`idnumber`='991234234234',`birthplace`='г. Москва',`broadcastplace`='Например : Моя Спальня',`emailtype`='text',`status`='offline',`lastupdate`='1383643181',`onlinemembers`='1',`monday`='0000',`tuesday`='0000',`wednesday`='0000',`thursday`='0000',`friday`='0000',`sunday`='0000',`saturday`='0000',`gmt`='+0';
INSERT INTO chatmodels SET `id`='7',`user`='emma2',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='woman',`dir`='52261f5e022b9af275419410a074ba5f',`language`='Russian',`language2`='English',`lang`='en',`birthDate`='31525200',`cpm`='295',`epercentage`='50',`minimum`='500',`name`='Эмма',`country`='1',`state`='Московская область',`city`='Москва',`zip`='111000',`adress`='Ленина, 1',`dateRegistered`='1390039813',`lastLogIn`='1390589630',`phone`='21321321321',`idtype`='IDcard',`idmonth`='January',`idyear`='1980',`idnumber`='1234567890',`birthplace`='Москва',`emailtype`='text',`status`='offline',`monday`='0000',`tuesday`='0000',`wednesday`='0000',`thursday`='0000',`friday`='0000',`sunday`='0000',`saturday`='0000',`gmt`='+0';
INSERT INTO chatmodels SET `id`='8',`user`='emma3',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='woman',`dir`='2c25ccc343dafe3b48eb2e502e56bd92',`language`='Russian',`language2`='English',`lang`='en',`birthDate`='31525200',`minimum`='500',`name`='Таня',`country`='1',`state`='Московская область',`city`='Москва',`zip`='111000',`adress`='Ленина, 1',`dateRegistered`='1390040404',`phone`='21321321321',`idtype`='Passport',`idmonth`='January',`idyear`='1980',`idnumber`='1234567890',`birthplace`='Москва',`emailtype`='text',`status`='pending',`monday`='0000',`tuesday`='0000',`wednesday`='0000',`thursday`='0000',`friday`='0000',`sunday`='0000',`saturday`='0000',`gmt`='+0';



DROP TABLE IF EXISTS chatoperators;

CREATE TABLE `chatoperators` (
  `id` varchar(32) NOT NULL DEFAULT '',
  `user` varchar(32) NOT NULL DEFAULT '',
  `password` varchar(32) NOT NULL DEFAULT '',
  `email` varchar(32) NOT NULL DEFAULT '',
  `name` varchar(32) NOT NULL DEFAULT '',
  `country` varchar(32) NOT NULL DEFAULT '',
  `state` varchar(32) NOT NULL DEFAULT '',
  `city` varchar(32) NOT NULL DEFAULT '',
  `zip` varchar(12) NOT NULL DEFAULT '',
  `phone` varchar(12) NOT NULL DEFAULT '',
  `address` varchar(32) NOT NULL DEFAULT '',
  `pMethod` varchar(12) DEFAULT NULL,
  `pInfo` varchar(255) DEFAULT NULL,
  `dateRegistered` int(11) NOT NULL DEFAULT '0',
  `lastLogIn` int(11) NOT NULL DEFAULT '0',
  `moneyEarned` varchar(24) NOT NULL DEFAULT '',
  `moneySent` varchar(24) NOT NULL DEFAULT '',
  `minimum` mediumint(9) NOT NULL DEFAULT '0',
  `status` varchar(12) NOT NULL DEFAULT '',
  `epercentage` tinyint(4) NOT NULL DEFAULT '0',
  `emailtype` enum('text','html') NOT NULL DEFAULT 'text',
  `company` varchar(32) DEFAULT NULL,
  `idtax` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`id`,`user`)
) ENGINE=MyISAM DEFAULT CHARSET=cp1251;




DROP TABLE IF EXISTS chatusers;

CREATE TABLE `chatusers` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `user` varchar(32) NOT NULL DEFAULT '',
  `password` varchar(32) NOT NULL DEFAULT '',
  `email` varchar(32) NOT NULL DEFAULT '',
  `sex` varchar(10) NOT NULL DEFAULT 'man',
  `dir` varchar(255) NOT NULL DEFAULT '',
  `lang` varchar(3) NOT NULL DEFAULT 'en',
  `name` varchar(32) NOT NULL DEFAULT '',
  `country` varchar(32) NOT NULL DEFAULT '',
  `state` varchar(32) NOT NULL DEFAULT '',
  `city` varchar(32) NOT NULL DEFAULT '',
  `phone` varchar(16) NOT NULL DEFAULT '',
  `zip` varchar(12) NOT NULL DEFAULT '',
  `adress` varchar(255) NOT NULL DEFAULT '',
  `dateRegistered` int(11) NOT NULL DEFAULT '0',
  `lastLogIn` int(11) NOT NULL DEFAULT '0',
  `money` varchar(255) NOT NULL DEFAULT '1',
  `emailnotify` char(1) NOT NULL DEFAULT '0',
  `smsnotify` char(1) NOT NULL DEFAULT '0',
  `status` varchar(12) NOT NULL DEFAULT '',
  `emailtype` enum('html','text') DEFAULT 'text',
  `freetime` smallint(6) NOT NULL DEFAULT '120',
  `freetimeexpired` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=cp1251;

INSERT INTO chatusers SET `id`='1',`user`='user',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='man',`dir`='ee11cbb19052e40b07aac0ca060c23ee',`lang`='ru',`name`='dionis',`country`='1',`state`='Марий Эл',`city`='Йошкар-Ола',`phone`='222222',`zip`='424000',`adress`='ул. Ленина, д.1',`dateRegistered`='1350472614',`lastLogIn`='1390589433',`money`='72.24',`status`='active',`emailtype`='text',`freetime`='120',;
INSERT INTO chatusers SET `id`='2',`user`='user2',`password`='85c6508b22098e575b67b17297fa7fa7',`email`='dionis20095@rambler.ru',`sex`='man',`dir`='7e58d63b60197ceb55a1c487989a3720',`lang`='ru',`name`='dionis',`country`='1',`state`='Марий Эл',`city`='Йошкар-Ола',`phone`='222222',`zip`='424000',`adress`='ул. Ленина, д.1',`dateRegistered`='1350472614',`lastLogIn`='1390589762',`money`='100',`status`='active',`emailtype`='text',`freetime`='120',;
INSERT INTO chatusers SET `id`='6',`user`='user3',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='man',`dir`='92877af70a45fd6a2ed7fe81e1236b78',`lang`='en',`name`='Юра',`country`='1',`state`='Московская область',`city`='Москва',`phone`='1280282180',`zip`='111000',`adress`='Ленина, 1',`dateRegistered`='1389897770',`lastLogIn`='1390061558',`status`='active',`emailtype`='text',`freetime`='120',;
INSERT INTO chatusers SET `id`='7',`user`='user4',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='man',`dir`='3f02ebe3d7929b091e3d8ccfde2f3bc6',`lang`='en',`name`='Вася',`country`='1',`state`='Московская область',`city`='Москва',`phone`='55454354',`zip`='122111',`adress`='Ленина, 1',`dateRegistered`='1389902029',`lastLogIn`='1390588081',`status`='active',`emailtype`='html',`freetime`='120',;
INSERT INTO chatusers SET `id`='8',`user`='user5',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='man',`dir`='0a791842f52a0acfbb3a783378c066b8',`lang`='en',`name`='Дима',`country`='1',`state`='Московская область',`city`='Москва',`phone`='55454354',`zip`='122111',`adress`='Ленина, 1',`dateRegistered`='1389902192',`lastLogIn`='1390588141',`status`='active',`emailtype`='text',`freetime`='120',;
INSERT INTO chatusers SET `id`='9',`user`='user6',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='man',`dir`='affec3b64cf90492377a8114c86fc093',`lang`='en',`name`='Дима',`country`='1',`state`='Московская область',`city`='Москва',`phone`='1212121212',`zip`='111000',`adress`='Ленина, 1',`dateRegistered`='1389902383',`status`='active',`emailtype`='text',`freetime`='120',;
INSERT INTO chatusers SET `id`='10',`user`='user7',`password`='96e79218965eb72c92a549dd5a330112',`email`='dionis20095@rambler.ru',`sex`='man',`dir`='3e0469fb134991f8f75a2760e409c6ed',`lang`='en',`name`='Денис',`country`='1',`state`='Московская область',`city`='Москва',`phone`='21321321321',`zip`='111000',`adress`='Ленина, 1',`dateRegistered`='1389980874',`status`='active',`emailtype`='text',`freetime`='120',;



DROP TABLE IF EXISTS countries;

CREATE TABLE `countries` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `name` varchar(24) DEFAULT NULL,
  `code` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=113 DEFAULT CHARSET=cp1251;

INSERT INTO countries SET `id`='1',`name`='Россия',`code`='40';
INSERT INTO countries SET `id`='2',`name`='Италия',`code`='39';
INSERT INTO countries SET `id`='8',`name`='Англия',`code`='44';
INSERT INTO countries SET `id`='14',`name`='Азербайджан',`code`='994';
INSERT INTO countries SET `id`='15',`name`='Бахрейн',`code`='973';
INSERT INTO countries SET `id`='17',`name`='Бельгия',`code`='32';
INSERT INTO countries SET `id`='19',`name`='Бразилия',`code`='55';
INSERT INTO countries SET `id`='21',`name`='Польша',`code`='284';
INSERT INTO countries SET `id`='22',`name`='Румыния',`code`='673';
INSERT INTO countries SET `id`='23',`name`='Грузия',`code`='359';
INSERT INTO countries SET `id`='27',`name`='Чили',`code`='56';
INSERT INTO countries SET `id`='28',`name`='Китай',`code`='86';
INSERT INTO countries SET `id`='30',`name`='Cote d Ivoire',`code`='225';
INSERT INTO countries SET `id`='31',`name`='Крит',`code`='385';
INSERT INTO countries SET `id`='32',`name`='Кипр',`code`='357';
INSERT INTO countries SET `id`='34',`name`='Чехия',`code`='420';
INSERT INTO countries SET `id`='35',`name`='Дания',`code`='45';
INSERT INTO countries SET `id`='36',`name`='Египет',`code`='20';
INSERT INTO countries SET `id`='37',`name`='Литва',`code`='372';
INSERT INTO countries SET `id`='38',`name`='Эстония',`code`='251';
INSERT INTO countries SET `id`='39',`name`='Белоруссия',`code`='298';
INSERT INTO countries SET `id`='40',`name`='Украина',`code`='679';
INSERT INTO countries SET `id`='41',`name`='Финляндия',`code`='358';
INSERT INTO countries SET `id`='42',`name`='Франция',`code`='33';
INSERT INTO countries SET `id`='43',`name`='Джоржия',`code`='995';
INSERT INTO countries SET `id`='44',`name`='Германия',`code`='49';
INSERT INTO countries SET `id`='45',`name`='Гибралтар',`code`='350';
INSERT INTO countries SET `id`='46',`name`='Греция',`code`='30';
INSERT INTO countries SET `id`='47',`name`='Гонг конг',`code`='852';
INSERT INTO countries SET `id`='48',`name`='Венгрия',`code`='36';
INSERT INTO countries SET `id`='49',`name`='Индия',`code`='91';
INSERT INTO countries SET `id`='50',`name`='Япония',`code`='81';
INSERT INTO countries SET `id`='51',`name`='Иерусалим',`code`='2';
INSERT INTO countries SET `id`='52',`name`='Молдова',`code`='373';
INSERT INTO countries SET `id`='53',`name`='Нидерланды',`code`='31';
INSERT INTO countries SET `id`='54',`name`='Норвегия',`code`='47';
INSERT INTO countries SET `id`='56',`name`='Ю.А.Р',`code`='7';
INSERT INTO countries SET `id`='57',`name`='Саудовская Аравия',`code`='966';
INSERT INTO countries SET `id`='59',`name`='Испания',`code`='34';
INSERT INTO countries SET `id`='60',`name`='U.S.A',`code`='1';
INSERT INTO countries SET `id`='61',`name`='Канада',`code`='1';
INSERT INTO countries SET `id`='62',`name`='Австралия',`code`='61';
INSERT INTO countries SET `id`='64',`name`='Сингапур',`code`='65';



DROP TABLE IF EXISTS favorites;

CREATE TABLE `favorites` (
  `member` varchar(32) NOT NULL DEFAULT '',
  `model` varchar(32) NOT NULL DEFAULT '',
  `dateadded` int(11) NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=cp1251;

INSERT INTO favorites SET `member`='user',`model`='emma',`dateadded`='1389727977';



DROP TABLE IF EXISTS modelpictures;

CREATE TABLE `modelpictures` (
  `user` varchar(32) NOT NULL DEFAULT '',
  `name` varchar(32) NOT NULL DEFAULT '',
  `dateuploaded` bigint(20) NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=cp1251;

INSERT INTO modelpictures SET `user`='emma',`name`='272cee7ffeb17d5801259149ead8a5d6',`dateuploaded`='1389624445';
INSERT INTO modelpictures SET `user`='emma',`name`='850ebd480337d23ac896b44ed61b81f3',`dateuploaded`='1389624452';
INSERT INTO modelpictures SET `user`='emma',`name`='afb76e2fc567825547528dafd15eac5e',`dateuploaded`='1389624457';
INSERT INTO modelpictures SET `user`='emma',`name`='312455312a164ed5a43680ecdff1d098',`dateuploaded`='1389624470';
INSERT INTO modelpictures SET `user`='emma',`name`='15ed0ef4e39c85f609481cb84db93490',`dateuploaded`='1389624475';
INSERT INTO modelpictures SET `user`='emma',`name`='6475a3b45ecdc9edcc12464e18518e44',`dateuploaded`='1389624482';



DROP TABLE IF EXISTS modelshows;

CREATE TABLE `modelshows` (
  `user` varchar(32) NOT NULL DEFAULT '',
  `name` varchar(24) NOT NULL DEFAULT '',
  `string` varchar(32) NOT NULL DEFAULT '',
  `previewtime` bigint(20) NOT NULL DEFAULT '0',
  `movietime` bigint(20) NOT NULL DEFAULT '0',
  `price` mediumint(9) NOT NULL DEFAULT '300',
  PRIMARY KEY (`user`,`string`)
) ENGINE=MyISAM DEFAULT CHARSET=cp1251;




DROP TABLE IF EXISTS paymentgate;

CREATE TABLE `paymentgate` (
  `code` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(255) NOT NULL,
  `url` varchar(255) NOT NULL,
  `purse` varchar(13) NOT NULL,
  `purse_r` varchar(13) NOT NULL,
  `secretkey` varchar(30) NOT NULL,
  `fms` varchar(60) NOT NULL,
  `title` varchar(300) NOT NULL,
  `site` varchar(50) NOT NULL,
  `keywords` varchar(800) NOT NULL,
  `feedbackemail` varchar(44) NOT NULL,
  `login` varchar(10) NOT NULL,
  `pass` varchar(50) NOT NULL,
  PRIMARY KEY (`code`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=cp1251;

INSERT INTO paymentgate SET `code`='1',`email`='seller@paypalsandbox.com',`url`='http://yourdomain.com/panel/chatusers/paypal.php',`purse`='Z158160319391',`purse_r`='R735702254840',`secretkey`='Sekret_Merchant',`fms`='rtmp://77.40.56.139/main/',`title`='Видео чат',`site`='http://77.40.56.139',`keywords`='видеочат',`feedbackemail`='dionis20095@rambler.ru',`login`='admin',`pass`='96e79218965eb72c92a549dd5a330112';



DROP TABLE IF EXISTS payments;

CREATE TABLE `payments` (
  `id` varchar(32) NOT NULL DEFAULT '',
  `date` bigint(24) NOT NULL DEFAULT '0',
  `ammount` varchar(24) NOT NULL DEFAULT '',
  `taxes` varchar(24) NOT NULL DEFAULT '',
  `method` varchar(12) NOT NULL DEFAULT '',
  `details` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`,`date`)
) ENGINE=MyISAM DEFAULT CHARSET=cp1251;

INSERT INTO payments SET `id`='662d4cbc46ffd211826cacd009da632b',`date`='1368728075',`ammount`='517',`method`='WebMoney',`details`='Z342209764673';



DROP TABLE IF EXISTS site3_sessions;

CREATE TABLE `site3_sessions` (
  `session_id` varchar(40) NOT NULL DEFAULT '0',
  `ip_address` varchar(16) NOT NULL DEFAULT '0',
  `user_agent` varchar(200) NOT NULL,
  `last_activity` int(10) unsigned NOT NULL DEFAULT '0',
  `user_data` text NOT NULL,
  PRIMARY KEY (`session_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO site3_sessions SET `session_id`='7cacf0893bcda222af2d6fa3d4c8c38b',`ip_address`='127.0.0.1',`user_agent`='Mozilla/5.0 (Windows NT 5.1; rv:26.0) Gecko/20100101 Firefox/26.0',`last_activity`='1390667909',;
INSERT INTO site3_sessions SET `session_id`='cee4e1c9814ef5b94d91e0e7b9dd16a6',`ip_address`='127.0.0.1',`user_agent`='Mozilla/5.0 (Windows NT 5.1; rv:26.0) Gecko/20100101 Firefox/26.0',`last_activity`='1390667909',;



DROP TABLE IF EXISTS videosessions;

CREATE TABLE `videosessions` (
  `sessionid` varchar(32) NOT NULL DEFAULT '',
  `member` varchar(32) NOT NULL DEFAULT '',
  `model` varchar(32) NOT NULL DEFAULT '',
  `sop` varchar(32) NOT NULL DEFAULT '',
  `cpm` mediumint(9) NOT NULL DEFAULT '0',
  `epercentage` smallint(6) NOT NULL DEFAULT '0',
  `date` int(11) NOT NULL DEFAULT '0',
  `duration` mediumint(9) NOT NULL DEFAULT '0',
  `paid` char(1) NOT NULL DEFAULT '',
  `soppaid` char(1) NOT NULL DEFAULT '0',
  `type` varchar(12) NOT NULL DEFAULT '',
  KEY `sessionid` (`sessionid`,`member`,`model`)
) ENGINE=MyISAM DEFAULT CHARSET=cp1251;

INSERT INTO videosessions SET `sessionid`='1c543408d63fffe2e707d3aaa86f605a',`member`='dionis20095',`model`='emma',`sop`='none',`cpm`='35',`epercentage`='50',`date`='1350497011',`duration`='60',`paid`='1',`type`='tip';
INSERT INTO videosessions SET `sessionid`='1aa63746c9f28b94cbba208278e4ba3c',`member`='dionis20095',`model`='emma',`sop`='none',`cpm`='295',`epercentage`='50',`date`='1350579454',`duration`='390',`paid`='1',`type`='show';
INSERT INTO videosessions SET `sessionid`='72981886586d51d00775cc1388a227ec',`member`='user',`model`='emma',`sop`='none',`cpm`='295',`epercentage`='50',`date`='1383642949',`duration`='240',`type`='show';
INSERT INTO videosessions SET `sessionid`='a28f8f6617a3411d0463ebb8a18a2068',`member`='user',`model`='emma',`sop`='none',`cpm`='295',`epercentage`='50',`date`='1389726005',`duration`='120',`type`='show';
INSERT INTO videosessions SET `sessionid`='b6ea218b883fcaeb64ad7ec7bee4f12f',`member`='user',`model`='emma',`sop`='none',`cpm`='295',`epercentage`='50',`date`='1389726935',`duration`='30',`type`='show';
INSERT INTO videosessions SET `sessionid`='4a4dcae85838eafe71fcf19290b6fcb5',`member`='user',`model`='emma',`sop`='none',`cpm`='295',`epercentage`='50',`date`='1389726964',`duration`='30',`type`='show';
INSERT INTO videosessions SET `sessionid`='7dbbe18989e70be00fc4ec62c39dee5d',`member`='user',`model`='emma',`sop`='none',`cpm`='295',`epercentage`='50',`date`='1389726995',`duration`='30',`type`='show';
INSERT INTO videosessions SET `sessionid`='26779b7e3bdf90d0726ee10d563e2dcc',`member`='user',`model`='emma',`sop`='none',`cpm`='295',`epercentage`='50',`date`='1389727330',`duration`='90',`type`='show';
INSERT INTO videosessions SET `sessionid`='5f1e45e3376f729f0b6caf7230036f6a',`member`='user',`model`='emma',`sop`='none',`cpm`='295',`epercentage`='50',`date`='1389727479',`duration`='60',`type`='show';
INSERT INTO videosessions SET `sessionid`='5f1e45e3376f729f0b6caf7230036f6a',`member`='user',`model`='emma',`sop`='none',`cpm`='1000',`epercentage`='50',`date`='1389727516',`duration`='60',`type`='tip';




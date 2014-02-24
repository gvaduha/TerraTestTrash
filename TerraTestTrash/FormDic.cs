using System.Collections.Generic;

namespace Test_I102
{
    public static class Dic
    {
        public static Dictionary<string, string> ApplicationType()
        {
            return new Dictionary<string, string> {{"credit", "Кредит (credit)"}, {"deposit", "Депозит (deposit)"}};
        }

        public static Dictionary<string, string> CardCategory()
        {
            return new Dictionary<string, string>
            {
                {"8", "MasterCard Gold"},
                {"9", "MasterCard Platinum"},
                {"7", "MasterCard Standart"},
                {"4", "Visa Classic"},
                {"5", "Visa Gold"},
                {"6", "Visa Platinum"}
            };
        }

        public static List<string> LastNameM()
        {
            return new List<string>
            {
                "Иванов",
                "Петров",
                "Сидоров",
                "Маслов",
                "Дмитриев",
                "Соков",
                "Вагонов",
                "Разломов",
                "Хренов",
                "Мишин",
                "Королев",
                "Дмитриев",
                "Сидоренко",
                "Михайлов",
                "Сизов",
                "Хмелев",
                "Дуров",
                "Монин",
                "Дедов",
                "Левашов",
                "Кактов",
                "Трубопроводов",
                "Дунин",
                "Жаров",
                "Маркин"
            };
        }

        public static List<string> LastNameG()
        {
            return new List<string>
            {
                "Иванова",
                "Петрова",
                "Сидорова",
                "Маслова",
                "Дмитриева",
                "Сокова",
                "Вагонова",
                "Разломова",
                "Хренова",
                "Мишина",
                "Королева",
                "Дмитриева",
                "Сидоренкоа",
                "Михайлова",
                "Сизова",
                "Хмелева",
                "Дурова",
                "Монина",
                "Дедова",
                "Левашова",
                "Кактова",
                "Трубопроводова",
                "Дунина",
                "Жарова",
                "Маркина"
            };
        }

        public static List<string> NameM()
        {
            return new List<string> {"Иван", "Петр", "Сидор", "Николай", "Феофан"};
        }

        public static List<string> NameG()
        {
            return new List<string> {"Екатерина", "Наталья", "Елена", "Татьяна", "Юлия", "Фекла"};
        }

        public static List<string> PaternalNameM()
        {
            return new List<string> {"Иванович", "Петрович", "Сидорович", "Николаевич", "Феофанович"};
        }

        public static List<string> PaternalNameG()
        {
            return new List<string> {"Дмитриевна", "Сергеевна", "Николаевна", "Артуровна", "Борисовна", "Демьяновна"};
        }

        public static Dictionary<string, string> TrueFalse()
        {
            return new Dictionary<string, string> {{"true", "Да"}, {"false", "Нет"}};
        }

        public static Dictionary<string, string> Gender()
        {
            return new Dictionary<string, string> {{"M", "Мужской"}, {"F", "Женский"}};
        }

        public static List<string> PlaceOfBirth()
        {
            return new List<string>
            {
                "Москва",
                "Нижний Новгород",
                "Ленинград",
                "Волгоград",
                "Санкт-Петербург",
                "Дмитров",
                "Калининград"
            };
        }

        public static List<string> IssuedBy()
        {
            return new List<string>
            {
                "ПВО ОВД Алексеевского р-на г.Москвы",
                "ПВО ОВД Дмитровского р-на г.Москвы",
                "ПВО ОВД Солнцевского р-на г.Москвы",
                "ПВО ОВД Ростокинского р-на г.Москвы",
                "ПВО ОВД Останкинского р-на г.Москвы",
                "ПВО ОВД Красносельского р-на г.Москвы",
                "ПВО ОВД Головинского р-на г.Москвы"
            };
        }

        public static Dictionary<string, string> DeliveryAddress()
        {
            return new Dictionary<string, string>
            {
                {"addr_real", "Фактический"},
                {"addr_workplace", "Рабочий"},
                {"addr_registration", "Регистрации"}
            };
        }

        public static Dictionary<string, string> LineCodeKLADR()
        {
            return new Dictionary<string, string>
            {
                {"7700000000000", "Москва"},
                {"7800000000000", "Петербург"},
                {"5000000000000", "Московская обдл"},
                {"7400000000000", "Челябинская обл"},
                {"1600000000000", "Татарстан"},
                {"6600000000000", "Свердловская обл."}
            };
        }

        public static List<string> AccountName()
        {
            return new List<string>
            {
                "ООО Карана",
                "ЗАО Сухой",
                "ООО КБ Яр-Банк",
                "ООО Сервис-Строй",
                "ОАО Альфа-Банк",
                "ИП Баранов",
                "ООО Аксимед"
            };
        }

        public static Dictionary<string, string> AccountType()
        {
            return new Dictionary<string, string>
            {
                {"soldier", "военнослужащий"},
                {"full_day", "по найму"},
                {"own_business", "собственное дело"}
            };
        }

        public static Dictionary<string, string> LaborContractType()
        {
            return new Dictionary<string, string>
            {
                {"empctype_001", "бессрочный трудовой договор (в т.ч. по трудовой книжке)"},
                {"empctype_002", "временный/срочный трудовой договор/контракт"}
            };
        }

        public static Dictionary<string, string> TotalWorkExperience()
        {
            return new Dictionary<string, string>
            {
                {"common_seniority_code.less3", "менее 3 месяцев"},
                {"common_seniority_code.3to12", "от 3 месяцев до 1 года"},
                {"common_seniority_code.12to36", "от 1 года до 3 лет"},
                {"common_seniority_code.36to60", "от 3 до 5 лет"},
                {"common_seniority_code.60to120", "от 5 до 10 лет"},
                {"common_seniority_code.120to192", "от 10 до 16 лет"},
                {"common_seniority_code.more192", "более 16 лет"}
            };
        }

        public static Dictionary<string, string> JobTitle()
        {
            return new Dictionary<string, string>
            {
                {"empl_post.businessman", "Частный предприниматель"},
                {"empl_post.own_business", "Собственный бизнес"},
                {"empl_post.specialist", "Специалист"},
                {"empl_post.employee", "Сотрудник организации"},
                {"empl_post.manager", "Руководитель среднего звена"},
                {"empl_post.director", "Руководитель высшего звена/Директор организации"}
            };
        }

        public static Dictionary<string, string> IncomeCheckStatus()
        {
            return new Dictionary<string, string>
            {
                {"inproof_2ndfl", "2НДФЛ"},
                {"inproof_3ndfl", "3НДФЛ"},
                {"inproof_vehicle", "Автомобиль"},
                {"inproof_salary_write-out", "Выписка по зарплатному счёту"},
                {"inproof_value_not_tresfered", "Значение не передаётся"},
                {"inproof_realty", "Значение не передаётся"},
                {"inproof_no", "Нет"},
                {"inproof_other", "Произвольная"}
            };
        }

        public static Dictionary<string, string> Education()
        {
            return new Dictionary<string, string>
            {
                {"academic_title", "Ученая степень"},
                {"higher_education", "Высшее"},
                {"incomplete_higher_education", "Неоконченное высшее"},
                {"secondary_education", "Среднее/неполное среднее"},
                {"some_higher_education", "Два высших и более"},
                {"spec_secondary_education", "Среднее-специальное"}
            };
        }

        public static Dictionary<string, string> MaritalStatus()
        {
            return new Dictionary<string, string>
            {
                {"MS_MARRIED", "В браке"},
                {"MS_DIVORCED", "В разводе"},
                {"MS_WIDOW", "Вдовец/вдова"},
                {"MS_CIVIL_MARRIED", "Гражданский брак"},
                {"MS_NEVER_BEEN_MARRIED", "Не женат/Не замужем"},
            };
        }

        public static Dictionary<string, string> MinorChildrenNummber()
        {
            return new Dictionary<string, string>
            {
                {"1_children", "Один"},
                {"2_children", "Два"},
                {"3_children", "Три"},
                {"4_or_more_children", "Четыре и более"},
                {"no_children", "Нет"},
            };
        }

        public static Dictionary<string, string> DependantsNumber()
        {
            return new Dictionary<string, string>
            {
                {"1", "Один"},
                {"2", "Два"},
                {"3", "Три"},
                {"4", "Четыре и более"},
                {"0", "Нет"},
            };
        }


        public static Dictionary<string, string> RelationDegree()
        {
            return new Dictionary<string, string>
            {
                {"br_brother", "Брат"},
                {"br_daughter", "Дочь"},
                {"br_friend", "Друг/подруга"},
                {"br_other", "Другое"},
                {"br_relation", "Иной родственник"},
                {"br_mother", "Мать"},
                {"br_father", "Отец"},
                {"br_sister", "Сестра"},
                {"br_spouse", "Супруг(а)"},
                {"br_son", "Сын"},
            };
        }


        public static Dictionary<string, string> SecretQuestion()
        {
            return new Dictionary<string, string>
            {
                {"4", "Вид Вашего первого питомца (кошка, попугай, …)"},
                {"6", "Город, где Вы начали свою трудовую биографию"},
                {"7", "Город, где Вы познакомились со своей супругой/супругом/лучшим другом/подругой"},
                {"quest_mother_surname", "Девичья фамилия Вашей матери?"},
                {"1", "Имя первой учительницы в школе"},
                {"5", "Кличка Вашего питомца"},
                {"2", "Номер школы, которую заканчивал"},
                {"3", "Цвет Вашей первой машины"},
            };
        }


        public static Dictionary<string, string> PreviousCreditsQuantity()
        {
            return new Dictionary<string, string>
            {
                {"0", "Нет"},
                {"1", "Один"},
                {"2", "Два и более"}
            };
        }

        public static Dictionary<string, string> AccountSphere()
        {
            return new Dictionary<string, string>
            {
                {"lprsnscope_004", "Услуги по продаже/аренде недвижимости"},
                {"lprsnscope_005", "Банковское дело"},
                {"lprsnscope_008", "Медицина"},
                {"lprsnscope_010", "Информационные технологии"},
                {"lprsnscope_012", "Консалтинг"},
                {"lprsnscope_013", "Культура/Искусство"},
                {"lprsnscope_017", "Органы власти и управления"},
                {"lprsnscope_018", "Наука"},
                {"lprsnscope_020", "Ресторанный бизнес/Общественное питание"},
                {"lprsnscope_028", "Маркетинг/Реклама"},
                {"lprsnscope_032", "Вооруженные силы"},
                {"lprsnscope_033", "Строительство"},
                {"lprsnscope_035", "Оптовая торговля"},
                {"lprsnscope_036", "Розничная торговля"},
                {"lprsnscope_037", "Транспорт"},
                {"lprsnscope_038", "Туризм (туроператоры, турагенты)"},
                {"lprsnscope_039", "ТЭК"},
                {"lprsnscope_042", "Юриспрюденция"},
                {"lprsnscope_044", "Промышленность, кроме ТЭК и строительства"},
                {"lprsnscope_045", "Безопасность"},
                {"lprsnscope_046", "Развлечения"},
                {"lprsnscope_047", "Пресса/Телевидение/Радио"},
                {"lprsnscope_048", "Работодатель-ИП"},
                {"lprsnscope_049", "Социальная сфера"},
                {"lprsnscope_050", "Услуги (кроме указанных выше)"},
                {"lprsnscope_051", "Пенсионер"},
                {"lprsnscope_052", "Студент"},
                {"lprsnscope_053", "Домохозяйка"},
                {"lprsnscope_070", "Финансы"},
                {"lprsnscope_075", "Страхование"},
                {"lprsnscope_080", "Образование"},
            };
        }

        public static List<string> AccountCompanyEmployeesQty()
        {
            return new List<string>
            {
                "employees_count.101to500",
                "employees_count.11to30",
                "employees_count.31to100",
                "employees_count.6to10",
                "employees_count.more500",
            };
        }

        public static List<string> SecretWord() //TODO:
        {
            return new List<string>
            {
                "12345",
                "secret_word",
                "secret",
            };
        }

        public static Dictionary<string, string> BankingServiceCredit()
        {
            return new Dictionary<string, string>
            {
                {"PPT_PIL1", "Кредит Fix-loan"},
                {"PPT_CC1", "Кредитная карта с грейс-периодом"},
                {"PPT_DC1", "Дебетовая карта с овердрафтом"},
            };
        }

        public static Dictionary<string, string> BankingServiceDebit()
        {
            return new Dictionary<string, string>
            {
                {"dep_classic", "Депозит Классический"},
                {"dep_multi", "Депозит Мультивалютный"},
                {"dep_diff", "Депозит С дифференцированной ставкой"},
                {"dep_limit", "Депозит С неснижаемым остатком"},
            };
        }

        public static Dictionary<string, string> CurrentWorkExperience()
        {
            return new Dictionary<string, string>
            {
                {"current_seniority_code.less3", "менее 3 месяцев"},
                {"current_seniority_code.3to12", "от 3 месяцев до 1 года"},
                {"current_seniority_code.12to36", "от 1 года до 3 лет"},
                {"current_seniority_code.36to60", "от 3 до 5 лет"},
                {"current_seniority_code.60to120", "от 5 до 10 лет"},
                {"current_seniority_code.more120", "более 10 лет"}
            };
        }

        public static Dictionary<string, string> CurrencyAsked()
        {
            return new Dictionary<string, string>
            {
                {"840", "USD"},
                {"RUB", "RUB"},
                {"EUR", "EUR"},
            };
        }

        public static List<string> Street() //TODO:
        {
            return new List<string>
            {
                "Ленинский пр-т",
                "Шаболовская",
                "Донская",
                "Мытная",
            };
        }

        public static List<string> PercentPayment() //TODO:
        {
            return new List<string>
            {
                "capitalization",
                "capitalization",
            };
        }

        public static List<string> PercentPaymentMethod() //TODO:
        {
            return new List<string>
            {
                "at_the_end",
                "at_the_end",
            };
        }

        public static Dictionary<string, string> EarlierCreditType()
        {
            return new Dictionary<string, string>
            {
                {"credtype_open-end", "Возобновляемый кредит-Кредитная линия"},
                {"other_credit", "Другое"},
                {"credtype_card_overdraft", "Карта с овердрафтом"},
                {"bills_credit", "Коммунальный счет"},
                {"credtype_mortgage", "Кредит на недвижимость, в т.ч. ипотека"},
                {"education_credit", "Кредит на обучение"},
                {"credtype_vehicle", "Кредит на приобретение автомобиля"},
                {"credtype_pledge", "Кредит под обеспечение (под залог)"},
                {"credtype_card", "Кредитная карта"},
                {"leasing", "Лизинг"},
                {"interbank_credit", "Межбанковский кредит"},
                {"micro_credit", "Мирозаем"},
                {"mobile_credit", "Мобильного оператора"},
                {"share_purchase_credit", "На покупку акций"},
                {"equipment_credit", "На покупку оборудования"},
                {"working_capital_credit", "На пополнение оборотных средств"},
                {"business_credit", "На развитие бизнеса"},
                {"building_credit", "На строительство"},
                {"undesignated_cash_credit", "Нецелевой кредит наличными"},
                {"credtype_individual", "Персональный кредит"},
                {"consumer_credit", "Потребительский кредит"},
                {"credtype_installment_sale", "Продажа в рассрочку (в точках продаж)"},
                {"account_view_credit", "Просмотр счета (проверка клиента без рассмотрения кредита)"},
                {"credtype_account_overdraft", "Счет с овердрафтом"},
                {"telecommunicate_credit", "Счет телекоммуникационных услуг"},
                {"factoring_credit", "Факторинг"},
            };
        }

        public static Dictionary<string, string> EarlierCreditStatuse()
        {
            return new Dictionary<string, string>
            {
                {"closed", "Закрыт (выплачен)"},
                {"opened", "Открыт"},
            };
        }

        public static Dictionary<string, string> EarlierBank()
        {
            return new Dictionary<string, string>
            {
                {"256", "Уралприватбанк"},
                {"257", "ЗАО Нижегородпромстройбанк"},
                {"258", "КБ Метрополь (ООО)"},
                {"259", "Коммерческий банк Гран (ОАО)"},
                {"260", "Банк Клиентский"},
                {"261", "Муниципальный коммерческий банк СИБЭС (ОАО)"},
            };
        }

        public static Dictionary<string, string> EarlierMaxLoanTerm()
        {
            return new Dictionary<string, string>
            {
                {"ol.31-60_days", "31 - 60 дней просроченной задолженности (1 месяц)"},
                {"ol.1-30_days", "1 - 30 дней просроченной задолженности"},
                {"ol.121-150_days", "121 - 150 дней просроченной задолженности (4 месяца)"},
                {"ol.151-180_days", "151 - 180 дней просроченной задолженности (5 месяцев)"},
                {"ol.more_then_180_days", "181 и более дней просроченной задолженности (6+ месяцев)"},
                {"ol.61-90_days", "61 - 90 дней просроченной задолженности (2 месяца)"},
                {"ol.91-120_days", "91 - 120 дней просроченной задолженности (3 месяца)"},
                {"ol.non-payment", "Неуплата"},
                {"ol.in_time", "Своевременно "},
                {"ol.write_off", "Списан"},
                {"ol.lawsuit", "Тяжба"},
            };
        }

        public static Dictionary<string, string> ClientType()
        {
            return new Dictionary<string, string>
            {
                {"PR_APPLICANT", "Заемщик"},
                {"PR_COAPPLICANT", "Созаемщик"},
                {"PR_PLEDGER", "Залогодатель"},
                {"PR_GUARANTOR", "Поручитель"},
            };
        }
    }
}

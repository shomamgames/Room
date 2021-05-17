﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Room
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public string smert { get; set; }
    }
    class Program
    {
        private static List<Person> people = new List<Person>();
        static void Privetststvie()
        {
            Console.WriteLine("Добро пожаловать в комнату 017");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"В комнате {people.Count} человек.");
            Console.WriteLine("Кто то из них убийца, и кто это, вы должны узнать!");
            Console.WriteLine("Далее, вы можете узнать про каждого персонажа");
            Console.WriteLine("\nВыберите номер: \n>>>>>>>>>>>>>>");
        }

        static void Main(string[] args)
        {
            people.Add(new Person() {Id=1, Name = "Цуцул Паша" ,Description= "Цуцул Паша сидит тихо, нервно оглядываясь, замечая, " +
                "что на него обратили внимание начинает не много рычать, поглядывая на недавно зарытую ямку" , smert = "Бедная собака была убита, а в ямке" +
                " была закопана косточка имертвый скорпион. Цуцул Паша не был убийцей... Бедная собака"});
            people.Add(new Person() {Id=2, Name = "Йилмаз" ,Description= "Йилмаз старый пират кафешек, ни одно заведение было им обчищено." +
                " Держа бутылку ракы в руках ухмыляется и сделав отрыжку, проверяет что то наличие в карманах подмигивая Чеченке" , smert = "Йилдыз" +
                " сопротивлялся как мог, но пал в битве замертво. В кармане у него оказались 2 чека из кафе \"Astepe\". И да, он не был убийцей."});
            people.Add(new Person() {Id=3, Name = "Небош" ,Description= "Небохат, в кругу аферистов известная как \"Продавец родствеников за бананы\" уже ни раз задолбавшая" +
                        " всех в комнате" +
                        " очередной раз пытается продать свою квартиру уже странному усачу," +
                        " у нее из кармана торчит странная бумажка и куча салфеток" , smert = "Небош сопротивлялась как могла, бросалась казявками, кричала" +
                        " во весь голос \"ОЙРЕМИСЫНЫЗ!!!\" но все же упала без сил и умерла. Бумажка из кармана была фатурой за газ, а салфетки полны сухими" +
                        " соплями. Небошка не была убийцей, какая бы она не была назойливой мухой"});
            people.Add(new Person() {Id=4, Name = "Продавец" ,Description= "Пожилой дяденька, чье имя засекречено Организацией ГьалыджыОглуевской Магазиной Мафии." +
                        " Через чур подозрительно и часто улыбается, иногда поглядывая на футбольный матч включеный на телефоне." +
                        " прячет в кулаке что то звенящее." , smert = "Продавец оторвался от футбола, посмотрел в ваши глаза, улыбнулся, на фоне играла грустная песня" +
                        " со скрипкой. Хади, не бакийорсун - сказав, закрыл глаза. Вы убили его. Звенящее в руке были мелочи для сдачи." +
                        " Он не был убийцей..."});
            people.Add(new Person() {Id=5, Name = "Клиентка из Чечни", Description = "Увидев, что на нее обратили внимание \"Налейте чай\" заскулила она а позже, достав телефон" +
                        " начала записывать голосовое в Whatsapp говоря на чеченском очень эксперссивно и нет нет заглядывая в свою сумку" , smert = "Все" +
                        " началось с удара ногой в живот, завязалась жесткая драка! В итоге клиентка была повержена! в сумке у нее оказался лук, которым" +
                        " она в Whatsapp восхищалась своей подруге. Она не убивала никого!"});
            people.Add(new Person() {Id=6, Name = "Странный  усач", Description = "Оглядывая его сверху вниз, вы видите - лысую голову > большие глаза > УСЫ > подбородок." +
                        " Он стоит очень скромно, одна рука в кармане, вторая, время от времени поправляет, застрявшее что то металическое в усах", smert= "Первые" +
                        " атаки Усач, соответствено отбивал своими шикарными и густыми усами. Но силы иссякли, ловкость убавилась и он пропустил смертельный удар." +
                        " В усах у него обнаружили титановую расческу для усов, она была на столько легка, что ею ни то что убить, но и поранить нельзя было..."});
            people.Add(new Person() {Id=7, Name = "Мави Эркек", Description = "Розовые Джинсы! Камни на белой футболке с вырезом до пупка! Классная прическа и макияж!" +
                        " Да! это Мави Эркек во все красе, танцует игриво заирывая со всеми мужчинами в комнате включая Цуцул Пашу" +
                        " Но танцевать ему явно что то мешает." , smert = "Мави Эркек танцуя уворачивался от ваших атак, во время танца у него вылетела левая туфля," +
                        " так как она не была зашнурована. В ближнем же бою он начал применять маховые сельские удары. Как оказалось Мави Эркек сельский парень," +
                        " который в будни работает в стильном магазине а на выходных пашет у себя в селе в сарае. После победы на ним, сняв с него штаны, " +
                        "обнаружилось, что орудие убийства - Биту, он прятал в жопе, что мешала ему танцевать. Убийца пойман, вы молодец! Миссия выполнена!"});
            people.Add(new Person() {Id=8, Name = "Орхан", Description = "Орхан! Единственный кто сюда не пришел, а приехал! На своей тачке. Да, на тачке в прямом смысле этого слова" +
                        " Мало того, он ее еще затащил в комнату. Странность есть и внем. А дело в том, что он иногда достает какую то фотку" +
                        " из чехла телефона, трясет разочарованно головой, и кладет ее обратно" , smert = "В начале всего хипиша, Орхан по комнате соскакивал" +
                        " на своей тачке, потом отбивался чехлом, но смерть его настигла. Фотка в чехле телефона оказалась фоткой его сына девушки, как и сам телефон" +
                        " Орхан не был убийцей и он хотел жить..."});

            Privetststvie();          
            Znakomstvo();
            OsmotrJertvi();
            vramyakill();
            final();

        }

        static void Znakomstvo()
        {
            int peopnum = 1;

            foreach (Person p in people)
            {

                Console.WriteLine(peopnum + " " + p.Name);
                peopnum = peopnum + 1;
            }
            Console.WriteLine("9 Далее >>>");

            while (true)
            {
                int vyborchela = Convert.ToInt32(Console.ReadLine());

                var chel = people.FirstOrDefault(x => x.Id == vyborchela);
                if (chel != null)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(chel.Description);
                    Console.WriteLine();
                }

                if (vyborchela == 9)
                {
                    break;
                }
            }
        }

        static void OsmotrJertvi()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Теперь очередь осмотреть жертву");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Нажмите любую кнопку для продолжения");
            Console.ReadKey();
            Console.WriteLine("На полу лежит мертвая девушка");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 Осмотреть руки \n2 Осмотреть голову \n3 Осмотреть карманы \n4 Осмотреть тело \n5 Осмотреть ноги \n6 Далее >>>");
            Console.WriteLine();

            while (true)
            {
                int osmotr = Convert.ToInt32(Console.ReadLine());

                if (osmotr == 2)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Лицо напуганое, макияж как будто сделан в спешку, очень не аккуратно." +
                        " \nГолова пробита чем то тяжелым и тупым предметом, много крови");
                    Console.WriteLine();
                }
                if (osmotr == 1)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("В правой руке у покойной черный шнурок от фирменной обуви, какой именно - неизвестно!");
                    Console.WriteLine();
                }
                if (osmotr == 3)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("В кармане вы нашли бумажку, на которой написано помадой \"Приходи (по такому то адресу) одна\", " +
                        "так же, эта бумажка ужасно пахнет селом!");
                    Console.WriteLine();
                }
                if (osmotr == 4)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("На теле нет никаких синяков, соответственно не было драки, а удар в голову был нанесен из под тешка." +
                        " Но тело пахнет выпивкой, как будто во время удара она держала в руках спиртной напиток и пролила его на себя");
                    Console.WriteLine();
                }
                if (osmotr == 5)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("На ногах нет обуви, но на верхней стороне ступней сильные царапины, как будто ее таскали далеко на животе");
                    Console.WriteLine();
                }
                if (osmotr == 6)
                {
                    return;
                }
            }
        }
        static void vramyakill()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Теперь пришло время избавитться от убийцы");
            Console.Write("Вы готовы? (Да \\ Нет) : ");
            Console.WriteLine();
            string reshenie = Console.ReadLine();

            if (reshenie == "Нет" || reshenie == "нет")
            {
                Console.WriteLine("1 Веруться к знакомству с персонажами \n2 Вернуться к осмотру жертвы");
                int otvetnet = Convert.ToInt32(Console.ReadLine());
                if (otvetnet == 1)
                {
                    Znakomstvo();

                    Console.WriteLine("1 К осмотру жертвы \n2 Далее >>> ");
                    int otvet2 = Convert.ToInt32(Console.ReadLine());
                    if (otvet2 == 1)
                    {
                        OsmotrJertvi();
                    }
                    if (otvet2 == 2)
                    {
                        ubiistvo();
                    }

                   
                }
                if (otvetnet == 2)
                {
                    OsmotrJertvi();

                    Console.WriteLine("1 К знакомству с персонажами \n2 Далее >>> ");
                    int otvet3 = Convert.ToInt32(Console.ReadLine());
                    if (otvet3 == 1)
                    {
                        Znakomstvo();
                    }
                    if (otvet3 == 2)
                    {
                        ubiistvo();
                    }
                   
                }
            }   
            if (reshenie == "Да" || reshenie == "да")
            {
                Console.WriteLine("Тогда приступим!");
                ubiistvo();
            }
        }
        static void ubiistvo ()
        {
            Console.WriteLine("Пришло время выбрать кого убить. Подуймай хорошо прежде чем начать");
            int peopnum = 1;

            foreach (Person p in people)
            {

                Console.WriteLine(peopnum + " " + p.Name);
                peopnum = peopnum + 1;
            }

            while (true)
            {
                int vybortokill = Convert.ToInt32(Console.ReadLine());

                var chelx = people.FirstOrDefault(x => x.Id == vybortokill);
                if (chelx != null && chelx.Id != 7)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(chelx.smert);
                    people.Remove(chelx);
                    Console.WriteLine($"В комнате осталось {people.Count} человек.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Продолжим поиски");
                    Console.WriteLine("------------------------------------------");
                }

                if (chelx != null && chelx.Id == 7)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(chelx.smert);
                    final();
                }




            }

        }
        static void final ()
        {
            Console.WriteLine("Вот и все... Убийца лежит, справедливость восторжествовала!");
            Console.ReadKey();
        }
    }
}



ArcherBuilder arch = new ArcherBuilder();
Director director = new Director(arch);
Player? player_1 = director.creatPlayer();

player_1?.showInfo();


Console.WriteLine('\n');



WarriorBuilder warriorBuilder = new WarriorBuilder();
director.setBuilder(warriorBuilder);
Player? player_2 = director.creatPlayer();

player_2?.showInfo();
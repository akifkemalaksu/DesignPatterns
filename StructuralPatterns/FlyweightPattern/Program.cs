using System;

Forest forest = new Forest();

TreeFactory factory = new TreeFactory();

forest.PlantTree(10, 20, "Oak", "Green", "Rough", factory);
forest.PlantTree(15, 25, "Pine", "Dark Green", "Smooth", factory);
forest.PlantTree(10, 20, "Oak", "Green", "Rough", factory);

forest.Draw();
Car peugeot = new Car("peugeot", "301");
Car peugeotA = new Car("peugeot", "302");
Car peugeotB = new Car("peugeot", "303");
Car peugeotC = new Car("peugeot", "304");

List<Car> carList = new List<Car>();

carList.Add(peugeot);
carList.Add(peugeotA);
carList.Add(peugeotB);
carList.Add(peugeotC);


for (int i = 0; i < carList.Count; i++)
{
Console.WriteLine(carList[i].model);
}

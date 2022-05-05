using PetInterfaces;

var fred = new Boxer();
var roxy = new Bully();
var beans = new Mutt();

IDog[] dogs = { fred, roxy, beans }; //interface lets you put different classes into a single array

foreach (IDog dog in dogs) {
    Console.WriteLine($"Name: {dog.Name} | Color: {dog.Color} | Size: {(dog.IsLarge ?"Large" : "Not Large")} |" +
        $" Bark: {dog.Bark()}");
}

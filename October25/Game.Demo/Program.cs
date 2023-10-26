using Game.Weapon.Models;



Weapon M4A1S = new Weapon("M4A1S",20,20,false,3.2f);

Weapon[] weapons = new Weapon[1];
weapons[0] = M4A1S;

WeaponShelf weaponShelf = new WeaponShelf(weapons);

int command;
do
{
    command = PromptWeaponSelectionAndGetInput();
    switch (command)
    {
        case 0:
            weaponShelf.AddWeapon(GetWeaponFromUsr());
            break;
        case 1:
            weaponShelf.PrintWeapons();
            break;
        case 2:
            
            break;
    }


    } while (command<2);

Weapon weapon = null;
SearchResult searchResult;
do
{

    Console.WriteLine();
    Console.Write("Select weapon: ");
    weaponShelf.PrintWeapons();
    Console.WriteLine();
    var SelectedWeaponIndx = Convert.ToInt32(Console.ReadLine());
    searchResult = weaponShelf.GetWeapon(SelectedWeaponIndx);
    if (searchResult.IsValidSearch == false)
    {
        Console.WriteLine("Not Valid Indx");
        continue;
    }
    weapon = searchResult.Weapon;
} while (!searchResult.IsValidSearch);

do
{

    command = PromptCommandsAndGetInput();

    switch (command)
    {
        case 0:
            Console.WriteLine(weapon.GetFullInfo());
            break;
        case 1:
            weapon.Shoot();
            break;
        case 2:
            weapon.Fire();
            break;
        case 3:
            Console.WriteLine(weapon.GetNeededBulletToFillMagCount());
            break;
        case 4:
            weapon.Reload();
            break;
        case 5:
            weapon.ChangeFireMode();
            break;
        case 6:
            return;
        default:
            Console.WriteLine("Invalid input!");
            break;
    }
    Console.WriteLine(" ======== ");
} while (command < 6);

int PromptCommandsAndGetInput()
{
    Console.Write("""
        0 -> Get Info
        1 -> Shoot
        2 -> Fire (full auto)
        3 -> GetRemainjfaslkdf
        4 -> Reload
        5 -> ChangeFireMode
        6 -> Quit

        """);
    var i = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine(" ======== ");
    return i;
}


int PromptWeaponSelectionAndGetInput()
{
    Console.Write("""
        0 -> Create Weapon
        1 -> Print Weaopons
        2 -> Switch to Polygon
        """);

    var i = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine(" ======== ");
    return i;
}





string PromptAndGetString(string prompt = "Enter: ")
{
    Console.Write(prompt);
    return Console.ReadLine();
}

int PromptAndGetInt(string prompt = "Enter: ")
{
    int i;
    do
    {
        Console.Write(prompt);
        i = Convert.ToInt32(Console.ReadLine());
        if(i<0)
        {
            Console.WriteLine("Negative is not accepted!");
        }

    } while (i < 0);


    return i;
}

float PromptAndGetFloat(string prompt = "Enter: ")
{
    float i;
    do
    {
        Console.Write(prompt);
        i = Convert.ToSingle(Console.ReadLine());

        if (i < 0)
        {
            Console.WriteLine("Negative is not accepted!");
        }
    } while (i < 0);


    return i;
}

Weapon GetWeaponFromUsr()
{
    int MagSize;
    int CurrentMagSize;
    var Name = PromptAndGetString("Enter weapon name: ");
    MagSize = PromptAndGetInt("Enter mag size: ");
    do
    {
        CurrentMagSize = PromptAndGetInt("Enter current mag size: ");
        if (CurrentMagSize > MagSize)
        {
            Console.WriteLine("Current magsize cannot be bigger than mag size!");
        }
    } while (CurrentMagSize > MagSize);
    var magEmptyTime = PromptAndGetFloat("Enter mag empty time: ");

    return new Weapon(Name,MagSize,CurrentMagSize,false,magEmptyTime);
}
